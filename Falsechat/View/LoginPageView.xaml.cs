using Falsechat.Repositories;
using Falsechat.ViewModel;
using System.Windows.Controls;

namespace Falsechat.View
{
    public partial class LoginPageView : Page
    {
        public LoginPageView()
        {
            InitializeComponent();
            DataContext = new LoginViewModel(new UserRepository());
        }
    }
}
