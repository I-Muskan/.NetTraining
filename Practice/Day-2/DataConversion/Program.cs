using System;

namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 8;
            int i=9;
            b =( byte)i; // implicit type conversion
            Console.WriteLine(b.GetType());
            Console.WriteLine(i.GetType());
        }
    }
}
