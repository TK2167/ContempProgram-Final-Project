using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class HobbiesContext : DbContext
    {

        public DbSet<Hobby>? Hobby { get; set; }
        
        public HobbiesContext(DbContextOptions<HobbiesContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Hobby>().HasData(
            new Hobby
            { 
                First_Name = "Joshua", 
                Last_Name = "Chapman", 
                Hobby_Name1 = "FL Studio", 
                Hours_Spent1 = 1435, 
                Hobby_Name2 = "Fixing Computers", 
                Hours_Spent2 = 500, 
                User_Id = 1
            },
            new Hobby
            { 
                First_Name = "Tigran", 
                Last_Name = "Klekchyan",
                Hobby_Name1 = "Playing Games", 
                Hours_Spent1 = 3000, 
                Hobby_Name2 = "Working out", 
                Hours_Spent2 = 85, 
                User_Id = 2
            },
            new Hobby
            { 
                First_Name = "Andrew", 
                Last_Name = "Iverson", 
                Hobby_Name1 = "Playing Cards", 
                Hours_Spent1 = 1500, 
                Hobby_Name2 = "Playing Games", 
                Hours_Spent2 = 1370, 
                User_Id = 3
            }
            );
        }
    }
}