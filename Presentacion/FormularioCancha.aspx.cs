using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
using System.Data;

namespace Presentacion
{
    public partial class FormularioCancha : System.Web.UI.Page
    {
        private CanchaNego canchaNego = new CanchaNego();
        private Cancha cancha = new Cancha();
        private ListItem items;

        protected void Page_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < cancha.Estado.Length; x++)
            {
                items = new ListItem(cancha.Estado.GetValue(x).ToString(), x.ToString());
                ddlEstado.Items.Add(items);
            }

            for (int x = 0; x < cancha.TipoCancha.Length; x++)
            {
                items = new ListItem(cancha.TipoCancha.GetValue(x).ToString(), x.ToString());
                ddlTipoCancha.Items.Add(items);
            }
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