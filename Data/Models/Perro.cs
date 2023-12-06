namespace ProyectoPerro.Data.Models
{
    public class Perro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string? Raza { get; set; }
        public string? Edad {  get; set; }
       
        public int Idcollar { get; set; }

        //Propiedades de navegacion
        public int CollarId { get; set; }
        public Collar Collar { get; set;}

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set;}
    }
}
