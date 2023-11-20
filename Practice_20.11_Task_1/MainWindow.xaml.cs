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

//В нижнюю часть формы добавить ToolBar, в котором расположить 5 кнопок с командами (любые, к примеру «Сохранить», «Открыть»).
//Обработать нажатия по каждой из кнопок, отобразив MessagBox с соответствующим сообщением


namespace Practice_20._11_Task_1
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

        private void SaveButon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Save Button has been pushed!");
        }

        private void OpenButon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Open Button has been pushed!");
        }

        private void EditButon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Edit Button has been pushed!");
        }

        private void PrintButon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Print Button has been pushed!");
        }

        private void ExitButon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Exit Button has been pushed!");
        }
    }
}