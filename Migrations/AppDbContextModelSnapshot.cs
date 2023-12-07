﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoPerro.Data;

namespace ProyectoPerro.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProyectoPerro.Data.Models.Collar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CollarModelo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerroId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PerroId");

                    b.ToTable("Collars");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Gps", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CollarId")
                        .HasColumnType("int");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("PosicionCasa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PosicionPerro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rango")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollarId");

                    b.ToTable("Gpss");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Perro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Perros");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Correo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idperro")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Collar", b =>
                {
                    b.HasOne("ProyectoPerro.Data.Models.Perro", "Perro")
                        .WithMany("Collars")
                        .HasForeignKey("PerroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Perro");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Gps", b =>
                {
                    b.HasOne("ProyectoPerro.Data.Models.Collar", "Collar")
                        .WithMany("Gps")
                        .HasForeignKey("CollarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collar");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Perro", b =>
                {
                    b.HasOne("ProyectoPerro.Data.Models.Usuario", "Usuario")
                        .WithMany("Perros")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Collar", b =>
                {
                    b.Navigation("Gps");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Perro", b =>
                {
                    b.Navigation("Collars");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Usuario", b =>
                {
                    b.Navigation("Perros");
                });
#pragma warning restore 612, 618
        }
    }
}
