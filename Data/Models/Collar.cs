namespace ProyectoPerro.Data.Models
{
    public class Collar
    {
        public int Id { get; set; }

        
        //propiedades de Navegacion
        public Perro Perro { get; set; }
        
    }
}
