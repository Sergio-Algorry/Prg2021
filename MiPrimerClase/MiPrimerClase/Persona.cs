using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPrimerClase
{
    public class Persona
    {
        public string Nombre { get; set; }
        
        public string Apellido { get; set; }

        public Materia MateriaCursando { get; set; } = new Materia();

        public string NombreCompleto()
        {
            return Nombre + ", " + Apellido;
        }

        public void Inscribir(Materia arg_materia)
        {
            MateriaCursando = arg_materia;
        }

        public string NombreCompletoConMateria()
        {
            string MCCM = "";
            MCCM = NombreCompleto() + "\r\n" 
                + MateriaCursando.Nombre + " - " + MateriaCursando.Año.ToString();
            return MCCM;
        }
    }
}
