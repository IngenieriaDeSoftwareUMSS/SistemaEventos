using System;
using System.Collections.Generic;

namespace SistemaEventosUMSS.BaseDeDatos
{
    public partial class Evento
    {
        public Evento()
        {
            Galeria = new HashSet<Galeria>();
            ListaCategorias = new HashSet<ListaCategorias>();
            UsuarioEvento = new HashSet<UsuarioEvento>();
        }

        public int IdEvento { get; set; }
        public string NombreEvento { get; set; }
        public string DescripcionEvento { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string DireccionEvento { get; set; }
        public double MapaLongitud { get; set; }
        public double MapaLatitud { get; set; }
        public decimal CostoEvento { get; set; }

        public ICollection<Galeria> Galeria { get; set; }
        public ICollection<ListaCategorias> ListaCategorias { get; set; }
        public ICollection<UsuarioEvento> UsuarioEvento { get; set; }
    }
}
