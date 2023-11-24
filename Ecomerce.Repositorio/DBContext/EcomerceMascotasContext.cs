using System;
using System.Collections.Generic;
using Ecomerce.Modelo;
using Microsoft.EntityFrameworkCore;

namespace Ecomerce.Repositorio.DBContext;

public partial class EcomerceMascotasContext : DbContext
{
    public EcomerceMascotasContext()
    {
    }

    public EcomerceMascotasContext(DbContextOptions<EcomerceMascotasContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categoria { get; set; }

    public virtual DbSet<ComentarioPedido> ComentarioPedidos { get; set; }

    public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }

    public virtual DbSet<EstadoPedido> EstadoPedidos { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<SeguimientoPedido> SeguimientoPedidos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<Venta> Venta { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.IdCategoria).HasName("PK__Categori__A3C02A10DA1C24E3");

            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ComentarioPedido>(entity =>
        {
            entity.HasKey(e => e.IdComentario).HasName("PK__Comentar__DDBEFBF9503845C1");

            entity.ToTable("ComentarioPedido");

            entity.Property(e => e.Comentario)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.ComentarioPedidos)
                .HasForeignKey(d => d.IdVenta)
                .HasConstraintName("FK__Comentari__IdVen__4E88ABD4");
        });

        modelBuilder.Entity<DetalleVenta>(entity =>
        {
            entity.HasKey(e => e.IdDetalleVenta).HasName("PK__DetalleV__AAA5CEC20F224915");

            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdProductoNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdProducto)
                .HasConstraintName("FK__DetalleVe__IdPro__44FF419A");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.DetalleVenta)
                .HasForeignKey(d => d.IdVenta)
                .HasConstraintName("FK__DetalleVe__IdVen__440B1D61");
        });

        modelBuilder.Entity<EstadoPedido>(entity =>
        {
            entity.HasKey(e => e.IdEstado).HasName("PK__EstadoPe__FBB0EDC1CAE25AB9");

            entity.ToTable("EstadoPedido");

            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProducto).HasName("PK__Producto__09889210D044AD6F");

            entity.ToTable("Producto");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Imagen).IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.PrecioOferta).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdCategoriaNavigation).WithMany(p => p.Productos)
                .HasForeignKey(d => d.IdCategoria)
                .HasConstraintName("FK__Producto__IdCate__398D8EEE");
        });

        modelBuilder.Entity<SeguimientoPedido>(entity =>
        {
            entity.HasKey(e => e.IdSeguimiento).HasName("PK__Seguimie__5643F60FEEB74B5D");

            entity.ToTable("SeguimientoPedido");

            entity.Property(e => e.Fecha)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");

            entity.HasOne(d => d.IdEstadoNavigation).WithMany(p => p.SeguimientoPedidos)
                .HasForeignKey(d => d.IdEstado)
                .HasConstraintName("FK__Seguimien__IdEst__4AB81AF0");

            entity.HasOne(d => d.IdVentaNavigation).WithMany(p => p.SeguimientoPedidos)
                .HasForeignKey(d => d.IdVenta)
                .HasConstraintName("FK__Seguimien__IdVen__49C3F6B7");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF978A74DB71");

            entity.ToTable("Usuario");

            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NombreCompleto)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rol)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.IdVenta).HasName("PK__Venta__BC1240BD4728C048");

            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("decimal(10, 2)");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Venta)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Venta__IdUsuario__403A8C7D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
