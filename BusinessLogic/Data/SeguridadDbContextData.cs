using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Data
{
    public class SeguridadDbContextData
    {
        public static async Task SeedUserAsync(UserManager<Usuario> userManager)
        {
            if (!userManager.Users.Any()) 
            {
                var usuario = new Usuario
                {
                    Nombre = "Oswaldo",
                    Apellido = "Cervantes",
                    UserName = "cervantesOsv",
                    Email = "oswaldocerv@outlook.com",
                    Direccion = new Direccion
                    {
                        Calle = "Andares 111",
                        Ciudad = "Jalisco Gdl",
                        CodigoPostal = "123456",
                        Departamento = "JaliscoCasaOsvaldo"
                    }
                };
                await userManager.CreateAsync(usuario, "ContraseñaDeosvaldo@22");
            }
        }
    }
}
