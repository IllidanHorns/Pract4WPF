using System.Windows;

namespace Pract4WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TestWindow test_window = new TestWindow();

        public string password_admin = "123";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void change_test_Click(object sender, RoutedEventArgs e)
        {
            if (admin_key_textbox.Text == "123")
            {
                test_window.change_test_button.IsEnabled = true;
                test_window.test_frame.Content = new ChangeTestPage();
                test_window.Show();
            }
            else
            {
                test_window.change_test_button.IsEnabled = false;
                test_window.test_frame.Content = new NonTestPage();
                test_window.Show();
                this.Visibility = Visibility.Collapsed;
            }
        }

        private void start_test_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}