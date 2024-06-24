using System.Windows;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AgreeCheckBox_Checked(object sender, RoutedEventArgs e)
        {
            SubsButton.IsEnabled = true;           
        }
        private void AgreeCheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            SubsButton.IsEnabled = false;         
        }

        private void SubsButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
