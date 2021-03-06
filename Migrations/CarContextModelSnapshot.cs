﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesMovie.Data;

namespace ParkingCar.Migrations
{
    [DbContext(typeof(CarContext))]
    partial class CarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9");

            modelBuilder.Entity("ParkingCar.Data.Domain.Car", b =>
                {
                    b.Property<string>("Plate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Entrance")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Exit")
                        .HasColumnType("TEXT");

                    b.Property<string>("Model")
                        .HasColumnType("TEXT");

                    b.HasKey("Plate");

                    b.ToTable("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
