namespace Busqueda_Libros.Datos
{
    public class LibrosDatos
    {
        private string _conexionString =
        "Server=127.0.0.1;Port=3306;Database=biblioteca;Uid=root;Pwd=;";


        public (long ISBN, string Título, string Autor, bool Disponible)? BuscarPorISBN(long isbn)
        {
            string query = "SELECT ISBN, Título, Autor, Disponible FROM libro WHERE ISBN = @ISBN";
            using (MySqlConnection conexion = new MySqlConnection(_conexionString))
            {
                MySqlCommand comando = new MySqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@ISBN", isbn);
                conexion.Open();
                using (MySqlDataReader reader = comando.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int isbnDb = reader.GetInt32("ISBN");
                        string títuloDb = reader["Título"].ToString();
                        string autorDb = reader["Autor"].ToString();
                        string disponibleDb = reader["Disponible"].ToString();

                        return (isbnDb, títuloDb, autorDb, disponibleDb);
                    }
                }
            }
            return null;
        }
    }
}