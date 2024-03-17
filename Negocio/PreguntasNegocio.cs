using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using Datos;

namespace Negocio
{
    public class PreguntasNegocio
    {
        //Atributos y Propiedades
        private CategoriaNegocio categoriaDatos = new CategoriaNegocio();
        private string idCat;
        private int idPreg;
        private string categoria;
        private string pregunta;
        private string respuestaCorrecta;
        private string respuestaIncorrecta1;
        private string respuestaIncorrecta2;
        
        public CategoriaNegocio CatDatos
        {
            get { return categoriaDatos; }
            set { categoriaDatos = value; }   
        }



        public string IdCat
        {
            get { return idCat; }
            set { idCat = value; }
        }
        
        public int IdPreg
        {
            get { return idPreg; }
            set { idPreg = value; }
        }

        
        public string Pregunta
        {
            get { return pregunta; }
            set { pregunta = value; }
        }

        public string RespuestaCorrecta
        {
            get { return respuestaCorrecta; }
            set { respuestaCorrecta = value; }
        }

        public string RespuestaIncorrecta1
        {
            get { return respuestaIncorrecta1; }
            set { respuestaIncorrecta1 = value; }
        }

        public string RespuestaIncorrecta2
        {
            get { return respuestaIncorrecta2; }
            set { respuestaIncorrecta2 = value; }
        }

        //Metodos 
        public void Registrar()
        {
            PreguntasDatos.Insertar(this.idCat, this.pregunta, this.respuestaCorrecta, this.respuestaIncorrecta1, this.respuestaIncorrecta2);
           
        }
        
        public void Modificar()
        {
            PreguntasDatos.Actualizar(this.idCat, this.pregunta, this.respuestaCorrecta, this.respuestaIncorrecta1, this.respuestaIncorrecta2, this.idPreg);
        }
        
        public void Eliminar()
        {
            PreguntasDatos.Eliminar(this.IdPreg);
        }
        
        public static List<PreguntasNegocio> Listar()
        {
            List<PreguntasNegocio> lista = new List<PreguntasNegocio>();
            foreach (var fila in PreguntasDatos.Seleccionar())
            {
                PreguntasNegocio obj = new PreguntasNegocio();

                obj.IdPreg = (int)fila[0];
                obj.IdCat = (string)fila[1].ToString();
                obj.Pregunta = (string)fila[2];
                obj.RespuestaCorrecta = (string)fila[3];
                obj.RespuestaIncorrecta1 = (string)fila[4];
                obj.RespuestaIncorrecta2 = (string)fila[5];
                obj.CatDatos.NombreCategoria = (string)fila[6];
                
                lista.Add(obj);
            }
            return lista;
        }





        public static List<PreguntasNegocio> ListarAle()
        {
            List<PreguntasNegocio> lista = new List<PreguntasNegocio>();
            foreach (var fila in PreguntasDatos.SeleccionarAle())
            {
                PreguntasNegocio obj = new PreguntasNegocio();

                obj.IdPreg = (int)fila[0];
                obj.IdCat = (string)fila[1].ToString();
                obj.Pregunta = (string)fila[2];
                obj.RespuestaCorrecta = (string)fila[3];
                obj.RespuestaIncorrecta1 = (string)fila[4];
                obj.RespuestaIncorrecta2 = (string)fila[5];
                obj.CatDatos.NombreCategoria = (string)fila[6];
                obj.CatDatos.Imagen = (string)fila[7];
                lista.Add(obj);
            }
            return lista;
        }






    }
}
