using System;
using EventManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EventManager.Data
{
    public class EventManagerDbContext : DbContext
    {
        public EventManagerDbContext(DbContextOptions<EventManagerDbContext> options)
            : base(options)
        {
        }
      

        public DbSet<Event> Events { get; set; }
    }
}