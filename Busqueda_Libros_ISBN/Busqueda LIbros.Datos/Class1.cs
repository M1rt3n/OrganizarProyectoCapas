namespace Busqueda_Libros.Datos
{
    public class LibrosDatos
    {
        private List<(long ISBN,string Título, string Autor, bool Disponible)> _tablaLibros = new List<(long, string, string, bool)>
        {
            (204172741094, "Cuentos de Terramar", "Ursula K. Le Guin", false),
            (289461249863, "El Señor de los Anillos", "J. R. R. Tolkien", true)
        };

        public (long ISBN, string Título, string Autor, bool Disponible)? BuscarPorISBN(long ISBN)
        {
            var resultado = _tablaLibros.FirstOrDefault(p => p.ISBN == ISBN);
            if (resultado.ISBN == null) return null;
            return resultado;
        }
    }
}
