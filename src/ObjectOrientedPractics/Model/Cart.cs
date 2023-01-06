using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Корзина с товарами.
    /// </summary>
    public class Cart : ICloneable, IEquatable<object>
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Задаёт и возвращает товары.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Возвращает стоимость товаров.
        /// </summary>
        public int Amount
        {
            get => _items.Select(item => item.Cost).Sum();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/> по-умолчанию.
        /// </summary>
        public Cart()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Cart"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public Cart(List<Item> items)
        {
            Items = items;
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

            Cart cart = other as Cart;
            if (cart == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Items.SequenceEqual(cart.Items);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public object Clone()
        {
            return new Cart(new List<Item>(Items));
        }
    }
}