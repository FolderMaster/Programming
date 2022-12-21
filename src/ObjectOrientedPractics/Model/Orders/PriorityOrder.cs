using System;
using System.Collections.Generic;

using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Заказ приоритетного обслуживания с желаемой датой и времени доставки.
    /// </summary>
    public class PriorityOrder : Order
    {
        /// <summary>
        /// Желаемая дата доставки.
        /// </summary>
        private DateTime _desiredDeliveryDate;

        /// <summary>
        /// Желаемое время доставки.
        /// </summary>
        private string _desiredDeliveryTime;

        /// <summary>
        /// Диапазоны времени доставки.
        /// </summary>
        private static readonly string[] _deliveryTimes = new string[]
        {
            "9:00 – 11:00",
            "11:00 – 13:00",
            "13:00 – 15:00",
            "15:00 – 17:00",
            "17:00 – 19:00",
            "19:00 – 21:00"
        };

        /// <summary>
        /// Возращает диапозоны времени доставки.
        /// </summary>
        public static string[] DeliveryTimes
        {
            get => _deliveryTimes;
        }

        /// <summary>
        /// Возращает и задаёт желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDeliveryDate
        {
            get => _desiredDeliveryDate;
            set => _desiredDeliveryDate = value;
        }

        /// <summary>
        /// Возращает и задаёт желаемое время доставки.
        /// </summary>
        public string DesiredDeliveryTime
        {
            get => _desiredDeliveryTime;
            set
            {
                _desiredDeliveryTime = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/> по-умолчанию.
        /// </summary>
        public PriorityOrder() : base()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="adress">Адрес.</param>
        /// <param name="status">Статус заказа.</param>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки.</param>
        /// <param name="desiredDeliveryTime">Желаемое время доставки.</param>
        public PriorityOrder(List<Item> items, Adress adress, OrderStatus status, DateTime 
            desiredDeliveryDate, string desiredDeliveryTime) : base(items, adress, status)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTime = desiredDeliveryTime;
        }
    }
}