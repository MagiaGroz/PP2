using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        Double value;
        String operation = "";
        bool operation_pressed;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "0" || operation_pressed)
            {
                textBox1.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
            if(operation!="")
            calculating();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            operation = "";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                double x;
                x = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text);
                textBox1.Text = Convert.ToString(x);
            }
        }

       private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                textBox1.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(textBox1.Text)));
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(textBox1.Text);
            operation_pressed = true;
            equation.Text = value.ToString() + " "+ operation;
           // if (value != Double.Parse(textBox1.Text) & operation!="" ) { calculating(); }

        }

       
        
        private void button11_Click(object sender, EventArgs e)
        {
           
            equation.Text = "";
            calculating();
            
        }

       private void calculating( )
        {
            switch (operation)
            {
                case "+":
                    textBox1.Text = (value + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (value - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (value * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (value / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if(int.Parse(textBox1.Text)==1|| int.Parse(textBox1.Text) == 2)
            {
                textBox1.Text = "1";
            }
            else {
                int[] fib = new int[int.Parse(textBox1.Text)];
                fib[0] = fib[1] = 1;
               int n = int.Parse(textBox1.Text);
                for (int i = 2; i < n; i++)
                {
                    

                    fib[i] = fib[i - 1] + fib[i - 2];

                    if (i == n - 1)
                    {
                        textBox1.Text = Convert.ToString(fib[i]);
                    }

                }
                 }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            
            double a = int.Parse(textBox1.Text)*(Math.PI/180);
            if (int.Parse(textBox1.Text) % 180 == 0)
                a = 0;
                textBox1.Text = Convert.ToString(Math.Sin(a));
        }
    }
}
