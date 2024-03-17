
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class PaisNegocio
    {
        //atributos
        private int idPais;
        private string nombrePais;

        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }

        public string NombrePais
        {
            get { return nombrePais; }
            set { nombrePais = value; }
        }


        public static List<PaisNegocio> Listar()
        {

            List<PaisNegocio> lista = new List<PaisNegocio>();
            foreach (var fila in PaisDatos.Seleccionar())
            {
                PaisNegocio obj = new PaisNegocio();
                obj.idPais = (int)fila[0];
                obj.nombrePais = (string)fila[1];

                lista.Add(obj);

            }
            return lista;
        }
    }
}
