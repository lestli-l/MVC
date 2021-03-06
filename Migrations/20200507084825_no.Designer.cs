﻿// <auto-generated />
using System;
using Manage_core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Manage_core.Migrations
{
    [DbContext(typeof(UserContext))]
    [Migration("20200507084825_no")]
    partial class no
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Manage_core.Models.Employee", b =>
                {
                    b.Property<string>("WorkNumber")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("ClassOfEmployee")
                        .HasColumnType("int");

                    b.Property<int>("ClassOfSalary")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DateOfJoin")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdCard")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LeaveDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ReasonOfLeaveing")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkState")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkNumber");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Manage_core.Models.Personal", b =>
                {
                    b.Property<string>("IdentityCard")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("HouseHold")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Marriage")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Rear")
                        .HasColumnType("int");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<string>("WorkId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdentityCard");

                    b.HasIndex("WorkId")
                        .IsUnique()
                        .HasFilter("[WorkId] IS NOT NULL");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("Manage_core.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Manage_core.Models.Personal", b =>
                {
                    b.HasOne("Manage_core.Models.Employee", "Employee")
                        .WithOne("Personal")
                        .HasForeignKey("Manage_core.Models.Personal", "WorkId");
                });
#pragma warning restore 612, 618
        }
    }
}
