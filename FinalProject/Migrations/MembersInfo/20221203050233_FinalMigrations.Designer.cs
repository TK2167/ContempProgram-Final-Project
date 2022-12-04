﻿// <auto-generated />
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations.MembersInfo
{
    [DbContext(typeof(MembersInfoContext))]
    [Migration("20221203050233_FinalMigrations")]
    partial class FinalMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalProject.Models.MemberInfo", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_id"), 1L, 1);

                    b.Property<int>("Birthdate")
                        .HasColumnType("int");

                    b.Property<string>("College_Program")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Program_year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_id");

                    b.ToTable("MemberInfo");

                    b.HasData(
                        new
                        {
                            User_id = 1,
                            Birthdate = 0,
                            College_Program = "Information Technology",
                            First_Name = "Joshua",
                            Last_Name = "Chapman",
                            Program_year = "Sophmore"
                        },
                        new
                        {
                            User_id = 2,
                            Birthdate = 0,
                            College_Program = "Information Technology",
                            First_Name = "Tigran",
                            Last_Name = "Klekchyan",
                            Program_year = "Senior"
                        },
                        new
                        {
                            User_id = 3,
                            Birthdate = 0,
                            College_Program = "Information Technology",
                            First_Name = "Andrew",
                            Last_Name = "Iverson",
                            Program_year = "Sophmore"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}