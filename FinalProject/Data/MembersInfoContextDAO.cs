using FinalProject.Models;
using FinalProject.Interfaces;

namespace FinalProject.Data
{
    public class MembersInfoContextDAO : IMembersInfoContextDAO
    {
        private MembersInfoContext _context;

        public MembersInfoContextDAO(MembersInfoContext context)
        {
            _context = context;
        }

        public List<MemberInfo> GetMembersInfo()
        {
            return _context.MemberInfo.ToList();
        }

        public MemberInfo GetMembersInfo(int User_Id)
        {
            return _context.MemberInfo.Where(x => x.User_Id.Equals(User_Id)).FirstOrDefault();
        }

        public int? RemoveMemberByUser_Id(int User_Id)
        {
            var Member = this.GetMembersInfo(User_Id);
            if (Member == null) return null;
            try
            {
                _context.MemberInfo.Remove(Member);
                _context.SaveChanges();
                return 1;
            }
            catch(Exception)
            {
                return 0;
            }
            
        }
        public int? UpdateMember(MemberInfo Member)
        {
            var MemberToUpdate = this.GetMembersInfo(Member.User_Id);
            if (MemberToUpdate == null)
                return null;

            MemberToUpdate.First_Name = Member.First_Name;
            MemberToUpdate.Last_Name = Member.Last_Name;
            MemberToUpdate.Birthdate = Member.Birthdate;
            MemberToUpdate.College_Program = Member.College_Program;
            MemberToUpdate.Program_year = Member.Program_year;

            try
            {
                _context.MemberInfo.Update(MemberToUpdate);
                _context.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public int? Add(MemberInfo Member)
        {
            var Members = _context.MemberInfo.Where(x => x.First_Name.Equals(Member.First_Name) && x.Last_Name.Equals(Member.Last_Name)).FirstOrDefault();
            
            if (Members != null)
                return null;
            
            try
            {
                _context.MemberInfo.Add(Member);
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