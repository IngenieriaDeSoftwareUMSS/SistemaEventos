using System;
using System.Collections.Generic;

namespace SistemaEventosUMSS.BaseDeDatos
{
    public partial class ListaAmigos
    {
        public int IdAmigo { get; set; }
        public int IdUsuario { get; set; }

        public UsuarioRegistrado IdAmigoNavigation { get; set; }
        public UsuarioRegistrado IdUsuarioNavigation { get; set; }
    }
}
