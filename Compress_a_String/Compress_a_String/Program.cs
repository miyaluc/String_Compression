using System;

namespace Compress_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Compression_Factory cf = new Compression_Factory();
            Console.WriteLine("Please enter a series of letters. No numbers or special characters allowed.");

            string input = Console.ReadLine();

            cf.Compress(input);

            Console.Read();
        }
    }
}
