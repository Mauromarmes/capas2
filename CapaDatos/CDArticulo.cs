using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaEntidad;
using System.Configuration;
using System.Linq.Expressions;


namespace CapaDatos
{
    public class CDArticulo
    {
        Conexion oconexion = new Conexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar_articulo(CEArticulo oarticulo)
            
        {
            try
            {
                ocmd.CommandType = CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDcompras");
                ocmd.CommandText = "guardar_articulo";
                ocmd.Parameters.Add("@cod_articulo", oarticulo.Cod_articulo);
                ocmd.Parameters.Add("@nom_articulo", oarticulo.Nom_articulo);
                ocmd.Parameters.Add("@vlr_articulo", oarticulo.Vlr_articulo);
                ocmd.Parameters.Add("@cantidad", oarticulo.Cantidad);
                ocmd.Parameters.Add("@activo", oarticulo.Activo);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            } 
        }
    }
}
