using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AssetsAPIMiguelCastro_.Models;

public partial class Ex1p6assets20243Context : DbContext
{
    public Ex1p6assets20243Context()
    {
    }

    public Ex1p6assets20243Context(DbContextOptions<Ex1p6assets20243Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Activo> Activos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
    { 

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Activo>(entity =>
        {
            entity.HasKey(e => e.Idactivo).HasName("PK__Activo__4D2680445A8AAA8D");

            entity.ToTable("Activo");

            entity.Property(e => e.Idactivo).HasColumnName("IDActivo");
            entity.Property(e => e.CostoActivo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Descripcion).HasMaxLength(1000);
            entity.Property(e => e.EstadoActivo)
                .IsRequired()
                .HasDefaultValueSql("('1')");
            entity.Property(e => e.FechaRegistro).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.NombreActivo).HasMaxLength(255);
            entity.Property(e => e.NumeroSerie).HasMaxLength(255);
            entity.Property(e => e.PorcentajeDepreciacion).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Responsable).HasMaxLength(255);
            entity.Property(e => e.Ubicacion).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
