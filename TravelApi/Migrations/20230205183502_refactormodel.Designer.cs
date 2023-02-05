﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TravelApi.Models;

#nullable disable

namespace TravelApi.Migrations
{
    [DbContext(typeof(TravelApiContext))]
    [Migration("20230205183502_refactormodel")]
    partial class refactormodel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("TravelApi.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("City")
                        .HasColumnType("longtext");

                    b.Property<string>("Country")
                        .HasColumnType("longtext");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("longtext");

                    b.HasKey("DestinationId");

                    b.ToTable("Destinations");

                    b.HasData(
                        new
                        {
                            DestinationId = 1,
                            City = "Seattle",
                            Country = "USA",
                            Rating = 5,
                            Review = "Good coffee, scenic bay, awesome market"
                        },
                        new
                        {
                            DestinationId = 2,
                            City = "Paris",
                            Country = "France",
                            Rating = 4,
                            Review = "Bon bageutte"
                        },
                        new
                        {
                            DestinationId = 3,
                            City = "Tokyo",
                            Country = "Japan",
                            Rating = 5,
                            Review = "So many weebs and ramen"
                        },
                        new
                        {
                            DestinationId = 4,
                            City = "London",
                            Country = "England",
                            Rating = 3,
                            Review = "Fish n chips mate!"
                        },
                        new
                        {
                            DestinationId = 5,
                            City = "New York",
                            Country = "USA",
                            Rating = 4,
                            Review = "Great Parks and Museums"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
