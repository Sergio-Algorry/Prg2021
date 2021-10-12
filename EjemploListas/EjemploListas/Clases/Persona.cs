using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListas.Clases
{
    public class Persona
    {
        public int Código { get; set; }
        public string Nombre { get; set; }
        public int AñoNacimiento { get; set; }

        public bool Validar()
        {
            bool resp = false;

            if (AñoNacimiento > 1900 && AñoNacimiento <= DateTime.Now.Year)
            {
                resp = true;
            }
            return resp;
        }
    }
}
