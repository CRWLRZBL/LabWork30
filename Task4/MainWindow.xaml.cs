using System.Windows;
using System.Windows.Controls;

namespace Task4
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

        private void FontSizeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            UserInputTextBox.FontSize = Convert.ToInt32(radioButton.Content);
        }

        private void AlignmentRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (LeftHARB.IsChecked == true)
            {
                UserInputTextBox.TextAlignment = TextAlignment.Left;
            }
            else if (CenterHARB.IsChecked == true)
            {
                UserInputTextBox.TextAlignment = TextAlignment.Center;
            }
            else
            {
                UserInputTextBox.TextAlignment = TextAlignment.Right;
            }
        }
    }
}