using FinalProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Data
{
    public class MembersInfoContext : DbContext
    {

        public DbSet<MemberInfo>? MemberInfo { get; set; }
        
        public MembersInfoContext(DbContextOptions<MembersInfoContext> options)
            : base(options)
        { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<MemberInfo>().HasData(
            new MemberInfo
            { 
                First_Name = "Joshua", 
                Last_Name = "Chapman", 
                Birthdate = 11/6/2002, 
                College_Program = "Information Technology", 
                Program_year = "Sophmore",
                User_Id = 1
            },
            new MemberInfo
            { 
                First_Name = "Tigran", 
                Last_Name = "Klekchyan", 
                Birthdate = 11/19/2000, 
                College_Program = "Information Technology", 
                Program_year = "Senior",
                User_Id = 2
            },
            new MemberInfo
            { 
                First_Name = "Andrew", 
                Last_Name = "Iverson", 
                Birthdate = 6/10/2002, 
                College_Program = "Information Technology", 
                Program_year = "Sophmore",
                User_Id = 3
            }
            );
        }
    }
}