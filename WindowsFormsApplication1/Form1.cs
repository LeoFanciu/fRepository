using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";

            int[] a = new int[10];
            Random r = new Random();
         

            for(int i=0; i < 10; i++)
            {
                    a[i]=r.Next(50);
            }
            Array.Sort(a);
            for(int i = 0; i < 10; i++)
            {
                textBox3.Text = textBox3.Text + a[i].ToString() + " ";

            }


            textBox1.Text = a.Max().ToString();
            textBox2.Text = a.Min().ToString();
          

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
