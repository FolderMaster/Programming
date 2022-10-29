using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Корзина с товарами.
    /// </summary>
    public class Cart
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
    }
}