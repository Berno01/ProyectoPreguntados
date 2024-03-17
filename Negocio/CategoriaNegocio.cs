using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class CategoriaNegocio
    {
        //Atributos y propiedades
        private int idCategoria;
        private string nombreCategoria;
        private string imagen;

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }

        public string NombreCategoria
        {
            get { return nombreCategoria; }
            set { nombreCategoria = value; }
        }

        public string Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public static List<CategoriaNegocio>Listar()
        {

            List<CategoriaNegocio> lista = new List<CategoriaNegocio>();
            foreach (var fila in CategoriaDatos.Seleccionar())
            {
                CategoriaNegocio obj = new CategoriaNegocio();
                obj.IdCategoria = (int)fila[0];
                obj.NombreCategoria = (string)fila[1];
                obj.Imagen = (string)fila[2];
                

                lista.Add(obj);

            }
            return lista;
        }


        

        public void Registrar()
        {
            CategoriaDatos.Insertar(this.NombreCategoria, this.Imagen);
        }

        public void Modificar()
        {
            CategoriaDatos.Modificar(this.IdCategoria, this.NombreCategoria, this.Imagen);
        }

        public void Borrar()
        {
            CategoriaDatos.Eliminar(this.IdCategoria);
        }


    }



}
