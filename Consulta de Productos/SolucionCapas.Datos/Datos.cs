using System.Collections.Generic;
using System.Linq;

namespace SolucionCapas.Datos
{
    public class ProductoDatos
    {
        private string _conexionString =
        "Server=127.0.0.1;Port=3306;Database=almacen;Uid=root;Pwd=;";


        public (string Código, string Nombre, int Precio)? BuscarPorCódigo(string código)
        {
            string query = "SELECT Código, Nombre, Precio FROM empleado WHERE Código = @Código";
            using (MySqlConnection conexion = new MySqlConnection(_conexionString))
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@Código", código);
                conexion.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string códigoDb = reader["Código"].ToString();
                        string nombreDb = reader["Nombre"].ToString();
                        int precioDb = reader.GetInt32("Precio");
                        return (códigoDb, nombreDb, precioDb);
                    }
                }
            }
            return null;
        }
    }
}