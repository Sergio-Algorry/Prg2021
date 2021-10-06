using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListas.Clases
{
    public class ListaPersonas
    {
        public Persona[] Personas { get; set; }

        public void Redimensionar()
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

        public bool AddPersona(string nombre, string año)
        {
            Persona persona = new Persona();
            persona.Nombre = nombre;
            persona.AñoNacimiento = Convert.ToInt32(año);

            bool resp = persona.Validar();

            if (resp)
            {
                Redimensionar();
                Personas[Personas.Length - 1] = persona;
            }
            return resp;
        }

        public override string ToString()
        {
            string Resp = "";
            Resp = "Lista:\r\n";
            foreach (Persona item in Personas)
            {
                Resp = Resp + item.AñoNacimiento.ToString() + " - " + item.Nombre + "\r\n";
            }

            return Resp;
        }

        public string ToStringFiltrado(int añoMinimo)
        {
            string Resp = "";
            Resp = "Lista:\r\n";
            foreach (Persona item in Personas)
            {
                if (item.AñoNacimiento >= añoMinimo)
                {
                    Resp = Resp + item.AñoNacimiento.ToString() + " - " + item.Nombre + "\r\n";
                }
            }

            return Resp;
        }
    }
}
