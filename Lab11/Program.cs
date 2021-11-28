using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            linearEq linear1 = new linearEq();
            linear1.k = 0;
            linear1.b = 0;
            linear1.Root();
            Console.ReadKey();
        }

        struct linearEq
        {
            public double k;
            public double b;



            public void Root()
            {
                {
                    if (k == 0)
                    {
                        if (b == 0)
                        {
                            Console.WriteLine("x-любое число");
                        }
                        else
                        { Console.WriteLine("Нет решений"); }
                    }
                    Console.WriteLine("{0:0.0}", (-b) / k);
                }



            }
        }
    }

}   

    






 