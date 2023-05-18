using Microsoft.Xaml.Behaviors;
using System.Windows.Controls;
using System.Windows;
using System.Windows.Input;

using Model.Service;

namespace View.Behavior
{
    /// <summary>
    /// Класс поведения <see cref="TextBox"/> вставки из буфера обмена.
    /// </summary>
    public class PhoneNumberTextBoxBehavior : Behavior<TextBox>
    {
        /// <summary>
        /// Прикрепляет поведение к элементу управления.
        /// </summary>
        protected override void OnAttached()
        {
            base.OnAttached();
            DataObject.AddPastingHandler(AssociatedObject, Paste);
            AssociatedObject.PreviewTextInput += PreviewTextInput;
        }

        /// <summary>
        /// Открепляет поведение к элементу управления.
        /// </summary>
        protected override void OnDetaching()
        {
            base.OnDetaching();
            DataObject.RemovePastingHandler(AssociatedObject, Paste);
            AssociatedObject.PreviewTextInput -= PreviewTextInput;
        }

        private void Paste(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string newString = (string) e.DataObject.GetData(typeof(string));
                if (!ValueValidator.AssertCharsIsForPhoneNumber(newString))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }

        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!ValueValidator.AssertCharsIsForPhoneNumber(e.Text))
            {
                e.Handled = true;
            }
        }
    }
}