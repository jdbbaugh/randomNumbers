using System;
using System.Collections.Generic;

namespace randomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> numbers = new List<int> {
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10),
                random.Next(10)
            };
            for( int i=0; i < numbers.Count; i++ )
            {
               if (numbers.Exists(num => num == i))
               {
                   Console.WriteLine($"numbers list contains {i}");
               } else {
                   Console.WriteLine($"numbers list does not contain {i}");
               }
            }
        }
    }
}
