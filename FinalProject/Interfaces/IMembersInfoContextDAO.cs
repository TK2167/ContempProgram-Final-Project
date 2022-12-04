using FinalProject.Models;

namespace FinalProject.Interfaces
{
    public interface IMembersInfoContextDAO
    {
        List<MemberInfo> GetMembersInfo();

        MemberInfo GetMembersInfo(int User_Id);
        int? RemoveMemberByUser_Id(int User_Id);
        int? UpdateMember(MemberInfo Member);
        int? Add(MemberInfo Member);

    }
}