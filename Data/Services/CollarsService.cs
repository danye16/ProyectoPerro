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
        public void AddorUpdateCollar(CollarVM collar)
        {
           
            // Verificar si ya existe un collar con el mismo PerroId
            var existingCollar = _context.Collars.FirstOrDefault(c => c.PerroId == collar.PerroId);

            if (existingCollar != null)
            {
                // Actualizar propiedades del collar existente
                existingCollar.CollarModelo = collar.CollarModelo;
                existingCollar.Color = collar.Color;
                _context.SaveChanges();
            }
            else
            {
                // Si no existe, crear un nuevo collar
                var newCollar = new Collar()
                {
                    CollarModelo = collar.CollarModelo,
                    Color = collar.Color,
                    PerroId = collar.PerroId,
                };

                _context.Collars.Add(newCollar);
                _context.SaveChanges();
            }
        }

        public List<Collar> GetAllCollars() => _context.Collars.ToList();


    }
}
