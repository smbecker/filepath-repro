using System;
using System.IO;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (var stream = File.Open(@"\\localhost\Test\test.txt.~SS", FileMode.Open))
            using (var reader = new StreamReader(stream))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
