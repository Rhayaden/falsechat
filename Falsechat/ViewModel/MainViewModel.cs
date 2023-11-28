using Falsechat.Core;
using Falsechat.Model;
using Falsechat.Repositories;
using Falsechat.Translation;
using Falsechat.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Falsechat.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private int _id;
        private string _username;
		private string _preferredLanguage;
        private string _selectedContactName;
        private string _selectedContactPrefLang;
        private string _enteredContactName;
        private ViewModelBase _frameContent;
        private ViewModelBase _frameContent2;
        private ObservableCollection<ContactModel> _contacts = new ObservableCollection<ContactModel>();
        private string _invalidEnteredContactName;
        private bool _invalidEnteredContactNameTextVisibility = false;
        private bool _userProfileVisibility = false;
        private bool _logoImageVisibility = true;
        private bool _addContactVisibility = false;
        private bool _messageTextBoxVisibility = false;
        private readonly AvailableLanguages _availableLanguagesDictionary = new AvailableLanguages();
        private readonly IUserRepository _userRepository;
		public RelayCommand AddContactButtonCommand { get; set; }
		public RelayCommand AddContactCommand { get; set; }
		public RelayCommand OpenChatCommand { get; set; }
		public RelayCommand UserProfileButtonCommand { get; set; }
		public RelayCommand ChangePrefLangButtonCommand { get; set; }
		public RelayCommand LogoutCommand { get; set; }
        public MainViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            LoadAuthenticatedUserData(Mediator.Email);
            Mediator.Username = Username.Trim();
            UserProfileButtonCommand = new RelayCommand(execute =>
            {
                UserProfileVisibility = !UserProfileVisibility;
            });
            AddContactButtonCommand = new RelayCommand(execute =>
            {
                FrameContent = null;
                FrameContent2 = null;
                SelectedContactName = string.Empty;
                SelectedContactPrefLang = string.Empty;
                LogoImageVisibility = false;
                AddContactVisibility = true;
                MessageTextBoxVisibility = false;
                FrameContent = null;
                UserProfileVisibility = false;
            });
            OpenChatCommand = new RelayCommand(execute =>
            {
                SelectedContactName = execute.ToString();
                string langCode = _userRepository.GetUserPrefLangByUsername(SelectedContactName);
                string preferredLanguage = _availableLanguagesDictionary.Languages[langCode];
                SelectedContactPrefLang = $"{SelectedContactName}'s preferred language is {preferredLanguage}";
                Mediator.CurrentContact = SelectedContactName;
                Mediator.PrefLangOfSelectedContact = langCode;
                LogoImageVisibility = false;
                AddContactVisibility = false;
                MessageTextBoxVisibility = true;
                UserProfileVisibility = false;
                if(FrameContent is null)
                {
                    FrameContent = new ChatViewModel(new UserRepository(), new RoomRepository(), new MyMemoryAPI());
                    FrameContent2 = null;
                }
                else
                {
                    FrameContent = null;
                    FrameContent2 = new ChatViewModel(new UserRepository(), new RoomRepository(), new MyMemoryAPI());
                }
            });
            AddContactCommand = new RelayCommand(execute =>
            {
                try
                {
                    if (!_userRepository.CheckUsernameExist(EnteredContactName))
                    {
                        InvalidEnteredContactNameTextVisibility = true;
                        InvalidEnteredContactName = "User is not found";
                        return;
                    }
                    if (_userRepository.GetUserByEmail(Mediator.Email).Id == _userRepository.GetIdByUsername(EnteredContactName))
                    {
                        InvalidEnteredContactNameTextVisibility = true;
                        InvalidEnteredContactName = "You can not add yourself as your contact";
                        return;
                    }
                    ObservableCollection<ContactModel> contacts = _userRepository.GetUserContactsByEmail(Mediator.Email);
                    string contactIdAsString = _userRepository.GetIdByUsername(EnteredContactName).ToString();
                    if (contacts != null)
                    {
                        var contactList = contacts.Select(contact => contact.Id.ToString()).ToList();
                        if (contactList.Contains(contactIdAsString))
                        {
                            InvalidEnteredContactNameTextVisibility = true;
                            InvalidEnteredContactName = "This user already in your contacts";
                            return;
                        }
                        InvalidEnteredContactNameTextVisibility = false;
                        contactList.Add(contactIdAsString);
                        _userRepository.UpdateUserContactsByEmail(Mediator.Email, contactList);
                        UpdateContactList();
                    }
                    else
                    {
                        InvalidEnteredContactNameTextVisibility = false;
                        List<string> newContactsList = new List<string>
                        {
                            contactIdAsString
                        };
                        _userRepository.UpdateUserContactsByEmail(Mediator.Email, newContactsList);
                        UpdateContactList();
                    }


                    MessageBox.Show($"{EnteredContactName} added to your contacts");
                    EnteredContactName = string.Empty;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }, canExecute => EnteredContactName != null);
            ChangePrefLangButtonCommand = new RelayCommand(execute =>
            {
                SelectedContactName = string.Empty;
                SelectedContactPrefLang = string.Empty;
                UserProfileVisibility = false;
                FrameContent = null;
                FrameContent2 = null;
                FrameContent = new ChangePrefLangViewModel(new UserRepository());
                SelectedContactName = string.Empty;
                LogoImageVisibility = false;
                AddContactVisibility = false;
                MessageTextBoxVisibility = false;
            });
            LogoutCommand = new RelayCommand(execute =>
            {
                UserProfileVisibility = false;
                Mediator.Email = null;
                var currentWindow = Application.Current.Windows[0];
                AuthView authView = new AuthView();
                authView.Show();
                currentWindow.Close();
            });
        }

        private void LoadAuthenticatedUserData(string email)
		{
			try
			{
				UserModel user = _userRepository.GetUserByEmail(email);
				Id = user.Id;
                Username = user.Username;
                PreferredLanguage = user.PreferredLanguage;
                if (user is null)
                {
                    return;
                }
                Contacts = _userRepository.GetUserContactsByEmail(email);
            }
            catch
			{
				MessageBox.Show("Not authenticated", "", MessageBoxButton.OK, MessageBoxImage.Warning);
				Application.Current.Shutdown();
            }
        }
        private void UpdateContactList()
        {
            Contacts?.Clear();
            Contacts = _userRepository.GetUserContactsByEmail(Mediator.Email);
        }

        public int Id
		{
			get { return _id; }
			set { _id = value;
				OnPropertyChanged();
			}
		}

		public string Username
		{
			get { return _username; }
			set { _username = value;
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

		public string SelectedContactName
		{
			get { return _selectedContactName; }
			set { _selectedContactName = value;
				OnPropertyChanged();
			}
		}

		public ViewModelBase FrameContent
		{
			get { return _frameContent; }
			set { _frameContent = value;
				OnPropertyChanged();
			}
		}

        public ViewModelBase FrameContent2
        {
            get { return _frameContent2; }
            set
            {
                _frameContent2 = value;
                OnPropertyChanged();
            }
        }

        public bool MessageTextBoxVisibility
		{
			get { return _messageTextBoxVisibility; }
			set { _messageTextBoxVisibility = value;
				OnPropertyChanged();
			}
		}

		public bool LogoImageVisibility
		{
			get { return _logoImageVisibility; }
			set { _logoImageVisibility = value;
				OnPropertyChanged();
			}
		}

		public ObservableCollection<ContactModel> Contacts
		{
			get { return _contacts; }
			set { _contacts = value;
                OnPropertyChanged();
			}
		}

		public bool AddContactVisibility
        {
			get { return _addContactVisibility; }
			set { _addContactVisibility = value;
				OnPropertyChanged();
			}
		}


		public string EnteredContactName
        {
			get { return _enteredContactName; }
			set { _enteredContactName = value;
				OnPropertyChanged();
			}
		}
        public string InvalidEnteredContactName
        {
            get { return _invalidEnteredContactName; }
            set
            {
                _invalidEnteredContactName = value;
                OnPropertyChanged();
            }
        }
        public bool InvalidEnteredContactNameTextVisibility
        {
            get { return _invalidEnteredContactNameTextVisibility; }
            set
            {
                _invalidEnteredContactNameTextVisibility = value;
                OnPropertyChanged();
            }
        }
        public bool UserProfileVisibility
        {
            get { return _userProfileVisibility; }
            set { _userProfileVisibility = value;
                OnPropertyChanged();
            }
        }

        public string SelectedContactPrefLang
        {
            get { return _selectedContactPrefLang; }
            set { _selectedContactPrefLang = value;
                OnPropertyChanged();
            }
        }


    }
}
