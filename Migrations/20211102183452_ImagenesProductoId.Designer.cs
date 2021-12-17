﻿// <auto-generated />
using System;
using ArysolDeportes_SantiagoFritz.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArysolDeportes_SantiagoFritz.Migrations
{
    [DbContext(typeof(ArysolDeportesDbContext))]
    [Migration("20211102183452_ImagenesProductoId")]
    partial class ImagenesProductoId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArysolDeportes_SantiagoFritz.Models.Categoria", b =>
                {
                    b.Property<int>("idCategoria")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdCategoria")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombreCategoria")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NombreCategoria");

                    b.HasKey("idCategoria");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ArysolDeportes_SantiagoFritz.Models.Imagen", b =>
                {
                    b.Property<int>("idImagen")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdImagen")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("contenido")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Contenido");

                    b.Property<bool>("eliminada")
                        .HasColumnType("bit")
                        .HasColumnName("Eliminada");

                    b.Property<int>("productoId")
                        .HasColumnType("int")
                        .HasColumnName("Productoid");

                    b.HasKey("idImagen");

                    b.HasIndex("productoId");

                    b.ToTable("Imagenes");
                });

            modelBuilder.Entity("ArysolDeportes_SantiagoFritz.Models.Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdProducto")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("categoriaidCategoria")
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Descripcion");

                    b.Property<bool>("eliminado")
                        .HasColumnType("bit")
                        .HasColumnName("Eliminado");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Nombre");

                    b.Property<double?>("precio")
                        .IsRequired()
                        .HasColumnType("float")
                        .HasColumnName("Precio");

                    b.Property<int?>("stock")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasColumnName("Stock");

                    b.HasKey("id");

                    b.HasIndex("categoriaidCategoria");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("ArysolDeportes_SantiagoFritz.Models.Imagen", b =>
                {
                    b.HasOne("ArysolDeportes_SantiagoFritz.Models.Producto", null)
                        .WithMany("imagenes")
                        .HasForeignKey("productoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArysolDeportes_SantiagoFritz.Models.Producto", b =>
                {
                    b.HasOne("ArysolDeportes_SantiagoFritz.Models.Categoria", "categoria")
                        .WithMany()
                        .HasForeignKey("categoriaidCategoria");

                    b.Navigation("categoria");
                });

            modelBuilder.Entity("ArysolDeportes_SantiagoFritz.Models.Producto", b =>
                {
                    b.Navigation("imagenes");
                });
#pragma warning restore 612, 618
        }
    }
}
