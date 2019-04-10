using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ComponenteEntidad;
using ComponenteDatos;

namespace ComponenteNegocio
{
    public class DetalleVentaCN
    {
        DetalleVentaDA cdao = new DetalleVentaDA();
        public string Insertar(DetalleVenta cat)
        {
            return cdao.Insertar(cat);
        }
    }
}
