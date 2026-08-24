using System;

namespace GestorMantenimiento.Models
{
    public class Equipo
    {
        public int Id { get; set; }

        public string Codigo { get; set; }

        public string Tipo { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public string NumeroSerie { get; set; }

        public string UsuarioAsignado { get; set; }

        public string Area { get; set; }

        public string SistemaOperativo { get; set; }

        public string RAM { get; set; }

        public string Almacenamiento { get; set; }

        public string IP { get; set; }

        public DateTime? FechaAdquisicion { get; set; }

        public DateTime? FechaGarantia { get; set; }

        public string Estado { get; set; }

        public string Observaciones { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}