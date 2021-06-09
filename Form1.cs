using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        // Calculate button
        private void button1_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(textBox1.Text);
            int breadth = Convert.ToInt32(textBox2.Text);

            rectangle r = new rectangle();
            r.set(length, breadth);
            double c = r.Area();
            label3.Visible = true;
            label3.Text = "Area is: " + Convert.ToString(c);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
        }
    }
}
