using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class Hobby
{
    public string? First_Name {get; set;}
    public string? Last_Name {get; set;}
    public string? Hobby_Name1 {get; set;}
    public string? Hobby_Name2 {get; set;}
    public int Hours_Spent1 {get; set;}
    public int Hours_Spent2 {get; set;}
    [Key]
    public int User_Id {get; set;}
    public Hobby() {}
    public Hobby(string First_Name, string Last_Name, string Hobby_Name1, int Hours_Spent1, string Hobby_Name2, int Hours_Spent2, int User_Id)
    {
        this.First_Name = First_Name;
        this.Last_Name = Last_Name;
        this.Hobby_Name1 = Hobby_Name1;
        this.Hours_Spent1 = Hours_Spent1;
        this.Hobby_Name2 = Hobby_Name2;
        this.Hours_Spent2 = Hours_Spent2;
        this.User_Id = User_Id;
       
    }
}
