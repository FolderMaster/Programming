using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    public interface IDiscount
    {
        /// <summary>
        /// Возращает информацию о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Рассчитывает размер скидки для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает размер скидки для товаров.</returns>
        int Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает размер скидки для товаров категории <see cref="Category"/>.
        /// </returns>
        int Apply(List<Item> items);

        /// <summary>
        /// Обновляет скидку после покупки товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        void Update(List<Item> items);
    }
}