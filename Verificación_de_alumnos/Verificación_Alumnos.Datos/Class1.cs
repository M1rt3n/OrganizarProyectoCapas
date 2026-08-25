using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
namespace Verificación_Alumnos.Datos
{
    public class AlumnoDatos
    {
        private string _conexionString =
     "Server=127.0.0.1;Port=3306;Database=archivo;Uid=root;Pwd=;";

        public (string Legajo, string Nombre, int Condición)? BuscarPorLegajo(string legajo)
        {
            string query = "SELECT Legajo, Nombre, Condición FROM alumno WHERE Legajo = @Legajo";
            using (MySqlConnection conexion = new MySqlConnection(_conexionString))
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Legajo", legajo);
                conexion.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string legajoDb = reader["Legajo"].ToString();
                        string nombreDb = reader["Nombre"].ToString();
                        int condiciónDb = reader.GetInt32("Legajo");

                        return (legajoDb, nombreDb, condiciónDb);
                    }
                }
            }
            return null;
        }
    }
}

