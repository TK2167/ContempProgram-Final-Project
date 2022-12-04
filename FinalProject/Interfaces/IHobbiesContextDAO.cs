using FinalProject.Models;

namespace FinalProject.Interfaces
{
    public interface IHobbiesContextDAO
    {
        List<Hobby> GetHobbies();
        Hobby GetHobbies(int User_Id);
        int? RemoveMemberByUser_Id(int User_Id);
        int? UpdateMember(Hobby Member);
        int? Add(Hobby Member);
    }
}