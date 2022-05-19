using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;


namespace CapaNegocio
{
    public class CNArticulo
    {
        CDArticulo odarticulo = new CDArticulo();
        public bool guardar_articulo(CEArticulo oenarticulo)
        {
            return odarticulo.guardar_articulo(oenarticulo);
        }
        
        
    }
}
