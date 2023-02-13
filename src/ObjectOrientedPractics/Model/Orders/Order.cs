using System;
using System.Collections.Generic;
using System.Linq;

using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Заказ c списком товаров, адресом и статусом.
    /// </summary>
    public class Order : IEquatable<object>, ICloneable
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
        /// Словарь статусов заказа по времени изменения.
        /// </summary>
        private Dictionary<DateTime, OrderStatus> _statusDictionary = new Dictionary<DateTime,
            OrderStatus>();

        /// <summary>
        /// Размер примененных скидок.
        /// </summary>
        private int _discountAmount = 0;

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
        public OrderStatus Status
        {
            get => _statusDictionary.Last().Value;
            set => _statusDictionary.Add(DateTime.Now, value);
        }

        /// <summary>
        /// Возращает время последнего изменения статуса.
        /// </summary>
        public DateTime LastChangedStatusDateTime
        {
            get => _statusDictionary.Last().Key;
        }

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
        /// Возращает и задаёт размер примененных скидок. Должно быть положительными.
        /// </summary>
        public int DiscountAmount
        {
            get => _discountAmount;
            set
            {
                ValueValidator.AssertOnPositiveValue(value, nameof(DiscountAmount));
                _discountAmount = value;
            }
        }

        /// <summary>
        /// Возвращает конечную стоимость заказа.
        /// </summary>
        public int Total
        {
            get => Amount - DiscountAmount;
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
        /// <param name="discountAmount">Размер примененных скидок.</param>
        public Order(List<Item> items, Adress adress, OrderStatus status, int discountAmount)
        {
            Items = items;
            Adress = adress;
            Status = status;
            DiscountAmount = discountAmount;
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

            Order order = other as Order;
            if (order == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Items.SequenceEqual(order.Items) && Adress.Equals(order.Adress) && 
                Status == order.Status && DiscountAmount == order.DiscountAmount;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public virtual object Clone()
        {
            return new Order(new List<Item>(Items), (Adress)Adress.Clone(), Status, 
                DiscountAmount);
        }
    }
}