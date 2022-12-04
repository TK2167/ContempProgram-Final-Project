using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class FavGamesContext : DbContext
    {

        public DbSet<FavGame>? FavGame { get; set; }

        public FavGamesContext(DbContextOptions<FavGamesContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<FavGame>().HasData(
            new FavGame
            { 
                First_Name = "Joshua", 
                Last_Name = "Chapman", 
                Game_Name = "Modern Warfare 2", 
                Release_Date = 2022, 
                Release_Platform = "Console and PC",
                Hours_Played = 3,
                User_Id = 1
            },
            new FavGame
            { 
                First_Name = "Tigran", 
                Last_Name = "Klekchyan",
                Game_Name = "Dota 2", 
                Release_Date = 2013, 
                Release_Platform = "PC",
                Hours_Played = 2501,
                User_Id = 2
            },
            new FavGame
            { 
                First_Name = "Andrew", 
                Last_Name = "Iverson", 
                Game_Name = "Red Dead Redemtion 2", 
                Release_Date = 2018, 
                Release_Platform = "Console and PC",
                Hours_Played = 77,
                User_Id = 3
            }
            );
        }
    }
}