using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services.IO;
using static ObjectOrientedPractics.Services.IO.CsvManager;

namespace ObjectOrientedPractics.Services.Factories
{
    /// <summary>
    /// Фабрика, создающая экземпляры класса <see cref="Item"/>.
    /// </summary>
    public static class ItemFactory
    {
        /// <summary>
        /// Генератор псевдослучайных чисел.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Чтение <see cref="Item"/> из файла.
        /// </summary>
        private static ReadObject<Item> ReadItem { get; } = (reader) =>
        {
            string name = reader.GetField("Product Name");
            if (name.Length > Item.MaxNameLength)
            {
                name = name.Substring(0, Item.MaxNameLength);
            }

            string info = reader.GetField("About Product");
            if (info.Length > Item.MaxInfoLength)
            {
                info = info.Substring(0, Item.MaxInfoLength);
            }

            string stringCost = reader.GetField("Selling Price");
            int cost = 1;
            Regex regex = new Regex(@"\n+");
            if (regex.IsMatch(stringCost))
            {
                cost = int.Parse(regex.Match(stringCost).Value);
                if(cost < Item.CostMin && cost >= Item.CostMax)
                {
                    cost = 1;
                }
            }

            return new Item(name, info, cost);
        };

        /// <summary>
        /// Cписок экземпляров класса <see cref="Item"/>.
        /// </summary>
        private static List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Чтение данных из файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        public static void Load(string filePath)
        {
            Items = CsvManager.Load(filePath, ReadItem);
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/> со случайной информацией.
        /// </summary>
        /// <returns>Экземпляр класса <see cref="Item"/>.</returns>
        public static Item CreateItem()
        {
            if(Items.Count == 0)
            {
                return new Item();
            }
            else
            {
                Item item = Items[_random.Next(Items.Count)];
                return new Item(item.Name, item.Info, item.Cost);
            }
        }
    }
}