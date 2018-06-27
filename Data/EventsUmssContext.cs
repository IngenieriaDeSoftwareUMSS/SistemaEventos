using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaEventosUMSS.Models;
using Microsoft.EntityFrameworkCore;

namespace SistemaEventosUMSS.Data
{
    public class EventsUmssContext : DbContext
    {
    public EventsUmssContext(DbContextOptions<EventsUmssContext> options) : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<EventUser> EventUsers { get; set; }
  }
}
