namespace Consulta_Empleados.Datos
{
    public class EmpleadosDatos
    {
        private List<(int Id, string Nombre, string Puesto, string Departamento)> _tablaEmpleados = new List<(int, string, string, string)>
        {
            (98713, "German", "Gerente", "Ventas"),
            (198236, "Javier", "Presidente", "IT")
        };

        public (int Id, string Nombre, string Puesto, string Departamento)? BuscarPorId(int Id)
        {
            var resultado = _tablaEmpleados.FirstOrDefault(p => p.Id == Id);
            if (resultado.Id == null) return null;
            return resultado;
        }
    }
}
