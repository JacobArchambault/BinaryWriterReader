using System.IO;
using static System.Console;
namespace BinaryWriterReader
{
    class Program
    {
        static void Main()
        {
            WriteLine("***** Fun with Binary Writers / Readers *****\n");

            // Open a binary writer for a file.
            FileInfo f = new FileInfo("BinFile.dat");
            using (BinaryWriter bw = new BinaryWriter(f.OpenWrite()))
            {
                // Print out the type of BaseStream.
                // (System.IO.FileStream in this case).
                WriteLine("Base stream is: {bw.BaseStream}");

                // Create some data to save in the file.
                double aDouble = 1234.67;
                int anInt = 34567;
                string aString = "A, B, C";

                // Write the data.
                bw.Write(aDouble);
                bw.Write(anInt);
                bw.Write(aString);
            }
            using (BinaryReader br = new BinaryReader(f.OpenRead()))
            {
                WriteLine(br.ReadDouble());
                WriteLine(br.ReadInt32());
                WriteLine(br.ReadString());
            }
                WriteLine("Done!");
            ReadLine();
        }
    }
}
