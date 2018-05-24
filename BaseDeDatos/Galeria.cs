using System;
using System.Collections.Generic;

namespace SistemaEventosUMSS.BaseDeDatos
{
    public partial class Galeria
    {
        public int IdGaleria { get; set; }
        public int IdEvento { get; set; }
        public byte[] ImagenEvento { get; set; }

        public Evento IdEventoNavigation { get; set; }
    }
}
