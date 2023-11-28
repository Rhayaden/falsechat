using Falsechat.Repositories;
using Falsechat.Validation;
using Falsechat.ViewModel;
using System.Text.RegularExpressions;
using System.Windows.Controls;
using System.Windows.Input;

namespace Falsechat.View
{
    public partial class ResetPasswordView : Page
    {
        public ResetPasswordView()
        {
            InitializeComponent();
            DataContext = new ResetPasswordViewModel(new AuthValidator(), new UserRepository());
        }
        private bool IsWhiteSpace(Key e)
        {
            return e == Key.Space;
        }
        private void UserEmailTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (IsWhiteSpace(e.Key))
            {
                e.Handled = true;
            }
        }
        private void SecurityKeyTextBox_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (IsWhiteSpace(e.Key))
            {
                e.Handled = true;
            }
        }

        private void NewPasswordBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (IsWhiteSpace(e.Key))
            {
                e.Handled = true;
            }
        }

        private void ConfirmNewPasswordBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (IsWhiteSpace(e.Key))
            {
                e.Handled = true;
            }
        }
        private void UserEmailTextBox_LostFocus(object sender, System.Windows.RoutedEventArgs e)
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
        private void SecurityKeyTextBox_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            string securityKey = SecurityKeyTextBox.Text;
            if (string.IsNullOrEmpty(securityKey))
            {
                InvalidSecurityKey.Visibility = System.Windows.Visibility.Visible;
                InvalidSecurityKey.Text = $"Please enter your security key";
            }
            else
            {
                InvalidSecurityKey.Visibility = System.Windows.Visibility.Collapsed;
                InvalidSecurityKey.Text = default;
            }
        }

        private void NewPasswordBox_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            int minimumPasswordLength = 8;
            int maximumPasswordLength = 24;
            string password = NewPasswordBox.Password;
            if (string.IsNullOrEmpty(password) ||
                password.Length < minimumPasswordLength ||
                password.Length > maximumPasswordLength)
            {
                InvalidNewPassword.Text = $"Password length must be between {minimumPasswordLength}-{maximumPasswordLength} characters";
            }
            else
            {
                InvalidNewPassword.Text = default;
            }
        }

        private void ConfirmNewPasswordBox_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            if (NewPasswordBox.Password != ConfirmNewPasswordBox.Password)
            {
                NewPasswordNotMatch.Text = "Passwords did not match";
            }
            else
            {
                NewPasswordNotMatch.Text = default;
            }
        }
    }
}
