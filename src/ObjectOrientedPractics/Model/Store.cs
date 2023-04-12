using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Магазин с товарами и покупателями.
    /// </summary>
    public class Store : IEquatable<object>, ICloneable
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
        /// Создаёт экземпляр класса <see cref="Store"/> по-умолчанию.
        /// </summary>
        public Store()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Store"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="customers">Список покупателей.</param>
        public Store(List<Item> items, List<Customer> customers)
        {
            Items = items;
            Customers = customers;
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

            Store store = other as Store;
            if (store == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Items.SequenceEqual(store.Items) && Customers.SequenceEqual(store.Customers);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public object Clone()
        {
            List<Item> items = new List<Item>();
            foreach(Item item in Items)
            {
                items.Add((Item)item.Clone());
            }

            List<Customer> customers = new List<Customer>();
            foreach (Customer customer in Customers)
            {
                customers.Add((Customer)customer.Clone());
            }

            return new Store(items, customers);
        }
    }
}