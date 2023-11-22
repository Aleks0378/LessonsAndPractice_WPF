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

//Создайте приложение WPF, которое имеет две кнопки: "Открыть окно" и "Закрыть окно".
//При нажатии на кнопку "Открыть окно" должно открываться новое окно с надписью "Привет, это новое окно!".
//При нажатии на кнопку "Закрыть окно" это новое окно должно закрываться.

namespace Practice_22._11_Task_1
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

        private void OpenwindowButton_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
        }
    }
}