﻿// <auto-generated />
using System;
using ConsoleApp_DB.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleApp_DB.Migrations
{
    [DbContext(typeof(EmployerDBContext))]
    [Migration("20240331173635_First")]
    partial class First
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleApp_DB.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ConsoleApp_DB.Entities.Employer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte>("Age")
                        .HasColumnType("tinyint");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentNo")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employers");
                });

            modelBuilder.Entity("ConsoleApp_DB.Entities.Employer", b =>
                {
                    b.HasOne("ConsoleApp_DB.Entities.Department", null)
                        .WithMany("Employers")
                        .HasForeignKey("DepartmentId");
                });

            modelBuilder.Entity("ConsoleApp_DB.Entities.Department", b =>
                {
                    b.Navigation("Employers");
                });
#pragma warning restore 612, 618
        }
    }
}