using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static bool plain(int x)
        {
            for (int i = 2; i < x; i++)
                if (x % i == 0)
                    return false;

            return true;
        }

        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            if (plain(x))
            {
                Console.WriteLine("Yes");
            }

            else
            {
                Console.WriteLine("No");
            }

            Console.ReadKey();
        }
    }
}
