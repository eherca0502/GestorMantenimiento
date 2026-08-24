using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using GestorMantenimiento.Models;

namespace GestorMantenimiento
{
    public class UsuariosDAO
    {
        private readonly Conexion conexionDB;

        public UsuariosDAO()
        {
            conexionDB = new Conexion();
        }


        public List<Usuario> ObtenerTodos()
        {
            List<Usuario> usuarios = new List<Usuario>();

            string query = @"
                SELECT
                    id,
                    nombre_usuario,
                    contrasena,
                    rol,
                    activo
                FROM usuarios
                ORDER BY id DESC";

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
                            usuarios.Add(MapearUsuario(reader));
                        }
                    }
                }
            }

            return usuarios;
        }



        public List<Usuario> Buscar(string texto)
        {
            List<Usuario> usuarios = new List<Usuario>();

            string query = @"
                SELECT
                    id,
                    nombre_usuario,
                    contrasena,
                    rol,
                    activo
                FROM usuarios
                WHERE
                    nombre_usuario LIKE @texto
                    OR rol LIKE @texto
                ORDER BY id DESC";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@texto",
                        "%" + (texto ?? "") + "%");

                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            usuarios.Add(MapearUsuario(reader));
                        }
                    }
                }
            }

            return usuarios;
        }


        

        public Usuario ObtenerPorId(int id)
        {
            Usuario usuario = null;

            string query = @"
                SELECT
                    id,
                    nombre_usuario,
                    contrasena,
                    rol,
                    activo
                FROM usuarios
                WHERE id = @id";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        id);

                    conexion.Open();

                    using (SqlDataReader reader =
                        comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = MapearUsuario(reader);
                        }
                    }
                }
            }

            return usuario;
        }


        public bool ExisteNombreUsuario(
            string nombreUsuario,
            int idExcluir = 0)
        {
            string query = @"
                SELECT COUNT(*)
                FROM usuarios
                WHERE nombre_usuario = @nombre_usuario
                AND id <> @id";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@nombre_usuario",
                        nombreUsuario);

                    comando.Parameters.AddWithValue(
                        "@id",
                        idExcluir);

                    conexion.Open();

                    int cantidad =
                        Convert.ToInt32(
                            comando.ExecuteScalar());

                    return cantidad > 0;
                }
            }
        }



        public bool Agregar(Usuario usuario)
        {
            string query = @"
                INSERT INTO usuarios
                (
                    nombre_usuario,
                    contrasena,
                    rol,
                    activo
                )
                VALUES
                (
                    @nombre_usuario,
                    @contrasena,
                    @rol,
                    @activo
                )";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    AgregarParametros(
                        comando,
                        usuario);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool Actualizar(Usuario usuario)
        {
            string query = @"
                UPDATE usuarios
                SET
                    nombre_usuario = @nombre_usuario,
                    contrasena = @contrasena,
                    rol = @rol,
                    activo = @activo
                WHERE id = @id";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        usuario.Id);

                    AgregarParametros(
                        comando,
                        usuario);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }


       

        public bool ActualizarSinCambiarContrasena(
            Usuario usuario)
        {
            string query = @"
                UPDATE usuarios
                SET
                    nombre_usuario = @nombre_usuario,
                    rol = @rol,
                    activo = @activo
                WHERE id = @id";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        usuario.Id);

                    comando.Parameters.AddWithValue(
                        "@nombre_usuario",
                        usuario.NombreUsuario ?? "");

                    comando.Parameters.AddWithValue(
                        "@rol",
                        usuario.Rol ?? "");

                    comando.Parameters.AddWithValue(
                        "@activo",
                        usuario.Activo);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }



        public bool Eliminar(int id)
        {
            string query = @"
                DELETE FROM usuarios
                WHERE id = @id";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        id);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool CambiarEstado(
            int id,
            bool activo)
        {
            string query = @"
                UPDATE usuarios
                SET activo = @activo
                WHERE id = @id";

            using (SqlConnection conexion =
                conexionDB.ObtenerConexion())
            {
                using (SqlCommand comando =
                    new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue(
                        "@id",
                        id);

                    comando.Parameters.AddWithValue(
                        "@activo",
                        activo);

                    conexion.Open();

                    return comando.ExecuteNonQuery() > 0;
                }
            }
        }



        public int ContarUsuarios()
        {
            string query = @"
                SELECT COUNT(*)
                FROM usuarios";

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



        public int ContarUsuariosActivos()
        {
            string query = @"
                SELECT COUNT(*)
                FROM usuarios
                WHERE activo = 1";

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


      

        private Usuario MapearUsuario(
            SqlDataReader reader)
        {
            return new Usuario
            {
                Id = Convert.ToInt32(
                    reader["id"]),

                NombreUsuario =
                    reader["nombre_usuario"] ==
                    DBNull.Value
                        ? ""
                        : reader["nombre_usuario"]
                            .ToString(),

                Contrasena =
                    reader["contrasena"] ==
                    DBNull.Value
                        ? ""
                        : reader["contrasena"]
                            .ToString(),

                Rol =
                    reader["rol"] ==
                    DBNull.Value
                        ? ""
                        : reader["rol"]
                            .ToString(),

                Activo =
                    reader["activo"] != DBNull.Value &&
                    Convert.ToBoolean(
                        reader["activo"])
            };
        }


        

        private void AgregarParametros(
            SqlCommand comando,
            Usuario usuario)
        {
            comando.Parameters.AddWithValue(
                "@nombre_usuario",
                usuario.NombreUsuario ?? "");

            comando.Parameters.AddWithValue(
                "@contrasena",
                usuario.Contrasena ?? "");

            comando.Parameters.AddWithValue(
                "@rol",
                usuario.Rol ?? "");

            comando.Parameters.AddWithValue(
                "@activo",
                usuario.Activo);
        }
    }
}
