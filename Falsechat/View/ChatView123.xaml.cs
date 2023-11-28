using Falsechat.Model;
using Falsechat.Repositories;
using Falsechat.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace Falsechat.View
{
    public partial class ChatView : UserControl
    {
        public ChatView()
        {
            InitializeComponent();
            DataContext = new ChatViewModel(new UserRepository(), new RoomRepository(), new RoomModel());
        }

        private void MessageTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(MessageTextBox.Text.Length > 0)
            {
                MessagePlaceHolder.Visibility = Visibility.Hidden;
            }
            else
            {
                MessagePlaceHolder.Visibility = Visibility.Visible;
            }
            if (MessageTextBox.Text.Length > MessageTextBox.MaxLength - 10)
            {
                MessageLengthWarner.Visibility = System.Windows.Visibility.Visible;
                MessageLengthWarner.Text = $"{MessageTextBox.Text.Length}/{MessageTextBox.MaxLength}";
            }
            else
            {
                MessageLengthWarner.Visibility = System.Windows.Visibility.Collapsed;
            }
        }

        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scrollViewer = sender as ScrollViewer;
            bool AutoScrollToEnd = true;
            if (scrollViewer.Tag != null)
            {
                AutoScrollToEnd = (bool)scrollViewer.Tag;
            }
            if (e.ExtentHeightChange == 0)
            {
                AutoScrollToEnd = scrollViewer.ScrollableHeight == scrollViewer.VerticalOffset;
            }
            else
            {
                if (AutoScrollToEnd)
                {
                    scrollViewer.ScrollToEnd();
                }
            }
            scrollViewer.Tag = AutoScrollToEnd;
            return;
        }
    }
}
