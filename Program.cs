using System;
using System.Collections.Generic;

namespace RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
List<int> numbers = new List<int> {
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
    random.Next(6),
};

            Console.WriteLine("Hello World!");
        }
    }
}
