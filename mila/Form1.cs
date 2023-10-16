using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mila
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
                bool a1, b1, c1;
                long a, b, c;
                a1 = long.TryParse(maskedTextBox1.Text, out a);
                b1 = long.TryParse(maskedTextBox2.Text, out b);
                c1 = long.TryParse(maskedTextBox3.Text, out c);
                if ((a1 && b1 && c1) == true)
                {
                    if (a < 1 || b < 1 || c < 1)
                    {
                        MessageBox.Show("Число должно быть больше 0!");
                    }
                    else
                    {
                        if ((c >= a && c >= b && a + b > c) || (b >= a && b >= c && a + c > b) || (a >= b && a >= c && b + c > a))
                        {
                            if (a == b && a == c)
                            {
                                MessageBox.Show("Треугольник равносторонний");
                            }
                            else if (a == b || a == c || b == c)
                            {
                                MessageBox.Show("Треугольник равнобедренный");
                            }
                            else
                            {
                                MessageBox.Show("Треугольник разносторонний");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Это не треугольник");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Данные не корректны или число слишком большое");
                }
        }
    }
}
