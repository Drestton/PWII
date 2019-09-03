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
    public class TurnoRepo
    {
        string cnn = ConfigurationManager.ConnectionStrings["ConexionBaseDeDatos"].ConnectionString;

        public void GuardarTurno(Turnos turnos)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {

                conn.Open();

                string query = "INSERT INTO dbo.Turno (idCliente, idCancha, fecha, franjaHoraria ,estado) VALUES  (@idCliente, @idCancha, @fecha, @franjaHoraria, @estado)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@idCliente", turnos.IdCliente);
                cmd.Parameters.AddWithValue("@idCancha", turnos.IdCancha);
                cmd.Parameters.AddWithValue("@fecha", turnos.Fecha);
                cmd.Parameters.AddWithValue("@franjaHoraria", turnos.FranjaHoraria1);
                cmd.Parameters.AddWithValue("@estado", turnos.Estado);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public void BorrarTurno(Turnos turnos)
        {
            SqlConnection conn = new SqlConnection(cnn);

            {
                conn.Open();

                string query = "DELETE FROM dbo.Turno WHERE turnos_Id = @turnos_Id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@turnos_Id", turnos.Turnos_Id);

                cmd.ExecuteNonQuery();

            }
        }



        public void ModificarTurno(Turnos turnos)
        {

            SqlConnection conn = new SqlConnection(cnn);
            {
                conn.Open();

                string query = "UPDATE dbo.Turno SET idCliente=@idCliente, idCancha=@idCancha, fecha=@fecha, franjaHoraria=@franjaHoraria, estado=@estado WHERE turnos_Id=@turnos_Id ";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@turnos_Id", turnos.Turnos_Id);
                cmd.Parameters.AddWithValue("@idCliente", turnos.IdCliente);
                cmd.Parameters.AddWithValue("@idCancha", turnos.IdCancha);
                cmd.Parameters.AddWithValue("@fecha", turnos.Fecha);
                cmd.Parameters.AddWithValue("@FranjaHoraria", turnos.FranjaHoraria1);
                cmd.Parameters.AddWithValue("@estado", turnos.Estado);

                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }

        public DataTable ListarTurno()
        {
            DataTable dataTable = new DataTable();

            String query = "SELECT * FROM dbo.Turno";

            SqlConnection conn = new SqlConnection(cnn);

            SqlCommand cmd = new SqlCommand(query, conn);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dataTable);

            conn.Close();

            return dataTable;

        }

        public Turnos BuscarTurnoPorId(int turnos_Id)
        {

            Turnos turnos = new Turnos();

            SqlDataReader sdr = null;

            string query = "SELECT * FROM Turno WHERE turnos_Id = @turnos_Id";

            SqlConnection conn = new SqlConnection(cnn);

            try
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@turnos_Id", turnos_Id);

                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();

                sdr = cmd.ExecuteReader();

                sdr.Read();

                turnos.Turnos_Id = Convert.ToInt32(sdr["turnos_Id"].ToString());
                turnos.IdCliente = Convert.ToInt32(sdr["idCliente"].ToString());
                turnos.IdCancha = Convert.ToInt32(sdr["idCancha"].ToString());
                turnos.Fecha = Convert.ToDateTime(sdr["Fecha"]);
                turnos.FranjaHoraria1 = sdr["FranjaHoraria"].ToString();
                turnos.Estado = sdr["Estado"].ToString();


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
            return turnos;
        }
    }

}

