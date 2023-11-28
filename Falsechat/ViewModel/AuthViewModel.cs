using Falsechat.Core;
using Falsechat.Repositories;
using Falsechat.Validation;

namespace Falsechat.ViewModel
{
    public class AuthViewModel : ViewModelBase
    {
		private ViewModelBase _frameContent;
		private bool _createAccountButtonVisibility;
		private bool _backToLoginButtonVisibility;
		private bool _noAccountLabelVisibility;
        private bool _forgotPasswordButtonVisibility;
        public RelayCommand MoveRegisterPageCommand {  get; set; }
        public RelayCommand MoveLoginPageCommand { get; set; }
		public RelayCommand ResetPasswordCommand { get; set; }
        public AuthViewModel()
        {
			ViewModelBase loginViewModel = new LoginViewModel(new UserRepository());
            _frameContent = loginViewModel;
			_noAccountLabelVisibility = true;
			_createAccountButtonVisibility = true;
            _forgotPasswordButtonVisibility = true;
            _backToLoginButtonVisibility = false;
			MoveRegisterPageCommand = new RelayCommand(execute =>
			{
				FrameContent = new RegisterViewModel(new AuthValidator(), new UserRepository());
				NoAccountLabelVisibility = false;
                CreateAccountButtonVisibility = false;
                ForgotPasswordButtonVisibility = false;
                BackToLoginButtonVisibility = true;
            });
			MoveLoginPageCommand = new RelayCommand(execute => {
                FrameContent = loginViewModel;
                NoAccountLabelVisibility = true;
                CreateAccountButtonVisibility = true;
                ForgotPasswordButtonVisibility = true;
                BackToLoginButtonVisibility = false;
            });
			ResetPasswordCommand = new RelayCommand(execute => {
                FrameContent = new ResetPasswordViewModel(new AuthValidator(), new UserRepository());
                NoAccountLabelVisibility = false;
                CreateAccountButtonVisibility = false;
                ForgotPasswordButtonVisibility = false;
                BackToLoginButtonVisibility = true;
            });
        }
        public ViewModelBase FrameContent
		{
			get { return _frameContent; }
			set { 
				_frameContent = value;
				OnPropertyChanged();
			}
		}
		public bool CreateAccountButtonVisibility
        {
			get { return _createAccountButtonVisibility; }
			set { _createAccountButtonVisibility = value;
				OnPropertyChanged();
			}
		}
		public bool BackToLoginButtonVisibility
        {
			get { return _backToLoginButtonVisibility; }
			set { _backToLoginButtonVisibility = value;
				OnPropertyChanged();
			}
		}
		public bool NoAccountLabelVisibility
        {
			get { return _noAccountLabelVisibility; }
			set { _noAccountLabelVisibility = value;
				OnPropertyChanged();
			}
		}


		public bool ForgotPasswordButtonVisibility
        {
			get { return _forgotPasswordButtonVisibility; }
			set { _forgotPasswordButtonVisibility = value;
				OnPropertyChanged();
			}
		}

	}
}