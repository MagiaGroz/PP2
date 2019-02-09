using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            

            StreamReader doc = new StreamReader(@"C:\Users\User\Desktop\File\Tree\papka\Prime.txt");   //новый обьект

            string[] word = doc.ReadLine().Split(); //считать с документа


            string text ="";  // строка хранящая простые числа
            for (int i = 0; i < word.Length; i++)
            {
                
                bool isPrime = true; // булеан для узнавания простого числа
                
                for (int j = 1; j <= Math.Sqrt(int.Parse(word[i])); j++) // пробегаемся до корня
                {
                    
                    if (int.Parse(word[i]) % (j+1) == 0 || int.Parse(word[i]) == 1 )  // 1 исключение
                    {  isPrime = false;  } // если поделилось то эт не прайм
                }
                if (isPrime || int.Parse(word[i])==2)
                {

                    text = text + " " + word[i]; // храним в строку
                    


                }
            }
                File.WriteAllText(@"C:\Users\User\Desktop\File\Tree\papka\ResOfPrime.txt", text); // записываем в документ
            

            

            doc.Close(); // закрываем
            

        }
    }
}
