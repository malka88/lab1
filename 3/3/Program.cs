using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void C(ref double x, ref double y)
        {
            x += y;
            y = x - y;
            x -= y;
            Console.Write("{0} = {1}, {1} = {0}", x, y);
        }

        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            C(ref x, ref y);
            Console.ReadKey();
        }
    }
}
