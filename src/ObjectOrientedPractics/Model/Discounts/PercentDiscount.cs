using System;
using System.Collections.Generic;
using System.Linq;

using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Процентная скидка, действующая на определённую категорию товаров.
    /// </summary>
    public class PercentDiscount : IDiscount, IComparable<object>
    {
        /// <summary>
        /// Максимальная скидка.
        /// </summary>
        private const double _maxDiscount = 0.1;

        /// <summary>
        /// Минимальная скидка.
        /// </summary>
        private const double _minDiscount = 0.01;

        /// <summary>
        /// Размер покупки для следующего увеличения скидки.
        /// </summary>
        private const double _upgradeItemAmount = 1000;

        /// <summary>
        /// Скидка.
        /// </summary>
        private double _discount = _minDiscount;

        /// <summary>
        /// Категория товаров, для которого действует скидка.
        /// </summary>
        private ItemCategory _category = ItemCategory.None;

        /// <summary>
        /// Стоимость купленных товаров.
        /// </summary>
        private int _itemAmount = 0;

        /// <summary>
        /// Возращает и задаёт категорию товаров, для которого действует скидка.
        /// </summary>
        public ItemCategory Category
        {
            get => _category;
            set => _category = value;
        }

        /// <summary>
        /// Возращает и задаёт стоимость купленных товаров. Должно быть положительным.
        /// </summary>
        public int ItemAmount
        {
            get => _itemAmount;
            set
            {
                ValueValidator.AssertOnPositiveValue(value, nameof(ItemAmount));
                _itemAmount = value;
                UpdateDiscount();
            }
        }

        /// <summary>
        /// Возращает скидку.
        /// </summary>
        public double Discount
        {
            get => _discount;
        }

        /// <summary>
        /// Возращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get => $"Percentage \"{Category}\" - {_discount}%";
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PercentDiscount"/> по умолчанию.
        /// </summary>
        public PercentDiscount()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PercentDiscount"/>.
        /// </summary>
        /// <param name="category">Категория товаров, для которого действует скидка.</param>
        /// <param name="itemAmount">Стоимость купленных товаров.</param>
        public PercentDiscount(ItemCategory category, int itemAmount)
        {
            Category = category;
            ItemAmount = itemAmount;
        }

        /// <summary>
        /// Подсчитывает стоимость товаров категории <see cref="Category"/>.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает стоимость товаров категории <see cref="Category"/>.</returns>
        private int GetItemCost(List<Item> items)
        {
            return items.Where((i) => i.Category == Category).Select((i) => i.Cost).Sum();
        }

        /// <summary>
        /// Обновляет скидку.
        /// </summary>
        private void UpdateDiscount()
        {
            double newDiscount = _minDiscount + Math.Round(ItemAmount / (_upgradeItemAmount * 100),
                2);
            _discount = newDiscount > _maxDiscount ? _maxDiscount : newDiscount;
        }

        /// <summary>
        /// Рассчитывает размер скидки для товаров категории <see cref="Category"/>.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает размер скидки для товаров категории <see cref="Category"/>.
        /// </returns>
        public int Calculate(List<Item> items)
        {
            return (int)(GetItemCost(items) * _discount);
        }

        /// <summary>
        /// Применяет скидку для товаров.
        /// </summary>
        /// <param name="items">Товары.</param>
        /// <returns>Возращает размер скидки для товаров категории <see cref="Category"/>.
        /// </returns>
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
            ItemAmount += GetItemCost(items);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        /// <exception cref="ArgumentException"></exception>
        public int CompareTo(object other)
        {
            if (other is PercentDiscount percentDiscount)
            {
                return Discount.CompareTo(percentDiscount.Discount);
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

            PercentDiscount pointsDiscount = other as PercentDiscount;
            if (pointsDiscount == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Category == pointsDiscount.Category && 
                ItemAmount == pointsDiscount.ItemAmount;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public object Clone()
        {
            return new PercentDiscount(Category, ItemAmount);
        }
    }
}