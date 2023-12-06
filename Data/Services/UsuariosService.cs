using ProyectoPerro.Data.Models;
using ProyectoPerro.Data.ViewModels;
using System;
using System.Linq;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace ProyectoPerro.Data.Services
{
    public class UsuariosService
    {
        private AppDbContext _context;
        public UsuariosService(AppDbContext context)
        {
            _context = context;
        }

        //agregar Usuarios a nuestra BD.
        public void AddUsuario(UsuarioVM usuario)
        {
            var _usuario = new Usuario()
            {
                Nombre = usuario.Nombre,
                Telefono = usuario.Telefono,
                Correo = usuario.Correo

                //  IdCollar = perro.Idcollar

            };
            _context.Usuarios.Add(_usuario);
            _context.SaveChanges();
        }
        public UsuarioWhitPerrosVM GetUsuarioData(int usuarioId)
        {
            var _usuarioData = _context.Usuarios.Where(n => n.Id == usuarioId)

                .Select(n => new UsuarioWhitPerrosVM()
                {
                    Nombre = n.Nombre,

                   UsuarioPerros = n.Perros.Select(n => new UsuarioPerroVM()
                   {
                      PerroNombre = n.Nombre,
                      UsuarioPerros=n.Usuario.Perros.Select(n=> n.Nombre).ToList()

               }).ToList()
            }).FirstOrDefault();
            return _usuarioData;
        }
    }
}
