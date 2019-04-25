using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagdatDeletingSameCircles
{
    public partial class Form1 : Form
    {
        Bitmap bp;
        Graphics gp;
        bool IsClicked;
        Pen pen;
        Point curpoint;
        Point[] points = new Point[10];
        int x = 250;
        int y = 150;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bp = new Bitmap(pictureBox1.Width, pictureBox1.Height);

           IsClicked = false;

            gp = Graphics.FromImage(bp);
            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                if(i%2==1)
                points[i].X = x + i*50;
                else
                points[i].X = x;

                
                
                
            }
            points[0].Y = y ;
            points[1].Y = y ;
            points[2].Y = y +  25;
            points[3].Y = y +  25;
            points[4].Y = y + 2 * 25;
            points[5].Y = y + 2 * 25;
            points[6].Y = y + 3 * 25;
            points[7].Y = y + 3 * 25;
            points[8].Y = y + 4 * 25;
            points[9].Y = y + 4 * 25;
           



            pictureBox1.Image = bp;
            gp.FillEllipse(new Pen(Color.Blue).Brush, points[0].X, points[0].Y, 50, 50);
            gp.FillEllipse(new Pen(Color.Blue).Brush, points[1].X, points[1].Y, 50, 50);

            gp.FillEllipse(new Pen(Color.Red).Brush, points[2].X, points[2].Y, 50, 50);
            gp.FillEllipse(new Pen(Color.Red).Brush, points[3].X, points[3].Y, 50, 50);

            gp.FillEllipse(new Pen(Color.Black).Brush, points[4].X, points[4].Y, 50, 50);
            gp.FillEllipse(new Pen(Color.Black).Brush, points[5].X, points[5].Y, 50, 50);

            gp.FillEllipse(new Pen(Color.Yellow).Brush, points[6].X, points[6].Y, 50, 50);
            gp.FillEllipse(new Pen(Color.Yellow).Brush, points[7].X, points[7].Y, 50, 50);

            gp.FillEllipse(new Pen(Color.Orange).Brush, points[8].X, points[8].Y, 50, 50);
            gp.FillEllipse(new Pen(Color.Orange).Brush, points[9].X, points[9].Y, 50, 50);

         
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           
                gp.FillEllipse(new Pen(Color.Blue).Brush, curpoint.X, curpoint.Y, 100, 100);
            
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            curpoint = e.Location;
            
            IsClicked = true;
        }
    }
}
