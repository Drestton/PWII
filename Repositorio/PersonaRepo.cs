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
    public class PersonaRepo
    {
        string cnn = ConfigurationManager.ConnectionStrings["ConexionBaseDeDatos"].ConnectionString;

        public void GuardarPersona(Persona persona)
        {
            SqlConnection conn = new SqlConnection(cnn);
            conn.Open();

            try
            {

                string query = "INSERT INTO dbo.Persona (  nombre, apellido ) VALUES  ( 'Luis', 'Parada')";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@nombre", persona.Nombre);
                cmd.Parameters.AddWithValue("@apellido", persona.Apellido);

                cmd.ExecuteNonQuery();
            }
            catch { }
        }
        
    }
}
