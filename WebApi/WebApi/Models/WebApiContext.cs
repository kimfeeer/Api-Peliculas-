using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi.Models
{
    public partial class WebApiContext : DbContext
    {
        public WebApiContext()
        {
        }

        public WebApiContext(DbContextOptions<WebApiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Peli> Pelis { get; set; } = null!;
        public virtual DbSet<Pelicula> Peliculas { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=LAPTOP-JK263EVG\\SQLEXPRESS; Database=WebApi;\nTrusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Peli>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pelis");

                entity.Property(e => e.Añopublicacion).IsUnicode(false);

                entity.Property(e => e.Director).IsUnicode(false);

                entity.Property(e => e.Genero).IsUnicode(false);

                entity.Property(e => e.Puntuacion).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Rating).IsUnicode(false);

                entity.Property(e => e.Titulo).IsUnicode(false);
            });

            modelBuilder.Entity<Pelicula>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pelicula");

                entity.Property(e => e.Añopublicacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Director)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Genero)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Puntuacion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rating)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Titulo)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
