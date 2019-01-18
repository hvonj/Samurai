using EfSamurai.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

public class SamuraiContext : DbContext
{
    public DbSet<Samurai> Samurais { get; set; }
    public object Battle { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
          "Server = (localdb)\\mssqllocaldb; Database = EfSamurai;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        modelBuilder.Entity<SamuraiBattle>()
                .HasKey(x => new { x.SamuraiId, x.BattleId });

        base.OnModelCreating(modelBuilder);
    }
}
