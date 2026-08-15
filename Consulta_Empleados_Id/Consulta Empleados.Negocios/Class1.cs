using Consulta_Empleados.Datos;
namespace Consulta_Empleados.Negocios
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Departamento { get; set; }
    }
    public class EmpleadosNegocio
    {
        private EmpleadosDatos _datos = new EmpleadosDatos();

        public Empleado ObtenerEmpleado(int Id)
        {
            var resultado = _datos.BuscarPorId(Id);

            if (resultado == null) return null;

            return new Empleado
            {
                Id = resultado.Value.Id,
                Nombre = resultado.Value.Nombre,
                Puesto = resultado.Value.Puesto,
                Departamento = resultado.Value.Departamento
            };
        }
    }
}
