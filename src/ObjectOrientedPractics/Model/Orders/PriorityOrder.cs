﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        /// <param name="discountAmount">Размер примененных скидок.</param>
        /// <param name="desiredDeliveryDate">Желаемая дата доставки.</param>
        /// <param name="desiredDeliveryTime">Желаемое время доставки.</param>
        public PriorityOrder(List<Item> items, Adress adress, OrderStatus status, int 
            discountAmount, DateTime desiredDeliveryDate, string desiredDeliveryTime) : 
            base(items, adress, status, discountAmount)
        {
            DesiredDeliveryDate = desiredDeliveryDate;
            DesiredDeliveryTime = desiredDeliveryTime;
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

            PriorityOrder priorityOrder = other as PriorityOrder;
            if (priorityOrder == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Items.SequenceEqual(priorityOrder.Items) && 
                Adress.Equals(priorityOrder.Adress) &&
                Status == priorityOrder.Status && 
                DiscountAmount == priorityOrder.DiscountAmount &&
                DesiredDeliveryDate == priorityOrder.DesiredDeliveryDate && 
                DesiredDeliveryTime == priorityOrder.DesiredDeliveryTime;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override object Clone()
        {
            return new PriorityOrder(new List<Item>(Items), (Adress)Adress.Clone(), Status, 
                DiscountAmount, DesiredDeliveryDate, DesiredDeliveryTime);
        }
    }
}