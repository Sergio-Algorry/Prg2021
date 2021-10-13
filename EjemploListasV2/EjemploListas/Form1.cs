﻿using EjemploListas.Clases;
using System;
using System.Windows.Forms;

namespace EjemploListas
{
    public partial class Form1 : Form
    {
        Persona per = new Persona();
        public ListaPersonas Lista { get; set; } = new ListaPersonas();
        public Form1()
        {
            InitializeComponent();
        }

        private void btCargar_Click(object sender, EventArgs e)
        {
            per.Nombre = txtNombre.Text;
            per.AñoNacimiento = Convert.ToInt32(txtNac.Text);

            if (!Lista.UpdatePersona(per))
            {
                txtNac.Focus();
                txtNac.SelectAll();
                lblLista.Text = "Persona no válida";
            }
            else
            {
                limpiar();
            }
            per = new Persona();
        }

        private void btMostrar_Click(object sender, EventArgs e)
        {
            lblLista.Text = Lista.ToString();
        }

        private void btFiltro_Click(object sender, EventArgs e)
        {
            lblLista.Text = Lista.ToStringFiltrado(2000);
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            per = Lista.BuscarPersona(Convert.ToInt32(txtCodigo.Text));

            if (per.Id > 0)
            {
                txtNombre.Text = per.Nombre;
                txtNac.Text = per.AñoNacimiento.ToString();

                txtNombre.Focus();
                txtCodigo.Text = "";
            }
            else
            {
                txtCodigo.Text = "no existe";
                txtCodigo.Focus();
                txtCodigo.SelectAll();
            }
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if(!Lista.DeletePersona(per))
            {
                limpiar();
            }
            else
            {
                lblLista.Text = "El registro " + per.Nombre + " no se pudo borrar.";
                limpiar();
            }
            per = new Persona();
        }

        private void limpiar()
        {
            btMostrar_Click(null, null);
            txtNac.Text = "";
            txtNombre.Text = "";
            txtNombre.Focus();
        }
    }
}
