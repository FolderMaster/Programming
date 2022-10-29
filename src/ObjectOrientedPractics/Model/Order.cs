using System;
using System.Collections.Generic;
using System.Linq;

using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Заказ c списком товаров, адресом и статусом.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Генератор уникального индентификатора экземпляра класса.
        /// </summary>
        private static IdGenerator _idGenerator = new IdGenerator();

        /// <summary>
        /// Уникальный индентификатор экземпляра класса.
        /// </summary>
        private readonly int _id = _idGenerator.GetNextId();

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Время создания.
        /// </summary>
        private readonly DateTime _createdDateTime = DateTime.UtcNow;

        /// <summary>
        /// Возвращает уникальный индентификатор экземпляра класса.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Задаёт и возвращает список товаров.
        /// </summary>
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Возвращает и задаёт адрес.
        /// </summary>
        public Adress Adress { get; set; } = new Adress();

        /// <summary>
        /// Возращает и задаёт статус заказа.
        /// </summary>
        public OrderStatus Status { get; set; } = OrderStatus.None;

        /// <summary>
        /// Возвращает время создания.
        /// </summary>
        public DateTime CreatedDateTime
        {
            get => _createdDateTime;
        }

        /// <summary>
        /// Возвращает стоимость товаров.
        /// </summary>
        public int Amount
        {
            get => _items.Select(item => item.Cost).Sum();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/> по-умолчанию.
        /// </summary>
        public Order()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="adress">Адрес.</param>
        /// <param name="status">Статус заказа.</param>
        public Order(List<Item> items, Adress adress, OrderStatus status)
        {
            Items = items;
            Adress = adress;
            Status = status;
        }
    }
}