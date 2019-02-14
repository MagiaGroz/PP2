using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            string text = Console.ReadLine();   // текст который будем проверять на на палиндром
            File.WriteAllText(@"C:\Users\User\Desktop\File\Tree\papka\Palindrom.txt", text); // записываем текст в файл
           StreamReader file = new StreamReader(@"C:\Users\User\Desktop\File\Tree\papka\Palindrom.txt"); // берем текст из файла
            bool isPalindrome = true; // заводим булеан
            
            if ((word = file.ReadLine() )!= null) // пока текст не закончится
            {
              
                for(int i = 0; i < word.Length/2; i++) // доходим до половины текста
                {
                   if(word[i] != word[word.Length - 1 - i]) { isPalindrome = false; } // если какая то часть текста не равна его противоположной части то это не палиндром
                }
                
            }

            file.Close(); // закрываем поток
            if (isPalindrome) // выводим палиндром это или нет
                Console.WriteLine("Yes");  
            
            else Console.WriteLine("No");

              
            Console.ReadKey();  // чтобы не закрылось сразу
        }
    }
}
