using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        struct Sstudent
        {
            public string fio;
            public byte math;
            public byte phys;
        }

        static Sstudent A(string fio, byte math, byte phys)
        {
            Sstudent x = new Sstudent();
            x.fio = fio;
            x.math = math;
            x.phys = phys;

            return x;
        }

        static void Main(string[] args)
        {
            string fio;
            byte math, phys;

            Sstudent[] x = new Sstudent[10];
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.Add\n2.Print\n3.Win\n4.Lose\n0.Exit");
                int z = int.Parse(Console.ReadLine());
                switch (z)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("fio");
                        fio = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("math");
                        math = byte.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("phys");
                        phys = byte.Parse(Console.ReadLine());

                        for (int i = 0; i < 10; i++)
                        {
                            if (x[i].math == 0)
                            {
                                x[i] = A(fio, math, phys);
                                break;
                            }
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("fio\tmath\tphys");
                        for (int i = 0; i < 10; i++)
                        {
                            if (x[i].fio != null)
                                Console.WriteLine("{0}\t{1}\t{2}", x[i].fio, x[i].math, x[i].phys);
                            else
                                break;
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("fio\tmath\tphys");
                        for (int i = 0; i < 10; i++)
                        {
                            if (x[i].math == 5 && x[i].phys == 5)
                                Console.WriteLine("{0}\t{1}\t{2}", x[i].fio, x[i].math, x[i].phys);
                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("fio\tmath\tphys");
                        for (int i = 0; i < 10; i++)
                        {
                            if (x[i].math == 2 || x[i].phys == 2)
                                Console.WriteLine("{0}\t{1}\t{2}", x[i].fio, x[i].math, x[i].phys);
                        }
                        Console.ReadKey();
                        break;
                    case 0:
                        break;
                }
            }
        }
    }
}
