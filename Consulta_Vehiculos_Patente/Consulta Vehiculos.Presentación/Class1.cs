using Consulta_Vehiculos.Negocios;
namespace Consulta_Vehiculos.Presentación
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Ingrese Patente: ");
            string Patente = Console.ReadLine();

            VehiculosNegocio negocio = new VehiculosNegocio();

            Vehiculo vehiculo = negocio.ObtenerVehiculo(Patente);

            if (vehiculo != null)
                Console.WriteLine($"Vehiculo disponible: {vehiculo.Modelo} , Condición: ${vehiculo.Deudas}");
            else
                Console.WriteLine("Vehiculo no disponible");
        }
    }
}
