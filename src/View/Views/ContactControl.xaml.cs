using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

using View.Model;

namespace View.Views
{
    /// <summary>
    /// Класс элемента управления для работы с <see cref="Contact"/>.
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Возвращает и задаёт контакт.
        /// </summary>
        public Contact Contact
        {
            get => (Contact)GetValue(ContactProperty);
            set => SetValue(ContactProperty, value);
        }

        /// <summary>
        /// Возвращает и задаёт логическое значение, указывающее только ли для чтения элемент
        /// управления.
        /// </summary>
        public bool IsReadOnly
        {
            get => (bool)GetValue(IsReadOnlyProperty);
            set => SetValue(IsReadOnlyProperty, value);
        }

        /// <summary>
        /// Возвращает и задаёт команду обработки ввода <see cref="Contact.PhoneNumber"/>.
        /// </summary>
        public ICommand PhoneNumberTextInputCommand
        {
            get => (ICommand)GetValue(PhoneNumberTextInputCommandProperty);
            set => SetValue(PhoneNumberTextInputCommandProperty, value);
        }

        /// <summary>
        /// Зависимое свойство <see cref="Contact"/>.
        /// </summary>
        public static DependencyProperty ContactProperty =
            DependencyProperty.Register(nameof(Contact), typeof(Contact), typeof(ContactControl),
                new FrameworkPropertyMetadata());

        /// <summary>
        /// Зависимое свойство <see cref="IsReadOnly"/>.
        /// </summary>
        public static DependencyProperty IsReadOnlyProperty =
            DependencyProperty.Register(nameof(IsReadOnly), typeof(bool), typeof(ContactControl),
                new FrameworkPropertyMetadata());

        /// <summary>
        /// Зависимое свойство <see cref="PhoneNumberTextInputCommand"/>.
        /// </summary>
        public static DependencyProperty PhoneNumberTextInputCommandProperty =
            DependencyProperty.Register(nameof(PhoneNumberTextInputCommand), typeof(ICommand),
                typeof(ContactControl), new FrameworkPropertyMetadata());

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ContactControl"/> по умолчанию.
        /// </summary>
        public ContactControl()
        {
            InitializeComponent();
        }
    }
}