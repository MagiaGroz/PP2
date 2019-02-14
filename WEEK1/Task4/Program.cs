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
            string[,] a = new string[n, n]; // создание 2д массива
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                    
                {
                    
                    if (i>=j) // сравнивание индекса
                    {
                        a[i, j] = "[*]"; // заполнение массива
                    }
                }
                
            }
            for (int i = 0; i < n; i++)
            {
               
                for (int j = 0; j < n; j++)
                {

                    Console.Write(a[i, j]); // вывод массива


                }
                Console.WriteLine(" "); // вывести строки отдельно
            }
            Console.ReadKey(); // чтобы сразу не закрылось
        }
    }
}
