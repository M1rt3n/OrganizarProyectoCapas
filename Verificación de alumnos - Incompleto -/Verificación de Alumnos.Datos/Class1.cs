using System.Collections.Generic;
using System.Linq;

namespace Verificación_de_Alumnos.Datos
{
    public class AlumnoDatos
    {
        private List<(string Legajo, string Nombre, int Condición)> _tablaAlumnos = new List<(string, string, int)>
        {
            ("981318", "Gilbert", 10),
            ("410947", "Analia", 9)
        };

        public (string Legajo, string Nombre, int Condición)? BuscarPorLegajo(string legajo)
        {
            var resultado = _tablaAlumnos.FirstOrDefault(p => p.Legajo == legajo);
            if (resultado.Legajo == null) return null;
            return resultado;
        }
    }

}