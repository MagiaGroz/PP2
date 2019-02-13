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
          
            string BasicFolder = @"C:\Users\User\Desktop\File";                     //начальная директория
        
            string targetFolder = @"C:\Users\User\Desktop\File\TestFolder";   // целевая директория
            string fileName = "Lol.txt";   // имя файла

            string   Created = Path.Combine(BasicFolder, fileName); // создание файла в начальной директории

           FileStream fs = File.Create(Created); // поток создающий файл в скобках путь где он должен быть и название
            fs.Close(); // закрываем поток
            string targetFile = Path.Combine(targetFolder, fileName); // создаем путь куда копировать

            

            File.Copy(Created, targetFile, true); //копируем
            File.Delete(Created); // начальное удаляем



        }


    }

}
