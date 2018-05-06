using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox1.Text;
            double.TryParse(t, out k);
            r12 = k * 0.25;
            label1.Text = r12.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox2.Text;
            double.TryParse(t, out k);
            r12 = k * 0.25;
            label2.Text = r12.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox3.Text;
            double.TryParse(t, out k);
            r12 = k * 0.25;
            label3.Text = r12.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox4.Text;
            double.TryParse(t, out k);
            r12 = k * 0.25;
            label4.Text = r12.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox5.Text;
            double.TryParse(t, out k);
            r12 = k * 0.25;
            label5.Text = r12.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox6.Text;
            double.TryParse(t, out k);
            r12 = k * 0.25;
            label6.Text = r12.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox7.Text;
            double.TryParse(t, out k);
            r12 = k * 0.25;
            label7.Text = r12.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox14.Text;
            double.TryParse(t, out k);
            r12 = k / 231;
            label14.Text = r12.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox13.Text;
            double.TryParse(t, out k);
            r12 = k / 231;
            label13.Text = r12.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox12.Text;
            double.TryParse(t, out k);
            r12 = k / 231;
            label12.Text = r12.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox11.Text;
            double.TryParse(t, out k);
            r12 = k / 231;
            label11.Text = r12.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox10.Text;
            double.TryParse(t, out k);
            r12 = k / 231;
            label10.Text = r12.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox9.Text;
            double.TryParse(t, out k);
            r12 = k / 231;
            label9.Text = r12.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double k, r12;
            string t = textBox8.Text;
            double.TryParse(t, out k);
            r12 = k / 231;
            label8.Text = r12.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double a, b, c, d, f, g, k, sum;
            string t = textBox15.Text, y = textBox16.Text, u = textBox17.Text, i = textBox18.Text, o = textBox19.Text, m = textBox20.Text, p = textBox21.Text;
            double.TryParse(t, out a);
            double.TryParse(y, out b);
            double.TryParse(u, out c);
            double.TryParse(i, out d);
            double.TryParse(o, out f);
            double.TryParse(p, out g);
            double.TryParse(m, out k);
            sum = a + b + c + d + f + g + k;
            

            double a1, b1, c1, d1, f1, g1, k1, sum1;
            string t1 = textBox22.Text, y1 = textBox23.Text, u1 = textBox24.Text, i1 = textBox25.Text, o1 = textBox26.Text, m1 = textBox27.Text, p1 = textBox28.Text;
            double.TryParse(t1, out a1);
            double.TryParse(y1, out b1);
            double.TryParse(u1, out c1);
            double.TryParse(i1, out d1);
            double.TryParse(o1, out f1);
            double.TryParse(p1, out g1);
            double.TryParse(m1, out k1);
            sum1 = a1 + b1 + c1 + d1 + f1 + g1 + k1;
            sum = sum * sum1;
            label30.Text = sum.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
