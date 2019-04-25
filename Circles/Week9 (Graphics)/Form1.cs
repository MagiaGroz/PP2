using System;
using System.Drawing;
using System.Windows.Forms;


namespace SaturdayQuiz3Task2BallsFallsDanara
{
    public partial class Form1 : Form
    {
        public Point[] pArray;
        Graphics g;
        public bool IsClicked;
        public Pen pen;
        public int R = 20;
        public Form1()
        {
            InitializeComponent();
        }

        int index = 0;

        private void Form1_Load(object sender, EventArgs e)

        {
            pArray = new Point[1000];
            pen = new Pen(Color.Red);
            IsClicked = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            for (int k = 0; k < index; k++)

            {
                pArray[k].Y += 5;
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)

        {
            IsClicked = true;
            Point point = e.Location;
            pArray[index] = point;
            index++;
            timer1.Start();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)

        {
            Graphics g = e.Graphics;

            if (IsClicked)
            {
                for (int k = 0; k < index; k++)

               {
                   g.FillEllipse(pen.Brush, pArray[k].X - R, pArray[k].Y - R, 2 * R, 2 * R);

               }

            }
        }



       

    }

}