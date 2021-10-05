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
        public Persona[] Personas { get; set; } = new Persona[3];
        public int Pos = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = txtNombre.Text;
            Pos = Pos + 1;
            Personas[Pos] = persona;
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            lblLista.Text = "Lista:\r\n";
            foreach (Persona item in Personas)
            {
                lblLista.Text = lblLista.Text + item.Nombre + "\r\n";
            }
        }
    }
}
