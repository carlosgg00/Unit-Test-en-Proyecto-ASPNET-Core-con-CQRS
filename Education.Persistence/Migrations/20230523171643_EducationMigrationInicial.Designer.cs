﻿// <auto-generated />
using System;
using Education.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Education.Persistence.Migrations
{
    [DbContext(typeof(EducationDbContext))]
    [Migration("20230523171643_EducationMigrationInicial")]
    partial class EducationMigrationInicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Education.Domain.Curso", b =>
                {
                    b.Property<Guid>("CursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime?>("FechaCreacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Precio")
                        .HasPrecision(14, 2)
                        .HasColumnType("decimal(14,2)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CursoId");

                    b.ToTable("Cursos");

                    b.HasData(
                        new
                        {
                            CursoId = new Guid("ff3596b4-e701-4809-aebb-68d61c25b567"),
                            Descripcion = "Curso de C# basico",
                            FechaCreacion = new DateTime(2023, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5767),
                            FechaPublicacion = new DateTime(2025, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5774),
                            Precio = 56m,
                            Titulo = "C# desde cero hasta avanzado"
                        },
                        new
                        {
                            CursoId = new Guid("53a13360-2e32-4f91-bd4f-0552c919eafc"),
                            Descripcion = "Curso de C# Java",
                            FechaCreacion = new DateTime(2023, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5804),
                            FechaPublicacion = new DateTime(2025, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5805),
                            Precio = 25m,
                            Titulo = "Master en Java Spring desde las raices"
                        },
                        new
                        {
                            CursoId = new Guid("01c21bc7-bb24-4a17-b985-32a0ed6262b8"),
                            Descripcion = "Curso de Unit Test para NET Core",
                            FechaCreacion = new DateTime(2023, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5812),
                            FechaPublicacion = new DateTime(2025, 5, 23, 11, 16, 43, 248, DateTimeKind.Local).AddTicks(5813),
                            Precio = 1000m,
                            Titulo = "Master en Unit Test con CQRS"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}