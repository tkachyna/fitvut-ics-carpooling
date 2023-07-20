﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using project.DAL;

#nullable disable

namespace project.DAL.Migrations
{
    [DbContext(typeof(CarPoolingDbContext))]
    [Migration("20220513130237_fixedEntities")]
    partial class fixedEntities
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DriveEntityUserEntity", b =>
                {
                    b.Property<Guid>("DrivesAsPassengerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PassengersId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("DrivesAsPassengerId", "PassengersId");

                    b.HasIndex("PassengersId");

                    b.ToTable("DriveEntityUserEntity");
                });

            modelBuilder.Entity("project.DAL.Entities.CarEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateOfRegistration")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manufacturer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<Guid?>("OwnerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("project.DAL.Entities.DriveEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("DriverId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsFull")
                        .HasColumnType("bit");

                    b.Property<string>("JourneyBeginning")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.HasIndex("DriverId");

                    b.ToTable("Drives");
                });

            modelBuilder.Entity("project.DAL.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DriveEntityUserEntity", b =>
                {
                    b.HasOne("project.DAL.Entities.DriveEntity", null)
                        .WithMany()
                        .HasForeignKey("DrivesAsPassengerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("project.DAL.Entities.UserEntity", null)
                        .WithMany()
                        .HasForeignKey("PassengersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("project.DAL.Entities.CarEntity", b =>
                {
                    b.HasOne("project.DAL.Entities.UserEntity", "Owner")
                        .WithMany("OwnedCars")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("project.DAL.Entities.DriveEntity", b =>
                {
                    b.HasOne("project.DAL.Entities.CarEntity", "Car")
                        .WithMany("Drives")
                        .HasForeignKey("CarId");

                    b.HasOne("project.DAL.Entities.UserEntity", "Driver")
                        .WithMany("DrivesAsDriver")
                        .HasForeignKey("DriverId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.Navigation("Car");

                    b.Navigation("Driver");
                });

            modelBuilder.Entity("project.DAL.Entities.CarEntity", b =>
                {
                    b.Navigation("Drives");
                });

            modelBuilder.Entity("project.DAL.Entities.UserEntity", b =>
                {
                    b.Navigation("DrivesAsDriver");

                    b.Navigation("OwnedCars");
                });
#pragma warning restore 612, 618
        }
    }
}
