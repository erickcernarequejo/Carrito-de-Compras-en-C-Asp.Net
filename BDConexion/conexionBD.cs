using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace BDConexion
{
    public class conexionBD
    {
        //private string cadena = @"Data Source=ERICK-PC\SQLEXPRESS;Initial Catalog=BDVENTAS_5;Integrated Security=True";
        private string cadena = @"Data Source=.;Initial Catalog=BDVENTAS_5;Integrated Security=True";
        private SqlConnection conexion;

        public SqlConnection conectarBD()
        {
            conexion = new SqlConnection(cadena);
            if (conexion.State == ConnectionState.Open)
            {
                conexion.Close();
            }
            else {
                conexion.Open();
            }
            return conexion;
        }
    }
}
