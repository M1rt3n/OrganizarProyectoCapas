using Busqueda_Libros.Datos;
namespace Busqueda_Libros.Negocios
{
    public class Libro
    {
        public long ISBN { get; set; }
        public string Título { get; set; }
        public string Autor { get; set; }
        public bool Disponible { get; set; }
    }
    public class LibrosNegocio
    {
        private LibrosDatos _datos = new LibrosDatos();

        public Libro ObtenerLibro(long ISBN)
        {
            var resultado = _datos.BuscarPorISBN(ISBN);

            if (resultado == null) return null;

            return new Libro
            {
                ISBN = resultado.Value.ISBN,
                Título = resultado.Value.Título,
                Autor = resultado.Value.Autor,
                Disponible = resultado.Value.Disponible
            };
        }
    }
}
