using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int num = -1;  // берем -1 так как i начинается с нуля
                for (int j = 0; j < n; j++)
                {

                    Console.Write("[*]");
                    num++;
                    if (num == i) { break; }


                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
