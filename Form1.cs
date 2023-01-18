using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string rawrr;
        int a = 0;
        int b = 1;
        int c;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < 1 ; i++ ) 
            {
                c = a + b;
                rawrr = a.ToString() + " + " + b.ToString() + " = " + c.ToString() + "\r\n";
                a = b;
                b = c;
                textBox1.Text = textBox1.Text + rawrr;
            }
        }
    }
}
