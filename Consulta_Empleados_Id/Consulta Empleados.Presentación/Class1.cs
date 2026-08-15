using Consulta_Empleados.Negocios;
namespace Consulta_Empleados.Presentación
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Ingrese Id: ");
            int Id = Convert.ToInt32(Console.ReadLine());

            EmpleadosNegocio negocio = new EmpleadosNegocio();

            Empleado empleado = negocio.ObtenerEmpleado(Id);

            if (empleado != null)
                Console.WriteLine($"Empleado encontrado: {empleado.Nombre}, Puesto: ${empleado.Puesto}, Departamento: ${empleado.Departamento}");
            else
                Console.WriteLine("Empleado no encontrado");
        }
    }
}
