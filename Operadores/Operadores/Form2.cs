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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "HOLA";
        }

        private void opcion2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDI FormMdi = new MDI();

            FormMdi.ShowDialog();
        }
    }
}
