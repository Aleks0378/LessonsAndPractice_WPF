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

//Создайте приложение, в котором есть основное окно, где пользователь может создавать заметки, и PopUp окно,
//которое появляется при нажатии на кнопку "Сохранить", чтобы подтвердить сохранение заметки.

namespace Practice_22._11_Task_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SaveConfirmationPopup savePopup;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем экземпляр всплывающего окна
            savePopup = new SaveConfirmationPopup();

            // Устанавливаем текст заметки из основного окна во всплывающем окне
            savePopup.NoteText = noteTextBox.Text;

            // Устанавливаем обработчик события подтверждения сохранения
            savePopup.SaveConfirmed += SavePopup_SaveConfirmed;

            // Отображаем всплывающее окно
            savePopup.Show();
        }

        private void SavePopup_SaveConfirmed(object sender, RoutedEventArgs e)
        {
            // Здесь можно выполнить действия после подтверждения сохранения,
            // например, сохранение заметки в базе данных или файле.

            // Закрываем всплывающее окно
            savePopup.Close();
        }
    }
}