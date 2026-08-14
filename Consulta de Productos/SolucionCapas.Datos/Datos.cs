using System.Collections.Generic;
using System.Linq;

namespace SolucionCapas.Datos
{
    public class ProductoDatos
    {
        private List<(string Código, string Nombre, int Precio)> _tablaProductos = new List<(string, string, int)>
        {
            ("14628723", "Heladera", 15000),
            ("19236094", "Silla", 3500)
        };

        public (string Código, string Nombre, int Precio)? BuscarPorCódigo(string código)
        {
            var resultado = _tablaProductos.FirstOrDefault(p => p.Código == código);
            if (resultado.Código == null) return null;
            return resultado;
        }
    }
}
