using System.Collections.Generic;
using System.Linq;

using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Скидка накопительных баллов.
    /// </summary>
    public class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Максимальная скидка.
        /// </summary>
        private const double _maxDiscount = 0.3;

        /// <summary>
        /// Кешбека.
        /// </summary>
        private const double _cashBack = 0.1;

        /// <summary>
        /// Количество накопительных баллов.
        /// </summary>
        private int _pointCount = 0;

        /// <summary>
        /// Возращает и задаёт количество накопительных баллов.
        /// </summary>
        private int PointCount
        {
            get => _pointCount;
            set
            {
                ValueValidator.AssertOnPositiveValue(value, nameof(PointCount));
                _pointCount = value;
            }
        }

        /// <summary>
        /// Возращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get => $"Cumulative - {PointCount} points";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PointsDiscount"/> по умолчанию.
        /// </summary>
        public PointsDiscount()
        {
        }

        /// <summary>
        /// Подсчитывает стоимость товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает размер скидки для товаров.</returns>
        int GetItemCost(List<Item> items)
        {
            return items.Select((i) => i.Cost).Sum();
        }

        /// <summary>
        /// Рассчитывает размер скидки для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает размер скидки для товаров.</returns>
        public int Calculate(List<Item> items)
        {
            int maxDiscountAmount = (int)(GetItemCost(items) * _maxDiscount);
            return maxDiscountAmount > PointCount ? PointCount : maxDiscountAmount;
        }

        /// <summary>
        /// Применяет скидку для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает размер скидки для товаров.</returns>
        public int Apply(List<Item> items)
        {
            int discountAmount = Calculate(items);
            PointCount -= discountAmount;
            return discountAmount;
        }

        /// <summary>
        /// Обновляет скидку после покупки товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        public void Update(List<Item> items)
        {
            PointCount += (int)(_cashBack * GetItemCost(items));
        }
    }
}