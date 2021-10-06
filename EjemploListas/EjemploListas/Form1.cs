using EjemploListas.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploListas
{
    public partial class Form1 : Form
    {
        //public Persona[] Personas { get; set; } = new Persona[3];
        //public int Pos = -1;
        //public Persona[] Personas { get; set; }

        public ListaPersonas Lista { get; set; } = new ListaPersonas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            //Persona persona = new Persona();
            //persona.Nombre = txtNombre.Text;
            //persona.AñoNacimiento = Convert.ToInt32(txtNac.Text);
            ////Pos = Pos + 1;
            //Lista.Redimensionar();
            ////Personas[Personas.Length - 1] = persona;
            //Lista.Personas[Lista.Personas.Length - 1] = persona;

            if ( !Lista.AddPersona(txtNombre.Text, txtNac.Text))
            {
                txtNac.Focus();
                txtNac.SelectAll();
                lblLista.Text = "Persona no válida";
            }
            else
            {
                txtNac.Text = "";
                txtNombre.Text = "";
                txtNombre.Focus();
                lblLista.Text = "Persona aceptada";
            }
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            //lblLista.Text = "Lista:\r\n";
            //foreach (Persona item in Lista.Personas)
            //{
            //    lblLista.Text = lblLista.Text + item.AñoNacimiento.ToString() + " - " + item.Nombre + "\r\n";
            //}

            lblLista.Text = Lista.ToString();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            lblLista.Text = Lista.ToStringFiltrado(2000);
        }

        //private void Redimensionar()
        //{
        //    if (Personas == null)
        //    {
        //        Personas = new Persona[1];
        //    }
        //    else
        //    {
        //        Persona[] arraux = new Persona[Personas.Length + 1];
        //        for (int i = 0; i < Personas.Length; i++)
        //        {
        //            arraux[i] = Personas[i];
        //        }
        //        Personas = arraux;
        //    }

        //}
    }
}
