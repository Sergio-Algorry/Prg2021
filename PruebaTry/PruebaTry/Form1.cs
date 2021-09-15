using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaTry
{
    public partial class Form1 : Form
    {
        int contador = 0;
        DateTime PEPE = System.Convert.ToDateTime("08/05/2021 10:45");

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void btIgual_Click(object sender, EventArgs e)
        {
            try
            {
                lblResultado.Text = (Convert.ToInt32(txtNumerador.Text)
                    / Convert.ToInt32(txtDenominador.Text)).ToString();

                if(lblResultado.Text !="6")
                {
                    Exception error = new Exception("No es el resultado que esperaba");
                    throw error;
                }
            }
            catch (DivideByZeroException pepe)
            {
                lblMensaje.Text = pepe.Message;
                txtDenominador.Text = "";
                lblMensaje.Visible = true;
            }
            catch (Exception pepe)
            {
                lblMensaje.Text = pepe.Message;
                lblMensaje.Visible = true;
            }
        }

        private void txtNumerador_KeyUp(object sender, KeyEventArgs e)
        {
           if( e.KeyCode == Keys.A)
            {
                lblMensaje.Text = "pepe";
                lblMensaje.Visible = true;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PEPE = PEPE.AddSeconds(1);
            lblResultado.Text = PEPE.ToString();

        }
    }
}
