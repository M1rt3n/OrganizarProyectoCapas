using System;
using SolucionCapas.Negocio;

public class Program
{
    public static void Main()
    {
        Console.Write("Ingrese Código: ");
        string código = Console.ReadLine();

        ProductoNegocio negocio = new ProductoNegocio();

        Producto producto = negocio.ObtenerProducto(código);

        if (producto != null)
            Console.WriteLine($"Encontrado: {producto.Nombre} , Precio: ${producto.Precio}");
        else
            Console.WriteLine("No existe.");
    }
}
