using System.Windows;
using System.Windows.Controls;

namespace Falsechat.Components
{
    public partial class CustomPasswordBox : UserControl
    {
        private bool _isPasswordChanging;
        public CustomPasswordBox()
        {
            InitializeComponent();
        }
        public static readonly DependencyProperty PasswordProperty =
           DependencyProperty.Register("Password", typeof(string),
               typeof(CustomPasswordBox),
               new PropertyMetadata(string.Empty, PasswordPropertyChanged));
        public string Password
        {
            get { return (string)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }
        private static void PasswordPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is CustomPasswordBox customPasswordBox)
            {
                customPasswordBox.UpdatePassword();
            }
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            _isPasswordChanging = true;
            Password = customPasswordBox.Password;
            _isPasswordChanging = false;
        }
        private void UpdatePassword()
        {
            if (!_isPasswordChanging)
            {
                customPasswordBox.Password = Password;
            }
        }
    }
}
