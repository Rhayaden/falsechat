using Falsechat.Core;
using Falsechat.Repositories;
using Falsechat.View;
using System;
using System.Windows;

namespace Falsechat.ViewModel
{
    public class LoginViewModel : ViewModelBase
    {
		private string _loginInfo;
		private string _userEmail;
		private string _userPassword;
		private readonly IUserRepository _userRepository;
		public RelayCommand LoginCommand { get; set; }
        public LoginViewModel(IUserRepository userRepository)
        {
            _userRepository = userRepository;
            LoginCommand = new RelayCommand(execute =>
            {
                try
                {
					if(_userRepository.Login(UserEmail, UserPassword))
					{
						Mediator.Email = UserEmail;
                        var currentWindow = Application.Current.Windows[0];
                        MainView mainView = new MainView();
                        mainView.Show();
                        currentWindow.Close();
					}
					else
					{
						if (_userRepository.CheckUserEmailExist(UserEmail))
						{
							LoginInfo = "Wrong password";
						}
                    }
                }
                catch (Exception ex)
                {
                    if (ex is InvalidOperationException)
                    {
                        LoginInfo = "Wrong email";
                        return;
                    }
                    MessageBox.Show(ex.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                

            }, canExecute => !string.IsNullOrEmpty(UserEmail) && !string.IsNullOrEmpty(UserPassword));
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

		public string LoginInfo
		{
			get { return _loginInfo; }
			set { _loginInfo = value;
				OnPropertyChanged();
			}
		}

	}
}
