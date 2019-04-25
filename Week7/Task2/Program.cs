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

            thread = new Thread(startThread); // создание треда (функция которую трэд будет делать)
            thread.Name = name; // имя трэда
            thread.Start(); // запускаем трэд
        }
        static void startThread() // функция которая будет выполнятся
        {
            for (int i = 0; i < 4; i++) {
                Console.WriteLine(Thread.CurrentThread.Name + " выводит " + i); // имя текущего трэда 
            
                Thread.Sleep(1000); // ждать
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
           
            MyThread t1 = new MyThread("Thread 1"); // создание экземпляров с конструктором имени
            MyThread t2 = new MyThread("Thread 2");
            MyThread t3 = new MyThread("Thread 3");


        }
    }
}
