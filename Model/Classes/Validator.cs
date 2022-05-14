using System;
namespace Programming.Model.Classes
{
    /// <summary>
    /// Валидатор различных условий для значений с исключениями, включающие в себя имена значений.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, что число неотрицательное.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(int value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        /// <summary>
        /// Проверяет, что число неотрицательное.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="name">Имя значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertOnPositiveValue(double value, string name)
        {
            if (value < 0)
            {
                throw new ArgumentException($"{name} must be positive");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в промежутке.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Нижняя граница промежутка.</param>
        /// <param name="max">Верхняя граница промежутка.</param>
        /// <param name="name">Имя значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(int value, int min, int max, string name)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"{name} must be in range [{min};{max}]");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в промежутке.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="min">Нижняя граница промежутка.</param>
        /// <param name="max">Верхняя граница промежутка.</param>
        /// <param name="name">Имя значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(double value, double min, double max, string name)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException($"{name} must be in range [{min};{max}]");
            }
        }

        /// <summary>
        /// Проверяет, что число больше другого.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="other">Другое значение.</param>
        /// <param name="valueName">Имя значения.</param>
        /// <param name="otherName">Имя другого значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertMoreValue(double value, double other, string valueName, string otherName)
        {
            if (value <= other)
            {
                throw new ArgumentException($"{valueName} must be more than {otherName}");
            }
        }

        /// <summary>
        /// Проверяет, что число меньше другого.
        /// </summary>
        /// <param name="value">Проверяемое значение.</param>
        /// <param name="other">Другое значение.</param>
        /// <param name="valueName">Имя значения.</param>
        /// <param name="otherName">Имя другого значения.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertLessValue(double value, double other, string valueName, string otherName)
        {
            if (value >= other)
            {
                throw new ArgumentException($"{valueName} must be less than {otherName}");
            }
        }
    }
}
