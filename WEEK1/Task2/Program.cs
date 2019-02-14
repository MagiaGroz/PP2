using System;

namespace ConsoleApp2
{
    class Student
    {
        string Name; // поля Имени айди и года
        string ID;
        int Year = 1;
        public Student(string NAME, string ID) 
        { 
            Name = NAME; 
            this.ID = ID;
        }
        public void GiveName() //метод вывода имени
        {
            Console.WriteLine(Name);
        }
        public void GiveID()//метод вывода айди
        {
            Console.WriteLine(ID);
        }
        public void GiveYear()//метод вывода года
        {
            Console.WriteLine(Year);
        }
        public void increase() // метод увеличения года обучения
        {
            Year++;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Temir = new Student("Temirlan", "17BD101001"); // конструктор
            Temir.GiveName(); // вывод значений
            Temir.GiveID();
            Temir.increase();
            Temir.GiveYear();
            Console.ReadKey(); // чтобы сразу не закрылось
        }
    }
}
