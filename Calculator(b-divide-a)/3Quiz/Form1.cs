using System;
using System.Windows.Forms;

namespace _3Quiz
{
    public partial class Form1 : Form
    {
        int a, b;
        
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonclicks(object sender, EventArgs e)
        {
            
                Button c = (Button)sender;
            Screen.Text = Screen.Text + c.Text;
           

        }
        
        private void and_Click(object sender, EventArgs e)
        {
            a = int.Parse(Screen.Text);
            Screen.Text = "";
            
            
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            b = int.Parse(Screen.Text);

             bool IsFound = false;
                  int i = a;
              while (!IsFound)
              {
                a--;
                if (a == 0) { a++; }

                if (a % b == 0)
                {
                    Screen.Text = Convert.ToString(a);
                    IsFound = true;
                    break;
                }



                i++;
                  if (i % b == 0)
                  {
                      Screen.Text = Convert.ToString(i);
                      IsFound = true;

                  }

                  
                      }
            

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
