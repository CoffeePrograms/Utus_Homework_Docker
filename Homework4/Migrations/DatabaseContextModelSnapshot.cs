﻿// <auto-generated />
using System;
using Homework4.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Homework4.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Homework4.Models.WeatherForecast", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Summary")
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<int>("TemperatureC")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("WeatherForecast");

                    b.HasData(
                        new
                        {
                            Id = new Guid("579fab4b-a0b0-4bfc-b4f9-05c2c37a7a20"),
                            Date = new DateOnly(2025, 2, 5),
                            Summary = "Bracing",
                            TemperatureC = -17
                        },
                        new
                        {
                            Id = new Guid("07daf33a-638e-4737-8612-4a847c6c047f"),
                            Date = new DateOnly(2025, 2, 6),
                            Summary = "Freezing",
                            TemperatureC = 7
                        },
                        new
                        {
                            Id = new Guid("2be2119d-bf85-46d3-a414-02efc55dc8c6"),
                            Date = new DateOnly(2025, 2, 7),
                            Summary = "Scorching",
                            TemperatureC = -2
                        },
                        new
                        {
                            Id = new Guid("e6702e34-6195-4609-ac87-4bab2705a70e"),
                            Date = new DateOnly(2025, 2, 8),
                            Summary = "Scorching",
                            TemperatureC = -1
                        },
                        new
                        {
                            Id = new Guid("5c8f5ed6-bc06-4cd8-8652-5d045e7623e1"),
                            Date = new DateOnly(2025, 2, 9),
                            Summary = "Scorching",
                            TemperatureC = 41
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
