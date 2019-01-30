using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Student
    {
        string Name;
        string ID;
        int Year = 1;
        public Student(string NAME, string ID)
        {
            Name = NAME;
            this.ID = ID;
        }
        public void GiveName()
        {
            Console.WriteLine(Name);
        }
        public void GiveID()
        {
            Console.WriteLine(ID);
        }
        public void GiveYear()
        {
            Console.WriteLine(Year);
        }
        public void increase()
        {
            Year++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Temir = new Student("Temirlan", "17BD101001");
            Temir.GiveName();
            Temir.GiveID();
            Temir.increase();
            Temir.GiveYear();
            Console.ReadKey();
        }
    }
}
