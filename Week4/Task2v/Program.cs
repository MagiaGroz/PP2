using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Xml.Serialization;
public class slab
{
    public int lowerlimit { get; set; }
    public int upperlimit { get; set; }
    public int percentage { get; set; }

}

class Program
{
    static void Main(string[] args)
    {
        List<slab> slabs = new List<slab>();
        slab s = new slab();
        s.lowerlimit = 0;
        s.upperlimit = 200000;
        s.percentage = 0;

        slabs.Add(s);

        s = new slab();
        s.lowerlimit = 0;
        s.upperlimit = 200000;
        s.percentage = 0;

        slabs.Add(s);

        //XmlSerializer serializer = new XmlSerializer( slabs.GetType(), new XmlRootAttribute("slabs"));
        XmlSerializer serializer = new XmlSerializer(slabs.GetType());
        //StringWriter writer = new StringWriter();
        //serializer.Serialize(writer, slabs);


        FileStream fs = new FileStream("kanatis.xml", FileMode.Create, FileAccess.Write);
        serializer.Serialize(fs, slabs);
        fs.Close();
    }
}