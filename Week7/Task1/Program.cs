using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Thread thread1 = new Thread(Do);
            Thread thread2 = new Thread(Do);
            Thread thread3 = new Thread(Do);
            thread1.Name = "thread1";
            thread2.Name = "thread2";
            thread3.Name = "thread3";
            Thread[] threads = new Thread[3] { thread1, thread2, thread3 }; //создание массива трэдов
            for (int i = 0; i < 3; i++) // запуск трэда
            {
                threads[i].Start();
            }

        }
        static void Do()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
                Thread.Sleep(100);
            }
        }
    }
}
