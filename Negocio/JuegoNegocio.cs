using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class JuegoNegocio
    {
        private int idJuego;
        private string idCat;
        private string ci;
        private double puntaje;



        public int IdJuego
        {
            get { return idJuego; }
            set { idJuego = value; }
        }
        public string IdCat
        {
            get { return idCat; }       
            set { idCat = value; }
        }

        public string Ci
        {
            get { return ci; }
            set { ci = value; }
        }

        public double Puntaje
        {
            get { return puntaje; }
            set{ puntaje = value; }
        }


        public void Registrar()
        {
            JuegoDatos.Insertar(this.IdCat, this.Ci, this.Puntaje);
        }






    }
}
