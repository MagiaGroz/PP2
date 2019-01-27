using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // size of massive
            int[] a = new int[n*2];
           
            string[] nums = Console.ReadLine().Split();  // take separate inetegers
            for(int i = 0; i < n; i++)
            {
                a[i] = int.Parse(nums[i]);  // filling massive
                a[i+1] = int.Parse(nums[i]);
                Console.Write(a[i] + " " + a[i + 1]+" ");  // print result

            }
            Console.ReadKey();
            
        }
    }
}
