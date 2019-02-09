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
          
            string BasicFolder = @"C:\Users\User\Desktop\File";
            string targetFolder = @"C:\Users\User\Desktop\File\TestFolder";
            string fileName = "Lol.txt";

            string   Created = Path.Combine(BasicFolder, fileName);

           FileStream fs = File.Create(Created);
            fs.Close();
            string targetFile = Path.Combine(targetFolder, fileName);

            

            File.Copy(Created, targetFile, true);
            File.Delete(Created);



        }


    }

}
