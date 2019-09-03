using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Presentacion
{
    public partial class ListarCancha : System.Web.UI.Page
    {
        CanchaNego canchaNego = new CanchaNego();
        Cancha cancha = new Cancha();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            CargarTablaCancha();
        }

        private void CargarTablaCancha()
        {
            GridViewTablaCancha.DataSource = canchaNego.ListarCancha();
            GridViewTablaCancha.DataBind();
        }

       

        protected void lnkBorrar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "lnkBorrar")
            {
                string idCancha = e.CommandArgument.ToString();

                cancha.IdCancha = int.Parse(idCancha);

                canchaNego.BorrarCancha(cancha);

                Response.Redirect("/ListarCancha.aspx?idCancha=" + e.CommandArgument);
            }
        }

        protected void lnkEdit_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "lnkEditar")
            {
                string idCancha = e.CommandArgument.ToString();
                Response.Redirect("~/EditarCancha.aspx?idCancha=" + e.CommandArgument);
            }
        }
    }
}