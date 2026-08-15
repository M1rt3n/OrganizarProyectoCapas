using System;
using Verificación_Alumnos.Negocios;

namespace Verificación_Alumnos.Presentación
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Ingrese Legajo: ");
            string Legajo = Console.ReadLine();

            AlumnoNegocio negocio = new AlumnoNegocio();

            Alumno alumno = negocio.ObtenerAlumno(Legajo);

            if (alumno != null)
                Console.WriteLine($"Encontrado: {alumno.Nombre} , Condición: ${alumno.Condición}");
            else
                Console.WriteLine("No existe.");
        }

    }
}
