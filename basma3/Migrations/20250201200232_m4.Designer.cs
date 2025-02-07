﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using basma2.models;

#nullable disable

namespace basma3.Migrations
{
    [DbContext(typeof(basma2Context))]
    [Migration("20250201200232_m4")]
    partial class m4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("basma2.models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Department");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "IT"
                        },
                        new
                        {
                            Id = 2,
                            Name = "HR"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Finance"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Marketing"
                        });
                });

            modelBuilder.Entity("basma2.models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("did")
                        .HasColumnType("int");

                    b.Property<int?>("superId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Email");

                    b.HasIndex("did");

                    b.HasIndex("superId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("basma2.models.EmployeesRecords", b =>
                {
                    b.Property<int>("recordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("recordId"));

                    b.Property<DateTime?>("Attendence")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("day")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("departure")
                        .HasColumnType("datetime2");

                    b.HasKey("recordId");

                    b.HasIndex("day");

                    b.ToTable("EmployeesRecords");
                });

            modelBuilder.Entity("basma3.models.Reports", b =>
                {
                    b.Property<int>("repordId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("repordId"));

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("RecordId")
                        .HasColumnType("int");

                    b.HasKey("repordId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("RecordId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("basma2.models.Employee", b =>
                {
                    b.HasOne("basma2.models.Department", "department")
                        .WithMany("Employees")
                        .HasForeignKey("did")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("basma2.models.Employee", "supervisor")
                        .WithMany()
                        .HasForeignKey("superId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("department");

                    b.Navigation("supervisor");
                });

            modelBuilder.Entity("basma3.models.Reports", b =>
                {
                    b.HasOne("basma2.models.Employee", "Employee")
                        .WithMany("Reports")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("basma2.models.EmployeesRecords", "Record")
                        .WithMany("Reports")
                        .HasForeignKey("RecordId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Record");
                });

            modelBuilder.Entity("basma2.models.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("basma2.models.Employee", b =>
                {
                    b.Navigation("Reports");
                });

            modelBuilder.Entity("basma2.models.EmployeesRecords", b =>
                {
                    b.Navigation("Reports");
                });
#pragma warning restore 612, 618
        }
    }
}
