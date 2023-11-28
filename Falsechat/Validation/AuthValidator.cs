using System.Text.RegularExpressions;

namespace Falsechat.Validation
{
    public class AuthValidator : IAuthValidator
    {
        private readonly int _minimumUsernameLength = 2;
        private readonly int _maximumUsernameLength = 16;
        private readonly int _minimumPasswordLength = 8;
        private readonly int _maximumPasswordLength = 24;
        private readonly int _minimumSecurityKeyLength = 8;
        private readonly int _maximumSecurityKeyLength = 16;
        public bool IsValidUsername(string username)
        {
            return username != null && username.Length >= _minimumUsernameLength && username.Length <= _maximumUsernameLength;
        }
        public bool IsValidEmail(string email)
        {
            return email != null && Regex.IsMatch(email, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
        }
        public bool IsValidPassword(string password)
        {
            return password != null && password.Length >= _minimumPasswordLength && password.Length <= _maximumPasswordLength;
        }
        public bool DoPasswordsMatch(string password, string confirmPassword)
        {
            return password != null && confirmPassword != null && password == confirmPassword;
        }
        public bool IsPreferredLanguageValid(string language)
        {
            return language != null;
        }
        public bool IsSecurityKeyValid(string securityKey)
        {
            return securityKey != null && securityKey.Length >= _minimumSecurityKeyLength && securityKey.Length <= _maximumSecurityKeyLength;
        }
    }
}
