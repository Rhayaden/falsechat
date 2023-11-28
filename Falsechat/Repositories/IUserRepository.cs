using Falsechat.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Falsechat.Repositories
{
    public interface IUserRepository
    {
        bool Login(string email, string hashedPassword);
        void Register(string username, string email, string hashedPassword, string preferredLanguage, string hashedSecurityKey);
        void ResetPassword(string email, string hashedNewPassword);
        bool CheckUsernameExist(string username);
        bool CheckUserEmailExist(string email);
        UserModel GetUserByEmail(string email);
        int GetIdByUsername(string username);
        string GetUsernameById(int id);
        string GetUsernameByEmail(string email);
        ObservableCollection<ContactModel> GetUserContactsByEmail(string email);
        string GetUserPrefLangByUsername(string username);
        string GetUserSecurityKeyByEmail(string email);
        void UpdateUserContactsByEmail(string email, List<string> contactId);
        void ChangeUserPrefLangByEmail(string email, string newPrefLang);
    }
}
