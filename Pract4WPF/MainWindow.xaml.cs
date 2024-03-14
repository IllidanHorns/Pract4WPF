using System.Windows;

namespace Pract4WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string password_admin = "123";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void change_test_Click(object sender, RoutedEventArgs e)
        {
            TestWindow test_window = new TestWindow();
            test_window.Owner = this;
            this.Visibility = Visibility.Collapsed;
            if (admin_key_textbox.Text == "123")
            {
                test_window.change_test_button.IsEnabled = true;
                test_window.test_frame.Content = new NonTestPage();
                test_window.Show();
            }
            else
            {
                test_window.change_test_button.IsEnabled = false;
                test_window.test_frame.Content = new NonTestPage();
                test_window.Show();
            }
        }

        private void start_test_Click(object sender, RoutedEventArgs e) 
        {
            TestWindow test_window = new TestWindow();
            test_window.change_test_button.IsEnabled = false;
            test_window.test_frame.Content = new NonTestPage();
            test_window.Owner = this;
            this.Visibility = Visibility.Collapsed;
            test_window.Show();
        }
    }
}