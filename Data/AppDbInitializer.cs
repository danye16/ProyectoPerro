using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using ProyectoPerro.Data.Models;
using System;
using System.Linq;

namespace ProyectoPerro.Data
{
    public class AppDbInitializer
    {
        //Metodo que agrega datos a nuestra BD
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Perros.Any())
                {
                    context.Perros.AddRange(new Perro()
                    {
                        Nombre = "Miguelito",
                        Raza = "Salchicha",
                        Edad = "4 años",


                    },
                    new Perro()
                    {
                        Nombre = "Miguelito2",
                        Raza = "Salchicha2",
                        Edad = "4 años",

                    });
                    context.SaveChanges();


                }
            }
        }       }
}
