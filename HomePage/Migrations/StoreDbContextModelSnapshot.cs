﻿// <auto-generated />
using System;
using HomePage.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HomePage.Migrations
{
    [DbContext(typeof(StoreDbContext))]
    partial class StoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("HomePage.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NumberOfSeat")
                        .HasColumnType("int");

                    b.Property<int>("ShowID")
                        .HasColumnType("int");

                    b.Property<int?>("ShowSeatID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserBookingID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("ShowID");

                    b.HasIndex("ShowSeatID");

                    b.HasIndex("UserBookingID");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("HomePage.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CategoryIcon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("HomePage.Models.CinemaHell", b =>
                {
                    b.Property<int>("CinemaHellID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalSeats")
                        .HasColumnType("int");

                    b.HasKey("CinemaHellID");

                    b.ToTable("CinemaHells");
                });

            modelBuilder.Entity("HomePage.Models.CinemaSeat", b =>
                {
                    b.Property<int>("CinemaSeatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CinemaHallID")
                        .HasColumnType("int");

                    b.Property<int?>("CinemaHellID")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("CinemaSeatID");

                    b.HasIndex("CinemaHellID");

                    b.ToTable("CinemaSeats");
                });

            modelBuilder.Entity("HomePage.Models.Media", b =>
                {
                    b.Property<int>("MediaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("ShopID")
                        .HasColumnType("int");

                    b.Property<string>("url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MediaID");

                    b.HasIndex("MovieID");

                    b.HasIndex("ShopID");

                    b.ToTable("Medias");
                });

            modelBuilder.Entity("HomePage.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Duration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieID");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("HomePage.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentMethod")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("PaymentID");

                    b.HasIndex("BookingID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("HomePage.Models.Product", b =>
                {
                    b.Property<int>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ProductImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductLike")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShopID")
                        .HasColumnType("int");

                    b.HasKey("ProductID");

                    b.HasIndex("ShopID");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("HomePage.Models.Shop", b =>
                {
                    b.Property<int>("ShopID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("ShopAbout")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopContact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShopOpenTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Shops");
                });

            modelBuilder.Entity("HomePage.Models.Show", b =>
                {
                    b.Property<int>("ShowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CinemaHellID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("MovieID")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ShowID");

                    b.HasIndex("CinemaHellID");

                    b.HasIndex("MovieID");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("HomePage.Models.ShowSeat", b =>
                {
                    b.Property<int>("ShowSeatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BookingID")
                        .HasColumnType("int");

                    b.Property<int>("CinemaSeatID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("ShowID")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ShowSeatID");

                    b.HasIndex("CinemaSeatID");

                    b.HasIndex("ShowID");

                    b.ToTable("ShowSeats");
                });

            modelBuilder.Entity("HomePage.Models.UserBooking", b =>
                {
                    b.Property<int>("UserBookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("UserBookingEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserBookingName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserBookingID");

                    b.ToTable("UserBookings");
                });

            modelBuilder.Entity("HomePage.Models.Booking", b =>
                {
                    b.HasOne("HomePage.Models.Show", "Shows")
                        .WithMany()
                        .HasForeignKey("ShowID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomePage.Models.ShowSeat", null)
                        .WithMany("Booking")
                        .HasForeignKey("ShowSeatID");

                    b.HasOne("HomePage.Models.UserBooking", "UserBooking")
                        .WithMany()
                        .HasForeignKey("UserBookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shows");

                    b.Navigation("UserBooking");
                });

            modelBuilder.Entity("HomePage.Models.CinemaSeat", b =>
                {
                    b.HasOne("HomePage.Models.CinemaHell", "CinemaHell")
                        .WithMany()
                        .HasForeignKey("CinemaHellID");

                    b.Navigation("CinemaHell");
                });

            modelBuilder.Entity("HomePage.Models.Media", b =>
                {
                    b.HasOne("HomePage.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomePage.Models.Shop", "Shops")
                        .WithMany("Medias")
                        .HasForeignKey("ShopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Movie");

                    b.Navigation("Shops");
                });

            modelBuilder.Entity("HomePage.Models.Payment", b =>
                {
                    b.HasOne("HomePage.Models.Booking", "Booking")
                        .WithMany()
                        .HasForeignKey("BookingID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Booking");
                });

            modelBuilder.Entity("HomePage.Models.Product", b =>
                {
                    b.HasOne("HomePage.Models.Shop", "Shops")
                        .WithMany()
                        .HasForeignKey("ShopID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Shops");
                });

            modelBuilder.Entity("HomePage.Models.Shop", b =>
                {
                    b.HasOne("HomePage.Models.Category", "Categories")
                        .WithMany("Shops")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("HomePage.Models.Show", b =>
                {
                    b.HasOne("HomePage.Models.CinemaHell", "CinemaHell")
                        .WithMany()
                        .HasForeignKey("CinemaHellID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomePage.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaHell");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("HomePage.Models.ShowSeat", b =>
                {
                    b.HasOne("HomePage.Models.CinemaSeat", "CinemaSeat")
                        .WithMany()
                        .HasForeignKey("CinemaSeatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HomePage.Models.Show", "Shows")
                        .WithMany()
                        .HasForeignKey("ShowID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CinemaSeat");

                    b.Navigation("Shows");
                });

            modelBuilder.Entity("HomePage.Models.Category", b =>
                {
                    b.Navigation("Shops");
                });

            modelBuilder.Entity("HomePage.Models.Shop", b =>
                {
                    b.Navigation("Medias");
                });

            modelBuilder.Entity("HomePage.Models.ShowSeat", b =>
                {
                    b.Navigation("Booking");
                });
#pragma warning restore 612, 618
        }
    }
}
