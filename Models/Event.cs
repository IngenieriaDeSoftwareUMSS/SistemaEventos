using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEventosUMSS.Models
{
    public class Event
    {
    public int ID { get; set; }
    public string NombreEvento { get; set; }
    public string Descripcion { get; set; }
    public string  DireccionEvento { get; set; }
    public double? MapaLongitud { get; set; }
    public double? MapaLatitud { get; set; }
    public DateTimeOffset FechaInicio { get; set; }
    public DateTimeOffset? FechaFin { get; set; }
    public double? CostoEvento { get; set; }
    public string Categoria { get; set; }

    public ICollection<EventUser> EventUsers { get; set; }
  }
}
