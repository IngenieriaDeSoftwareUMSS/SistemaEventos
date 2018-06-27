using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaEventosUMSS.Models
{
  public class EventUser
  {
    public int ID { get; set; }
    public int EventID { get; set; }
    public int UserID { get; set; }

    public Event Event{ get; set; }
    public User User { get; set; }
  }
}
