using System.Data.SqlClient;

namespace GestorMantenimiento
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            @"Server=DESKTOP-CQ4EC7K\SQLEXPRESS01;Database=GestorMantenimiento;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
