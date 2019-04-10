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
    public class CategoriaDA
    {
        private conexionBD conn = new conexionBD();
        private SqlCommand cmdCategoria = new SqlCommand();
        public List<Categorias> Listar()
        {
            List<Categorias> lista = new List<Categorias>();
            Categorias c;
            SqlDataReader lector;
            try
            {
                cmdCategoria.CommandType = CommandType.StoredProcedure;
                cmdCategoria.CommandText = "pa_Categorias_ListasTodos";
                cmdCategoria.Connection = conn.conectarBD();

                lector = cmdCategoria.ExecuteReader();

                while (lector.Read())
                {
                    c = new Categorias();
                    c.Codcategoria = (string)(lector[0]);
                    c.Descategoria = (string)(lector[1]);
                    lista.Add(c);
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
