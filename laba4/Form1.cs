using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba4
{
    public partial class Form1 : Form
    {
        double f(double x, double b)
        {
            return 9*(x + 15*Math.Pow(Math.Pow(x, 3) + Math.Pow(b, 3), 1/2));
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = (-2.4).ToString();
            textBox2.Text = (1.0).ToString();
            textBox3.Text = (0.2).ToString();
            textBox4.Text = (2.5).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBox1.Text);
            double xk = double.Parse(textBox2.Text);
            double dx = double.Parse(textBox3.Text);
            double b = double.Parse(textBox3.Text);
            for (double i = x0; i <= xk; i += dx)
            {
                double y = f(i, b);
                textBox5.Text += "x=" + Convert.ToString(i) + "; y=" + Convert.ToString(y) + Environment.NewLine;
            }
        }

        
    }
}
