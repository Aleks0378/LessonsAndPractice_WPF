using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practice_15._11_Task_2
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            
            RadioButton radioButton = (RadioButton)sender;
            if (radioButton.IsChecked == true)
            {
                
                CurrentColorTextBlock.Text = $"Текущий цвет: {radioButton.Content}";
            }
        }

        private void ApplyButton_Click(object sender, RoutedEventArgs e)
        {
           
            if (RedRadioButton.IsChecked == true)
                ApplyColor(Colors.Red);
            else if (BlueRadioButton.IsChecked == true)
                ApplyColor(Colors.Blue);
            else if (GreenRadioButton.IsChecked == true)
                ApplyColor(Colors.Green);
            else if (OrangeRadioButton.IsChecked == true)
                ApplyColor(Colors.Orange);
            else if (BlackRadioButton.IsChecked == true)
                ApplyColor(Colors.Black);
        }

        private void ApplyColor(Color color)
        {
            
            CurrentColorTextBlock.Foreground = new SolidColorBrush(color);
        }
    }
}