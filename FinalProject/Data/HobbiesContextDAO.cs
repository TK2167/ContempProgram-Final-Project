using FinalProject.Models;
using FinalProject.Interfaces;

namespace FinalProject.Data
{
    public class HobbiesContextDAO : IHobbiesContextDAO
    {
        private HobbiesContext _context;

        public HobbiesContextDAO(HobbiesContext context)
        {
            _context = context;
        }

         public List<Hobby> GetHobbies()
        {
            return _context.Hobby.ToList();
        }

        public Hobby GetHobbies(int User_Id)
        {
            return _context.Hobby.Where(x => x.User_Id.Equals(User_Id)).FirstOrDefault();
        }

        public int? RemoveMemberByUser_Id(int User_Id)
        {
            var Member = this.GetHobbies(User_Id);
            if (Member == null) return null;
            try
            {
                _context.Hobby.Remove(Member);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }
        public int? UpdateMember(Hobby Member)
        {
            var MemberToUpdate = this.GetHobbies(Member.User_Id);
            if (MemberToUpdate == null)
                return null;

            MemberToUpdate.First_Name = Member.First_Name;
            MemberToUpdate.Last_Name = Member.Last_Name;
            MemberToUpdate.Hobby_Name1 = Member.Hobby_Name1;
            MemberToUpdate.Hours_Spent1 = Member.Hours_Spent1;
            MemberToUpdate.Hobby_Name2 = Member.Hobby_Name2;
            MemberToUpdate.Hours_Spent2 = Member.Hours_Spent2;

            try
            {
                _context.Hobby.Update(MemberToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int? Add(Hobby Member)
        {
            var Members = _context.Hobby.Where(x => x.First_Name.Equals(Member.First_Name) && x.Last_Name.Equals(Member.Last_Name)).FirstOrDefault();
            
            if (Members != null)
                return null;
            
            try
            {
                _context.Hobby.Add(Member);
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