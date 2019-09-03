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
    public partial class ListarTurno : System.Web.UI.Page
    {
        TurnoNego turnoNego = new TurnoNego();
        Turnos turnos = new Turnos();
             

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;

            CargarTablaTurno();
        }

        private void CargarTablaTurno()
        {
            GridViewTablaTurno.DataSource = turnoNego.ListarTurno();
            GridViewTablaTurno.DataBind();
        }

        
        protected void lnkDelete_Command(object sender, CommandEventArgs e)
        {
            if (e.CommandName == "lnkBorrar")
            {
                string turnos_Id = e.CommandArgument.ToString();

                turnos.Turnos_Id= int.Parse(turnos_Id);

                turnoNego.BorrarTurno(turnos);

                Response.Redirect("~/ListarTurno.aspx?turnos_Id=" + e.CommandArgument);

                
            }
        }

    }
}