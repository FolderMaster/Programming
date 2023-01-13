using System;
using System.ComponentModel;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Controls.Classes
{
    /// <summary>
    /// Представление заказа.
    /// </summary>
    public class OrderView
    {
        /// <summary>
        /// Заказ.
        /// </summary>
        private Order _order = null;

        /// <summary>
        /// Покупатель.
        /// </summary>
        private Customer _customer = null;

        /// <summary>
        /// Возращает и задаёт заказ.
        /// </summary>
        [Browsable(false)]
        public Order Order
        {
            get => _order;
            set => _order = value;
        }

        /// <summary>
        /// Возращает и задаёт покупателя.
        /// </summary>
        [Browsable(false)]
        public Customer Customer
        {
            get => _customer;
            set => _customer = value;
        }

        /// <summary>
        /// Возращает уникальный индентификатор.
        /// </summary>
        public int Id
        {
            get => Order.Id;
        }

        /// <summary>
        /// Возращает статус заказа.
        /// </summary>
        public OrderStatus Status
        {
            get => Order.Status;
        }

        /// <summary>
        /// Возращает время последнего изменения статуса заказа.
        /// </summary>
        public DateTime LastChangedStatusDateTime
        {
            get => Order.LastChangedStatusDateTime;
        }

        /// <summary>
        /// Возращает стоимость товаров.
        /// </summary>
        public int Amount
        {
            get => Order.Amount;
        }

        /// <summary>
        /// Возращаит итоговую стоимость.
        /// </summary>
        public int Total
        {
            get => Order.Total;
        }

        /// <summary>
        /// Возращает имя и фамилию покупателя.
        /// </summary>
        public string CustomerFullName
        {
            get => Customer.FullName;
        }

        /// <summary>
        /// Возращает адрес.
        /// </summary>
        public Adress Adress
        {
            get => Order.Adress;
        }

        /// <summary>
        /// Возращает значение, указывающее приоритетный заказ или нет.
        /// </summary>
        public bool IsPriority
        {
            get => Order as PriorityOrder != null;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrderView"/>.
        /// </summary>
        /// <param name="order">Заказ.</param>
        /// <param name="customer">Покупатель.</param>
        public OrderView(Order order, Customer customer)
        {
            Order = order;
            Customer = customer;
        }
    }
}