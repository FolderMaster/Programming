using System;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Controls.Classes
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
        /// Возращает и задаёт стоимость товаров.
        /// </summary>
        public int Amount { get; set; }

        /// <summary>
        /// Возращаит и задаёт итоговую стоимость.
        /// </summary>
        public int Total { get; set; }

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
        /// <param name="order">Заказ.</param>
        /// <param name="customer">Покупатель.</param>
        public OrderView(Order order, Customer customer)
        {
            Id = order.Id;
            Status = order.Status;
            LastChangedStatusDateTime= order.LastChangedStatusDateTime;
            Amount = order.Amount;
            Total = order.Total;
            CustomerFullName = customer.FullName;
            Adress = order.Adress;
            IsPriority = order as PriorityOrder != null;
        }
    }
}