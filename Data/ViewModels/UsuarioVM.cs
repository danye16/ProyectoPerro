using System.Collections.Generic;

namespace ProyectoPerro.Data.ViewModels
{
    public class UsuarioVM
    {

        public string Nombre { get; set; }
        public string? Telefono { get; set; }
        public string? Correo { get; set; }

        public int CollarID { get; set; }
    }

    public class UsuarioWhitPerrosVM
    {
        public string NombreUsuario { get; set; }
        public List<UsuarioPerroVM> UsuarioPerros { get; set; }
    }

    public class UsuarioPerroVM
    {
        public string NickPerro { get; set; }
        public string EdadPerro { get; set; }

        public List<string> UsuarioPerros { get; set; }
    }
}
