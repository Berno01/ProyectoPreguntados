using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class PreguntasDatos
    {
        public static void Insertar(string categoria, string pregunta, string respCorr, string respInc1, string respInc2)
        {
            Conexion.Ejecutar("insert into Preguntas values('" + categoria + "', '" + pregunta + "', '" + respCorr + "', '" + respInc1 + "', '" + respInc2 + "')");
        }
        public static void Actualizar(string idCat, string pregunta, string respCorr, string respInc1, string respInc2, int idPregunta)
        {
            Conexion.Ejecutar("UPDATE Preguntas set idCategoria = "+idCat+", Pregunta = '"+pregunta+"', RespuestaCorrecta = '"+respCorr+"', RespuestaIncorrecta1 = '"+respInc1+"', RespuestaIncorrecta2 = '"+respInc2+"' where idPregunta= "+idPregunta);
        }
        public static void Eliminar(int id)
        {
            Conexion.Ejecutar("Delete from Preguntas where idPregunta = "+ id);
        }
        public static List<object[]> Seleccionar()
        {
            return Conexion.Seleccionar("select idPregunta, P.idCategoria, Pregunta, RespuestaCorrecta, RespuestaIncorrecta1, RespuestaIncorrecta2, NombreCategoria  FROM Preguntas P, Categoria C where P.idCategoria=C.idCategoria");

            /*return Conexion.Seleccionar("select Pregunta, RespuestaCorrecta, RespuestaIncorrecta1, RespuestaIncorrecta2, NombreCategoria FROM Preguntas P, Categoria C where P.idCategoria=C.idCategoria");
             */
            
        }

        public static List<object[]> SeleccionarAle()
        {
            return Conexion.Seleccionar("select TOP 1 idPregunta, P.idCategoria, Pregunta, RespuestaCorrecta, RespuestaIncorrecta1, RespuestaIncorrecta2, C.NombreCategoria, C.Imagen from Preguntas P, Categoria C order BY NEWID()");

          
        }



    }
}
