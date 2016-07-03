using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.IO;

namespace CSharpInDepth
{
    public class Class1
    {
        

        public void test()
        {
            int count;
            byte[] byteArray;
            char[] charArray;
            UnicodeEncoding uniEncoding = new UnicodeEncoding();

            // Create the data to write to the stream.
            byte[] firstString = Encoding.Default.GetBytes("Invalid file path characters are: ");
            byte[] secondString = Encoding.Default.GetBytes(Path.InvalidPathChars);

            using (MemoryStream memStream = new MemoryStream(100))
            {
                // Write the first string to the stream.
                memStream.Write(firstString, 0, firstString.Length);

                // Write the second string to the stream, byte by byte.
                count = 0;
                while (count < secondString.Length)
                {
                    memStream.WriteByte(secondString[count++]);
                }
                
                // Set the position to the beginning of the stream.
                memStream.Seek(0, SeekOrigin.Begin);

                // Read the first 20 bytes from the stream.
                byteArray = new byte[memStream.Length];
                count = memStream.Read(byteArray, 0, 20);

                // Read the remaining bytes, byte by byte.
                while (count < memStream.Length)
                {
                    byteArray[count++] =
                        Convert.ToByte(memStream.ReadByte());
                }

                // Decode the byte array into a char array 
                // and write it to the console.
                charArray = new char[Encoding.Default.GetCharCount(
                    byteArray, 0, count)];
                Encoding.Default.GetDecoder().GetChars(
                    byteArray, 0, count, charArray, 0);
            }
        }
        
    }
}
