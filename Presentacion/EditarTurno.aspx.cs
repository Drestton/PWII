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
	public partial class EditarTurno : System.Web.UI.Page
	{
        Turnos turnos = new Turnos();
        TurnoNego turnoNego = new TurnoNego();
        ClienteNego clienteNego = new ClienteNego();
		protected void Page_Load(object sender, EventArgs e)
		{
            string turnos_Id = Request["turnos_Id"].ToString();

            if (IsPostBack)
            {
                return;
            }
            else
            {
                RellenarCampos();
                DatosCliente();
                LlenaDropDownListCancha();
            }
           

		}

        private void LlenaDropDownListCancha()
        {
            CanchaNego canchaNego = new CanchaNego();
            ddlCancha.DataSource = canchaNego.ListarCancha();
            ddlCancha.DataBind();
            ddlCancha.Items.Insert(0, new ListItem("---Seleccione---"));

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

        protected void RellenarCampos()
        {
            if(Request.QueryString["turnos_Id"] != null)
            {
                int turnos_Id = Convert.ToInt32(Request.QueryString["turnos_Id"]);
                Turnos turnos = turnoNego.BuscarTurnoPorId(turnos_Id);

                txtFecha.Text = turnos.Fecha.ToString();               
                ddlFranjaHoraria.Text = turnos.FranjaHoraria1;
                ddlEstado.Text = turnos.Estado;
                                
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int turnos_Id = Convert.ToInt32(Request.QueryString["turnos_Id"]);

            turnos.Turnos_Id = turnos_Id;
            turnos.IdCliente = Convert.ToInt32(Request.QueryString["idCliente"]);
            turnos.Fecha = Convert.ToDateTime(txtFecha.Text);
            turnos.FranjaHoraria1 = ddlFranjaHoraria.Text;
            turnos.Estado = ddlEstado.Text;


            turnoNego.ModificarTurno(turnos);

            Response.Redirect("./ListarTurno.aspx");
        }

    }
}