using ProyectoPerro.Data.Models;
using ProyectoPerro.Data.ViewModels;
using System;
using System.Collections.Generic;
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
                    NombreUsuario = n.Nombre,

                   UsuarioPerros = n.Perros.Select(n => new UsuarioPerroVM()
                   {
                      NickPerro = n.Nombre,
                      EdadPerro =n.Edad
                     // UsuarioPerros=n.Usuario.Perros.Select(n=> n.Nombre).ToList()

               }).ToList()
            }).FirstOrDefault();
            return _usuarioData;

        }
        //Metodo para listar Usuarios

        public List<Usuario> GetAllUsers() => _context.Usuarios.ToList();

        //Método que nos permite modificar un Usuario que se encuentra en la BD
        public Usuario UpdateUsuarioById(int usuarioid, UsuarioVM usuario)
        {
            var _usuario = _context.Usuarios.FirstOrDefault(n => n.Id == usuarioid);
            if (_usuario != null)
            {
                _usuario.Nombre = usuario.Nombre;
                _usuario.Telefono = usuario.Telefono;
                _usuario.Correo = usuario.Correo;
              
                _context.SaveChanges();
            }
            return _usuario;
        }

        //Metodo para eliminar un libro de la BD
        public void DeleteUsuarioById(int usuarioid)
        {
            var _usuario = _context.Usuarios.FirstOrDefault(n => n.Id == usuarioid);
            if (_usuario != null)
            {
                _context.Usuarios.Remove(_usuario);
                _context.SaveChanges();
            }
        }
    }
}
