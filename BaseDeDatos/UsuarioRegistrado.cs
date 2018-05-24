using System;
using System.Collections.Generic;

namespace SistemaEventosUMSS.BaseDeDatos
{
    public partial class UsuarioRegistrado
    {
        public UsuarioRegistrado()
        {
            ListaAmigosIdAmigoNavigation = new HashSet<ListaAmigos>();
            ListaAmigosIdUsuarioNavigation = new HashSet<ListaAmigos>();
            UsuarioEvento = new HashSet<UsuarioEvento>();
        }

        public int IdUsuario { get; set; }
        public string MailUsuario { get; set; }
        public string Password { get; set; }
        public string NombreUsuario { get; set; }
        public string ApellidoUsuario { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public ICollection<ListaAmigos> ListaAmigosIdAmigoNavigation { get; set; }
        public ICollection<ListaAmigos> ListaAmigosIdUsuarioNavigation { get; set; }
        public ICollection<UsuarioEvento> UsuarioEvento { get; set; }
    }
}
