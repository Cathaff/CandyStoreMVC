﻿// <auto-generated />
using CandyStore.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CandyStore.Migrations
{
    [DbContext(typeof(CandyStoreDbContext))]
    partial class CandyStoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.0");

            modelBuilder.Entity("CandyStore.Entity.Candy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Color")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Candies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Color = "Brown",
                            Name = "Chocolate"
                        },
                        new
                        {
                            Id = 2,
                            Color = "Pink/Blue",
                            Name = "Fizzy Pop"
                        },
                        new
                        {
                            Id = 3,
                            Color = "Beige",
                            Name = "Werthes's Original"
                        },
                        new
                        {
                            Id = 4,
                            Color = "Red",
                            Name = "Ferrari"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
