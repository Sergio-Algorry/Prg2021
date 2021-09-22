using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox3.Focus();
            this.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;

            textBox3.Enabled = false;

            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            textBox1.Visible = false;
            textBox1.Text = "";
            textBox2.Visible = false;
            textBox2.Text = "";

            textBox3.Enabled = true;
            textBox3.Focus();

            textBox3.SelectAll();

        }
    }
}
