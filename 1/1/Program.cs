using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void A()
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int x = i * j;
                    Console.WriteLine("{0} * {1} = {2} ", i, j, x);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            A();
            Console.ReadKey();
        }
    }
}
