using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestorMantenimiento.Models;

namespace GestorMantenimiento.Data
{
    public class EquipoDAO
    {
        private readonly Conexion conexionDB;

        public EquipoDAO()
        {
            conexionDB = new Conexion();
        }


        public List<Equipo> ObtenerTodos()
        {
            List<Equipo> equipos = new List<Equipo>();

            string query = @"
                SELECT
                    id,
                    codigo,
                    tipo,
                    marca,
                    modelo,
                    numero_serie,
                    usuario_asignado,
                    area,
                    sistema_operativo,
                    ram,
                    almacenamiento,
                    ip,
                    fecha_adquisicion,
                    fecha_garantia,
                    estado,
                    observaciones,
                    fecha_registro
                FROM equipos
                ORDER BY id DESC";

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            equipos.Add(MapearEquipo(reader));
                        }
                    }
                }
            }

            return equipos;
        }



        public List<Equipo> Buscar(string texto)
        {
            List<Equipo> equipos = new List<Equipo>();

            string query = @"
                SELECT
                    id,
                    codigo,
                    tipo,
                    marca,
                    modelo,
                    numero_serie,
                    usuario_asignado,
                    area,
                    sistema_operativo,
                    ram,
                    almacenamiento,
                    ip,
                    fecha_adquisicion,
                    fecha_garantia,
                    estado,
                    observaciones,
                    fecha_registro
                FROM equipos
                WHERE
                    codigo LIKE @texto
                    OR tipo LIKE @texto
                    OR marca LIKE @texto
                    OR modelo LIKE @texto
                    OR numero_serie LIKE @texto
                    OR usuario_asignado LIKE @texto
                    OR area LIKE @texto
                    OR estado LIKE @texto
                ORDER BY id DESC";

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@texto",
                        "%" + (texto ?? "") + "%");

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            equipos.Add(MapearEquipo(reader));
                        }
                    }
                }
            }

            return equipos;
        }


        public Equipo ObtenerPorId(int id)
        {
            Equipo equipo = null;

            string query = @"
                SELECT
                    id,
                    codigo,
                    tipo,
                    marca,
                    modelo,
                    numero_serie,
                    usuario_asignado,
                    area,
                    sistema_operativo,
                    ram,
                    almacenamiento,
                    ip,
                    fecha_adquisicion,
                    fecha_garantia,
                    estado,
                    observaciones,
                    fecha_registro
                FROM equipos
                WHERE id = @id";

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexion.Open();

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            equipo = MapearEquipo(reader);
                        }
                    }
                }
            }

            return equipo;
        }


        public bool Agregar(Equipo equipo)
        {
            string query = @"
                INSERT INTO equipos
                (
                    codigo,
                    tipo,
                    marca,
                    modelo,
                    numero_serie,
                    usuario_asignado,
                    area,
                    sistema_operativo,
                    ram,
                    almacenamiento,
                    ip,
                    fecha_adquisicion,
                    fecha_garantia,
                    estado,
                    observaciones,
                    fecha_registro
                )
                VALUES
                (
                    @codigo,
                    @tipo,
                    @marca,
                    @modelo,
                    @numero_serie,
                    @usuario_asignado,
                    @area,
                    @sistema_operativo,
                    @ram,
                    @almacenamiento,
                    @ip,
                    @fecha_adquisicion,
                    @fecha_garantia,
                    @estado,
                    @observaciones,
                    GETDATE()
                )";

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    AgregarParametros(comando, equipo);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool Actualizar(Equipo equipo)
        {
            string query = @"
                UPDATE equipos
                SET
                    codigo = @codigo,
                    tipo = @tipo,
                    marca = @marca,
                    modelo = @modelo,
                    numero_serie = @numero_serie,
                    usuario_asignado = @usuario_asignado,
                    area = @area,
                    sistema_operativo = @sistema_operativo,
                    ram = @ram,
                    almacenamiento = @almacenamiento,
                    ip = @ip,
                    fecha_adquisicion = @fecha_adquisicion,
                    fecha_garantia = @fecha_garantia,
                    estado = @estado,
                    observaciones = @observaciones
                WHERE id = @id";

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", equipo.Id);

                    AgregarParametros(comando, equipo);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }



        public bool Eliminar(int id)
        {
            string query = @"
                DELETE FROM equipos
                WHERE id = @id";

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", id);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }


        public int ContarEquipos()
        {
            string query = @"
                SELECT COUNT(*)
                FROM equipos";

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    conexion.Open();

                    return Convert.ToInt32(comando.ExecuteScalar());
                }
            }
        }

        public int ContarPorEstado(string estado)
        {
            string query = @"
                SELECT COUNT(*)
                FROM equipos
                WHERE estado = @estado";

            using (SqlConnection conexion = conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@estado", estado);

                    conexion.Open();

                    return Convert.ToInt32(comando.ExecuteScalar());
                }
            }
        }


        private Equipo MapearEquipo(SqlDataReader reader)
        {
            return new Equipo
            {
                Id = Convert.ToInt32(reader["id"]),

                Codigo = reader["codigo"] == DBNull.Value
                    ? ""
                    : reader["codigo"].ToString(),

                Tipo = reader["tipo"] == DBNull.Value
                    ? ""
                    : reader["tipo"].ToString(),

                Marca = reader["marca"] == DBNull.Value
                    ? ""
                    : reader["marca"].ToString(),

                Modelo = reader["modelo"] == DBNull.Value
                    ? ""
                    : reader["modelo"].ToString(),

                NumeroSerie = reader["numero_serie"] == DBNull.Value
                    ? ""
                    : reader["numero_serie"].ToString(),

                UsuarioAsignado = reader["usuario_asignado"] == DBNull.Value
                    ? ""
                    : reader["usuario_asignado"].ToString(),

                Area = reader["area"] == DBNull.Value
                    ? ""
                    : reader["area"].ToString(),

                SistemaOperativo = reader["sistema_operativo"] == DBNull.Value
                    ? ""
                    : reader["sistema_operativo"].ToString(),

                RAM = reader["ram"] == DBNull.Value
                    ? ""
                    : reader["ram"].ToString(),

                Almacenamiento = reader["almacenamiento"] == DBNull.Value
                    ? ""
                    : reader["almacenamiento"].ToString(),

                IP = reader["ip"] == DBNull.Value
                    ? ""
                    : reader["ip"].ToString(),

                FechaAdquisicion =
                    reader["fecha_adquisicion"] == DBNull.Value
                    ? (DateTime?)null
                    : Convert.ToDateTime(
                        reader["fecha_adquisicion"]),

                FechaGarantia =
                    reader["fecha_garantia"] == DBNull.Value
                    ? (DateTime?)null
                    : Convert.ToDateTime(
                        reader["fecha_garantia"]),

                Estado = reader["estado"] == DBNull.Value
                    ? ""
                    : reader["estado"].ToString(),

                Observaciones = reader["observaciones"] == DBNull.Value
                    ? ""
                    : reader["observaciones"].ToString(),

                FechaRegistro =
                    reader["fecha_registro"] == DBNull.Value
                    ? DateTime.Now
                    : Convert.ToDateTime(
                        reader["fecha_registro"])
            };
        }


        private void AgregarParametros(
            SqlCommand comando,
            Equipo equipo)
        {
            comando.Parameters.AddWithValue(
                "@codigo",
                equipo.Codigo ?? "");

            comando.Parameters.AddWithValue(
                "@tipo",
                equipo.Tipo ?? "");

            comando.Parameters.AddWithValue(
                "@marca",
                equipo.Marca ?? "");

            comando.Parameters.AddWithValue(
                "@modelo",
                equipo.Modelo ?? "");

            comando.Parameters.AddWithValue(
                "@numero_serie",
                equipo.NumeroSerie ?? "");

            comando.Parameters.AddWithValue(
                "@usuario_asignado",
                equipo.UsuarioAsignado ?? "");

            comando.Parameters.AddWithValue(
                "@area",
                equipo.Area ?? "");

            comando.Parameters.AddWithValue(
                "@sistema_operativo",
                equipo.SistemaOperativo ?? "");

            comando.Parameters.AddWithValue(
                "@ram",
                equipo.RAM ?? "");

            comando.Parameters.AddWithValue(
                "@almacenamiento",
                equipo.Almacenamiento ?? "");

            comando.Parameters.AddWithValue(
                "@ip",
                equipo.IP ?? "");

            comando.Parameters.AddWithValue(
                "@fecha_adquisicion",
                equipo.FechaAdquisicion.HasValue
                    ? (object)equipo.FechaAdquisicion.Value
                    : DBNull.Value);

            comando.Parameters.AddWithValue(
                "@fecha_garantia",
                equipo.FechaGarantia.HasValue
                    ? (object)equipo.FechaGarantia.Value
                    : DBNull.Value);

            comando.Parameters.AddWithValue(
                "@estado",
                equipo.Estado ?? "");

            comando.Parameters.AddWithValue(
                "@observaciones",
                equipo.Observaciones ?? "");
        }
    
    public int ContarGarantiasPorVencer()
        {
            string query = @"
        SELECT COUNT(*)
        FROM equipos
        WHERE fecha_garantia IS NOT NULL
          AND fecha_garantia >= CAST(GETDATE() AS DATE)
          AND fecha_garantia <= DATEADD(DAY, 30, CAST(GETDATE() AS DATE))";

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
     

        public List<Equipo> ObtenerGarantias()
        {
            List<Equipo> equipos = new List<Equipo>();

            string query = @"
        SELECT
            id,
            codigo,
            tipo,
            marca,
            modelo,
            numero_serie,
            usuario_asignado,
            area,
            sistema_operativo,
            ram,
            almacenamiento,
            ip,
            fecha_adquisicion,
            fecha_garantia,
            estado,
            observaciones,
            fecha_registro
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
                            equipos.Add(
                                MapearEquipo(reader));
                        }
                    }
                }
            }

            return equipos;
        }
        public int ContarGarantiasVencidas()
        {
            string query = @"
        SELECT COUNT(*)
        FROM equipos
        WHERE fecha_garantia IS NOT NULL
        AND fecha_garantia < CAST(GETDATE() AS DATE)";

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
        AND fecha_garantia >= CAST(GETDATE() AS DATE)";

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
    } 

}