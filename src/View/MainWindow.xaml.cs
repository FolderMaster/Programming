using System.Windows;

using ViewModel;

using View.MessageShowable;

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

            DataContext = new MainVM(new ErrorMessageBox());
        }
    }
}