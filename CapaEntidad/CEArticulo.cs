using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class CEArticulo
    {
        private string cod_articulo;
        private string nom_articulo;
        private int vlr_articulo;
        private int cantidad;
        private byte activo;

        public string Cod_articulo { get => cod_articulo; set => cod_articulo = value; }
        public string Nom_articulo { get => nom_articulo; set => nom_articulo = value; }
        public int Vlr_articulo { get => vlr_articulo; set => vlr_articulo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
