using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace View.Model.Services
{
    /// <summary>
    /// Класс валидации данных с методами.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Регулярное выражение номера телефона.
        /// </summary>
        private static Regex _phoneNumberRegex = new Regex("^(\\+)?([-]?[(]?\\d[)]?)+$");

        /// <summary>
        /// Регулярное выражение электронной почты.
        /// </summary>
        private static Regex _emailRegex = new Regex("^[\\w\\d._-]+@[\\w]+\\.[\\w]+$");

        /// <summary>
        /// Проверяет, находит ли в строке соответствие регулярного значения.
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Название свойства.</param>
        /// <param name="errorText">Текст ошибки.</param>
        /// <returns>Логическое значение, которое указывает на прохождение проверки.</returns>
        private static string AssertStringIsRegexMatch(Predicate<string> predicate, string value,
            string propertyName, string errorText)
        {
            var text = "";
            if (!predicate(value))
            {
                text = $"{propertyName}{errorText}";
            }
            return text;
        }

        /// <summary>
        /// Проверяет, что каждый символ для телефона: числа, скобки, дефис.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <returns>Логическое значение, которое указывает на прохождение проверки.</returns>
        public static bool AssertCharsIsForPhoneNumber(string value) =>
            value.Where((c) => !"1234567890+-()".Contains(c)).Count() == 0;

        /// <summary>
        /// Проверяет, что строка соответствует названию (должно быть не длиннее 100 символов).
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="propertyName">Название свойства.</param>
        /// <returns>Логическое значение, которое указывает на прохождение проверки.</returns>
        public static string AssertStringIsName(string value, string propertyName) =>
            AssertStringIsRegexMatch((string s) => s.Length <= 100, value, propertyName,
                "'s length less than or equal to must be 100 characters!");

        /// <summary>
        /// Проверяет, что строка соответствует номеру телефона (должно быть не длиннее 100
        /// символов и соответствовать как паттерну "+7-(913)-813-10-68").
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertyName">Название свойства.</param>
        /// <returns>Логическое значение, которое указывает на прохождение проверки.</returns>
        public static string AssertStringIsPhoneNumber(string value, string propertyName) =>
            AssertStringIsRegexMatch((string s) => _phoneNumberRegex.IsMatch(s) && s.Length <= 100,
                value, propertyName, " must be like \"+7-(913)-813-10-68\" and length less than" +
                " or equal to must be 100 characters!");

        /// <summary>
        /// Проверяет, что строка соответствует электронной почте (должно быть не длиннее 100
        /// символов и соответствовать паттерну "folder-master_2002@mail.com").
        /// </summary>
        /// <param name="value"></param>
        /// <param name="propertyName">Название свойства.</param>
        /// <returns>Логическое значение, которое указывает на прохождение проверки.</returns>
        public static string AssertStringIsEmail(string value, string propertyName) =>
            AssertStringIsRegexMatch((string s) => _emailRegex.IsMatch(s) && s.Length <= 100,
                value, propertyName, " must be like \"folder-master_2002@mail.com\" and length" +
                " less than or equal to must be 100 characters!");
    }
}