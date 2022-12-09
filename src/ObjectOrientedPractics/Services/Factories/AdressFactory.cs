using System;
using System.Collections.Generic;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services.Factories
{
    /// <summary>
    /// Фабрика, создающая экземпляры класса <see cref="Adress"/>.
    /// </summary>
    public static class AdressFactory
    {
        /// <summary>
        /// Генератор псевдослучайных чисел.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Adress"/> со случайной информацией.
        /// </summary>
        /// <param name="customers">Список покупателей.</param>
        /// <returns>Экземпляр класса <see cref="Adress"/>.</returns>
        public static Adress CreateAdress(List<Customer> customers)
        {
            return customers[_random.Next(customers.Count)].Adress;
        }
    }
}