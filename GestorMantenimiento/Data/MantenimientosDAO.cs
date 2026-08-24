using System;
using System.Data;
using System.Data.SqlClient;

namespace GestorMantenimiento
{
    public class MantenimientosDAO
    {


        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
                    SELECT
                        m.id,
                        m.equipo_id,
                        e.codigo AS codigo_equipo,
                        e.tipo AS tipo_equipo,
                        e.marca,
                        e.modelo,
                        m.usuario_id,
                        m.tipo,
                        m.problema,
                        m.diagnostico,
                        m.solucion,
                        m.costo,
                        m.fecha_mantenimiento,
                        m.observaciones
                    FROM mantenimientos m
                    INNER JOIN equipos e
                        ON m.equipo_id = e.id
                    ORDER BY m.fecha_mantenimiento DESC";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }



        public DataTable ObtenerEquipos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
                    SELECT
                        id,
                        codigo,
                        tipo,
                        marca,
                        modelo
                    FROM equipos
                    ORDER BY codigo";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }


        public DataTable Buscar(string texto)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
                    SELECT
                        m.id,
                        m.equipo_id,
                        e.codigo AS codigo_equipo,
                        e.tipo AS tipo_equipo,
                        e.marca,
                        e.modelo,
                        m.usuario_id,
                        m.tipo,
                        m.problema,
                        m.diagnostico,
                        m.solucion,
                        m.costo,
                        m.fecha_mantenimiento,
                        m.observaciones
                    FROM mantenimientos m
                    INNER JOIN equipos e
                        ON m.equipo_id = e.id
                    WHERE
                        e.codigo LIKE @texto
                        OR e.marca LIKE @texto
                        OR e.modelo LIKE @texto
                        OR m.tipo LIKE @texto
                        OR m.problema LIKE @texto
                        OR m.diagnostico LIKE @texto
                        OR m.solucion LIKE @texto
                    ORDER BY m.fecha_mantenimiento DESC";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@texto",
                        "%" + (texto ?? "") + "%");

                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }


        public bool Insertar(
            int equipoId,
            int usuarioId,
            string tipo,
            string problema,
            string diagnostico,
            string solucion,
            decimal costo,
            DateTime fecha,
            string observaciones)
        {
            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
                    INSERT INTO mantenimientos
                    (
                        equipo_id,
                        usuario_id,
                        tipo,
                        problema,
                        diagnostico,
                        solucion,
                        costo,
                        fecha_mantenimiento,
                        observaciones
                    )
                    VALUES
                    (
                        @equipo_id,
                        @usuario_id,
                        @tipo,
                        @problema,
                        @diagnostico,
                        @solucion,
                        @costo,
                        @fecha,
                        @observaciones
                    )";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@equipo_id",
                        equipoId);

                    comando.Parameters.AddWithValue(
                        "@usuario_id",
                        usuarioId);

                    comando.Parameters.AddWithValue(
                        "@tipo",
                        tipo);

                    comando.Parameters.AddWithValue(
                        "@problema",
                        string.IsNullOrWhiteSpace(problema)
                            ? (object)DBNull.Value
                            : problema);

                    comando.Parameters.AddWithValue(
                        "@diagnostico",
                        string.IsNullOrWhiteSpace(diagnostico)
                            ? (object)DBNull.Value
                            : diagnostico);

                    comando.Parameters.AddWithValue(
                        "@solucion",
                        string.IsNullOrWhiteSpace(solucion)
                            ? (object)DBNull.Value
                            : solucion);

                    comando.Parameters.AddWithValue(
                        "@costo",
                        costo);

                    comando.Parameters.AddWithValue(
                        "@fecha",
                        fecha);

                    comando.Parameters.AddWithValue(
                        "@observaciones",
                        string.IsNullOrWhiteSpace(observaciones)
                            ? (object)DBNull.Value
                            : observaciones);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }




        public bool Actualizar(
            int id,
            int equipoId,
            string tipo,
            string problema,
            string diagnostico,
            string solucion,
            decimal costo,
            DateTime fecha,
            string observaciones)
        {
            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
                    UPDATE mantenimientos
                    SET
                        equipo_id = @equipo_id,
                        tipo = @tipo,
                        problema = @problema,
                        diagnostico = @diagnostico,
                        solucion = @solucion,
                        costo = @costo,
                        fecha_mantenimiento = @fecha,
                        observaciones = @observaciones
                    WHERE id = @id";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        id);

                    comando.Parameters.AddWithValue(
                        "@equipo_id",
                        equipoId);

                    comando.Parameters.AddWithValue(
                        "@tipo",
                        tipo);

                    comando.Parameters.AddWithValue(
                        "@problema",
                        string.IsNullOrWhiteSpace(problema)
                            ? (object)DBNull.Value
                            : problema);

                    comando.Parameters.AddWithValue(
                        "@diagnostico",
                        string.IsNullOrWhiteSpace(diagnostico)
                            ? (object)DBNull.Value
                            : diagnostico);

                    comando.Parameters.AddWithValue(
                        "@solucion",
                        string.IsNullOrWhiteSpace(solucion)
                            ? (object)DBNull.Value
                            : solucion);

                    comando.Parameters.AddWithValue(
                        "@costo",
                        costo);

                    comando.Parameters.AddWithValue(
                        "@fecha",
                        fecha);

                    comando.Parameters.AddWithValue(
                        "@observaciones",
                        string.IsNullOrWhiteSpace(observaciones)
                            ? (object)DBNull.Value
                            : observaciones);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }



        public bool Eliminar(int id)
        {
            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
                    DELETE FROM mantenimientos
                    WHERE id = @id";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        id);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }


        public DataTable ObtenerPorId(int id)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
                    SELECT *
                    FROM mantenimientos
                    WHERE id = @id";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        id);

                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }


        public int ContarMantenimientos()
        {
            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
                    SELECT COUNT(*)
                    FROM mantenimientos";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    return Convert.ToInt32(
                        comando.ExecuteScalar());
                }
            }
        }



        public int ContarMantenimientosMes()
        {
            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
                    SELECT COUNT(*)
                    FROM mantenimientos
                    WHERE
                        YEAR(fecha_mantenimiento) = YEAR(GETDATE())
                        AND
                        MONTH(fecha_mantenimiento) = MONTH(GETDATE())";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    return Convert.ToInt32(
                        comando.ExecuteScalar());
                }
            }
        }



        public int ContarGarantiasPorVencer()
        {
            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
                    SELECT COUNT(*)
                    FROM equipos
                    WHERE
                        fecha_garantia IS NOT NULL
                        AND fecha_garantia >= CAST(GETDATE() AS DATE)
                        AND fecha_garantia <= DATEADD(DAY, 30, CAST(GETDATE() AS DATE))";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    conexion.Open();

                    return Convert.ToInt32(
                        comando.ExecuteScalar());
                }
            }
        }
        public DataTable ObtenerRecientes(int cantidad)
        {
            DataTable tabla = new DataTable();

            using (SqlConnection conexion =
                new Conexion().ObtenerConexion())
            {
                string consulta = @"
            SELECT TOP (@cantidad)
                e.codigo AS codigo_equipo,
                e.tipo AS tipo_equipo,
                e.marca,
                e.modelo,
                m.tipo,
                m.problema,
                m.fecha_mantenimiento
            FROM mantenimientos m
            INNER JOIN equipos e
                ON m.equipo_id = e.id
            ORDER BY m.fecha_mantenimiento DESC";

                using (SqlCommand comando =
                    new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@cantidad",
                        cantidad);

                    using (SqlDataAdapter adaptador =
                        new SqlDataAdapter(comando))
                    {
                        adaptador.Fill(tabla);
                    }
                }
            }

            return tabla;
        }
    }
}