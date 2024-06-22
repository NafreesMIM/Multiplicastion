using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiplication_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textBox1.Select();
            int no = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= 20; i++)
            {
                listBox1.Items.Add(i+"   "+" X "+" "+no+" "+"="+" "+i*no);
            }
        }
    }
}
