using System.Windows;

using View.ViewModel;

namespace View.Views
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

            DataContext = new MainVM(new ErrorMessageBox());
        }
    }
}