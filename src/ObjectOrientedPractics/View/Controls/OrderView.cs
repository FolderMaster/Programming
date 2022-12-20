using System;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Представление класса <see cref="Order"/>.
    /// </summary>
    public class OrderView
    {
        /// <summary>
        /// Возращает и задаёт уникальный индентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Возращает и задаёт статус заказа.
        /// </summary>
        public OrderStatus Status { get; set; }

        /// <summary>
        /// Возращает и задаёт время последнего изменения статуса заказа.
        /// </summary>
        public DateTime LastChangedStatusDateTime { get; set; }

        /// <summary>
        /// Возращает и задаёт стоимость.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Имя и фамилия покупателя.
        /// </summary>
        public string CustomerFullName { get; set; }

        /// <summary>
        /// Возращает и задаёт адрес.
        /// </summary>
        public Adress Adress { get; set; }

        /// <summary>
        /// Возращает и задаёт значение, указывающее приоритетный заказ или нет.
        /// </summary>
        public bool IsPriority { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrderView"/> по-умолчанию.
        /// </summary>
        public OrderView()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrderView"/>.
        /// </summary>
        /// <param name="id">Уникальный индентификатор.</param>
        /// <param name="status">Статус заказа.</param>
        /// <param name="lastChangedStatusDateTime">Время последнего изменения статуса 
        /// заказа.</param>
        /// <param name="amount">Стоимость.</param>
        /// <param name="customerFullName">Имя и фамилия покупателя.</param>
        /// <param name="adress">Адрес.</param>
        /// <param name="isPriority">Значение, указывающее приоритетный заказ или нет.</param>
        public OrderView(int id, OrderStatus status, DateTime lastChangedStatusDateTime, 
            int amount, string customerFullName, Adress adress, bool isPriority)
        {
            Id = id;
            Status = status;
            LastChangedStatusDateTime = lastChangedStatusDateTime;
            Amount = amount;
            CustomerFullName = customerFullName;
            Adress = adress;
            IsPriority = isPriority;
        }
    }
}