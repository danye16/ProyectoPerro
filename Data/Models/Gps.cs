﻿namespace ProyectoPerro.Data.Models
{
    public class Gps
    {
        public int Id { get; set; }
        public string Rango { get; set; }
        public string PosicionCasa { get; set; }
        public string PosicionPerro { get; set; }
        public bool Estado { get; set; }

        public int CollarId { get; set; }
        public Collar Collar { get; set; }
    }
}
