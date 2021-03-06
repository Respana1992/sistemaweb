﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using sistemaweb.Models;

namespace sistemaweb.Migrations
{
    [DbContext(typeof(dbproductosContext))]
    partial class dbproductosContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview7.19362.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("sistemaweb.Models.Categoria", b =>
                {
                    b.Property<int>("Idcategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idcategoria")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnName("descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("estado")
                        .HasDefaultValueSql("((1))");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Idcategoria")
                        .HasName("PK__categori__140587C70A4A298F");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasName("UQ__categori__72AFBCC60D2B5D59");

                    b.ToTable("categoria");
                });

            modelBuilder.Entity("sistemaweb.Models.Producto", b =>
                {
                    b.Property<int>("Idproducto")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idproducto")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Codigo")
                        .HasColumnName("codigo")
                        .HasMaxLength(64)
                        .IsUnicode(false);

                    b.Property<string>("Descripcion")
                        .HasColumnName("descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false);

                    b.Property<bool?>("Estado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("estado")
                        .HasDefaultValueSql("((1))");

                    b.Property<int>("Idcategoria")
                        .HasColumnName("idcategoria");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnName("precio_venta")
                        .HasColumnType("decimal(11, 2)");

                    b.Property<int>("Stock")
                        .HasColumnName("stock");

                    b.HasKey("Idproducto")
                        .HasName("PK__producto__DC53BE3C723C9D7B");

                    b.HasIndex("Idcategoria");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasName("UQ__producto__72AFBCC60BBD3E86");

                    b.ToTable("producto");
                });

            modelBuilder.Entity("sistemaweb.Models.Producto", b =>
                {
                    b.HasOne("sistemaweb.Models.Categoria", "IdcategoriaNavigation")
                        .WithMany("Producto")
                        .HasForeignKey("Idcategoria")
                        .HasConstraintName("FK__producto__idcate__164452B1")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
