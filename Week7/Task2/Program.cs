using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class MyThread
    {
        Thread thread;

        public MyThread(string name) //Конструктор получает имя функции
        {

            thread = new Thread(startThread);
            thread.Name = name;
            thread.Start();
        }
        static void startThread()
        {
            for (int i = 0; i < 4; i++) {
                Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i);
            
                Thread.Sleep(1000);
                if (i == 3)
                {
                    Console.WriteLine(Thread.CurrentThread.Name + " завершился");
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            MyThread t1 = new MyThread("Thread 1");
            MyThread t2 = new MyThread("Thread 2");
            MyThread t3 = new MyThread("Thread 3");


        }
    }
}
