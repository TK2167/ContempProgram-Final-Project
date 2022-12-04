using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class FavGame
{
    public string? First_Name {get; set;}
    public string? Last_Name {get; set;}
    public string? Game_Name {get; set;}
    public int Release_Date {get; set;}
    public string? Release_Platform {get; set;}
    public int Hours_Played {get; set;}
    [Key]
    public int User_Id {get; set;}
    public FavGame() {}
    public FavGame(string First_Name, string Last_Name, string Game_Name, int Release_Date, string Release_Platform, int Hours_Played, int User_Id)
    {
        this.First_Name = First_Name;
        this.Last_Name = Last_Name;
        this.Game_Name = Game_Name;
        this.Release_Date = Release_Date;
        this.Release_Platform = Release_Platform;
        this.Hours_Played = Hours_Played;
        this.User_Id = User_Id;
       
    }

}
