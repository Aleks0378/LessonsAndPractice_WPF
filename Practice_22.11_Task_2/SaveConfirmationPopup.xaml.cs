using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Practice_22._11_Task_2
{
    /// <summary>
    /// Логика взаимодействия для SaveConfirmationPopup.xaml
    /// </summary>
    public partial class SaveConfirmationPopup : Window
    {
        public event RoutedEventHandler SaveConfirmed;

        public string NoteText { get; set; }

        public SaveConfirmationPopup()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            // Вызываем событие подтверждения сохранения
            SaveConfirmed?.Invoke(this, new RoutedEventArgs());

            // Здесь можно выполнить другие действия по сохранению
            // ...

            // Закрываем всплывающее окно
            Close();
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            // Закрываем всплывающее окно без сохранения
            Close();
        }
    }
}
