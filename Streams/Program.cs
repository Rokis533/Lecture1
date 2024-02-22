using System.Diagnostics.Metrics;
using System.Text;

namespace Streams
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string path = "testFileCreate.txt";

            using (FileStream writer = new FileStream(path, FileMode.Create))
            {

                byte[] text = Encoding.ASCII.GetBytes("Hello");

                writer.Write(text);

            }

            using (FileStream reader = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.None, 4096))
            {
                List<byte> bytes = new List<byte>();
                int oneByte = 0;
                while ((oneByte = reader.ReadByte()) != -1)
                {
                    bytes.Add((byte)oneByte);
                }

                Console.WriteLine(Encoding.ASCII.GetString(bytes.ToArray()));
            }
            /*
                1. hey 
                2. yo 
             
             */

            Thread.Sleep(10000);
        }
    }
}


