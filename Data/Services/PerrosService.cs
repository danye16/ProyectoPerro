using System.Threading;
using ProyectoPerro.Data.ViewModels;
using ProyectoPerro.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ProyectoPerro.Data.Services
{
    public class PerrosService
    {
        private AppDbContext _context;
        public PerrosService(AppDbContext context)
        {
            _context = context;
        }

        //Aqui vamos a tener un unico metodo para
        //agregar libros a nuestra BD.
        public void AddPerro(PerroVM perro)
        {
            var _perro = new Perro()
            {
                Nombre = perro.Nombre,
                Raza = perro.Raza,
                Edad = perro.Edad,

                //  IdCollar = perro.Idcollar

            };
            _context.Perros.Add(_perro);
            _context.SaveChanges();
        }


            //Metodo para listar Perros
            public List<Perro> GetAllPerros() => _context.Perros.ToList();

            //Metodo para buscar un unico Perro
            public Perro GetPerroById(int perroid) => _context.Perros.FirstOrDefault(n => n.Id == perroid);
        
    }
}
