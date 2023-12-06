using System.Collections.Generic;

namespace ProyectoPerro.Data.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }
        public int Idperro {  get; set; }

        public List<Perro> Perros { get; set; }

    }
}
