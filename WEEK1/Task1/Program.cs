using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // Size of  massive
            string[] nums = Console.ReadLine().Split(); // for taking numbers separate
            int[] a = new int[n]; // 1st massive
            int[] b = new int[n]; // massive with prime numbers
            int num = 0; // number of prime numbers


            for (int i = 0; i < n; i++)
            {

                a[i] = int.Parse(nums[i]); // занести в массив чисел массив строк в котором введенные пользователем числа 
                for (int j = 2; j < a[i]; j++)
                {

                    if (a[i] % j == 0) // checking on prime
                    {
                        break; // если поделилось на хоть что то кроме самого себя  и 1 то тогда сразу выходим из цикла
                    }
                    if (a[i] - 1 == j)
                    { // если дошло до конца и не разделилось ни на что тогда это прайм число
                        num++;

                        b[i] = a[i];

                        break;

                    }

                }

            }
            Console.WriteLine(num); // number of prime numbers
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] != 0)
                    Console.Write(b[i] + " "); // выводим простые числа
            }

            Console.ReadKey();  // чтобы не закрылось сразу

        }
    }
}
