using System.Windows;

namespace Pract4WPF
{
    /// <summary>
    /// Логика взаимодействия для TestWindow.xaml
    /// </summary>
    public partial class TestWindow : Window
    {
        public TestWindow()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
