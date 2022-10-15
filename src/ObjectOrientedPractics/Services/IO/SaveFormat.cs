using System.Collections.Generic;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services.IO
{
    /// <summary>
    /// Формат файла сохранения с нужными данными.
    /// </summary>
    public class SaveFormat
    {
        /// <summary>
        /// Возращает и задаёт список экземпляров класса <see cref="Item"/>.
        /// </summary>
        public List<Item> Items { get; set; }

        /// <summary>
        /// Возращает и задаёт список экземпляров класса <see cref="Customer"/>.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SaveFormat"/> по-умолчанию.
        /// </summary>
        public SaveFormat()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SaveFormat"/>.
        /// </summary>
        /// <param name="items">Список экземпляров класса <see cref="Item"/>.</param>
        /// <param name="customers">Список экземпляров класса <see cref="Customer"/>.</param>
        public SaveFormat(List<Item> items, List<Customer> customers)
        {
            Items = items;
            Customers = customers;
        }
    }
}