using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (x == 12 || x == 1 || x == 2)
                    Console.WriteLine("Winter");
            if (x == 3 || x == 4 || x == 5)
                    Console.WriteLine("Spring");
            if (x == 6 || x == 7 || x == 8)
                    Console.WriteLine("Summer");
            if (x == 9 || x == 10 || x == 11)
                    Console.WriteLine("Autumn");

            Console.ReadKey();
        }
    }
}
