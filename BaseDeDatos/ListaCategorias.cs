using System;
using System.Collections.Generic;

namespace SistemaEventosUMSS.BaseDeDatos
{
    public partial class ListaCategorias
    {
        public int IdEvento { get; set; }
        public int IdCategoria { get; set; }

        public Categoria IdCategoriaNavigation { get; set; }
        public Evento IdEventoNavigation { get; set; }
    }
}
