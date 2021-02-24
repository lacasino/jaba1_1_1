using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int cleaning = 35;
        public int x_ray = 15;
        public int root_canal = 50;
        public int fluoride = 60;
        public int cavity_filling = 70;
        public int sum = 0;
        public string services = " ";
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sum += x_ray;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sum += cleaning;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            sum += root_canal;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            sum += cavity_filling;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            sum += fluoride;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = "________";
            sum = 0;
            label5.Text = "Клієнт ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(sum);
            label5.Text = label5.Text + textBox1.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var alph = new Form2();
            alph.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
