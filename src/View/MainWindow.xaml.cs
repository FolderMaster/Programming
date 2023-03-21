using System.Windows;

using View.ViewModel;

namespace View
{
    /// <summary>
    /// Основное окно приложения.
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainWindow"/> по умолчанию.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainVM();
        }
    }
}
