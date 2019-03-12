using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int[,] z = new int[5, 5];
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    z[i, j] = rnd.Next(x, y + 1);
                    Console.Write("{0}", z[i,j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
