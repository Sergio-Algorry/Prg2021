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
        public int UltimoCodigo { get; set; } = 0;

        //public bool AddPersona(string nombre, string año)
        //{
        //    Persona persona = new Persona();
        //    persona.Nombre = nombre;
        //    persona.AñoNacimiento = Convert.ToInt32(año);

        //    bool resp = persona.Validar();

        //    if (resp)
        //    {
        //        UltimoCodigo = UltimoCodigo + 1;
        //        persona.Id = UltimoCodigo;
        //        Redimensionar();
        //        Personas[Personas.Length - 1] = persona;
        //    }
        //    return resp;
        //}

        public bool UpdatePersona(Persona persona)
        {
            bool resp = persona.Validar();

            if (resp)
            {
                if (persona.Id == 0)
                {
                    UltimoCodigo = UltimoCodigo + 1;
                    persona.Id = UltimoCodigo;
                    Redimensionar();
                    Personas[Personas.Length - 1] = persona;
                }
                else
                {
                    for (int i = 0; i < Personas.Length; i++)
                    {
                        if(Personas[i].Id==persona.Id)
                        {
                            Personas[i] = persona;
                            break;
                        }
                    }
                }
            }
            return resp;
        }

        public Persona BuscarPersona(int id)
        {
            Persona res = new Persona();
            foreach (Persona item in Personas)
            {
                if (item.Id == id)
                {
                    res = item;
                    break;
                }
            }

            return res;
        }

        public bool DeletePersona(Persona persona)
        {
            bool resp = false;

            for (int i = 0; i < Personas.Length; i++)
            {
                if (Personas[i].Id == persona.Id)
                {
                    EliminarRegistro(i);
                    break;
                }
            }

            return resp;
        }

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

        public void EliminarRegistro(int posicion)
        {
            for (int i = posicion; i < Personas.Length-1; i++)
            {
                Personas[i] = Personas[i + 1];
            }

            Persona[] arraux = new Persona[Personas.Length - 1];
            for (int i = 0; i < Personas.Length-1; i++)
            {
                arraux[i] = Personas[i];
            }
            Personas = arraux;
        }

        public override string ToString()
        {
            string Resp = "Lista:\r\n";
            foreach (Persona item in Personas)
            {
                Resp = Resp
                    + item.Id.ToString() + " - "
                    + item.AñoNacimiento.ToString()
                    + " - " + item.Nombre + "\r\n";
            }

            return Resp;
        }

        public string ToStringFiltrado(int añoMinimo)
        {
            string Resp = "Lista:\r\n";
            foreach (Persona item in Personas)
            {
                if (item.AñoNacimiento >= añoMinimo)
                {
                    Resp = Resp
                        + item.Id.ToString() + " - "
                        + item.AñoNacimiento.ToString()
                        + " - " + item.Nombre + "\r\n";
                }
            }

            return Resp;
        }

    }
}
