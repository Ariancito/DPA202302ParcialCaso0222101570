using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DPA202302ParcialCaso0222101570.Models;

public partial class Parcial2023Context : DbContext
{
    public Parcial2023Context()
    {
    }

    public Parcial2023Context(DbContextOptions<Parcial2023Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Country> Country { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=WS2302500;Database=Parcial2023;TrustServerCertificate=True;Integrated Security=true;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Country>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Currency)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Description)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
