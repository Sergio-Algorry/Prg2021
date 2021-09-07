using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadoes
{
    public partial class frmInicial : Form
    {
        int numero;
        public frmInicial()
        {
            InitializeComponent();
            numero = 0;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            int variable;

            //variable = ++numero;
            numero = numero + 1;
            variable = numero;

            //variable = numero++;
            //variable = numero;
            //numero = numero + 1;

            lblResultado.Text = System.Convert.ToString(numero);
            lblVariable.Text = System.Convert.ToString(variable);
        }

        private void btOpLog_Click(object sender, EventArgs e)
        {
            bool resultado;

            resultado = numero == 0;

            lblResultado.Text = resultado.ToString();
        }

        private void btCorto_Click(object sender, EventArgs e)
        {
            bool resultado;
            int numerador = 10;
            int divisor = 0;
            resultado = (divisor != 0) && ((numerador/divisor)>0);


            lblResultado.Text = resultado.ToString();
        }
    }
}
