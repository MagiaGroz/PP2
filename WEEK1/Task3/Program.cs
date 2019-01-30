using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Double(string[] nums) // Метод дубликации
        {
            int[] a = new int[nums.Length * 2]; // массив который мы будем выводить будет больше начального 
                                                                                            

           
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(nums[i/2]); // a[i] будет увеличиватся но nums[i] только через 2 числа 
            }
            for(int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " "); // выводим
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // size of massive
            string[] nums = Console.ReadLine().Split();  // take separate inetegers
            Double(nums);
            Console.ReadKey();

        }
    }
}
