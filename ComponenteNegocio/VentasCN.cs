using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ComponenteEntidad;
using ComponenteDatos;

namespace ComponenteNegocio
{
    public class VentasCN
    {
        VentasDA cdao = new VentasDA();
        public string Insertar(Ventas cat)
        {
            return cdao.Insertar(cat);
        }
        public List<Ventas> UltimoEmp()
        {
            VentasDA cd = new VentasDA();
            return cd.UltimoCod();
        }
    }
}
