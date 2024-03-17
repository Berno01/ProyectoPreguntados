using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class RankDatos
    {
        public static List<object[]> Seleccionar()
        {
            return Conexion.Seleccionar("SELECT * FROM Categoria");
        }

    }
}
