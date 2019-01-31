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
                int num = -1;  // берем -1 так как i начинается с нуля и если будет 0 то оно сразу остоновится
                for (int j = 0; j < n; j++)
                {

                    a[i,j]="[*]"; // заполнение 2д массива 
                    num++; // следующая строка звезд всегда должна быть больше на 1
                    if (num == i) { break; } // остонавливает заполнение массива


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
            Console.ReadKey();
        }
    }
}
