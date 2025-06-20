using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SimpsonsEpisodeGenerator.Models;

namespace SimpsonsEpisodeGenerator.Data;

public partial class SimpsonsEpisodeGeneratorContext : DbContext
{
    public SimpsonsEpisodeGeneratorContext()
    {
    }

    public SimpsonsEpisodeGeneratorContext(DbContextOptions<SimpsonsEpisodeGeneratorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Changelog> Changelogs { get; set; }

    public virtual DbSet<Episode> Episodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=SimpsonsEpisodeGenerator");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Changelog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__changelo__3213E83F784ECD38");

            entity.Property(e => e.InstalledOn).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Episode>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
