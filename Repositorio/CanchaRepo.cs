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

                SqlCommand cmd = new SqlCommand("canchaGuardarModificar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCancha", 0);
                cmd.Parameters.AddWithValue("@tipoCancha", cancha.SeleCancha);
                cmd.Parameters.AddWithValue("@numeroCancha", cancha.NumeroCancha);
                cmd.Parameters.AddWithValue("@estado", cancha.SeleEstado);

                cmd.ExecuteNonQuery();
            }
        }

        public void BorrarCancha(Cancha cancha)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("canchaBorrar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCancha", cancha.IdCancha);

                cmd.ExecuteNonQuery();
            }
        }

        public DataTable ListarCancha()
        {
            DataTable dataTable = new DataTable();

            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();

            SqlCommand cmd = new SqlCommand("canchaListar", conn);
            cmd.CommandType = CommandType.StoredProcedure;

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

                SqlCommand cmd = new SqlCommand("canchaGuardarModificar", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCancha", cancha.IdCancha);
                cmd.Parameters.AddWithValue("@tipoCancha", cancha.SeleCancha);
                cmd.Parameters.AddWithValue("@numeroCancha", cancha.NumeroCancha);
                cmd.Parameters.AddWithValue("@estado", cancha.SeleEstado);

                cmd.ExecuteNonQuery();
            }
        }

        public Cancha BuscarCanchaPorID(int idCancha)
        {
            Cancha cancha = new Cancha();

            SqlDataReader sdr = null;

            SqlConnection conn = new SqlConnection(cnn);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand("canchaBuscarPorId", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCancha", idCancha);

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
