﻿// <auto-generated />
using FinalProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinalProject.Migrations
{
    [DbContext(typeof(FavGamesContext))]
    [Migration("20221203045852_FinalMigrations")]
    partial class FinalMigrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("FinalProject.Models.FavGame", b =>
                {
                    b.Property<int>("User_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_id"), 1L, 1);

                    b.Property<string>("First_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Game_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Hours_Played")
                        .HasColumnType("int");

                    b.Property<string>("Last_Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Release_Date")
                        .HasColumnType("int");

                    b.Property<string>("Release_Platform")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_id");

                    b.ToTable("FavGame");

                    b.HasData(
                        new
                        {
                            User_id = 1,
                            First_Name = "Joshua",
                            Game_Name = "Modern Warfare 2",
                            Hours_Played = 3,
                            Last_Name = "Chapman",
                            Release_Date = 2022,
                            Release_Platform = "Console and PC"
                        },
                        new
                        {
                            User_id = 2,
                            First_Name = "Tigran",
                            Game_Name = "Dota 2",
                            Hours_Played = 2501,
                            Last_Name = "Klekchyan",
                            Release_Date = 2013,
                            Release_Platform = "PC"
                        },
                        new
                        {
                            User_id = 3,
                            First_Name = "Andrew",
                            Game_Name = "Red Dead Redemtion 2",
                            Hours_Played = 77,
                            Last_Name = "Iverson",
                            Release_Date = 2018,
                            Release_Platform = "Console and PC"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
