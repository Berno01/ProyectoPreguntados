using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Globalization;
using System.Data;
using System.Drawing;
using System.IO;

namespace Datos
{
    internal class Conexion
    {
        private static string cadena = "Data Source= GHOST\\SERVIDORES;Initial Catalog=Preguntados;Integrated Security=True";
        //Ejecutar Consultas Insert, Update, Delete

        public static void Ejecutar(string consulta)
        {
            SqlConnection conex = new SqlConnection(cadena);
            conex.Open();
            SqlCommand command = new SqlCommand(consulta, conex);
            command.ExecuteNonQuery();
            conex.Close();
        }
        //Seleccionar Datos consulta Select
        public static List<object[]> Seleccionar(string consulta)
        {
            List<object[]> lista = new List<object[]>();
            SqlConnection conex = new SqlConnection(cadena);
            conex.Open();
            SqlCommand command = new SqlCommand(consulta, conex);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                object[] fila = new object[dr.FieldCount];
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    fila[i] = dr[i];
                }
                lista.Add(fila);
            }
            conex.Close();
            return lista;
        }

        public static DataTable EjecutarQuery (string q)
        {
            


            SqlConnection conex = new SqlConnection(cadena);
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(q, conex);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try 
            {
                conex.Open();
                da.Fill(dt);
                conex.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally { conex.Close(); }
            return dt;


        }

    }
}
