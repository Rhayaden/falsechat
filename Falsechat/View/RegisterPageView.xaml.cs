using Falsechat.Repositories;
using Falsechat.Validation;
using Falsechat.ViewModel;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Falsechat.View
{
    public partial class RegisterPageView : Page
    {
        public RegisterPageView()
        {
            InitializeComponent();
            DataContext = new RegisterViewModel(new AuthValidator(), new UserRepository());
        }
        private void PreferredLanguageInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            LanguageInfoText.Visibility = System.Windows.Visibility.Visible;
        }
        private void PreferredLanguageInfo_MouseLeave(object sender, MouseEventArgs e)
        {
            LanguageInfoText.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void UsernameTextBox_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            int minimumUsernameLength = 2;
            int maximumUsernameLength = 16;
            string username = UsernameTextBox.Text;
            if (string.IsNullOrEmpty(username) ||
                username.Length < minimumUsernameLength ||
                username.Length > maximumUsernameLength)
            {
                InvalidUsername.Visibility = System.Windows.Visibility.Visible;
                InvalidUsername.Text = $"Username length must be between {minimumUsernameLength}-{maximumUsernameLength} characters";
            }
            else
            {
                InvalidUsername.Visibility = System.Windows.Visibility.Collapsed;
                InvalidUsername.Text = default;
            }
        }
        private void UserEmailTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            string email = UserEmailTextBox.Text;
            if (!Regex.IsMatch(email, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
                InvalidEmail.Visibility = System.Windows.Visibility.Visible;
                InvalidEmail.Text = "Please enter a valid email";
            }
            else
            {
                InvalidEmail.Visibility = System.Windows.Visibility.Collapsed;
                InvalidEmail.Text = default;
            }
        }
        private void UserPasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            int minimumPasswordLength = 8;
            int maximumPasswordLength = 24;
            string password = UserPasswordBox.Password;
            if (string.IsNullOrEmpty(password) ||
                password.Length < minimumPasswordLength ||
                password.Length > maximumPasswordLength)
            {
                InvalidPassword.Text = $"Password length must be between {minimumPasswordLength}-{maximumPasswordLength} characters";
            }
            else
            {
                InvalidPassword.Text = default;
            }
        }
        private void ConfirmPasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if(UserPasswordBox.Password != ConfirmPasswordBox.Password)
            {
                PasswordNotMatch.Text = "Passwords did not match";
            }
            else
            {
                PasswordNotMatch.Text = default;
            }
        }
        private void PreferredLanguageComboBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PreferredLanguageComboBox.Text is null)
            {
                InvalidLanguage.Text = "Please select a language";
            }
            else
            {
                InvalidLanguage.Text = default;
            }
        }
        private void SecurityKeyTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            int minimumSecurityKeyLength = 8;
            int maximumSecurityKeyLength = 16;
            string securityKey = SecurityKeyTextBox.Text;
            if (string.IsNullOrEmpty(securityKey) ||
                securityKey.Length < minimumSecurityKeyLength ||
                securityKey.Length > maximumSecurityKeyLength)
            {
                InvalidSecurityKey.Text = $"Security Key length must be between {minimumSecurityKeyLength}-{maximumSecurityKeyLength} characters";
            }
            else
            {
                InvalidSecurityKey.Text = default;
            }
        }
        private bool IsWhiteSpace(Key e)
        {
            return e == Key.Space;
        }
        private void UsernameTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if(IsWhiteSpace(e.Key)) {
                e.Handled = true;
            }
        }
        private void UserPasswordBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (IsWhiteSpace(e.Key))
            {
                e.Handled = true;
            }
        }
        private void UserEmailTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (IsWhiteSpace(e.Key))
            {
                e.Handled = true;
            }
        }
        private void ConfirmPasswordBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (IsWhiteSpace(e.Key))
            {
                e.Handled = true;
            }
        }

        private void SecurityKeyTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (IsWhiteSpace(e.Key))
            {
                e.Handled = true;
            }
        }

        private void SecurityKeyInfo_MouseEnter(object sender, MouseEventArgs e)
        {
            SecurityKeyInfoText.Visibility = System.Windows.Visibility.Visible;
        }

        private void SecurityKeyInfo_MouseLeave(object sender, MouseEventArgs e)
        {
            SecurityKeyInfoText.Visibility = System.Windows.Visibility.Collapsed;
        }
    }
}