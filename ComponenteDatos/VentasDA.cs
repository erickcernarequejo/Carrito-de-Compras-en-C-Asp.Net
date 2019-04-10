using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BDConexion;
using ComponenteEntidad;
using System.Data;
using System.Data.SqlClient;

namespace ComponenteDatos
{
    public class VentasDA
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdVentas = new SqlCommand(); 

        public string Insertar(Ventas prod)
        {
            string rpta = "";
            try
            {
                cmdVentas.CommandType = CommandType.StoredProcedure;
                cmdVentas.CommandText = "pa_ventas";
                cmdVentas.Connection = conn.conectarBD();
                {
                    cmdVentas.Parameters.AddWithValue("@codigo", prod.Codigo);
                    cmdVentas.Parameters.AddWithValue("@fecha", prod.Fecha);
                    cmdVentas.Parameters.AddWithValue("@subtotal", prod.Subtotal);
                    cmdVentas.Parameters.AddWithValue("@igv", prod.Igv);
                    cmdVentas.Parameters.AddWithValue("@total", prod.Total);
                    cmdVentas.Parameters.AddWithValue("@cliente", prod.Cliente);
                }
                int registros;
                registros = cmdVentas.ExecuteNonQuery();
                if (registros == 1)
                {
                    rpta = "OK";
                }
                else {
                    rpta = "Error al Insertar";
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return rpta;
        }

        public string contador;
        public List<Ventas> UltimoCod()
        {            
            SqlCommand sqlcmd = new SqlCommand("select count(VEN_Codigo),max (VEN_Codigo) from VENTA",conn.conectarBD());
            sqlcmd.CommandType = CommandType.Text;

            SqlDataReader PaTable = sqlcmd.ExecuteReader();
            List<Ventas> Coleccion = new List<Ventas>();
            while (PaTable.Read())
            {
                this.contador = Convert.ToString(PaTable.GetInt32(0));
                if (contador == "0")
                {
                    Coleccion.Add(new Ventas(PaTable.GetInt32(0).ToString()));

                }
                else {
                    Coleccion.Add(new Ventas(PaTable.GetString(1)));

                }
            }          
            return Coleccion;
        }
    }
}
