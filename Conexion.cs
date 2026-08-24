using System.Data.SqlClient;

namespace GestorMantenimiento
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            @"Server=Tu servidor;Database=GestorMantenimiento;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
