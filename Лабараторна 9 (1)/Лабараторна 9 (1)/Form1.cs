using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабараторна_9__1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            triangle tr = new triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));

            textBox3.Text = Convert.ToString(tr.S());

            textBox4.Text = Convert.ToString(tr.P());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            triangle t1 = new triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            triangle t2 = new triangle(Convert.ToDouble(rnd.Next(1, 10)), Convert.ToDouble(rnd.Next(1, 10)));
            textBox5.Text = t2.comparisontriangle(t1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            triangle t1 = new triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            double t2 = Convert.ToDouble(textBox7.Text);
            triangle s = t1 * t2;
            textBox6.Text = s.TRG_intput_output().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            triangle t1 = new triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            triangle t2 = new triangle(Convert.ToDouble(rnd.Next(1, 10)), Convert.ToDouble(rnd.Next(1, 10)));
            triangle s = t1 - t2;
            textBox8.Text = s.TRG_intput_output().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            triangle t1 = new triangle(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text));
            triangle t2 = new triangle(Convert.ToDouble(rnd.Next(1, 10)), Convert.ToDouble(rnd.Next(1, 10)));
            triangle s = t1 + t2;
            textBox7.Text = s.TRG_intput_output().ToString();
        }
    }
}
