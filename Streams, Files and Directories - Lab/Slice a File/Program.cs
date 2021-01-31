using System;
using System.IO;

namespace Slice_a_File
{
    class Program
    {
        static void Main(string[] args)
        {
            using(FileStream streamReader = new FileStream("../../../slice.txt", FileMode.Open))
            {
                int partSize = (int)streamReader.Length / 4;

                for (int i = 0; i < streamReader.Length; i++)
                {
                    byte[] newbyte = new byte[1];
                    int count = 0;
                    
                    using(FileStream streamWritter = new FileStream($"../../../slice-part{i +1}.txt", FileMode.Create, FileAccess.Write))
                    {
                        while (count < partSize)
                        {
                            streamReader.Read(newbyte, 0, newbyte.Length);
                            streamWritter.Write(newbyte, 0, newbyte.Length);

                            count += newbyte.Length;
                        }
                    }

                }
            }
            
        }
    }
}
