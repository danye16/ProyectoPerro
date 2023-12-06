﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoPerro.Data;

namespace ProyectoPerro.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231206050854_Collar")]
    partial class Collar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.HasKey("Id");

                    b.ToTable("Collar");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Perro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CollarId")
                        .HasColumnType("int");

                    b.Property<string>("Edad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idcollar")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Raza")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CollarId")
                        .IsUnique();

                    b.ToTable("Perros");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Perro", b =>
                {
                    b.HasOne("ProyectoPerro.Data.Models.Collar", "Collar")
                        .WithOne("Perro")
                        .HasForeignKey("ProyectoPerro.Data.Models.Perro", "CollarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Collar");
                });

            modelBuilder.Entity("ProyectoPerro.Data.Models.Collar", b =>
                {
                    b.Navigation("Perro");
                });
#pragma warning restore 612, 618
        }
    }
}
