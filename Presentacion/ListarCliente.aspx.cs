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
    public partial class ListarCliente : System.Web.UI.Page
    {
        ClienteNego clienteNego = new ClienteNego();
        Cliente cliente = new Cliente();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            CargarTablaCliente();

        }

        private void CargarTablaCliente()
        {
            GridViewTablaCliente.DataSource = clienteNego.ListarCliente();
            GridViewTablaCliente.DataBind();
        }


        protected void lnkEdit_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "lnkEditar")
            {
                string idCliente = e.CommandArgument.ToString();
                Response.Redirect("~/EditarCliente.aspx?idCliente=" + e.CommandArgument);


            }
        }

        protected void lnkDelete_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "lnkBorrar")
            {
                string idCliente = e.CommandArgument.ToString();

                cliente.IdCliente = int.Parse(idCliente);

                clienteNego.BorrarCliente(cliente);

                Response.Redirect("~/ListarCliente.aspx?idCliente=" + e.CommandArgument);
            }
        }

        protected void lnkReservar_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "lnkReservar")
            {
                string idCliente = e.CommandArgument.ToString();

                cliente.IdCliente = int.Parse(idCliente);

                Response.Redirect("~/ReservarTurno.aspx?idCliente=" + e.CommandArgument);
            }
        }
    }
}