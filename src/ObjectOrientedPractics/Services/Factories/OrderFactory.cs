using System;
using System.Collections.Generic;

using ObjectOrientedPractics.Model;

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
        /// Создаёт экземпляр класса <see cref="Order"/> со случайной информацией.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="customers">Список покупателей.</param>
        /// <param name="max">Максимальное количество товаров.</param>
        /// <returns>Экземпляр класса <see cref="Order"/>.</returns>
        public static Order CreateOrder(List<Item> items, List<Customer> customers, int max = 10)
        {
            int count = _random.Next(1, max);
            List<Item> orderItems = new List<Item>();
            for(int n = 0; n < count; ++n)
            {
                orderItems.Add(items[_random.Next(items.Count)]);
            }
            return new Order(orderItems, AdressFactory.CreateAdress(customers), OrderStatus.New);
        }
    }
}
