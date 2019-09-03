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
    public partial class ReservarTurno : System.Web.UI.Page
    {
        TurnoNego turnoNego = new TurnoNego();
        ClienteNego clienteNego = new ClienteNego();

        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (IsPostBack)
            {
                return;
            }
            else
            {
                DatosCliente();

                LlenaDropDownListCancha();
            }
        }
    

        public void DatosCliente()
        {
            if (Request.QueryString["idCliente"] != null)
            {
                int idCliente = Convert.ToInt32(Request.QueryString["idCliente"]);

                Cliente cliente = clienteNego.BuscarClientePorID(idCliente);

                lblNombreApellido.Text = cliente.NombreApellido;
                lblDNI.Text = cliente.Documento;
            }
        }

        protected void GuardarTurno_Click(object sender, EventArgs e)
        {
            CargarTurno();

        }

        private void LlenaDropDownListCancha()
        {
            CanchaNego canchaNego = new CanchaNego();
            ddlCancha.DataSource = canchaNego.ListarCancha();
            ddlCancha.DataBind();
            ddlCancha.Items.Insert(0, new ListItem("---Seleccione---"));

        }

        public void CargarTurno()
        {
            Turnos t1 = new Turnos();

            t1.IdCliente = Convert.ToInt32(Request.QueryString["idCliente"]);
            t1.Fecha = Convert.ToDateTime(txtFecha.Text);
            t1.FranjaHoraria1 = ddlFranjaHoraria.Text;
            t1.Estado = ddlEstado.Text;

            turnoNego.GuardarTurno(t1);

            Response.Redirect("./ListarTurno.aspx");

        }

       
    }
}