using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomFigures
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;
        Graphics gBitmap;
        Pen pen = new Pen(Color.Red);
        int rand;
        Random random = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

			bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);

			gBitmap = Graphics.FromImage(bitmap);

			pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            rand = random.Next(1, 5);
            if (rand == 1)
                gBitmap.FillEllipse(pen.Brush, e.Location.X - 25, e.Location.Y - 25, 50, 50);
            else if (rand == 2)
            {
                pen.Color = Color.Yellow;

                gBitmap.FillRectangle(pen.Brush, e.Location.X - 25, e.Location.Y - 25, 50, 50);
            }
            else if (rand == 3)
            {
                pen.Color = Color.Blue;
                gBitmap.FillEllipse(pen.Brush, e.Location.X - 25, e.Location.Y - 25, 10, 50);
                gBitmap.FillEllipse(pen.Brush, e.Location.X - 45, e.Location.Y - 25, 50, 10);
            }
            else if (rand == 4)
            {
                Point[] points = new Point[3];
                points[0].X = e.Location.X;
                points[0].Y = e.Location.Y;
                points[1].X = e.Location.X - 50;
                points[1].Y = e.Location.Y + 75;
                points[2].X = e.Location.X + 50;
                points[2].Y = e.Location.Y + 75;
                gBitmap.FillPolygon(new Pen(Color.Black).Brush, points);
            }
            this.Refresh();

        }
    }
}
