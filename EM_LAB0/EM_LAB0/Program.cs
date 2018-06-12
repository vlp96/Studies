using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace MV_LR0
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            int N = 1000000 * 1000;
            byte[] bytes = BitConverter.GetBytes(201805978 * N);

            MemoryStream MemStream = new MemoryStream();
            FileStream FStream = new FileStream("C:\\Users\\Владимир\\Documents\\test.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            stopwatch.Start();
            MemStream.Write(bytes, 0, bytes.Length);
            stopwatch.Stop();

            MemStream.Close();

            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);

            stopwatch.Reset();

            stopwatch.Start();
            FStream.Write(bytes, 0, bytes.Length);
            stopwatch.Stop();

            FStream.Close();

            Console.WriteLine(stopwatch.Elapsed.TotalMilliseconds);
            Console.ReadLine();
        }
    }
}
