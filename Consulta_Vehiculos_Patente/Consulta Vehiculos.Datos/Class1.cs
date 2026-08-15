namespace Consulta_Vehiculos.Datos
{
    public class VehiculosDatos
    {
        private List<(string Patente, string Modelo, int Deudas)> _tablaVehiculos = new List<(string, string, int)>
        {
            ("872415", "Ferrari", 1000),
            ("982645", "Chevrolt", 0)
        };

        public (string Patente, string Modelo, int Deudas)? BuscarPorPatente(string patente)
        {
            var resultado = _tablaVehiculos.FirstOrDefault(p => p.Patente == patente);
            if (resultado.Patente == null) return null;
            return resultado;
        }
    }
}
