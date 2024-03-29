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
    [Migration("20220406134101_CarPooling")]
    partial class CarPooling
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfSeats")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("project.DAL.Entities.DriveEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Destination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsFull")
                        .HasColumnType("bit");

                    b.Property<string>("JourneyBeginning")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("UserEntityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("UserEntityId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.HasIndex("UserEntityId1");

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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsOnJourney")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("project.DAL.Entities.CarEntity", b =>
                {
                    b.HasOne("project.DAL.Entities.UserEntity", null)
                        .WithMany("OwnedCars")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("project.DAL.Entities.DriveEntity", b =>
                {
                    b.HasOne("project.DAL.Entities.UserEntity", null)
                        .WithMany("DrivesAsDriver")
                        .HasForeignKey("UserEntityId");

                    b.HasOne("project.DAL.Entities.UserEntity", null)
                        .WithMany("DrivesAsPassenger")
                        .HasForeignKey("UserEntityId1");
                });

            modelBuilder.Entity("project.DAL.Entities.UserEntity", b =>
                {
                    b.Navigation("DrivesAsDriver");

                    b.Navigation("DrivesAsPassenger");

                    b.Navigation("OwnedCars");
                });
#pragma warning restore 612, 618
        }
    }
}
