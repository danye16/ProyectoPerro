using ProyectoPerro.Data.Models;
using ProyectoPerro.Data.ViewModels;
using ProyectoPerro.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace ProyectoPerro.Data.Services
{
    public class GpsService
    {
        private AppDbContext _context;
        public GpsService(AppDbContext context)
        {
            _context = context;
        }

        //agregar Usuarios a nuestra BD.
        public void AddOrUpdateGps(GpsVM gps)
        {
            var existeGps = _context.Gpss.FirstOrDefault(c => c.CollarId == gps.CollarId);
            if (existeGps != null)
            {
                existeGps.Rango = gps.Rango;
                existeGps.PosicionCasa = gps.PosicionCasa;
                existeGps.PosicionPerro = gps.PosicionPerro;
                existeGps.Estado = gps.Estado;

                _context.SaveChanges();
            }
            else
            {
                // Si no existe, crear un nuevo collar
                var _gps = new Gps()
                {
                    Rango = gps.Rango,
                    PosicionCasa = gps.PosicionCasa,
                    PosicionPerro = gps.PosicionPerro,
                    Estado = gps.Estado,
                    CollarId = gps.CollarId
                };

                _context.Gpss.Add(_gps);
                _context.SaveChanges();
            }
        }

        //Metodo para listar GPS
        public List<Gps> GetAllGPS() => _context.Gpss.ToList();

        //Metodo para buscar un unico GPS
        public Gps GetGPSById(int gpsid) => _context.Gpss.FirstOrDefault(n => n.Id == gpsid);
    }
}
