﻿using System;
using System.Collections.Generic;
using System.Linq;

using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Discounts
{
    /// <summary>
    /// Процентная скидка, действующая на определённую категорию товаров.
    /// </summary>
    public class PercentDiscount : IDiscount
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
    }
}