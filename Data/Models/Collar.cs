using System.Collections.Generic;

namespace ProyectoPerro.Data.Models
{
    public class Collar
    {
        public int Id { get; set; }

        public string CollarModelo { get; set; }
        public string Color { get; set; }

        //propiedades de Navegacion
        public int PerroId { get; set; }
        public Perro Perro { get; set; }


        public List<Gps> Gps { get; set; }
        //   public List<Perro> Perros { get; set; }
    }
}
