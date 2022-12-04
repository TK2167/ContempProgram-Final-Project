
using FinalProject.Models;
using FinalProject.Interfaces;

namespace FinalProject.Data
{
    public class FavGamesContextDAO : IFavGamesContextDAO
    {
        private FavGamesContext _context;

        public FavGamesContextDAO(FavGamesContext context)
        {
            _context = context;
        }
        public List<FavGame> GetFavGames()
        {
            return _context.FavGame.ToList();
        }

        public FavGame GetFavGames(int User_Id)
        {
            return _context.FavGame.Where(x => x.User_Id.Equals(User_Id)).FirstOrDefault();
        }

        public int? RemoveMemberByUser_Id(int User_Id)
        {
            var Member = this.GetFavGames(User_Id);
            if (Member == null) return null;
            try
            {
                _context.FavGame.Remove(Member);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }

        public int? UpdateMember(FavGame Member)
        {
            var MemberToUpdate = this.GetFavGames(Member.User_Id);
            if (MemberToUpdate == null)
                return null;

            MemberToUpdate.First_Name = Member.First_Name;
            MemberToUpdate.Last_Name = Member.Last_Name;
            MemberToUpdate.Game_Name = Member.Game_Name;
            MemberToUpdate.Release_Date = Member.Release_Date;
            MemberToUpdate.Release_Platform = Member.Release_Platform;
            MemberToUpdate.Hours_Played = Member.Hours_Played;
            
            try
            {
            _context.FavGame.Update(MemberToUpdate);
            _context.SaveChanges();
            return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }
        public int? Add(FavGame Member)
        {
            var Members = _context.FavGame.Where(x => x.First_Name.Equals(Member.First_Name) && x.Last_Name.Equals(Member.Last_Name)).FirstOrDefault();
            
            if (Members != null)
                return null;
            
            try
            {
                _context.FavGame.Add(Member);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
        }

    }
}