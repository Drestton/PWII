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
    public partial class EditarCancha : System.Web.UI.Page
    {
        Cancha cancha = new Cancha();
        CanchaNego canchaNego = new CanchaNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            int idCancha = int.Parse(Request["idCancha"].ToString());

            if (!Page.IsPostBack)
            {
                RellenarCampos(idCancha);
            }
        }

        protected void RellenarCampos(int idCancha)
        {
            if (Request.QueryString["idCancha"] != null)
            {
                int IdCancha = Convert.ToInt32(Request.QueryString["idCancha"]);

                Cancha cancha = canchaNego.BuscarCanchaPorID(idCancha);

                ddlTipoCancha.Text = cancha.SeleCancha;
                txtNumeroCancha.Text = cancha.NumeroCancha.ToString();
                ddlEstado.Text = cancha.SeleEstado;
            }
        }

        protected void btnGuardarCancha_Click(object sender, EventArgs e)
        {
            int IdCancha = Convert.ToInt32(Request.QueryString["idCancha"]);

            cancha.IdCancha = IdCancha;
            cancha.SeleCancha = ddlTipoCancha.SelectedItem.Text;
            cancha.NumeroCancha = Convert.ToInt32(txtNumeroCancha.Text);
            cancha.SeleEstado = ddlEstado.SelectedItem.Text;

            canchaNego.ModificarCancha(cancha);

            Response.Redirect("./ListarCancha.aspx");
        }
    }
}