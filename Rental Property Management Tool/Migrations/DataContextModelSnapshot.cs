﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rental_Property_Management_Tool.Data;

namespace Rental_Property_Management_Tool.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("OverheadCostRentalProperty", b =>
                {
                    b.Property<int>("CostsId")
                        .HasColumnType("int");

                    b.Property<int>("RentalPropertiesId")
                        .HasColumnType("int");

                    b.HasKey("CostsId", "RentalPropertiesId");

                    b.HasIndex("RentalPropertiesId");

                    b.ToTable("OverheadCostRentalProperty");
                });

            modelBuilder.Entity("Rental_Property_Management_Tool.Models.OverheadCost", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<string>("CostDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OverheadCosts");
                });

            modelBuilder.Entity("Rental_Property_Management_Tool.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LegalEntity")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Rental_Property_Management_Tool.Models.RentalProperty", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonsId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentalEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RentalStart")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Rented")
                        .HasColumnType("bit");

                    b.Property<double>("SquaresMeters")
                        .HasColumnType("float");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonsId");

                    b.HasIndex("UserId");

                    b.ToTable("RentalProperties");
                });

            modelBuilder.Entity("Rental_Property_Management_Tool.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("OverheadCostRentalProperty", b =>
                {
                    b.HasOne("Rental_Property_Management_Tool.Models.OverheadCost", null)
                        .WithMany()
                        .HasForeignKey("CostsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rental_Property_Management_Tool.Models.RentalProperty", null)
                        .WithMany()
                        .HasForeignKey("RentalPropertiesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Rental_Property_Management_Tool.Models.RentalProperty", b =>
                {
                    b.HasOne("Rental_Property_Management_Tool.Models.Person", "Persons")
                        .WithMany("RentedProperties")
                        .HasForeignKey("PersonsId");

                    b.HasOne("Rental_Property_Management_Tool.Models.User", "User")
                        .WithMany("RentalProperties")
                        .HasForeignKey("UserId");

                    b.Navigation("Persons");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Rental_Property_Management_Tool.Models.Person", b =>
                {
                    b.Navigation("RentedProperties");
                });

            modelBuilder.Entity("Rental_Property_Management_Tool.Models.User", b =>
                {
                    b.Navigation("RentalProperties");
                });
#pragma warning restore 612, 618
        }
    }
}
