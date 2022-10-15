using System.Collections.Generic;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Магазин с товарами и покупателями.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Товары.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Покупатели.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Возращает и задаёт товары.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Возращает и задаёт товары.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set => _customers = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Adress"/> по-умолчанию.
        /// </summary>
        public Store()
        {
        }
    }
}