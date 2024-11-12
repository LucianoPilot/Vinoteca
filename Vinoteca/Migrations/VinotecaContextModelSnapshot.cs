﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vinoteca.Data;

#nullable disable

namespace Vinoteca.Migrations
{
    [DbContext(typeof(VinotecaContext))]
    partial class VinotecaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("CataWine", b =>
                {
                    b.Property<int>("CataId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("WinesId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CataId", "WinesId");

                    b.HasIndex("WinesId");

                    b.ToTable("CataWine");
                });

            modelBuilder.Entity("Vinoteca.Data.Entities.Cata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<string>("Invitados")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Catas");
                });

            modelBuilder.Entity("Vinoteca.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Rol")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "Pa$$w0rd",
                            Rol = 0,
                            UserName = "mgs@gmail.com"
                        },
                        new
                        {
                            Id = 2,
                            Password = "Cl4ve!",
                            Rol = 0,
                            UserName = "jhonwick@gmail.com"
                        });
                });

            modelBuilder.Entity("Vinoteca.Data.Entities.Wine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Region")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Stock")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Variety")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Wines");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 11, 12, 6, 19, 29, 209, DateTimeKind.Utc).AddTicks(5436),
                            Name = "Malbec",
                            Region = "Mendoza",
                            Stock = 30,
                            Variety = "Malbec",
                            Year = 2020
                        },
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 11, 12, 6, 19, 29, 209, DateTimeKind.Utc).AddTicks(5432),
                            Name = "Cabernet Sauvignon",
                            Region = "Mendoza",
                            Stock = 50,
                            Variety = "Cabernet Sauvignon",
                            Year = 2018
                        });
                });

            modelBuilder.Entity("CataWine", b =>
                {
                    b.HasOne("Vinoteca.Data.Entities.Cata", null)
                        .WithMany()
                        .HasForeignKey("CataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Vinoteca.Data.Entities.Wine", null)
                        .WithMany()
                        .HasForeignKey("WinesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}