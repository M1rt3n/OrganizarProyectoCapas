using System;
using SolucionCapas.Datos; // Lee a Datos

namespace SolucionCapas.Negocio
{
    
    public class Producto
    {
        public string Código { get; set; }
        public string Nombre { get; set; }
        public int Precio { get; set; }
    }

    public class ProductoNegocio
    {
        private ProductoDatos _datos = new ProductoDatos();

        public Producto ObtenerProducto(string código)
        {
            if (string.IsNullOrEmpty(código)) return null;

            var resultado = _datos.BuscarPorCódigo(código);

            if (resultado == null) return null;

            return new Producto
            {
                Código = resultado.Value.Código,
                Nombre = resultado.Value.Nombre,
                Precio = resultado.Value.Precio
            };
        }
    }
}