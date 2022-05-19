using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaEntidad;
using System.Data;
using CapaNegocio;

namespace WebApplication1
{
    public partial class FormArticulo : System.Web.UI.Page
    {
        CNArticulo onarticulo = new CNArticulo();
        CEArticulo oearticulo = new CEArticulo();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            oearticulo.Cod_articulo = Convert.ToString(txtArticulo.Text);
            oearticulo.Nom_articulo = Convert.ToString(txtNomArticulo.Text);
            oearticulo.Vlr_articulo = Convert.ToInt32(txtVlrArticulo.Text);
            oearticulo.Cantidad = Convert.ToInt32(txtCantidad.Text);
            oearticulo.Activo = Convert.ToByte(txtActivo.Text);

            if(onarticulo.guardar_articulo(oearticulo))
            {
                lblMensaje.Text = "Articulo Guardado";
            }
            else
            {
                lblMensaje.Text = "No se puede guardar el articulo";
            }
        }
    }
}