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
    public class DetalleVentaDA
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdDetalleVentas = new SqlCommand();

        public string Insertar(DetalleVenta prod)
        {
            string rpta = "";
            try
            {
                cmdDetalleVentas.CommandType = CommandType.StoredProcedure;
                cmdDetalleVentas.CommandText = "pa_detalleventa";
                cmdDetalleVentas.Connection = conn.conectarBD();
                {
                    cmdDetalleVentas.Parameters.AddWithValue("@codigo", prod.Codigo);
                    cmdDetalleVentas.Parameters.AddWithValue("@cantidad", prod.Cantidad);
                    cmdDetalleVentas.Parameters.AddWithValue("@precio", prod.Precio);
                    cmdDetalleVentas.Parameters.AddWithValue("@subtotal", prod.Subtotal);
                    cmdDetalleVentas.Parameters.AddWithValue("@codproducto", prod.Codproducto);
                }
                int registros;
                registros = cmdDetalleVentas.ExecuteNonQuery();
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
    }
}
