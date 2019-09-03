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
    public class CanchaRepo
    {

        string cnn = ConfigurationManager.ConnectionStrings["ConexionBaseDeDatos"].ConnectionString;

        public void GuardarCancha(Cancha cancha)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {
                conn.Open();

                string query = "INSERT INTO dbo.Cancha (tipoCancha, numeroCancha, estado) VALUES  (@seleCancha, @numeroCancha, @seleEstado)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@seleCancha", cancha.SeleCancha);
                cmd.Parameters.AddWithValue("@numeroCancha", cancha.NumeroCancha);
                cmd.Parameters.AddWithValue("@seleEstado", cancha.SeleEstado);

                cmd.ExecuteNonQuery();
            }
        }

        public void BorrarCancha(Cancha cancha)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {
                conn.Open();

                string query = "DELETE FROM dbo.Cancha WHERE idCancha = @idCancha";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idCancha", cancha.IdCancha);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarCancha()
        {
            DataTable dataTable = new DataTable();

            String query = "SELECT * from Cancha";

            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dataTable);

            conn.Close();

            return dataTable;
        }

        
        public void ModificarCancha(Cancha cancha)
        {
            SqlConnection conn = new SqlConnection(cnn);
            {
                conn.Open();

                string query = "UPDATE dbo.Cancha SET tipoCancha = @seleCancha, numeroCancha = @numeroCancha, estado = @seleEstado WHERE idCancha=@idCancha";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idCancha", cancha.IdCancha);
                cmd.Parameters.AddWithValue("@seleCancha", cancha.SeleCancha);
                cmd.Parameters.AddWithValue("@numeroCancha", cancha.NumeroCancha);
                cmd.Parameters.AddWithValue("@seleEstado", cancha.SeleEstado);

                cmd.ExecuteNonQuery();
            }
        }

        public Cancha BuscarCanchaPorID(int idCancha)
        {
            Cancha cancha = new Cancha();

            SqlDataReader sdr = null;

            string query = "SELECT * FROM Cancha WHERE idCancha = @idCancha";

            SqlConnection conn = new SqlConnection(cnn);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@idCancha", idCancha);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                sdr = cmd.ExecuteReader();

                sdr.Read();

                cancha.IdCancha = Convert.ToInt32(sdr["IdCancha"].ToString());
                cancha.SeleCancha = sdr["TipoCancha"].ToString();
                cancha.NumeroCancha = Convert.ToInt32(sdr["NumeroCancha"].ToString());
                cancha.SeleEstado = sdr["Estado"].ToString();
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
            return cancha;
        }
    }
}
