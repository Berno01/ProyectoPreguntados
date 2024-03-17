using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class JuegoDatos
    {
        public static void Insertar(string idCat, string ci, double puntaje)
        {
            Conexion.Ejecutar("insert into Juego values("+idCat+", '"+ci+"', "+puntaje+")");
        }

        public static void Seleccionar()
        {
            Conexion.Ejecutar("select TOP 1 * from Preguntas ORDER BY NEWID()");
        }

    }
}
