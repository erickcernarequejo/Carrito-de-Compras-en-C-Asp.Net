using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ComponenteEntidad;
using ComponenteDatos;

namespace ComponenteNegocio
{
    public class ProductosCN
    {
        ProductosDA cdao = new ProductosDA();
        public List<Productos> ListarTodos()
        {
            return cdao.ListarTodos();
        }

        public string Insertar(Productos cat)
        {
            return cdao.Insertar(cat);
        }

        public Productos ListarporCategorias(string id)
        {
            return cdao.ListarporCategoria(id);
        }

    }
}
