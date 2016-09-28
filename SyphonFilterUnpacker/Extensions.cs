using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SyphonFilterUnpacker
{
    public static class Extensions
    {
        public static string extractString(this byte[] bytes)
        {
            StringBuilder s = new StringBuilder();
            foreach (byte b in bytes)
            {
                if (b == 0x00)
                    break;

                s.Append(Convert.ToChar(b));
            }
            return s.ToString();
        }

        public static int extractInt32(this byte[] bytes, int index = 0)
        {
            return (bytes[index + 3] << 24) + (bytes[index + 2] << 16) + (bytes[index + 1] << 8) + bytes[index + 0];
        }


        public static byte[] extractPiece(this System.IO.FileStream fs, int offset, int length)
        {
            byte[] data = new byte[length];
            //fs.Position = offset;
            fs.Read(data, 0, length);
            
            return data;
        }

        public static void Save(this byte[] data, string path)
        {
            using (FileStream fs = File.Create(path))
            {
                fs.Write(data, 0, data.Length);
            }
        }





        public static byte[] nameToByteArray(this string name, int size)
        {
            char[] n = name.ToCharArray();
            byte[] x = new byte[size];
            for (int i = 0; i < size; i++)
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


        public static byte[] int32ToByteArray(this int value)
        {
            byte[] result = new byte[4];

            for (int i = 0; i < 4; i++)
            {
                result[i] = (byte)((value >> i * 8) & 0xFF);
            }
            return result;
        }

    }
}
