using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Midterm
{
    class Program
    {
        public static string s = "helloWorld";
        static void Main(string[] args)
        {
           
            Timer time = new Timer(Print, null, 0, 1000);
            Console.ReadLine();
            Console.WriteLine(s[0]);
        }
        public static int i = 0;
       static void Print(object state) {
            if (i % 2 == 0)
                Console.BackgroundColor = ConsoleColor.Red;
            else
                Console.BackgroundColor = ConsoleColor.Green;
            if (i > s.Length) { Environment.Exit(0); }
                Console.Write(s[i]);
           
            i++;
               
            

        }
    }
}
