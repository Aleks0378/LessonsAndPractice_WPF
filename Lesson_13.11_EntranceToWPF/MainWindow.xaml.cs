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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson_13._11_EntranceToWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private decimal totalAmount = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateTotalButtonClick(object sender, RoutedEventArgs e)
        {
            // Валидация ввода
            if (decimal.TryParse(purchaseTextBox.Text, out decimal purchaseAmount))
            {
                // Добавляем стоимость покупки к общей сумме
                totalAmount += purchaseAmount;

                // Отображаем общую сумму
                totalTextBlock.Text = $"Общая сумма: {totalAmount:C}";

                // Очищаем TextBox для следующей покупки
                purchaseTextBox.Clear();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректную стоимость покупки.", "Ошибка ввода");
            }
        }
    }
}
