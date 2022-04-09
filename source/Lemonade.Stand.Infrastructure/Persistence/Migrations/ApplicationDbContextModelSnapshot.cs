﻿// <auto-generated />
using Lemonade.Stand.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lemonade.Stand.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Lemonade.Stand.Core.Entities.Fruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Fruits");
                });

            modelBuilder.Entity("Lemonade.Stand.Core.Entities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AllowedFruitId")
                        .HasColumnType("int");

                    b.Property<decimal>("ConsumptionPerGlass")
                        .HasColumnType("decimal(65,30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PricePerGlass")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AllowedFruitId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Lemonade.Stand.Core.Entities.Recipe", b =>
                {
                    b.HasOne("Lemonade.Stand.Core.Entities.Fruit", "AllowedFruit")
                        .WithMany()
                        .HasForeignKey("AllowedFruitId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AllowedFruit");
                });
#pragma warning restore 612, 618
        }
    }
}