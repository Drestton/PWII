using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace Presentacion
{
    public partial class GrillaTurno : System.Web.UI.Page
    {
        TurnoNego turnoNego = new TurnoNego();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargarCombo();
        }

        protected void ddlFranjaHoraria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string texto = ddlFranjaHoraria.SelectedItem.Text;
            string valor = ddlFranjaHoraria.SelectedItem.Value;
            txtFranjaHoraria.Text = ddlFranjaHoraria.SelectedItem.Text;
        }

        protected void CargarCombo()
        {
            List<ListarTurno> listaCliente = new List<ListarTurno>();

            ddlFranjaHoraria.DataSource = listaCliente;
            ddlFranjaHoraria.DataTextField = "nombreReserva";
            ddlFranjaHoraria.DataValueField = "turnos_Id";
            ddlFranjaHoraria.DataBind();
        }

    }
}