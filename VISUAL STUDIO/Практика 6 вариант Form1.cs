using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика1_за_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double L = Convert.ToDouble(textBox1.Text);
            double A = Convert.ToDouble(textBox2.Text);
            double B= Convert.ToDouble(textBox3.Text);
            double Vbr = L * A * B;
            textBox4.Text = Vbr.ToString();

            double VA = L * 2 * Math.PI * (A / 2) * Math.Sqrt(2);
            double VB = L * 2 * Math.PI * (B / 2) * Math.Sqrt(2);
            double Vc = Vbr - VA - VB;
            textBox5.Text = Vc.ToString();

        }
    }
}
