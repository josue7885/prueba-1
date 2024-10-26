using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace prueva1bloque2
{
    internal class db_conexion
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand miCommando = new SqlCommand();
        SqlDataAdapter miAdaptador = new SqlDataAdapter();
        DataSet ds = new DataSet();

        public db_conexion() {
        miConexion.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\bd_bloque2.mdf;Integrated Security=True";
                }
        public DataSet obtenerDatos()
        {
            ds.Clear();
            miCommando.Connection= miConexion;
            miCommando.CommandText = "SELECT * FROM peliculas";
            miAdaptador.Fill(ds, "peliculas");

            miAdaptador.SelectCommand = miCommando;
            miAdaptador.Fill(ds, "peliculas");

            return ds;
        }
    }
}
