using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerArreglo
{
    public partial class Form1 : Form
    {
        //string[] nombres = new string[1000];
        string[] nombres;
        int pos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btDimensionar_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(txtCant.Text);
            nombres = new string[cant];
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            nombres[pos]= txtNombre.Text;
            pos = pos + 1;

            txtNombre.Focus();
            txtNombre.SelectAll();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            lblLista.Text = "";
            foreach (string item in nombres)
            {
                lblLista.Text = lblLista.Text + item + "\r\n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////Intancia
            //string[] Dias;
            ////inicializando
            //Dias = new string[7];
            ////dando valor a cada posicion del arreglo
            //Dias[0] = "Lunes";
            //Dias[1] = "Martes";
            //Dias[2] = "Miercoles";
            //Dias[3] = "Jueves";
            //Dias[4] = "Viernes";
            //Dias[5] = "Sábado";
            //Dias[6] = "Domingo";

            //Intancia - inicializando - dando valor a cada posicion del arreglo
            string[] Dias = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sábado", "Domingo" };

            //for (int i = 0; i < Dias.Length; i++)
            //{
            //    label1.Text = label1.Text + Dias[i] + "\r\n";
            //}

            foreach (string item in Dias)
            {
                label1.Text = label1.Text + item + "\r\n";
            }
        }
    }
}
