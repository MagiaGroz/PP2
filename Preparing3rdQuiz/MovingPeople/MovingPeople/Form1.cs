using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingPeople
{
    public partial class Form1 : Form
    {
        Bitmap bp;
        Graphics gp;
        Point Person1;
        Point Person2;
        Pen pen ;
        bool  IsClicked = false;
        Point[] points;
        int R = 15;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person1 = new Point(200, 180);

            Person2 = new Point(120, 180);

            bp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gp = Graphics.FromImage(bp);
            pen = new Pen(Color.Green);
            pictureBox1.Image = bp;
            gp.FillRectangle(pen.Brush, 0, 0, pictureBox1.Width, pictureBox1.Height);           
            pen.Color = Color.Blue;
            gp.FillRectangle(pen.Brush, 0, 0, pictureBox1.Width, pictureBox1.Height/2+10);
            pen.Color = Color.Yellow;
            gp.FillEllipse(pen.Brush, 50, 50, 100, 100);
            pen.Color = Color.Blue;
            gp.FillEllipse(pen.Brush, 80, 40, 90, 90);
            pen.Color = Color.White;
            points = new Point[] { new Point(350, 5), new Point(330, 25), new Point(350, 45), new Point(370, 25), new Point(350, 5) };

            gp.FillPolygon(pen.Brush, points);
            points = new Point[] { new Point(200, 45), new Point(180, 65), new Point(200, 85), new Point(220, 65), new Point(200, 45) };

            gp.FillPolygon(pen.Brush, points);
            points = new Point[] { new Point(500, 65), new Point(480, 85), new Point(500, 105), new Point(520, 85), new Point(500, 65) };

            gp.FillPolygon(pen.Brush, points);
            points = new Point[] { new Point(750, 85), new Point(730, 105), new Point(750, 125), new Point(770, 105), new Point(750, 85) };

            gp.FillPolygon(pen.Brush, points);

            timer1.Start();


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new Pen(Color.Red).Brush, Person1.X, Person1.Y, 2 * R, 2 * R);//голова первого 
            e.Graphics.DrawLine(new Pen(Color.Black), Person1.X + R, Person1.Y + 2*R, Person1.X + R, Person1.Y + 5 * R-5);//тело
            e.Graphics.DrawLine(new Pen(Color.Black), Person1.X + R, Person1.Y + 2 * R+10, Person1.X + 2*R, Person1.Y + 3 * R);//правая рука
            e.Graphics.DrawLine(new Pen(Color.Black), Person1.X + R, Person1.Y + 2 * R + 10, Person1.X -  R+10, Person1.Y + 3 * R);//левая рука

            e.Graphics.DrawLine(new Pen(Color.Black), Person1.X + R, Person1.Y + 4 * R + 10, Person1.X + 2 * R, Person1.Y + 6 * R);//права нога
            e.Graphics.DrawLine(new Pen(Color.Black), Person1.X + R, Person1.Y + 4 * R + 10, Person1.X - R+10, Person1.Y + 6 * R);//левая нога
            e.Graphics.FillEllipse(new Pen(Color.Red).Brush, Person2.X, Person2.Y, 2 * R, 2 * R);//голова второго 
            e.Graphics.DrawLine(new Pen(Color.Black), Person2.X + R, Person2.Y + 2 * R, Person2.X + R, Person2.Y + 5 * R - 5);//тело
            e.Graphics.DrawLine(new Pen(Color.Black), Person2.X + R, Person2.Y + 2 * R + 10, Person2.X + 2 * R, Person2.Y + 3 * R);//правая рука
            e.Graphics.DrawLine(new Pen(Color.Black), Person2.X + R, Person2.Y + 2 * R + 10, Person2.X - R + 10, Person2.Y + 3 * R);//левая рука

            e.Graphics.DrawLine(new Pen(Color.Black), Person2.X + R, Person2.Y + 4 * R + 10, Person2.X + 2 * R, Person2.Y + 6 * R);//права нога
            e.Graphics.DrawLine(new Pen(Color.Black), Person2.X + R, Person2.Y + 4 * R + 10, Person2.X - R + 10, Person2.Y + 6 * R);//левая нога
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Person1.X += 10;
            Person2.X -= 10;
            Refresh();
        }
    }
}
