using Falsechat.Core;
using Falsechat.Repositories;
using Falsechat.Validation;
using System;
using System.Windows;

namespace Falsechat.ViewModel
{
    public class ResetPasswordViewModel : ViewModelBase
    {
        private string _userEmail;
        private string _securityKey;
        private string _newPassword;
        private string _confirmNewPassword;
        private string _wrongEmail;
        private string _wrongSecurityKey;
        private bool _wrongEmailTextVisibility = false;
        private bool _wrongSecurityKeyTextVisibility = false;
        private readonly IAuthValidator _authValidator;
        private readonly IUserRepository _userRepository;
        public RelayCommand ResetPasswordCommand { get; set; }
        public ResetPasswordViewModel(IAuthValidator authValidator, IUserRepository userRepository)
        {
            _authValidator = authValidator;
            _userRepository = userRepository;
            ResetPasswordCommand = new RelayCommand(execute =>
            {
                string hashedNewPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(NewPassword, 13);
                try
                {
                    if (!_userRepository.CheckUserEmailExist(UserEmail))
                    {
                        WrongEmailTextVisibility = true;
                        WrongEmail = "No account found for this email";
                        return;
                    }
                    else
                    {
                        WrongEmailTextVisibility = false;
                    }
                    if(BCrypt.Net.BCrypt.EnhancedVerify(SecurityKey, _userRepository.GetUserSecurityKeyByEmail(UserEmail).ToString()))
                    {
                        WrongEmailTextVisibility = false;
                        WrongSecurityKeyTextVisibility = false;
                        _userRepository.ResetPassword(UserEmail, hashedNewPassword);
                        MessageBox.Show("Password changed successfully", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
                        ResetPage();
                    }
                    else
                    {
                        WrongSecurityKeyTextVisibility = true;
                        WrongSecurityKey = "Wrong security key";
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }, canExecute =>
            _authValidator.IsValidEmail(UserEmail) &&
            _authValidator.IsValidPassword(NewPassword) &&
            _authValidator.DoPasswordsMatch(NewPassword, ConfirmNewPassword));
        }
        public string UserEmail
        {
            get { return _userEmail; }
            set
            {
                _userEmail = value;
                OnPropertyChanged();
            }
        }
        public string SecurityKey
        {
            get { return _securityKey; }
            set { _securityKey = value;
                OnPropertyChanged();
            }
        }
        public string NewPassword
        {
            get { return _newPassword; }
            set { _newPassword = value;
                OnPropertyChanged();
            }
        }
        public string ConfirmNewPassword
        {
            get { return _confirmNewPassword; }
            set { _confirmNewPassword = value;
                OnPropertyChanged();
            }
        }

        public string WrongEmail
        {
            get { return _wrongEmail; }
            set { _wrongEmail = value;
                OnPropertyChanged();
            }
        }
        public string WrongSecurityKey
        {
            get { return _wrongSecurityKey; }
            set { _wrongSecurityKey = value;
                OnPropertyChanged();
            }
        }
        public bool WrongEmailTextVisibility
        {
            get { return _wrongEmailTextVisibility; }
            set { _wrongEmailTextVisibility = value;
                OnPropertyChanged();
            }
        }
        public bool WrongSecurityKeyTextVisibility
        {
            get { return _wrongSecurityKeyTextVisibility; }
            set { _wrongSecurityKeyTextVisibility = value;
                OnPropertyChanged();
            }
        }
        private void ResetPage()
        {
            UserEmail = string.Empty;
            SecurityKey = string.Empty;
            NewPassword = string.Empty;
            ConfirmNewPassword = string.Empty;
        }
    }
}