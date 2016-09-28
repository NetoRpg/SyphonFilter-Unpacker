using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace SyphonFilterUnpacker
{
    class FOG
    {
        public bool UnpackHOG = false;
        public bool RepackHOG = false;
        private string PATH;
        private string FILENAME;
        private int NAME_SIZE;
        private byte[] HEADER = new byte[16];
        private byte[] NAME = new byte[20];
        private byte[] INTS = new byte[8];
        List<string> NAMES = new List<string>();
        List<int> OFFSETS = new List<int>();
        List<int> SIZES = new List<int>();
        System.Windows.Forms.ToolStripProgressBar PB;
        System.Windows.Forms.ToolStripStatusLabel LB;

        public FOG(string path)
        {
            this.PATH = path;
            //System.Windows.Forms.MessageBox.Show(path);
        }

        public void setAtt(ref System.Windows.Forms.ToolStripProgressBar pb, ref System.Windows.Forms.ToolStripStatusLabel lb)
        {
            this.PB = pb;
            this.LB = lb;

        }

        public void Unpack()
        {

            using (FileStream fs = new FileStream(this.PATH, FileMode.Open, FileAccess.Read))
            {
                string path = Path.Combine(Path.GetDirectoryName(this.PATH), Path.GetFileNameWithoutExtension(this.PATH));

                if (LB != null)
                {
                    LB.Text = "Unpacking: " + Path.GetFileName(PATH);
                    LB.GetCurrentParent().Update();
                }

                using (MemoryStream ms = new MemoryStream(fs.extractPiece(0, 2048)))
                {

                    ms.Read(this.HEADER, 0, 16);

                    ms.Read(this.NAME, 0, 20);
                    NameSize(this.NAME);

                    ms.Position = 16;


                    while (ms.Read(this.NAME, 0, NAME_SIZE) == NAME_SIZE || ms.Position > 2048)
                    {

                        if (this.NAME[0] == 0xCD)
                            break;

                        ms.Read(INTS, 0, 8);

                        this.NAMES.Add(this.NAME.extractString());

                        this.SIZES.Add(INTS.extractInt32(4));
                        this.OFFSETS.Add(INTS.extractInt32(0));

                    }
                }

                if (PB != null)
                {

                    PB.Minimum = 0;
                    PB.Value = 0;
                    PB.Step = 1;
                    PB.Maximum = NAMES.Count;
                }


                Directory.CreateDirectory(path);

                for (int i = 0; i < this.NAMES.Count; i++)
                {

                    //if (PB != null)
                        PB.PerformStep();
                        System.Windows.Forms.Application.DoEvents(); 
                    

                        int size = this.SIZES[i] * 2048;
                        int offset = this.OFFSETS[i] * 2048;

                        if (fs.Position != offset)
                            fs.Position = offset;

                        fs.extractPiece(0, size).Save(Path.Combine(path, this.NAMES[i]));
                }

                GenerateXML(path);

                if (UnpackHOG)
                    UnpackHOGs();

                if (LB != null)
                    LB.Text = "Succefully Unpacked!";
            }

        }


        public void Repack(string spath)
        {
            ReadXML();

            if (RepackHOG)
                RepackHOGs();


            if (LB != null)
                LB.Text = "Repacking: " + FILENAME;


            if (PB != null)
            {
                PB.Minimum = 0;
                PB.Maximum = NAMES.Count;
                PB.Value = 1;
                PB.Step = 1;
            }
            using (FileStream fs = File.Create(Path.Combine(spath, FILENAME)))
            {

                using (MemoryStream header = new MemoryStream(2048))
                {
                    List<byte> file;
                    header.Write(HEADER, 0, 16);
                    fs.Position = 2048;
                    foreach (string name in NAMES)
                    {

                        if (PB != null)
                            PB.PerformStep();

                        string path;
                        if (RepackHOG && Path.GetExtension(name) == ".HOG" && File.Exists(name))
                            path = Path.Combine(Path.Combine(Path.GetDirectoryName(PATH), "TMP"), name);
                        else
                            path = Path.Combine(Path.GetDirectoryName(PATH), name);

                        //MemoryStream file = new MemoryStream();

                        file = new List<byte>(File.ReadAllBytes(path));

                        int pos = (int)(fs.Position / 2048);
                        int size = file.Count / 2048;

                        header.Write(nameToByteArray(name), 0, NAME_SIZE);

                        // System.Windows.Forms.MessageBox.Show(pos.ToString());
                        if (file.Count == 0)
                        {
                            header.Write(INTS, 0, 8);
                            continue;
                        }

                        while (file.Count % 2048 != 0)
                            file.Add(0xCD);

                        //System.Windows.Forms.MessageBox.Show(BitConverter.ToString(a));

                        header.Write(pos.int32ToByteArray(), 0, 4);



                        header.Write((file.Count / 2048).int32ToByteArray(), 0, 4);

                        fs.Write(file.ToArray(), 0, file.Count);
                    }

                    fs.Position = 0;

                    int x = (int)(2048 - header.Position);

                    while (header.Length != 2048)
                        header.WriteByte(0xCD);


                    byte[] rest = new byte[fs.Length % 2048];

                    //for (int i = 0; i < rest.Length; i++)
                    //    rest[i] = 0xCD;
                    //System.Windows.Forms.MessageBox.Show(rest.Length.ToString() + " - " + fs.Length.ToString()  );
                    fs.Write(header.ToArray(), 0, 2048);
                    fs.Write(rest, 0, rest.Length);
                }

            }
            if (RepackHOG && Directory.Exists(Path.Combine(Path.GetDirectoryName(PATH), "TMP")))
                Directory.Delete(Path.Combine(Path.GetDirectoryName(PATH), "TMP"), true);


            if (LB != null)
                LB.Text = "Succefully Repacked!";
        }

        private void GenerateXML(string path) {

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.OmitXmlDeclaration = true;

            using (XmlWriter writer = XmlWriter.Create(Path.Combine(path,"FOGInfo.xml"), settings))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("FOG");
                writer.WriteAttributeString("Name", Path.GetFileName(PATH));
                writer.WriteAttributeString("Type", NAME_SIZE.ToString());
                writer.WriteAttributeString("Header", Convert.ToBase64String(HEADER));
                for (int i = 0; i < NAMES.Count; i++)
                {
                    writer.WriteStartElement("File");
                    writer.WriteAttributeString("Name", NAMES[i]);
                    writer.WriteAttributeString("Size", SIZES[i].ToString());
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
                    if (reader.Name.Equals("FOG") && (reader.NodeType == XmlNodeType.Element))
                    {
                        FILENAME = reader.GetAttribute("Name");
                        HEADER = Convert.FromBase64String(reader.GetAttribute("Header"));
                        NAME_SIZE = Convert.ToInt32(reader.GetAttribute("Type"));
                    }
                    else if (reader.Name.Equals("File") && (reader.NodeType == XmlNodeType.Element))
                    {
                        NAMES.Add(reader.GetAttribute("Name"));
                        SIZES.Add(Convert.ToInt32(reader.GetAttribute("Size")));
                    }
                }
            }


            

        }

        private void UnpackHOGs()
        {
            string path = Path.Combine(Path.GetDirectoryName(PATH), Path.GetFileNameWithoutExtension(PATH));
            HOG hog;
            foreach (string name in NAMES)
            {
                if (Path.GetExtension(name) == ".HOG")
                {
                    hog = new HOG(Path.Combine(path, name));
                    hog.Unpack();
                }
            }
        
        }

        public void RepackHOGs()
        {

            foreach (string s in Directory.GetDirectories(Path.GetDirectoryName(PATH)))
            {
                Directory.CreateDirectory(Path.Combine(Path.GetDirectoryName(PATH), "TMP"));
                HOG hog;
                if (File.Exists(Path.Combine(s, "HOGInfo.xml"))) 
                {
                    hog = new HOG(Path.Combine(s, "HOGInfo.xml"));
                    hog.Repack(Path.Combine(Path.GetDirectoryName(PATH), "TMP"));
                }
            }
        
        }


        private byte[] nameToByteArray(string name)
        {
            char[] n = name.ToCharArray();
            byte[] x = new byte[NAME_SIZE];
            for (int i = 0; i < NAME_SIZE; i++)
            {
                if (i < n.Length)
                    x[i] = (byte)n[i];
                else if (i == n.Length)
                    x[i] = 0x00;
                else
                    x[i] = 0xCD;
            }
            return x;
        }


        private int NameSize(byte[] data)
        {
            int size, count = 0;
            for (int i = 19; i > 15; i--)
            {
                if (data[i] == 0xCD)
                    count++;
            }

            if (count == 4)
                size = 20;
            else
                size = 16;

            this.NAME_SIZE = size;
            return size;
        }

    }
}
