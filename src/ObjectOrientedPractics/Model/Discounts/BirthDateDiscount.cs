using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Скидка по дню рождения.
    /// </summary>
    public class BirthDateDiscount : IDiscount
    {
        /// <summary>
        /// Количество дней, до и перед датой рождения которыми действует скидка.
        /// </summary>
        private const int _discountDayCount = 7;

        /// <summary>
        /// Скидка.
        /// </summary>
        private const double _discount = 0.1;

        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _birthDate = DateTime.UtcNow;

        /// <summary>
        /// Возращает и задаёт дату рождения.
        /// </summary>
        public DateTime BirthDate
        {
            get => _birthDate;
            set => _birthDate = value;
        }

        /// <summary>
        /// Возращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get => $"Birth date - {_birthDate.ToShortDateString()}";
        }

        /// <summary>
        /// Создаёт экземпляр класса по умолчанию.
        /// </summary>
        public BirthDateDiscount()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса.
        /// </summary>
        /// <param name="birthDate">Дата рождения.</param>
        public BirthDateDiscount(DateTime birthDate)
        {
            _birthDate = birthDate;
        }

        /// <summary>
        /// Подсчитывает стоимость товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает стоимость товаров.</returns>
        private int GetItemCost(List<Item> items)
        {
            return items.Select((i) => i.Cost).Sum();
        }

        /// <summary>
        /// Проверяет доступность скидки.
        /// </summary>
        /// <returns>Логическое значение, обозначающее возможность скидки.</returns>
        private bool IsAvailableDiscount()
        {
            DateTime nowDate = DateTime.UtcNow;
            DateTime thisYearBirthDate = new DateTime(nowDate.Year, BirthDate.Month, 
                BirthDate.Day);
            DateTime beginAvailableDate = thisYearBirthDate.AddDays(-_discountDayCount);
            DateTime endAvailableDate = thisYearBirthDate.AddDays(_discountDayCount);
            return beginAvailableDate <= nowDate && endAvailableDate >= nowDate;
        }

        /// <summary>
        /// Рассчитывает размер скидки для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает размер скидки для товаров.</returns>
        public int Calculate(List<Item> items)
        {
            return IsAvailableDiscount() ? (int)(_discount * GetItemCost(items)) : 0;
        }

        /// <summary>
        /// Применяет скидку для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает размер скидки для товаров.</returns>
        public int Apply(List<Item> items)
        {
            return Calculate(items);
        }

        /// <summary>
        /// Обновляет скидку после покупки товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        public void Update(List<Item> items)
        {
        }
    }
}