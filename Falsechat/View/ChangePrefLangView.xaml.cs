using Falsechat.Repositories;
using Falsechat.ViewModel;
using System.Windows.Controls;

namespace Falsechat.View
{
    public partial class ChangePrefLangView : UserControl
    {
        public ChangePrefLangView()
        {
            InitializeComponent();
            DataContext = new ChangePrefLangViewModel(new UserRepository());
        }
    }
}
