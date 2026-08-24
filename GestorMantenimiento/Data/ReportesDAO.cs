using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace GestorMantenimiento.Data
{
    public class ReportesDAO
    {
        private readonly Conexion conexionDB;

        public ReportesDAO()
        {
            conexionDB = new Conexion();
        }




        public List<ReporteEquipo> ObtenerReporteEquipos()
        {
            List<ReporteEquipo> lista =
                new List<ReporteEquipo>();

            string query = @"
                SELECT
                    e.id,
                    e.codigo,
                    e.tipo,
                    e.marca,
                    e.modelo,
                    e.numero_serie,
                    e.usuario_asignado,
                    e.area,
                    e.estado,
                    e.fecha_adquisicion,
                    e.fecha_garantia
                FROM equipos e
                ORDER BY e.id DESC";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ReporteEquipo
                            {
                                Id = Convert.ToInt32(
                                    reader["id"]),

                                Codigo =
                                    reader["codigo"] == DBNull.Value
                                    ? ""
                                    : reader["codigo"].ToString(),

                                Tipo =
                                    reader["tipo"] == DBNull.Value
                                    ? ""
                                    : reader["tipo"].ToString(),

                                Marca =
                                    reader["marca"] == DBNull.Value
                                    ? ""
                                    : reader["marca"].ToString(),

                                Modelo =
                                    reader["modelo"] == DBNull.Value
                                    ? ""
                                    : reader["modelo"].ToString(),

                                NumeroSerie =
                                    reader["numero_serie"] == DBNull.Value
                                    ? ""
                                    : reader["numero_serie"].ToString(),

                                UsuarioAsignado =
                                    reader["usuario_asignado"] == DBNull.Value
                                    ? ""
                                    : reader["usuario_asignado"].ToString(),

                                Area =
                                    reader["area"] == DBNull.Value
                                    ? ""
                                    : reader["area"].ToString(),

                                Estado =
                                    reader["estado"] == DBNull.Value
                                    ? ""
                                    : reader["estado"].ToString(),

                                FechaAdquisicion =
                                    reader["fecha_adquisicion"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(
                                        reader["fecha_adquisicion"]),

                                FechaGarantia =
                                    reader["fecha_garantia"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(
                                        reader["fecha_garantia"])
                            });
                        }
                    }
                }
            }

            return lista;
        }


        public List<ReporteMantenimiento> ObtenerReporteMantenimientos()
        {
            List<ReporteMantenimiento> lista =
                new List<ReporteMantenimiento>();

            string query = @"
                SELECT
                    m.id,
                    m.equipo_id,
                    m.usuario_id,
                    e.codigo,
                    e.tipo AS tipo_equipo,
                    e.marca,
                    e.modelo,
                    u.nombre_usuario,
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
                INNER JOIN usuarios u
                    ON m.usuario_id = u.id
                ORDER BY m.fecha_mantenimiento DESC";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lista.Add(new ReporteMantenimiento
                            {
                                Id = Convert.ToInt32(
                                    reader["id"]),

                                EquipoId = Convert.ToInt32(
                                    reader["equipo_id"]),

                                UsuarioId = Convert.ToInt32(
                                    reader["usuario_id"]),

                                Codigo =
                                    reader["codigo"] == DBNull.Value
                                    ? ""
                                    : reader["codigo"].ToString(),

                                TipoEquipo =
                                    reader["tipo_equipo"] == DBNull.Value
                                    ? ""
                                    : reader["tipo_equipo"].ToString(),

                                Marca =
                                    reader["marca"] == DBNull.Value
                                    ? ""
                                    : reader["marca"].ToString(),

                                Modelo =
                                    reader["modelo"] == DBNull.Value
                                    ? ""
                                    : reader["modelo"].ToString(),

                                NombreUsuario =
                                    reader["nombre_usuario"] == DBNull.Value
                                    ? ""
                                    : reader["nombre_usuario"].ToString(),

                                Tipo =
                                    reader["tipo"] == DBNull.Value
                                    ? ""
                                    : reader["tipo"].ToString(),

                                Problema =
                                    reader["problema"] == DBNull.Value
                                    ? ""
                                    : reader["problema"].ToString(),

                                Diagnostico =
                                    reader["diagnostico"] == DBNull.Value
                                    ? ""
                                    : reader["diagnostico"].ToString(),

                                Solucion =
                                    reader["solucion"] == DBNull.Value
                                    ? ""
                                    : reader["solucion"].ToString(),

                                Costo =
                                    reader["costo"] == DBNull.Value
                                    ? 0
                                    : Convert.ToDecimal(
                                        reader["costo"]),

                                FechaMantenimiento =
                                    reader["fecha_mantenimiento"] == DBNull.Value
                                    ? (DateTime?)null
                                    : Convert.ToDateTime(
                                        reader["fecha_mantenimiento"]),

                                Observaciones =
                                    reader["observaciones"] == DBNull.Value
                                    ? ""
                                    : reader["observaciones"].ToString()
                            });
                        }
                    }
                }
            }

            return lista;
        }



        public List<ReporteGarantia> ObtenerReporteGarantias()
        {
            List<ReporteGarantia> lista =
                new List<ReporteGarantia>();

            string query = @"
                SELECT
                    id,
                    codigo,
                    tipo,
                    marca,
                    modelo,
                    usuario_asignado,
                    area,
                    fecha_garantia,
                    estado
                FROM equipos
                WHERE fecha_garantia IS NOT NULL
                ORDER BY fecha_garantia ASC";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DateTime fecha =
                                Convert.ToDateTime(
                                    reader["fecha_garantia"]);

                            DateTime hoy =
                                DateTime.Today;

                            string estadoGarantia;

                            if (fecha.Date < hoy)
                            {
                                estadoGarantia = "Vencida";
                            }
                            else if (fecha.Date == hoy)
                            {
                                estadoGarantia = "Vence hoy";
                            }
                            else if (
                                fecha.Date <=
                                hoy.AddDays(30))
                            {
                                estadoGarantia = "Por vencer";
                            }
                            else
                            {
                                estadoGarantia = "Vigente";
                            }

                            lista.Add(new ReporteGarantia
                            {
                                Id = Convert.ToInt32(
                                    reader["id"]),

                                Codigo =
                                    reader["codigo"] == DBNull.Value
                                    ? ""
                                    : reader["codigo"].ToString(),

                                Tipo =
                                    reader["tipo"] == DBNull.Value
                                    ? ""
                                    : reader["tipo"].ToString(),

                                Marca =
                                    reader["marca"] == DBNull.Value
                                    ? ""
                                    : reader["marca"].ToString(),

                                Modelo =
                                    reader["modelo"] == DBNull.Value
                                    ? ""
                                    : reader["modelo"].ToString(),

                                UsuarioAsignado =
                                    reader["usuario_asignado"] == DBNull.Value
                                    ? ""
                                    : reader["usuario_asignado"].ToString(),

                                Area =
                                    reader["area"] == DBNull.Value
                                    ? ""
                                    : reader["area"].ToString(),

                                FechaGarantia = fecha,

                                EstadoGarantia =
                                    estadoGarantia
                            });
                        }
                    }
                }
            }

            return lista;
        }



        public decimal ObtenerCostoTotalMantenimientos()
        {
            string query = @"
                SELECT ISNULL(
                    SUM(costo),
                    0)
                FROM mantenimientos";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    return Convert.ToDecimal(
                        comando.ExecuteScalar());
                }
            }
        }


        public int ContarMantenimientos()
        {
            string query = @"
                SELECT COUNT(*)
                FROM mantenimientos";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    return Convert.ToInt32(
                        comando.ExecuteScalar());
                }
            }
        }


        public int ContarEquipos()
        {
            string query = @"
                SELECT COUNT(*)
                FROM equipos";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    return Convert.ToInt32(
                        comando.ExecuteScalar());
                }
            }
        }


        public int ContarGarantiasVigentes()
        {
            string query = @"
                SELECT COUNT(*)
                FROM equipos
                WHERE fecha_garantia IS NOT NULL
                AND fecha_garantia >=
                    CAST(GETDATE() AS DATE)";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    return Convert.ToInt32(
                        comando.ExecuteScalar());
                }
            }
        }


        public int ContarGarantiasVencidas()
        {
            string query = @"
                SELECT COUNT(*)
                FROM equipos
                WHERE fecha_garantia IS NOT NULL
                AND fecha_garantia <
                    CAST(GETDATE() AS DATE)";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    return Convert.ToInt32(
                        comando.ExecuteScalar());
                }
            }
        }


        public class ReporteEquipo
        {
            public int Id { get; set; }

            public string Codigo { get; set; }

            public string Tipo { get; set; }

            public string Marca { get; set; }

            public string Modelo { get; set; }

            public string NumeroSerie { get; set; }

            public string UsuarioAsignado { get; set; }

            public string Area { get; set; }

            public string Estado { get; set; }

            public DateTime? FechaAdquisicion { get; set; }

            public DateTime? FechaGarantia { get; set; }
        }



        public class ReporteMantenimiento
        {
            public int Id { get; set; }

            public int EquipoId { get; set; }

            public int UsuarioId { get; set; }

            public string Codigo { get; set; }

            public string TipoEquipo { get; set; }

            public string Marca { get; set; }

            public string Modelo { get; set; }

            public string NombreUsuario { get; set; }

            public string Tipo { get; set; }

            public string Problema { get; set; }

            public string Diagnostico { get; set; }

            public string Solucion { get; set; }

            public decimal Costo { get; set; }

            public DateTime? FechaMantenimiento { get; set; }

            public string Observaciones { get; set; }
        }


        public class ReporteGarantia
        {
            public int Id { get; set; }

            public string Codigo { get; set; }

            public string Tipo { get; set; }

            public string Marca { get; set; }

            public string Modelo { get; set; }

            public string UsuarioAsignado { get; set; }

            public string Area { get; set; }

            public DateTime FechaGarantia { get; set; }

            public string EstadoGarantia { get; set; }
        }
    }
}
