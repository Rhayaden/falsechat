using Falsechat.Core;
using Falsechat.Repositories;
using Falsechat.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Falsechat.ViewModel
{
    public class RegisterViewModel : ViewModelBase
    {
        private string _username;
		private string _userEmail;
		private string _userPassword;
		private string _confirmPassword;
		private string _preferredLanguage;
		private List<string> _availableLanguages;
        private string _securityKey;
		private bool _isChecked;
		private string _invalidUsername;
        private string _takenUsername;
        private string _takenEmail;
        private bool _takenUsernameTextVisibility = false;
        private bool _takenEmailTextVisibility = false;
		private readonly AvailableLanguages _availableLanguagesDictionary = new AvailableLanguages();
        private readonly IAuthValidator _authValidator;
		private readonly IUserRepository _userRepository;
        public RelayCommand RegisterCommand { get; set; }
        public RegisterViewModel(IAuthValidator authValidator, IUserRepository userRepository)
        {
            _authValidator = authValidator;
            _userRepository = userRepository;
				List<string> langList = new List<string>();
			foreach(var lang in _availableLanguagesDictionary.Languages)
			{
				langList.Add(lang.Value);
			}
			_availableLanguages = langList;
            RegisterCommand = new RelayCommand(execute =>
            {
                string hashedUserPassword = BCrypt.Net.BCrypt.EnhancedHashPassword(UserPassword, 13);
                string hashedSecurityKey = BCrypt.Net.BCrypt.EnhancedHashPassword(SecurityKey, 13);
                bool checkUsernameExist = _userRepository.CheckUsernameExist(Username);
				bool checkUserEmailExist = _userRepository.CheckUserEmailExist(UserEmail);
                try
                {
                    if (checkUsernameExist || checkUserEmailExist)
                    {
						if (checkUsernameExist)
						{
							TakenUsernameTextVisibility = true;
                            TakenUsername = "This username is already in use";
						}
						else
						{
                            TakenUsernameTextVisibility = false;
                        }
                        if (checkUserEmailExist)
                        {
							TakenEmailTextVisibility = true;
                            TakenEmail = "This email is already in use";
						}
						else
						{
                            TakenEmailTextVisibility = false;
                        }
						return;
                    }
					string langCode = _availableLanguagesDictionary.Languages.FirstOrDefault(lang => lang.Value == PreferredLanguage).Key;
                    _userRepository.Register(Username, UserEmail, hashedUserPassword, langCode, hashedSecurityKey);
                    MessageBox.Show("Successfully registered", "Success", MessageBoxButton.OK);
                    ResetPage();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }

            }, canExecute =>
            _authValidator.IsValidUsername(Username) &&
            _authValidator.IsValidEmail(UserEmail) &&
            _authValidator.IsValidPassword(UserPassword) &&
            _authValidator.DoPasswordsMatch(UserPassword, ConfirmPassword) &&
            _authValidator.IsPreferredLanguageValid(PreferredLanguage) &&
            _authValidator.IsSecurityKeyValid(SecurityKey) &&
            IsChecked == true);
        }
        public string Username
		{
			get { return _username; }
			set { _username = value;
				OnPropertyChanged();
			}
		}
		public string UserEmail
		{
			get { return _userEmail; }
			set { _userEmail = value;
				OnPropertyChanged();
			}
		}
		public string UserPassword
		{
			get { return _userPassword; }
			set { _userPassword = value;
				OnPropertyChanged();
			}
		}
		public string ConfirmPassword
		{
			get { return _confirmPassword; }
			set { _confirmPassword = value;
				OnPropertyChanged();
			}
		}
		public string PreferredLanguage
		{
			get { return _preferredLanguage; }
			set { _preferredLanguage = value;
				OnPropertyChanged();
			}
		}
        public string SecurityKey
        {
            get { return _securityKey; }
            set
            { _securityKey = value;
            OnPropertyChanged();
            }
        }
        public bool IsChecked
		{
			get { return _isChecked; }
			set { _isChecked = value;
				OnPropertyChanged();
			}
		}
		public string InvalidUsername
		{
			get { return _invalidUsername; }
			set { _invalidUsername = value;
				OnPropertyChanged();
			}
		}
		public string TakenUsername
		{
			get { return _takenUsername; }
			set { _takenUsername = value;
				OnPropertyChanged();
			}
		}
		public string TakenEmail
		{
			get { return _takenEmail; }
			set { _takenEmail = value;
				OnPropertyChanged();
			}
		}
		public bool TakenUsernameTextVisibility
        {
			get { return _takenUsernameTextVisibility; }
			set { _takenUsernameTextVisibility = value;
				OnPropertyChanged();
			}
		}
		public bool TakenEmailTextVisibility
        {
			get { return _takenEmailTextVisibility; }
			set { _takenEmailTextVisibility = value;
				OnPropertyChanged();
			}
		}
        private void ResetPage()
        {
            Username = string.Empty;
            UserEmail = string.Empty;
            UserPassword = string.Empty;
            ConfirmPassword = string.Empty;
            PreferredLanguage = default;
			SecurityKey = string.Empty;
            IsChecked = false;
        }

		public List<string> AvailableLanguages
		{
			get { return _availableLanguages; }
			set
			{
				_availableLanguages = value;
				OnPropertyChanged();
			}
		}

	}
}