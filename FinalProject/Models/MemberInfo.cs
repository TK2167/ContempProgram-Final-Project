using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models;

public class MemberInfo
{
    public string? First_Name {get; set;}
    public string? Last_Name {get; set;}
    public int Birthdate {get; set;}
    public string? College_Program {get; set;}
    public string? Program_year {get; set;}
    [Key]
    public int User_Id {get; set;}
    public MemberInfo() {}
    public MemberInfo(string First_Name, string Last_Name, int Birthdate, string College_Program, string Program_year, int User_Id)
    {
        this.First_Name = First_Name;
        this.Last_Name = Last_Name;
        this.Birthdate = Birthdate;
        this.College_Program = College_Program;
        this.Program_year = Program_year;
        this.User_Id = User_Id;
       
    }
}
