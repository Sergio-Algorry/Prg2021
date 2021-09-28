using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerClase
{
    public partial class Form1 : Form
    {
        Persona PersonaAMostrar = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            //Persona PersonaAMostrar;
            //PersonaAMostrar = new Persona();

            PersonaAMostrar.Nombre = txtNombre.Text;
            PersonaAMostrar.Apellido = txtApellido.Text;

            //lblPersonas.Text = PersonaAMostrar.Nombre 
            //                   + ", " 
            //                   + PersonaAMostrar.Apellido;


            lblPersonas.Text = PersonaAMostrar.NombreCompleto();
        }

        private void btInscribir_Click(object sender, EventArgs e)
        {
            Materia MateriaInscripta = new Materia();
            MateriaInscripta.Nombre = txtNombreMateria.Text;
            MateriaInscripta.Año = Convert.ToInt32(txtAño.Text);

            //PersonaAMostrar.MateriaCursando = MateriaInscripta;
            PersonaAMostrar.Inscribir(MateriaInscripta);

            //lblMostrarInscripcion.Text = PersonaAMostrar.MateriaCursando.Nombre 
            //                             + ", Año " 
            //                             + PersonaAMostrar.MateriaCursando.Año.ToString();

            lblMostrarInscripcion.Text = PersonaAMostrar.NombreCompletoConMateria();
        }
    }
}
