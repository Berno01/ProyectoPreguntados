using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class GeneroNegocio
    {
        //atributos
        private int idGenero;
        private string nombreGenero;

        public int IdGenero
        {
            get { return idGenero; }
            set { idGenero = value; }
        }

        public string NombreGenero
        { get { return nombreGenero; }
          set { nombreGenero = value; }
        }


        public static List<GeneroNegocio> Listar()
        {

            List<GeneroNegocio> lista = new List<GeneroNegocio>();
            foreach (var fila in GeneroDatos.Seleccionar())
            {
                GeneroNegocio obj = new GeneroNegocio();
                obj.idGenero = (int)fila[0];
                obj.nombreGenero = (string)fila[1];
        
                lista.Add(obj);

            }
            return lista;
        }

    }
}
