using Microsoft.EntityFrameworkCore;
using OrganizadordeevntosMirelys.Models;
using System;

namespace OrganizadordeevntosMirelys.DataB;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Evento> Evento { get; set; }
    public DbSet<Invitado> Invitados { get; set; }
    public DbSet<TareaEvento> Tareas { get; set; }
    public DbSet<Presupuesto> Presupuestos { get; set; }
    public DbSet<Cronograma> Cronogramas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Evento>()
            .HasOne(e => e.Presupuesto)
            .WithOne(p => p.Evento)
            .HasForeignKey<Presupuesto>(p => p.EventoId);
    }
}



