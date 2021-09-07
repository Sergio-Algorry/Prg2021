using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaVariables
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
        }

        private void btSumar_Click(object sender, EventArgs e)
        { 
            lblResultado.Text = System.Convert.ToString(sumar());
        }

        private int sumar()
        {
            int numero1;
            int numero2;
            int resultado;

            numero1 = System.Convert.ToInt32(txtNumero1.Text);
            numero2 = System.Convert.ToInt32(txtNumero2.Text);

            resultado = numero1 + numero2;

            return resultado;
        }
    }
}
