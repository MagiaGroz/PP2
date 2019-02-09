using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task4
{

    public class Tree
    {

        static void Main()
        {
            
            DirectoryInfo direc = new DirectoryInfo(@"C:\Users\User\Desktop\File");
            WalkInTree(direc, 0); // вызов рекурсии

        }

        static void WalkInTree(DirectoryInfo dir, int cnt) // создаем рекурсию
        {
            FileInfo[] files = null; //для запоминания списка файлов
            DirectoryInfo[] subDirs = null; //для папок

            // берем все файлы        
            files = dir.GetFiles("*.*");
            // Берем все папки
            subDirs = dir.GetDirectories();

            if (files != null) // Проверяем на нулл
            {

                foreach (FileInfo fi in files)
                {

                    for (int i = 0; i < cnt; i++) // при каждом заходе в новую папку каунт увеличивается
                    {                             // следовательно приобретается вид дерева
                        Console.Write("    "); // пишем столько пустот сколько подпапок
                    }
                    Console.WriteLine(fi.Name); // выводим имя файла
                }

                foreach (DirectoryInfo direc in subDirs)
                {
                    for (int i = 0; i < cnt; i++) 
                    {
                        Console.Write("    "); // пишем столько пустот сколько подпапок
                    }
                    Console.WriteLine(direc.Name); // пишем имя папки

                    WalkInTree(direc, cnt + 1); // вызываем этот же метод только уже для подпапки и увеличиваем кол-во пустот
                }

            }
        }
        
    }

}
