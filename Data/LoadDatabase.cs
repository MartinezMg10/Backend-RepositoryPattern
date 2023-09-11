using Microsoft.AspNetCore.Identity;
using NetKubernetes.Models;

namespace NetKubernetes.Data;

public class LoadDatabase{

    public static async Task InsertarData(AppDbContext contexto, UserManager<Usuario> usuarioManager){
        if(usuarioManager.Users.Any()){
            var usuario = new Usuario{
                Nombre = "Vaxi",
                Apellido = "Drez",
                Email = "vaxi.drez.social@gmail.com",
                UserName = "Vaxi.drez",
                Telefono = "98154684"
            };

            await usuarioManager.CreateAsync(usuario, "PasswordVxidrez123$");
        }

        if(!contexto.Inmuebles!.Any())
        {
            contexto.Inmuebles!.AddRange(
                new Inmueble{
                    Nombre = "Casa de Invierno",
                    Direccion = "Av. El sol 32",
                    Precio = 4500M,
                    FechaCreacion = DateTime.Now
                },
                new Inmueble{
                    Nombre = "Casa de Invierno",
                    Direccion = "Av. El sol 32",
                    Precio = 4500M,
                    FechaCreacion = DateTime.Now
                },
                new Inmueble{
                    Nombre = "Casa de Invierno",
                    Direccion = "Av. El sol 32",
                    Precio = 4500M,
                    FechaCreacion = DateTime.Now
                }
            );
        }

        contexto.SaveChanges();
    }
}