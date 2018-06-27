using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaEventosUMSS.Models;

namespace SistemaEventosUMSS.Data
{
    public class DbInitializer
    {
    public static void Initialize(EventsUmssContext context)
    {
      context.Database.EnsureCreated();

      //Buscando algunos eventos
      if (context.Events.Any())
      {
        return;
      }

      var events = new Event[]
        {
          new Event{ NombreEvento="ALoha Fest", Descripcion="Fiesta aloha da la bienvenida a la primavera", DireccionEvento="Auditorio Fcyt",
            FechaInicio =DateTime.Parse("2018-06-01"), FechaFin=DateTime.Parse("2018-06-02"), MapaLatitud=-17.391848, MapaLongitud=-66.256003},
          new Event{ NombreEvento="Cumbia fest", Descripcion="", DireccionEvento="Auditorio Fcyt",
            FechaInicio =DateTime.Parse("2018-06-01"), FechaFin=DateTime.Parse("2018-06-03"), MapaLatitud=-17.389605, MapaLongitud=-66.261656, CostoEvento=150.00},
          new Event{ NombreEvento="Concierto Filarmonica", Descripcion="musica", DireccionEvento="LAb INFSIS",
            FechaInicio =DateTime.Parse("2018-06-06"), FechaFin=DateTime.Parse("2018-06-10"), MapaLatitud=-17.394404, MapaLongitud=-66.276059}
        };

      foreach (Event e in events)
      {
        context.Events.Add(e);
      }
      context.SaveChanges();

      var usuarios = new User[]
      {
        new User{ NombreUsuario="Jose", ApellidoUsuario="Vela", FechaNacimiento=DateTime.Parse("1990-02-01"), EMail="jose@correo1.com", PasswordUsuario="pass1"},
        new User{ NombreUsuario="Arturo", ApellidoUsuario="Ramos", FechaNacimiento=DateTime.Parse("1980-08-01"), EMail="arturo@correo2.com", PasswordUsuario="pass2"},
        new User{ NombreUsuario="Isis", ApellidoUsuario="Borda", FechaNacimiento=DateTime.Parse("1990-12-27"), EMail="isis@correo3.com", PasswordUsuario="pass3"}
      };

      foreach (User u in usuarios)
      {
        context.Users.Add(u);
      }
      context.SaveChanges();

      var usuariosEventos = new EventUser[]
      {
        new EventUser{ UserID=1, EventID=1 },
        new EventUser{ UserID=2, EventID=2 },
        new EventUser{ UserID=3, EventID=3 }
      };
    }
    }
}
