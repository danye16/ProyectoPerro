using System.Threading;
using ProyectoPerro.Data.ViewModels;
using ProyectoPerro.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System;
namespace ProyectoPerro.Data.Services
{
    public class CollarService
    {
        private AppDbContext _context;
        public CollarService(AppDbContext context)
        {
            _context = context;
        }


        public void AddCollar(CollarVM perro)
        {
            var _perro = new Collar()
            {
                Nombre = perro.Nombre,
                Raza = perro.Raza,
                Edad = perro.Edad,

                //  IdCollar = perro.Idcollar

            };
            _context.Perros.Add(_perro);
            _context.SaveChanges();
        }
    }
}
