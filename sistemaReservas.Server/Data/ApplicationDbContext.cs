using sistemaReservas.Server.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;

namespace sistemaReservas.Server.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<TipoMesa>().Property(e => e.Color).HasConversion(v => v.ToString(), v => (KnownColor)Enum.Parse(typeof(Color), v));
            

            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);

        }

        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Mesa> Mesas { get; set; }
        public DbSet<Silla> Sillas { get; set; }
        public DbSet<TipoMesa> TipoMesa { get; set; }
        public DbSet<Entrada> Entradas { get; set; }

    }
}
