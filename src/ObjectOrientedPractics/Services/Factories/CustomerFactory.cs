using System;
using System.Collections.Generic;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services.IO;
using static ObjectOrientedPractics.Services.IO.CsvManager;

namespace ObjectOrientedPractics.Services.Factories
{
    /// <summary>
    /// Фабрика, создающая экземпляры класса <see cref="Customer"/>.
    /// </summary>
    public static class CustomerFactory
    {
        /// <summary>
        /// Генератор псевдослучайных чисел.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Чтение <see cref="Customer"/> из файла.
        /// </summary>
        private static ReadObject<Customer> ReadCustomer { get; } = (reader) =>
        {
            string fullName = reader.GetField("first_name") + " " + reader.GetField("last_name");
            if (fullName.Length > Customer.MaxFullNameLength)
            {
                fullName = fullName.Substring(0, Customer.MaxFullNameLength);
            }

            string adress = reader.GetField("address") + " " + reader.GetField("city") + " " +
            reader.GetField("county");
            if (adress.Length > Customer.MaxAdressLength)
            {
                adress = adress.Substring(0, Customer.MaxAdressLength);
            }

            return new Customer(fullName, adress);
        };

        /// <summary>
        /// Cписок экземпляров класса <see cref="Customer"/>.
        /// </summary>
        private static List<Customer> Customers { get; set; } = new List<Customer>();

        /// <summary>
        /// Чтение данных из файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        public static void Load(string filePath)
        {
            Customers = CsvManager.Load(filePath, ReadCustomer);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/> со случайной информацией.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Customer"/>.</returns>
        public static Customer CreateCustomer()
        {
            if (Customers.Count == 0)
            {
                return new Customer();
            }
            else
            {
                Customer customer = Customers[_random.Next(Customers.Count)];
                return new Customer(customer.FullName, customer.Adress);
            }
        }
    }
}