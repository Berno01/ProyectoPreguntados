using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Datos
{
    public class RegistroDatos
    {
        public static void Insertar(string ci, string nombreUser, int genero, int idPais, string usuario, string contra, string foto)
        {
            Conexion.Ejecutar("INSERT INTO Usuarios values ('"+ci+"', '"+nombreUser+"', 2, "+genero+", "+idPais+", '"+usuario+"', '"+contra+"', '"+foto+"')");
        }


        public static List<object[]> Seleccionar()
        {
            return Conexion.Seleccionar("select * from usuarios ");
        }

        public static List<object[]> SeleccionarRank()
        {
            return Conexion.Seleccionar("select U.ci, NombreCompleto, nombreGenero, U.foto, J.puntaje from usuarios U, Juego J, Genero G where U.idGenero = G.idGenero");
        }


    }
}
