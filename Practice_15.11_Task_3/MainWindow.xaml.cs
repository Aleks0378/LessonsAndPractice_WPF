using System.Collections.ObjectModel;
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

namespace Practice_15._11_Task_3
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<Book> books;
        private int currentPage = 0;
        private int pageSize = 2;

        public MainWindow()
        {
            InitializeComponent();
            InitializeBooks();
            DisplayBooks();
        }

        private void InitializeBooks()
        {
            // Замените URL изображения, жанр, описание, год и другие данные на ваши собственные
            books = new ObservableCollection<Book>
            {
                new Book("Книга Бойцовский клуб Ч. Поланик", 
                "D:\\Visual Studio\\C#\\Сентябрь 2023\\LessonsAndPractice_WPF\\Practice_15.11_Task_3\\Images\\book1.webp",
                "Роман",
                "Бойцовский клуб Ч. Поланик\r\n\r\nРоман, бросивший вызов литературной традиции и ставший феноменом.",
                "2023",
                "Бойцовский клуб Ч. Поланик\r\n\r\nРоман, бросивший вызов литературной традиции и ставший феноменом\r\nЛимитированное издание со взрывчатым форзацем!\r\n\r\n" +
                "Его называют «библией разрушителей цивилизации»\r\nОтмечен наградами Pacific Northwest Booksellers Association Award и Oregon Book Award\r\nКультовая экранизация с Брэдом Питтом и Эдвардом Нортоном\r\nБой будет продолжаться столько, сколько нужно\r\n\r\n" +
                "Если можно постоянно просыпаться в разных местах и в разное время, почему бы однажды не проснуться другим человеком? Именно такой истины доходит в определенный день безымянный герой этой истории." +
                " Достичь желаемого, внести новое содержание в переполненную бессонницей реальность ему поможет мятежник по имени Тайлер Дёрден. Тот приводит героя в место, называемое бойцовским клубом. И первое правило клуба – никогда никому не говорить о нем.\r\n\r\n" +
                "Здесь собираются те, кто прозябает в плену обыденности, кто, сражаясь, хочет снова почувствовать себя мужем. Те, кто выбирает: ад или ничто. Мужчины, которые за пределами боли, вне рамок этики, на краю безумия хотят обрести дикую, первобытную свободу. " +
                "Но первым шагом к этой свободе должно стать не сражение, а смерть.\r\n\r\nЧака Поланика называют \"шоковым писателем\". Потомок украинского эмигранта, он начал литературную карьеру в зрелом возрасте, уже имея, что сказать читателям." +
                " Его книги давно вышли за пределы собственно художественного произведения и стали явлением контркультуры.\r\n\r\nСтиль Поланика – резкий, категорический, провокативный – это манифест поколения Х." +
                " Произведения писателя получили награды Pacific Northwest Booksellers Association Award и Oregon Book Award, а также несколько раз номинировались на Премию Брема Стокера."),
                new Book("Книга Люби ближнего твоего Э. М. Ремарк",
                "D:\\Visual Studio\\C#\\Сентябрь 2023\\LessonsAndPractice_WPF\\Practice_15.11_Task_3\\Images\\book2.webp",
                "Роман",
                "Люби ближнего своего Э. М. Ремарк\r\n\r\nПереиздание романа отдельной книгой\r\nНовое авторское оформление\r\nК публикации в апреле готовится «Черный обелиск»",
                "2023",
                "Это история двух незнакомцев, разделивших одну судьбу – судьбу беженцев." +
                " Наивный молодой Людвиг Карен и циник Йозеф Штайнер вынуждены бежать из нацистской Германии. " +
                "Они больше не имеют ни родины, ни прошлого, ни будущего. Есть только \"здесь\" и \"сейчас\". Людвиг попадает в тюрьму из-за отсутствия документов на жительство.\r\n\r\n" +
                "Именно здесь судьба сводит его со Штайнером, который станет наставником для молодого наивного парня. Его проводником в трудную и непростую жизнь эмигранта." +
                " Судьба готовит им немало испытаний. Они будут бродить одинокие и отчаявшиеся предвоенной Европой, преследуемые страхом, голодом и нищетой. Война отобрала у этих двоих все. " +
                "Оставила только право остаться людьми. И право любить. Но станет ли им на это сил? Ибо война не оставляет в сердце ничего, кроме пустоты, ненависти и... надежды.\r\n\r\nЖестокие сутки." +
                " Мир укрепляют пушками и бомбовозами, гуманизм развивают концлагерями и погромами. Мы живем во время переоценки всех ценностей, Керне." +
                " Агрессор ныне называется поборником мира, избитый и преследуемый — нарушителем покоя. И есть целые народы, верящие в это!\r\n\r\n«Люби ближнего твоего», Ремарк\r\n\r\n" +
                "Об авторе:\r\n\r\nЭрих Мария Ремарк – один из самых известных писателей ХХ века. " +
                "Его антивоенные романы \"На Западном фронте без изменений\", \"Три товарища\", \"Триумфальная арка\" являются настоящими мировыми сенсациями, не теряющими актуальности и по сей день. " +
                "Рядом с Хемингуэем и Олдингтоном Ремарк - одна из культовых фигур литературного течения \"потерянного поколения\"."),
                new Book("Book 3", "https://example.com/book3.jpg", "Genre 3", "Description 3", "2022", "Full description 3"),
                new Book("Book 4", "https://example.com/book4.jpg", "Genre 4", "Description 4", "2023", "Full description 4"),
                new Book("Book 5", "https://example.com/book5.jpg", "Genre 5", "Description 5", "2024", "Full description 5"),
                // Добавьте больше книг, если нужно
            };
        }

        private void DisplayBooks()
        {
            booksItemsControl.ItemsSource = GetPageBooks();
        }

        private ObservableCollection<Book> GetPageBooks()
        {
            int startIndex = currentPage * pageSize;
            int count = Math.Min(pageSize, books.Count - startIndex);

            var pageBooks = new ObservableCollection<Book>();

            for (int i = 0; i < count; i++)
            {
                pageBooks.Add(books[startIndex + i]);
            }

            return pageBooks;
        }

        private void ShowDetails_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            foreach (var child in ((StackPanel)button.Parent).Children)
            {
                if (child is StackPanel detailsPanel && detailsPanel.Name == "detailsPanel")
                {
                    detailsPanel.Visibility = detailsPanel.Visibility == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible;
                }
            }
        }

        private void PreviousPage_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayBooks();
            }
        }

        private void NextPage_Click(object sender, RoutedEventArgs e)
        {
            if (currentPage < (books.Count - 1) / pageSize)
            {
                currentPage++;
                DisplayBooks();
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public string FullDescription { get; set; }

        public Book(string title, string imageUrl, string genre, string description, string year, string fullDescription)
        {
            Title = title;
            ImageUrl = imageUrl;
            Genre = genre;
            Description = description;
            Year = year;
            FullDescription = fullDescription;
        }
    }
}