using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriaDatos
    {
        public static void Eliminar(int id)
        {
            Conexion.Ejecutar("DELETE FROM Categoria WHERE idCategoria = "+id);
        }


       

        public static void Insertar(string nombreCat, string imagen)
        {
            Conexion.Ejecutar("Insert into Categoria values('" + nombreCat + "', '"+imagen+"')");
        }

        public static void Modificar(int idCat,string nombreCat, string imagen)
        {

            Conexion.Ejecutar("update categoria set NombreCategoria='"+nombreCat+"', Imagen='"+imagen+"' where idCategoria="+idCat);
        }

        public static List<object[]> Seleccionar()
        {
            return Conexion.Seleccionar("SELECT * FROM Categoria");
        }

        public static DataTable SeleccionarEs()
        {
            return Conexion.EjecutarQuery("SELECT * FROM Categoria");
            
        }
    }

}
