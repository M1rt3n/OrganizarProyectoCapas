using System;
using Verificación_de_Alumnos.Negocios;

namespace Verificación_de_Alumnos.Presentación
{
    public class Program
    {
        public static void Main()
        {
            Console.Write("Ingrese Legajo: ");
            string Legajo = Console.ReadLine();

            AlumnoNegocio negocio = new AlumnoNegocio();

            Alumno alumno = negocio.ObtenerAlumno(Legajo);

            if (Alumno != null)
                Console.WriteLine($"Encontrado: {Alumno.Nombre} , Condición: ${Alumno.Condición}");
            else
                Console.WriteLine("No existe.");
        }

    }
}