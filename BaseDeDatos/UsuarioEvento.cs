using System;
using System.Collections.Generic;

namespace SistemaEventosUMSS.BaseDeDatos
{
    public partial class UsuarioEvento
    {
        public int IdUsuario { get; set; }
        public int IdEvento { get; set; }
        public bool Creador { get; set; }

        public Evento IdEventoNavigation { get; set; }
        public UsuarioRegistrado IdUsuarioNavigation { get; set; }
    }
}
