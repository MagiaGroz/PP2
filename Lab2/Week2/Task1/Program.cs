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
            string text = Console.ReadLine();
            File.WriteAllText(@"C:\Users\User\Desktop\File\Tree\papka\Palindrom.txt", text);
           StreamReader file = new StreamReader(@"C:\Users\User\Desktop\File\Tree\papka\Palindrom.txt");
            bool isPalindrome = true;
            
            if ((word = file.ReadLine() )!= null)
            {
              
                for(int i = 0; i < word.Length/2; i++)
                {
                   if(word[i] != word[word.Length - 1 - i]) { isPalindrome = false; }
                }
                
            }

            file.Close();
            if (isPalindrome)
                Console.WriteLine("Yes");  
            
            else Console.WriteLine("No");

              
            Console.ReadKey();  
        }
    }
}
