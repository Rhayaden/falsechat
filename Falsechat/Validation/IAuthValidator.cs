namespace Falsechat.Validation
{
    public interface IAuthValidator
    {
        bool IsValidUsername(string username);
        bool IsValidEmail(string email);
        bool IsValidPassword(string password);
        bool DoPasswordsMatch(string password, string confirmPassword);
        bool IsPreferredLanguageValid(string language);
        bool IsSecurityKeyValid(string key);
    }
}
