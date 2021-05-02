using GlobalTicket.TicketManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalTicket.TicketManagement.Persistence
{
    public class GlobalTicketDbContext : DbContext
    {
        public GlobalTicketDbContext(DbContextOptions<GlobalTicketDbContext> options) : base(options)
        {

        }
        public DbSet<Event> Events { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(GlobalTicketDbContext).Assembly);

            
        }

    }
}
