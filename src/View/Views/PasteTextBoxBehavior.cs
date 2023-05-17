using Microsoft.Xaml.Behaviors;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

using View.ViewModel;

namespace View.Views
{
    /// <summary>
    /// Класс поведения <see cref="TextBox"/> вставки из буфера обмена.
    /// </summary>
    public class PasteTextBoxBehavior : Behavior<TextBox>
    {
        /// <summary>
        /// Возвращает и задаёт команду обработки.
        /// </summary>
        public ICommand Command
        {
            get => (ICommand)GetValue(CommandProperty);
            set => SetValue(CommandProperty, value);
        }

        /// <summary>
        /// Зависимое свойство <see cref="Command"/>.
        /// </summary>
        public static DependencyProperty CommandProperty =
            DependencyProperty.Register(nameof(Command), typeof(ICommand),
                typeof(PasteTextBoxBehavior), new FrameworkPropertyMetadata());

        /// <summary>
        /// Прикрепляет поведение к элементу управления.
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
            DataObject.AddPastingHandler(AssociatedObject, Paste);
        }

        /// <summary>
        /// Открепляет поведение к элементу управления.
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            DataObject.RemovePastingHandler(AssociatedObject, Paste);
        }


        /// <summary>
        /// Реализует вставку из буфера обмена.
        /// </summary>
        /// <param name="sender">Объект вызова события.</param>
        /// <param name="e">Аргументы события вставки.</param>
        private void Paste(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string newString = (string)e.DataObject.GetData(typeof(string));
                bool handled = false;
                Command.Execute(new TextInputArgs(newString, (bool h) => handled = h));
                if (handled)
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}