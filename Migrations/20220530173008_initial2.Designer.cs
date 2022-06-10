﻿// <auto-generated />
using System;
using BerrasBio_proj1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BerrasBio_proj1.Migrations
{
    [DbContext(typeof(BerrasBio_proj1Context))]
    [Migration("20220530173008_initial2")]
    partial class initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BerrasBio_proj1.DbModel.Booking", b =>
                {
                    b.Property<int>("BookingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingId"), 1L, 1);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TicketQuantity")
                        .HasColumnType("int");

                    b.HasKey("BookingId");

                    b.ToTable("Bookings", (string)null);
                });

            modelBuilder.Entity("BerrasBio_proj1.DbModel.Movie", b =>
                {
                    b.Property<int>("MovieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieId"), 1L, 1);

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MovieId");

                    b.ToTable("Movies", (string)null);
                });

            modelBuilder.Entity("BerrasBio_proj1.DbModel.Salon", b =>
                {
                    b.Property<int>("SalonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalonId"), 1L, 1);

                    b.Property<int>("SalonSize")
                        .HasColumnType("int");

                    b.HasKey("SalonId");

                    b.ToTable("Salons", (string)null);
                });

            modelBuilder.Entity("BerrasBio_proj1.DbModel.Showing", b =>
                {
                    b.Property<int>("ShowingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowingId"), 1L, 1);

                    b.Property<int?>("BookingId1")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId1")
                        .HasColumnType("int");

                    b.Property<int>("RemainingSeats")
                        .HasColumnType("int");

                    b.Property<int?>("SalonId1")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartHour")
                        .HasColumnType("datetime2");

                    b.HasKey("ShowingId");

                    b.HasIndex("BookingId1");

                    b.HasIndex("MovieId1");

                    b.HasIndex("SalonId1");

                    b.ToTable("Showings", (string)null);
                });

            modelBuilder.Entity("BerrasBio_proj1.DbModel.Showing", b =>
                {
                    b.HasOne("BerrasBio_proj1.DbModel.Booking", "Booking")
                        .WithMany("Showings")
                        .HasForeignKey("BookingId1");

                    b.HasOne("BerrasBio_proj1.DbModel.Movie", "Movie")
                        .WithMany("Showings")
                        .HasForeignKey("MovieId1");

                    b.HasOne("BerrasBio_proj1.DbModel.Salon", "Salon")
                        .WithMany("Showings")
                        .HasForeignKey("SalonId1");

                    b.Navigation("Booking");

                    b.Navigation("Movie");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("BerrasBio_proj1.DbModel.Booking", b =>
                {
                    b.Navigation("Showings");
                });

            modelBuilder.Entity("BerrasBio_proj1.DbModel.Movie", b =>
                {
                    b.Navigation("Showings");
                });

            modelBuilder.Entity("BerrasBio_proj1.DbModel.Salon", b =>
                {
                    b.Navigation("Showings");
                });
#pragma warning restore 612, 618
        }
    }
}
