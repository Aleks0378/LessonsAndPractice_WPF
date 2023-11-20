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
using System.Windows.Threading;

//Создайте приложение, которое будет иметь 3 панели ToolBar, расположенные в нижней, верхней и левой части окна.
//Во всех кроме нижней, расположить кнопки меню, в нижней – выводить текущее время с использованием Timer.

namespace Practice_20._11_Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            timeTextBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}