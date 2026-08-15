using Consulta_Vehiculos.Datos;

namespace Consulta_Vehiculos.Negocios
{
    public class Vehiculo
    {
        public string Patente { get; set; }
        public string Modelo { get; set; }
        public int Deudas { get; set; }
    }
    public class VehiculosNegocio
    {
        private VehiculosDatos _datos = new VehiculosDatos();

        public Vehiculo ObtenerVehiculo(string patente)
        {
            if (string.IsNullOrEmpty(patente)) return null;

            var resultado = _datos.BuscarPorPatente(patente);

            if (resultado == null) return null;

            return new Vehiculo
            {
                Patente = resultado.Value.Patente,
                Modelo = resultado.Value.Modelo,
                Deudas = resultado.Value.Deudas
            };
        }
    }
}
