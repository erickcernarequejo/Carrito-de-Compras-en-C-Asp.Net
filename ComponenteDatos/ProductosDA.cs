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
    public class ProductosDA
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdProducto = new SqlCommand();

        public string Insertar(Productos prod)
        {
            string rpta = "";
            try
            {
                cmdProducto.CommandType = CommandType.StoredProcedure;
                cmdProducto.CommandText = "pa_Productos_insertar";
                cmdProducto.Connection = conn.conectarBD();
                {
                    cmdProducto.Parameters.AddWithValue("@codproducto", prod.Codproducto);
                    cmdProducto.Parameters.AddWithValue("@desproducto", prod.Desproducto);
                    cmdProducto.Parameters.AddWithValue("@codcategoria", prod.Codcategoria);
                    cmdProducto.Parameters.AddWithValue("@preproducto", prod.Preproducto);
                    cmdProducto.Parameters.AddWithValue("@canproducto", prod.Canproducto);
                }
                int registros;
                registros = cmdProducto.ExecuteNonQuery();
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

        public Productos ListarporCategoria(string codcategoria)
        {
            Productos p = new Productos();
            SqlDataReader lector;
            try
            {
                cmdProducto.CommandType = CommandType.StoredProcedure;
                cmdProducto.CommandText = "PA_Productos_Bucar_Por_Categorias";
                cmdProducto.Connection = conn.conectarBD();
                {
                    cmdProducto.Parameters.AddWithValue("@codcategoria", codcategoria);
                }

                lector = cmdProducto.ExecuteReader();

                if (lector.Read())
                {
                    p = new Productos();
                    p.Codproducto= (string)(lector[0]);
                    p.Desproducto = (string)(lector[1]);
                    p.Codcategoria = (string)(lector[2]);
                    p.Preproducto = (double)(lector[3]);
                    p.Canproducto = (int)(lector[4]);
                    p.Imagen = (string)(lector[5]);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return p;
        }

        public List<Productos> ListarTodos()
        {
            List<Productos> lista = new List<Productos>();
            Productos p;
            SqlDataReader lector;
            try
            {
                cmdProducto.CommandType = CommandType.StoredProcedure;
                cmdProducto.CommandText = "pa_productos_ListarTodos";
                cmdProducto.Connection = conn.conectarBD();

                lector = cmdProducto.ExecuteReader();

                while (lector.Read())
                {
                    p = new Productos();
                    p.Codproducto = (string)(lector[0]);
                    p.Desproducto = (string)(lector[1]);
                    p.Codcategoria = (string)(lector[2]);
                    p.Preproducto = (double)(lector[3]);
                    p.Canproducto = (int)(lector[4]);
                    p.Imagen = (string)(lector[5]);
                    lista.Add(p);
                }
            }
            catch (Exception ex)
            {
                System.Console.Write(ex.Message);
            }
            return lista;
        }
    }
}
