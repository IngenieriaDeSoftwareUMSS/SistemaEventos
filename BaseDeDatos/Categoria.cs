using System;
using System.Collections.Generic;

namespace SistemaEventosUMSS.BaseDeDatos
{
    public partial class Categoria
    {
        public Categoria()
        {
            ListaCategorias = new HashSet<ListaCategorias>();
        }

        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string ColorCategoria { get; set; }
        public string DescripcionCategoria { get; set; }

        public ICollection<ListaCategorias> ListaCategorias { get; set; }
    }
}
