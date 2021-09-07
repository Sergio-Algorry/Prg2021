using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadores
{
    public partial class Form1 : Form
    {
        public string cadena;
        public Form1()
        {
            InitializeComponent();
            cadena = "Hola Pepe";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = cadena;
        }

        private void btDisparaForm2_Click(object sender, EventArgs e)
        {
            Form2 nuevoFormulario = new Form2();

            nuevoFormulario.Show();
        }
    }
}
