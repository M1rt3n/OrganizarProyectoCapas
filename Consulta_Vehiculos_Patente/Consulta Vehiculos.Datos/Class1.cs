using MySql.Data.MySqlClient;
namespace Consulta_Vehiculos.Datos
{
    public class VehiculosDatos
    {
        private string _conexionString =
     "Server=127.0.0.1;Port=3306;Database=almacen;Uid=root;Pwd=;";

        public (string Patente, string Modelo, int Deudas)? BuscarPorPatente(string patente)
        {
            string query = "SELECT Patente, Nombre, Deudas FROM automovil WHERE Patente = @Patente";
            using (MySqlConnection conexion = new MySqlConnection(_conexionString))
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Patente", patente);
                conexion.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string patenteDb = reader["Patente"].ToString();
                        string nombreDb = reader["Nombre"].ToString();
                        int deudasDb = reader.GetInt32("Deudas");
                        return (patenteDb, nombreDb, deudasDb);
                    }
                }
            }
            return null;
        }
    }
}
