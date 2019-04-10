using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponenteDatos
{
    class Conexion
    {
        private static readonly Conexion _instancia = new Conexion();
        
        public static Conexion Instancia
        {
            get { return _instancia; }
        }

        public string cadenaconexion()
        {
            return "Data Source=.;Initial Catalog=BDVENTAS_5;Integrated Security=True";
        }
    }
}
