using FinalProject.Models;

namespace FinalProject.Interfaces
{
    public interface IFavGamesContextDAO
    {
        List<FavGame> GetFavGames();
        FavGame GetFavGames(int User_Id);
        int? RemoveMemberByUser_Id(int User_Id);
        int? UpdateMember(FavGame Member);
        int? Add(FavGame Member);

    }
}