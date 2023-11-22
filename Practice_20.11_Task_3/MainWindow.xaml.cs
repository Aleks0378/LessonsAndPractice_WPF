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

//Создайте приложение, в котором пользователь может создавать и управлять событиями на календаре.
//Вам нужно внедрить следующую функциональность:
 
//1) Ваше приложение должно содержать элемент управления Calendar для выбора даты.
//Пользователь может выбрать дату, и выбранная дата будет выделена на календаре. 
//2) Пользователь может добавлять события, связанные с выбранной датой.
//Например, пользователь может выбрать дату и ввести название и описание события.
//Эти события должны сохраняться в памяти приложения (коллекция).
//3) События, связанные с выбранной датой, должны быть отображены под календарем.
//Вы можете использовать ListView или DataGrid для отображения списка событий.

namespace Practice_20._11_Task_3
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
    }
}