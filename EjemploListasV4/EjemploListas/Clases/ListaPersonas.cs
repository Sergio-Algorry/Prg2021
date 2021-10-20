using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploListas.Clases
{
    public class ListaPersonas
    {
        public DataTable DT { get; set; } = new DataTable();
        public int UltimoId { get; set; } = 0;

        public ListaPersonas()
        {
            DT.TableName = "ListaPersonas";
            DT.Columns.Add("Id");
            DT.Columns.Add("Nombre");
            DT.Columns.Add("AñoNacimiento");

            LeerDT_DeArchivo();
        }

        public void LeerDT_DeArchivo()
        {
            if(System.IO.File.Exists("Lista.xml"))
            {
                //DT.Clear();
                DT.ReadXml("Lista.xml");
                UltimoId = 0;
                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    if( Convert.ToInt32( DT.Rows[i]["Id"])>UltimoId)
                    {
                        UltimoId = Convert.ToInt32(DT.Rows[i]["Id"]);
                    }
                }
            }
        }

        public bool UpdatePersona(Persona persona)
        {
            bool resp = persona.Validar();

            if (resp)
            {
                if (persona.Id == 0)
                {
                    UltimoId = UltimoId + 1;
                    persona.Id = UltimoId;

                    DT.Rows.Add();
                    int NumeroRegistroNuevo = DT.Rows.Count - 1;
                    
                    DT.Rows[NumeroRegistroNuevo]["Id"] = persona.Id.ToString();
                    DT.Rows[NumeroRegistroNuevo]["Nombre"] = persona.Nombre;
                    DT.Rows[NumeroRegistroNuevo]["AñoNacimiento"] = persona.AñoNacimiento.ToString();

                    DT.WriteXml("Lista.xml");
                }
                else
                {
                    for (int fila = 0; fila < DT.Rows.Count; fila++)
                    {
                        if(Convert.ToInt32( DT.Rows[fila]["Id"])==persona.Id)
                        {
                            DT.Rows[fila]["Nombre"] = persona.Nombre;
                            DT.Rows[fila]["AñoNacimiento"] = persona.AñoNacimiento.ToString();
                            DT.WriteXml("Lista.xml");
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
            for (int fila = 0; fila < DT.Rows.Count; fila++)
            {
                if (Convert.ToInt32(DT.Rows[fila]["Id"]) == id)
                {
                    res.Id = Convert.ToInt32(DT.Rows[fila]["Id"]);
                    res.Nombre = DT.Rows[fila]["Nombre"].ToString();
                    res.AñoNacimiento = Convert.ToInt32(DT.Rows[fila]["AñoNacimiento"]);
                    break;
                }
            }

            return res;
        }

        public bool DeletePersona(Persona persona)
        {
            bool resp = false;
            for (int fila = 0; fila < DT.Rows.Count; fila++)
            {
                if (Convert.ToInt32(DT.Rows[fila]["Id"]) == persona.Id)
                {
                    DT.Rows[fila].Delete();
                    DT.WriteXml("Lista.xml");
                    resp = true;
                    break;
                }
            }

            return resp;
        }
    }
}
