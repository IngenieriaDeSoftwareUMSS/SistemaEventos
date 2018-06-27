using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace SistemaEventosUMSS.Models
{
  public class User
  {
    [DatabaseGenerated(DatabaseGeneratedOption.None)]
    public int ID { get; set; }
    public string EMail { get; set; }
    public string PasswordUsuario { get; set; }
    public string NombreUsuario { get; set; }
    public string ApellidoUsuario { get; set; }
    public DateTime FechaNacimiento { get; set; }

    public ICollection<EventUser> EventUsers { get; set; }
  }
}
