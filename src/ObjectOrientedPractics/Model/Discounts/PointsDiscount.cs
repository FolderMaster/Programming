using System;
using System.Collections.Generic;
using System.Linq;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Скидка накопительных баллов.
    /// </summary>
    public class PointsDiscount : IDiscount, IComparable<object>
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
        /// Возращает и задаёт количество накопительных баллов. Должно быть положительным.
        /// </summary>
        public int PointCount
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
        /// Создаёт экземпляр класса <see cref="PointsDiscount"/>.
        /// </summary>
        /// <param name="pointCount">Количество накопительных баллов.</param>
        public PointsDiscount(int pointCount)
        {
            PointCount = pointCount;
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

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object other)
        {
            if (other is PointsDiscount pointsDiscount)
            {
                return PointCount.CompareTo(pointsDiscount.PointCount);
            }
            else
            {
                throw new ArgumentException();
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            PointsDiscount pointsDiscount = other as PointsDiscount;
            if (pointsDiscount == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return PointCount == pointsDiscount.PointCount;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public object Clone()
        {
            return new PointsDiscount(PointCount);
        }
    }
}