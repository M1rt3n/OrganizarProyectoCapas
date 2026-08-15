using Busqueda_Libros.Negocios;
namespace Busqueda_Libros.Presentación
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Ingrese ISBN: ");
            long ISBN = Convert.ToInt32(Console.ReadLine());

            LibrosNegocio negocio = new LibrosNegocio();

            Libro libro = negocio.ObtenerLibro(ISBN);

            if (libro != null)
                Console.WriteLine($"Libro encontrado: {libro.Título}, Autor: ${libro.Autor}, Disponible{libro.Disponible}");
            else
                Console.WriteLine("Libro no encontrado");
        }
    }
}
