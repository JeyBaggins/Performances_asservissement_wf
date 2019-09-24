using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Quadratic : Form
    {
        public Quadratic()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double Tr = double.Parse(textBoxA.Text);
            double D = double.Parse(textBoxB.Text);
            if (D<=0)
            {
                MessageBox.Show("D doit être strictement positif");
            }
            else
            {
                double Xi = Math.Sqrt((Math.Pow(Math.Log(D),2))/((Math.Pow(Math.Log(D), 2))+Math.Pow(Math.PI,2)));
                double Wn = 3/(Tr*Xi);
                double b = 2 * Xi * Wn;
                double c = Math.Pow(Wn, 2);
                string XiText = Xi.ToString("0.0000");
                string WnText = Wn.ToString("0.0000");
                string bText = b.ToString("0.000");
                string cText = c.ToString("0.000");
                XiBox.Text = XiText;
                WnBox.Text = WnText;
                EC_Box.Text = "s^2 + "+bText+"s + "+cText;

            }
            
            
            
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Quadratic_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EQ_Box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
