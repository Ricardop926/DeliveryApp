using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Delivery.Core.Entities;

namespace Delivery.Infrastructure.Data
{
    public partial class DB_MafiaTechContext : DbContext
    {
        public DB_MafiaTechContext()
        {
        }

        public DB_MafiaTechContext(DbContextOptions<DB_MafiaTechContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCliente> TblClientes { get; set; } = null!;
        public virtual DbSet<TblDetallepedido> TblDetallepedidos { get; set; } = null!;
        public virtual DbSet<TblEmpleado> TblEmpleados { get; set; } = null!;
        public virtual DbSet<TblPedido> TblPedidos { get; set; } = null!;
        public object Tblpedidos { get; internal set; }
        public virtual DbSet<TblProducto> TblProductos { get; set; } = null!;
        public virtual DbSet<TblRestaurante> TblRestaurantes { get; set; } = null!;
        public virtual DbSet<View1> View1s { get; set; } = null!;
        public object TblProducto { get; internal set; }
        public object Posts { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK__tbl_clie__D5946642C33D1459");

                entity.ToTable("tbl_cliente");

                entity.Property(e => e.IdCliente).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIngreso)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblDetallepedido>(entity =>
            {
                entity.HasKey(e => e.IdDetallePedido)
                    .HasName("PK__tbl_deta__610F00568536E19F");

                entity.ToTable("tbl_detallepedido");

                entity.Property(e => e.IdDetallePedido)
                    .HasColumnType("decimal(38, 0)")
                    .HasColumnName("idDetallePedido");

                entity.Property(e => e.Cantidad)
                    .HasColumnType("decimal(20, 0)")
                    .HasColumnName("cantidad");

                entity.Property(e => e.IdEmpleado).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdPedido).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdProducto).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdRestaurante).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NombreEmpleado)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NombreRestautante)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioUnidad).HasColumnType("decimal(20, 0)");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.TblDetallepedidos)
                    .HasForeignKey(d => d.IdEmpleado)
                    .HasConstraintName("FK__tbl_detal__IdEmp__47DBAE45");

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.TblDetallepedidos)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK__tbl_detal__IdPed__46E78A0C");

                entity.HasOne(d => d.IdRestauranteNavigation)
                    .WithMany(p => p.TblDetallepedidos)
                    .HasForeignKey(d => d.IdRestaurante)
                    .HasConstraintName("FK__tbl_detal__IdRes__48CFD27E");
            });

            modelBuilder.Entity<TblEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK__tbl_empl__CE6D8B9ED4F105B2");

                entity.ToTable("tbl_empleado");

                entity.Property(e => e.IdEmpleado).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FechaIngreso).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FechaNcimiento).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NombreEmpleado)
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblPedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido)
                    .HasName("PK__tbl_pedi__9D335DC3AD2343D5");

                entity.ToTable("tbl_pedidos");

                entity.Property(e => e.IdPedido).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DireccionEntrega)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.IdCliente).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdEmpleado).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdProducto).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Iva)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("iva");

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Total).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.TblPedidos)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__tbl_pedid__IdCli__3B75D760");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.TblPedidos)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK__tbl_pedid__IdPro__3C69FB99");
            });

            modelBuilder.Entity<TblProducto>(entity =>
            {
                entity.HasKey(e => e.IdProducto)
                    .HasName("PK__tbl_prod__0988921063F11D93");

                entity.ToTable("tbl_producto");

                entity.Property(e => e.IdProducto).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdRestaurante).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.NombreProducto)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblRestaurante>(entity =>
            {
                entity.HasKey(e => e.IdRestaurante)
                    .HasName("PK__tbl_rest__29CE64FA7481C1D2");

                entity.ToTable("tbl_restaurante");

                entity.Property(e => e.IdRestaurante).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DireccionRestaurante)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.EmailRestaurante)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.NombreRestautante)
                    .HasMaxLength(18)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<View1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_1");

                entity.Property(e => e.IdCliente).HasColumnType("decimal(18, 0)");
            });
            
        }
    }
}
