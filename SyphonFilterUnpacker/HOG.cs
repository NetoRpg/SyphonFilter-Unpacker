using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace SyphonFilterUnpacker
{
    class HOG
    {
        string PATH, FILENAME;
        int TYPE = 1;
        List<string> NAMES = new List<string>();
        byte[] HEADER = new byte[20];

        public HOG(string path) 
        {
            this.PATH = path;
        }

        public void Unpack() 
        {
            using (FileStream fs = new FileStream(this.PATH, FileMode.Open, FileAccess.Read))
            {
                

                int fileNumber, namesOffset, headerSize;


                fs.Read(HEADER, 0, 20);

                fileNumber = HEADER.extractInt32(4);
                namesOffset = HEADER.extractInt32(12);
                headerSize = HEADER.extractInt32(16);

                byte[] names = new byte[headerSize - namesOffset];

                fs.Position = namesOffset;
                fs.Read(names, 0, names.Length);
                // names = fs.extractPiece(0, names.Length);

                //fs.Position = namesOffset;
                //fs.Read(names, 0, names.Length);

                int i = 0, x = 0;
                StringBuilder name = new StringBuilder();

                string path = Path.Combine(Path.GetDirectoryName(PATH), Path.GetFileNameWithoutExtension(PATH));
                Directory.CreateDirectory(path);

                while (i < fileNumber && x < names.Length) 
                {
                    if (names[x] == 0x00)
                    { 
                        this.NAMES.Add(name.ToString());
                        name = new StringBuilder();
                        i++;
                        x++;
                    }

                    name.Append(Convert.ToChar(names[x]));

                    x++;
                }

                fs.Position = 20;
                byte[] fPointers = fs.extractPiece(0, (fileNumber * 4) + 4);

                if (fPointers.extractInt32(fileNumber * 4) + 2048 == fs.Length)
                    TYPE = 2;

                int size;

                fs.Position = 2048;

                for (i = 0; i < fileNumber; i++)
                {
                    
                    if (i == fileNumber - 1)
                        size = (int)(fs.Length - fs.Position);
                    else
                        size = fPointers.extractInt32((i*4) + 4) - fPointers.extractInt32(i*4);

                    fs.extractPiece(0, size).Save(Path.Combine(path, this.NAMES[i]));

                    //using (FileStream file = File.Create(Path.Combine(path, this.NAMES[i])))
                    //{
                    //    data = new byte[size];

                    //    fs.Read(data, 0, size);
                    //    file.Write(data, 0, size);
                    //}
                    
                    
                }

                GenerateXML(path);


            }
        }


        public void Repack(string path)
        {

            ReadXML();

            //System.Windows.Forms.MessageBox.Show(Path.Combine(Path.GetDirectoryName(PATH), FILENAME));

            using (FileStream fs = File.Create(Path.Combine(path, FILENAME)))
            {
                MemoryStream ms = new MemoryStream(2048);
                ms.Write(HEADER, 0, 20);

                fs.Position = 2048;
                
                int pos;
                byte[] data;
                foreach (string n in NAMES)
                {
                    pos = (int)fs.Position - 2048;   
                    ms.Write(pos.int32ToByteArray(), 0, 4);
                    data = File.ReadAllBytes(Path.Combine(Path.GetDirectoryName(PATH), n));

                    fs.Write(data, 0, data.Length);
                }

                if (TYPE == 2)
                { 
                    pos = (int)fs.Position - 2048;
                    ms.Write(pos.int32ToByteArray(), 0, 4);
                }

                foreach (string n in NAMES)
                {
                    ms.Write(n.nameToByteArray(n.Length + 1), 0, n.Length + 1);
                }
                fs.Position = 0;
                fs.Write(ms.ToArray(), 0, (int)ms.Length);
            }
        
        }


        private void GenerateXML(string path)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (XmlWriter writer = XmlWriter.Create(Path.Combine(path, "HOGInfo.xml"), settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("HOG");
                writer.WriteAttributeString("Name", Path.GetFileName(PATH));
                writer.WriteAttributeString("Header", Convert.ToBase64String(HEADER));
                writer.WriteAttributeString("Type", TYPE.ToString());
                for (int i = 0; i < NAMES.Count; i++)
                {
                    writer.WriteStartElement("File");
                    writer.WriteAttributeString("Name", NAMES[i]);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();
                writer.WriteEndDocument();
                writer.Flush();
            }
            
        
        }

        private void ReadXML() 
        {
            using (XmlReader reader = XmlReader.Create(PATH))
            {

                while (reader.Read())
                {
                    if (reader.Name.Equals("HOG") && (reader.NodeType == XmlNodeType.Element))
                    {
                        FILENAME = reader.GetAttribute("Name");
                        TYPE = Convert.ToInt32(reader.GetAttribute("Type"));
                        HEADER = Convert.FromBase64String(reader.GetAttribute("Header"));
                    }
                    else if (reader.Name.Equals("File") && (reader.NodeType == XmlNodeType.Element))
                    {
                        NAMES.Add(reader.GetAttribute("Name"));
                    }
                }
            }
        
        }

    }
}
