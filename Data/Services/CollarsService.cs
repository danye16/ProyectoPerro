using System.Threading;
using ProyectoPerro.Data.ViewModels;
using ProyectoPerro.Data.Models;
using System.Collections.Generic;
using System.Linq;
using System;
namespace ProyectoPerro.Data.Services
{
    public class CollarsService
    {
        private AppDbContext _context;
        public CollarsService(AppDbContext context)
        {
            _context = context;
        }

        //Aqui vamos a tener un unico metodo para
        //agregar Perros a nuestra BD.
        public void AddCollar(CollarVM collar)
        {
            var _collar = new Collar()
            {
                CollarModelo= collar.CollarModelo,
                Color=collar.Color,
                PerroId = collar.PerroId,
               
                //  IdCollar = perro.Idcollar

            };
            _context.Collars.Add(_collar);
            _context.SaveChanges();
        }

    }
}
