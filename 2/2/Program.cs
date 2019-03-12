using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void B(char x)
        {
            int y;
            y = (int)x;
            if (y > 47 && y < 58)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        static void Main(string[] args)
        {
            char x = char.Parse(Console.ReadLine());
            B(x);
            Console.ReadLine();
        }
    }
}
