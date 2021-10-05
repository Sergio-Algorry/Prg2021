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
        public Persona[] Personas { get; set; }
        //public int Pos = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = txtNombre.Text;
            //Pos = Pos + 1;
            Redimensionar();
            Personas[Personas.Length - 1] = persona;
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            lblLista.Text = "Lista:\r\n";
            foreach (Persona item in Personas)
            {
                lblLista.Text = lblLista.Text + item.Nombre + "\r\n";
            }
        }

        private void Redimensionar()
        {
            if (Personas == null)
            {
                Personas = new Persona[1];
            }
            else
            {
                Persona[] arraux = new Persona[Personas.Length + 1];
                for (int i = 0; i < Personas.Length; i++)
                {
                    arraux[i] = Personas[i];
                }
                Personas = arraux;
            }

        }
    }
}
