using System;
using System.Collections.Generic;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services.Factories
{
    /// <summary>
    /// Фабрика, создающая экземпляры класса <see cref="Order"/>.
    /// </summary>
    public static class OrderFactory
    {
        /// <summary>
        /// Генератор псевдослучайных чисел.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Максимальное количество товаров.
        /// </summary>
        private static int _maxCount = 10;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Order"/> со случайной информацией.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="customers">Список покупателей.</param>
        /// <param name="isPriority">Значение, указывающее приоритный заказ.</param>
        /// <returns>Экземпляр класса <see cref="Order"/>.</returns>
        public static Order CreateOrder(List<Item> items, List<Customer> customers, bool 
            isPriority)
        {
            int count = _random.Next(1, _maxCount);
            List<Item> orderItems = new List<Item>();
            for(int n = 0; n < count; ++n)
            {
                orderItems.Add(items[_random.Next(items.Count)]);
            }
            if(isPriority)
            {
                return new PriorityOrder(orderItems, AdressFactory.CreateAdress(customers), 
                    OrderStatus.New, DateTime.UtcNow, PriorityOrder.DeliveryTimes[0]);
            }
            else
            {
                return new Order(orderItems, AdressFactory.CreateAdress(customers), 
                    OrderStatus.New);
            }
        }
    }
}
