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
    public partial class EditarCliente : System.Web.UI.Page
    {
        Cliente cliente = new Cliente();
        ClienteNego clienteNego = new ClienteNego();

        protected void Page_Load(object sender, EventArgs e)
        {
            int idCliente = int.Parse(Request["idCliente"].ToString());

            if (!Page.IsPostBack)
            {

                RellenaCampos(idCliente); //si es la primera vez que carga la pagina rellena los campos

            }
        }

        protected void RellenaCampos(int idCliente)
        {

            if (Request.QueryString["idCliente"] != null)
            {
                int IdCliente = Convert.ToInt32(Request.QueryString["idCliente"]);

                Cliente cliente = clienteNego.BuscarClientePorID(idCliente);


                txtNombreApellido.Text = cliente.NombreApellido;
                
                txtEdad.Text = cliente.Edad.ToString();
                txtDocumento.Text = cliente.Documento;
                txtDireccion.Text = cliente.Direccion;
                txtCorreo.Text = cliente.CorreoElectronico;
                txtTelefono.Text = cliente.Telefono.ToString();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int IdCliente = Convert.ToInt32(Request.QueryString["idCliente"]);

            cliente.IdCliente = IdCliente;
            cliente.NombreApellido = txtNombreApellido.Text;
            
            cliente.Edad = Convert.ToInt32(txtEdad.Text);
            cliente.Documento = txtDocumento.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.CorreoElectronico = txtCorreo.Text;
            cliente.Telefono = Convert.ToInt32(txtTelefono.Text);

            clienteNego.ModificarCliente(cliente);

            Response.Redirect("./ListarCliente.aspx");

        }
    }
}
