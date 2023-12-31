﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyFirstBlazorApp.Data.Modals;

#nullable disable

namespace MyFirstBlazorApp.Migrations
{
    [DbContext(typeof(EmployeeManagerDbContext))]
    partial class EmployeeManagerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyFirstBlazorApp.Data.Modals.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sales"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Marketing"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Human Resources"
                        },
                        new
                        {
                            Id = 5,
                            Name = "IT"
                        });
                });

            modelBuilder.Entity("MyFirstBlazorApp.Data.Modals.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DepartmentId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeveloper")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("TimeStamp")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            DepartmentId = 2,
                            FirstName = "Dusty",
                            ImageUrl = "piggy.jpg",
                            IsDeveloper = true,
                            LastName = "Shaw"
                        },
                        new
                        {
                            Id = 111,
                            DepartmentId = 2,
                            FirstName = "Enoch",
                            ImageUrl = "Beaker.jpg",
                            IsDeveloper = true,
                            LastName = "Whitaker"
                        },
                        new
                        {
                            Id = 121,
                            DepartmentId = 4,
                            FirstName = "Garion",
                            ImageUrl = "kermit.jpg",
                            IsDeveloper = true,
                            LastName = "Cox"
                        },
                        new
                        {
                            Id = 131,
                            DepartmentId = 5,
                            FirstName = "Fozzie",
                            ImageUrl = "Fozzie_Bear.jpg",
                            IsDeveloper = false,
                            LastName = "Bear"
                        },
                        new
                        {
                            Id = 141,
                            DepartmentId = 2,
                            FirstName = "Gonzo",
                            ImageUrl = "Gonzo.jpg",
                            IsDeveloper = false,
                            LastName = "The Great"
                        },
                        new
                        {
                            Id = 151,
                            DepartmentId = 1,
                            FirstName = "Sam",
                            ImageUrl = "SamTheEagle.jpg",
                            IsDeveloper = false,
                            LastName = "The Eagle"
                        },
                        new
                        {
                            Id = 171,
                            DepartmentId = 4,
                            FirstName = "Beaker",
                            ImageUrl = "Beaker.jpg",
                            IsDeveloper = false,
                            LastName = "The Muppet"
                        },
                        new
                        {
                            Id = 181,
                            DepartmentId = 5,
                            FirstName = "Fozzie ",
                            ImageUrl = "Fozzie_Bear.jpg",
                            IsDeveloper = false,
                            LastName = "Bear 2"
                        },
                        new
                        {
                            Id = 191,
                            DepartmentId = 2,
                            FirstName = "Gonzo",
                            ImageUrl = "Gonzo.jpg",
                            IsDeveloper = false,
                            LastName = "The Great 2"
                        },
                        new
                        {
                            Id = 201,
                            DepartmentId = 1,
                            FirstName = "Sam",
                            ImageUrl = "SamTheEagle.jpg",
                            IsDeveloper = false,
                            LastName = "The Eagle 2"
                        },
                        new
                        {
                            Id = 211,
                            DepartmentId = 4,
                            FirstName = "Fried",
                            ImageUrl = "Beaker.jpg",
                            IsDeveloper = false,
                            LastName = "Pickle ?"
                        });
                });

            modelBuilder.Entity("MyFirstBlazorApp.Data.Modals.Employee", b =>
                {
                    b.HasOne("MyFirstBlazorApp.Data.Modals.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("MyFirstBlazorApp.Data.Modals.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
