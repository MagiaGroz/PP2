using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task2
{
    class Program
    {
        public class Movie
        {
            public string name;
            public int data;
            public Movie(string name, int data)
            {
                this.name = name;
                this.data = data; 
            }

        }
        public class Person{
            public string name;
            public int age;
            Movie firstMovie = new Movie("1Emoji", 2017);
            Movie secondMovie = new Movie("2asd", 1244);
            Movie thirdMovie = new Movie("3Emojdi", 2234);
            Movie fourthMovie = new Movie("4Emojid", 2027);

            public Person(string name, int age, Movie lol)
            {
                this.name = name;
                this.age = age;
                this.firstMovie = lol;
            }

            }
        
            static void Main(string[] args)
            {
                
                
            Person ak1ar = new Person("Ak1ar", 29, firstMovie);
            Person d= new Person("Ak2ar", 29, secondmie);
            Person a3bar = new Person("Ak3ar", 29, semovie);
            Person ak4ar = new Person("Akb4r", 29, movie);
            Person[] people = new Person[4];

            FileStream fs = new FileStream("Employee.xml", FileMode.Create, FileAccess.Write);

                XmlSerializer xs = new XmlSerializer(people.GetType());
                xs.Serialize(fs, people);
                fs.Close();
                Des(people);
            }
            static void Des(Person people)
            {
                FileStream fs = new FileStream("Employee.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(people.GetType());
                Person save = xs.Deserialize(fs) as Person;


                fs.Close();
            }
        
    }
}
