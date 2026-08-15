using System;
using Verificación_Alumnos.Datos;

namespace Verificación_Alumnos.Negocios
{
    public class Alumno
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
        public int Condición { get; set; }
    }
    public class AlumnoNegocio
    {
        private AlumnoDatos _datos = new AlumnoDatos();

        public Alumno ObtenerAlumno(string legajo)
        {
            if (string.IsNullOrEmpty(legajo)) return null;

            var resultado = _datos.BuscarPorLegajo(legajo);

            if (resultado == null) return null;

            return new Alumno
            {
                Legajo = resultado.Value.Legajo,
                Nombre = resultado.Value.Nombre,
                Condición = resultado.Value.Condición
            };
        }
    }

}
