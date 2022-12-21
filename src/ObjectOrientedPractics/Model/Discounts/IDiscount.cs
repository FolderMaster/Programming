using System.Collections.Generic;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Интерфейс скидок, которые рассчитывают свой размер, применяют его и обновляются.
    /// </summary>
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
        /// <returns>Возращает размер скидки для товаров.</returns>
        int Apply(List<Item> items);

        /// <summary>
        /// Применяет скидку для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        void Update(List<Item> items);
    }
}