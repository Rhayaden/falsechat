using Falsechat.Core;
using Falsechat.Repositories;
using System;
using System.Linq;
using System.Windows;

namespace Falsechat.ViewModel
{
    public class ChangePrefLangViewModel : ViewModelBase
    {
        private string _newPreferredLanguage;
        private bool _invalidPrefLangVisibility = false;
        private readonly AvailableLanguages _availableLanguagesDictionary = new AvailableLanguages();
        private readonly IUserRepository _userRepository;
        public RelayCommand ChangePrefLangCommand { get; set; }
        public ChangePrefLangViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            ChangePrefLangCommand = new RelayCommand(execute => {
                try
                {
                    string username = _userRepository.GetUsernameByEmail(Mediator.Email);
                    string langCode = _availableLanguagesDictionary.Languages.FirstOrDefault(lang => lang.Value == NewPreferredLanguage).Key;
                    if (_userRepository.GetUserPrefLangByUsername(username) == langCode)
                    {
                        InvalidPrefLangVisibility = true;
                        return;
                    }
                    InvalidPrefLangVisibility = false;
                    _userRepository.ChangeUserPrefLangByEmail(Mediator.Email, langCode);
                    MessageBox.Show($"Your preferred language changed to {NewPreferredLanguage}");
                    NewPreferredLanguage = null;
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }, canExecute => NewPreferredLanguage != null);
        }

        public string NewPreferredLanguage
        {
            get { return _newPreferredLanguage; }
            set { _newPreferredLanguage = value;
                OnPropertyChanged();
            }
        }

        public bool InvalidPrefLangVisibility
        {
            get { return _invalidPrefLangVisibility; }
            set { _invalidPrefLangVisibility = value;
                OnPropertyChanged();
            }
        }

    }
}
