﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SosuPower.DataAccess;

#nullable disable

namespace SosuPower.DataAccess.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240617140158_ModifiedPrescriptions")]
    partial class ModifiedPrescriptions
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EmployeeTask", b =>
                {
                    b.Property<int>("EmployeesEmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("TasksTaskId")
                        .HasColumnType("int");

                    b.HasKey("EmployeesEmployeeId", "TasksTaskId");

                    b.HasIndex("TasksTaskId");

                    b.ToTable("EmployeeTask");
                });

            modelBuilder.Entity("SosuPower.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AddressId"));

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("AddressId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("SosuPower.Entities.CareCenter", b =>
                {
                    b.Property<int>("CareCenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CareCenterId"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CareCenterId");

                    b.HasIndex("AddressId");

                    b.ToTable("CareCenters");
                });

            modelBuilder.Entity("SosuPower.Entities.Diagnosis", b =>
                {
                    b.Property<int>("DiagnosisId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DiagnosisId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.HasKey("DiagnosisId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Diagnoses");
                });

            modelBuilder.Entity("SosuPower.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<int>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmployeeId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("SosuPower.Entities.Medicine", b =>
                {
                    b.Property<int>("MedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineId"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicineId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("SosuPower.Entities.MedicineTask", b =>
                {
                    b.Property<int>("MedicineTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MedicineTaskId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<int?>("MedicineId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaskId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MedicineTaskId");

                    b.HasIndex("MedicineId");

                    b.HasIndex("TaskId");

                    b.ToTable("MedicineTasks");
                });

            modelBuilder.Entity("SosuPower.Entities.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PrescriptionId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ResidentId")
                        .HasColumnType("int");

                    b.Property<string>("Unit")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("SosuPower.Entities.Resident", b =>
                {
                    b.Property<int>("ResidentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResidentId"));

                    b.Property<int?>("CareCenterId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Notes")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("RoomNumber")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ResidentId");

                    b.HasIndex("CareCenterId");

                    b.ToTable("Residents");
                });

            modelBuilder.Entity("SosuPower.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("SosuPower.Entities.SubTask", b =>
                {
                    b.Property<int>("SubTaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubTaskId"));

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TaskId")
                        .HasColumnType("int");

                    b.HasKey("SubTaskId");

                    b.HasIndex("TaskId");

                    b.ToTable("SubTasks");
                });

            modelBuilder.Entity("SosuPower.Entities.Task", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskId"));

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.Property<int>("ResidentId")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeEnd")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TimeStart")
                        .HasColumnType("datetime2");

                    b.HasKey("TaskId");

                    b.HasIndex("ResidentId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("EmployeeTask", b =>
                {
                    b.HasOne("SosuPower.Entities.Employee", null)
                        .WithMany()
                        .HasForeignKey("EmployeesEmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SosuPower.Entities.Task", null)
                        .WithMany()
                        .HasForeignKey("TasksTaskId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SosuPower.Entities.CareCenter", b =>
                {
                    b.HasOne("SosuPower.Entities.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("SosuPower.Entities.Diagnosis", b =>
                {
                    b.HasOne("SosuPower.Entities.Resident", null)
                        .WithMany("Diagnoses")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("SosuPower.Entities.Employee", b =>
                {
                    b.HasOne("SosuPower.Entities.CareCenter", "CareCenter")
                        .WithMany()
                        .HasForeignKey("CareCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CareCenter");
                });

            modelBuilder.Entity("SosuPower.Entities.MedicineTask", b =>
                {
                    b.HasOne("SosuPower.Entities.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId");

                    b.HasOne("SosuPower.Entities.Task", null)
                        .WithMany("MedicineTasks")
                        .HasForeignKey("TaskId");

                    b.Navigation("Medicine");
                });

            modelBuilder.Entity("SosuPower.Entities.Prescription", b =>
                {
                    b.HasOne("SosuPower.Entities.Resident", null)
                        .WithMany("Prescriptions")
                        .HasForeignKey("ResidentId");
                });

            modelBuilder.Entity("SosuPower.Entities.Resident", b =>
                {
                    b.HasOne("SosuPower.Entities.CareCenter", null)
                        .WithMany("Residents")
                        .HasForeignKey("CareCenterId");
                });

            modelBuilder.Entity("SosuPower.Entities.Role", b =>
                {
                    b.HasOne("SosuPower.Entities.Employee", null)
                        .WithMany("Roles")
                        .HasForeignKey("EmployeeId");
                });

            modelBuilder.Entity("SosuPower.Entities.SubTask", b =>
                {
                    b.HasOne("SosuPower.Entities.Task", null)
                        .WithMany("SubTasks")
                        .HasForeignKey("TaskId");
                });

            modelBuilder.Entity("SosuPower.Entities.Task", b =>
                {
                    b.HasOne("SosuPower.Entities.Resident", "Resident")
                        .WithMany()
                        .HasForeignKey("ResidentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Resident");
                });

            modelBuilder.Entity("SosuPower.Entities.CareCenter", b =>
                {
                    b.Navigation("Residents");
                });

            modelBuilder.Entity("SosuPower.Entities.Employee", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("SosuPower.Entities.Resident", b =>
                {
                    b.Navigation("Diagnoses");

                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("SosuPower.Entities.Task", b =>
                {
                    b.Navigation("MedicineTasks");

                    b.Navigation("SubTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
