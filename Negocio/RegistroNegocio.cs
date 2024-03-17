using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class RegistroNegocio
    {
        //atributos

        private string ci;
        private string nombreCompl;
        private int idRol;
        private int idGenero;
        private string nomGenero;
        private int idPais;
        string usuario;
        string contra;
        string foto;
        double puntaje;

      
        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }

        public string NombreCompl
        {
            get { return nombreCompl; }
            set { nombreCompl = value; }
        }

        public int IdRol
        { 
            get { return idRol; }
            set { idRol = value; }
        }

        public int IdGenero
        {
            get { return idGenero; }
            set {idGenero = value; }
        }

        public int IdPais
        {
            get { return idPais; }
            set { idPais = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Contra
        {
            get { return contra; }
            set { contra = value; }
        }

        public string Foto
        {
            get { return foto; }
            set { foto = value; }
        }

        public string NomGenero
        {
            get { return nomGenero; }
            set { nomGenero = value; }
        }

        public double Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }


        public void Registrar()
        {
            RegistroDatos.Insertar(this.Ci, this.NombreCompl, this.IdGenero, this.IdPais, this.Usuario, this.Contra, this.Foto);
        }


        public static List<RegistroNegocio> ListarRank()
        {

            List<RegistroNegocio> lista = new List<RegistroNegocio>();
            foreach (var fila in RegistroDatos.SeleccionarRank())
            {
                RegistroNegocio obj = new RegistroNegocio();
                obj.Ci = (string)fila[0];
                obj.NombreCompl = (string)fila[1];
                obj.NomGenero = (string)fila[2];
                obj.Foto = (string)fila[3];
                obj.Puntaje = (double)fila[4];
                lista.Add(obj);

            }
            return lista;
        }


        public static List<RegistroNegocio> Listar()
        {

            List<RegistroNegocio> lista = new List<RegistroNegocio>();
            foreach (var fila in RegistroDatos.Seleccionar())
            {
                RegistroNegocio obj = new RegistroNegocio();
                obj.Ci = (string)fila[0];
                obj.NombreCompl = (string)fila[1];
                obj.IdRol = (int)fila[2];
                obj.IdGenero = (int)fila[3];
                obj.IdPais = (int)fila[4];
                obj.Usuario = (string)fila[5];
                obj.Contra = (string)fila[6];
                obj.Foto = (string)fila[7];
                lista.Add(obj);

            }
            return lista;
        }



    }
}
