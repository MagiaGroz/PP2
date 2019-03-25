using System;
using System.IO;

using System.Xml.Serialization;
namespace Task1
{
    public class ComNumber
    {
        public double A;
        public double B;
        public ComNumber()
        {

        }
        public void PrintAbout()
        {
            Console.WriteLine(A + " " + B);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            ComNumber Equation = new ComNumber();
            Equation.A = 3.24;
            Equation.B = 5.56;
            F1(Equation);
            F2();
        }
        private static void F1(ComNumber Equation)
        {

            FileStream fs = new FileStream("complex.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(ComNumber));
            xs.Serialize(fs, Equation);
            fs.Close();
        }
        private static void F2()
        {
            FileStream fs = new FileStream("complex.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(ComNumber));
            ComNumber Equat = xs.Deserialize(fs) as ComNumber;
            Equat.PrintAbout();
            fs.Close();


        }
    }
}
