using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Presentacion
{
    public partial class FormularioCancha : System.Web.UI.Page
    {
        CanchaNego canchaNego = new CanchaNego();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void GuardarCancha()
        {
            Cancha cancha = new Cancha();

            cancha.SeleCancha = ddlTipoCancha.SelectedItem.Text;
            cancha.NumeroCancha = Convert.ToInt32(txtNumeroCancha.Text);
            cancha.SeleEstado = ddlEstado.SelectedItem.Text;

            canchaNego.GuardarCancha(cancha);

            Response.Redirect("./ListarCancha.aspx");
        }

        protected void btnGuardarCancha_Click(object sender, EventArgs e)
        {
            GuardarCancha();
        }
    }
}