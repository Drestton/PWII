using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dominio;

namespace Repositorio
{
    public class ClienteRepo
    {

        string cnn = ConfigurationManager.ConnectionStrings["ConexionBaseDeDatos"].ConnectionString;

        public DataTable ListarCliente()
        {
            DataTable dataTable = new DataTable();

            SqlConnection conn = new SqlConnection(cnn);
        
            conn.Open();

            SqlCommand cmd = new SqlCommand("clienteListar", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //toma el datatable y mete lo que traigamos de la query
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dataTable);

            conn.Close();

            return dataTable;
        }

        public void GuardarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("clienteGuardar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombreApellido", cliente.NombreApellido);
                
                cmd.Parameters.AddWithValue("@edad", cliente.Edad);
                cmd.Parameters.AddWithValue("@documento", cliente.Documento);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@correoElectronico", cliente.CorreoElectronico);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);

                cmd.ExecuteNonQuery();

            }

        }
        public void BorrarCliente(Cliente cliente)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();

                SqlCommand cmd = new SqlCommand("clienteBorrar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                cmd.ExecuteNonQuery();
            }
        }

        

        public void ModificarCliente(Cliente cliente)
        {

            SqlConnection conn = new SqlConnection(cnn);
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("clienteModificar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", cliente.IdCliente);
                cmd.Parameters.AddWithValue("@nombreApellido", cliente.NombreApellido);
                
                cmd.Parameters.AddWithValue("@edad", cliente.Edad);
                cmd.Parameters.AddWithValue("@documento", cliente.Documento);
                cmd.Parameters.AddWithValue("@direccion", cliente.Direccion);
                cmd.Parameters.AddWithValue("@correoElectronico", cliente.CorreoElectronico);
                cmd.Parameters.AddWithValue("@telefono", cliente.Telefono);

                cmd.ExecuteNonQuery();
            }
        }
        public Cliente BuscarClientePorID(int idCliente)
        {
            Cliente cliente = new Cliente();

            SqlDataReader sdr = null;

            SqlConnection conn = new SqlConnection(cnn);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("clienteBuscarPorId", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                cmd.ExecuteNonQuery();

                sdr = cmd.ExecuteReader();

                sdr.Read();

                cliente.IdCliente = Convert.ToInt32(sdr["IdCliente"].ToString());
                cliente.NombreApellido = sdr["NombreApellido"].ToString();
                
                cliente.Edad = Convert.ToInt32(sdr["Edad"].ToString());
                cliente.Documento = sdr["Documento"].ToString();
                cliente.Direccion = sdr["Direccion"].ToString();
                cliente.CorreoElectronico = sdr["CorreoElectronico"].ToString();
                cliente.Telefono = Convert.ToInt32(sdr["Telefono"].ToString());

            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                string msg = "Insert Error:";
                msg += ex.Message;
                throw new Exception(msg);
            }
            finally
            {
                conn.Close();
            }
            return cliente;
        }
    }
}