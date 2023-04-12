using System;
using System.Collections.Generic;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Инструменты для работы с информацией: фильтр и сортировка.
    /// </summary>
    public static class DataTools
    {
        /// <summary>
        /// Делегат метода фильтрации с объектом и аргументом в качестве параметра.
        /// </summary>
        /// <typeparam name="T1">Тип данных объекта.</typeparam>
        /// <typeparam name="T2">Тип данных аргумента.</typeparam>
        /// <param name="item">Объект.</param>
        /// <param name="argument">Аргумент.</param>
        /// <returns>Логическое значение, указывающее, оставлять ли объект.</returns>
        public delegate bool Filter<T1, T2>(T1 item, T2 argument);

        /// <summary>
        /// Фильтрует товар, оставляя товар выше стоимости.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <param name="cost">Стоимость</param>
        /// <returns>Логическое значение, указывающее, оставлять ли товар.</returns>
        public static bool FilterItemOverCost(Item item, int cost)
        {
            return item.Cost > cost;
        }

        /// <summary>
        /// Фильтрует товар, оставляя товар с категорией.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <param name="category">Категория.</param>
        /// <returns>Логическое значение, указывающее, оставлять ли товар.</returns>
        public static bool FilterItemByCategory(Item item, ItemCategory category)
        {
            return item.Category == category;
        }

        /// <summary>
        /// Фильтрует информацию по делегату и аргументу.
        /// </summary>
        /// <typeparam name="T1">Тип данных информации.</typeparam>
        /// <typeparam name="T2">Тип данных аргумента.</typeparam>
        /// <param name="data">Информация.</param>
        /// <param name="filter">Делегат фильтрации.</param>
        /// <param name="argument">Аргумент.</param>
        /// <returns>Отфильтрованная информация.</returns>
        public static List<T1> FilterData<T1, T2>(List<T1> data, Func<T1, T2, bool> filter, T2
            argument)
        {
            List<T1> result = new List<T1>();
            foreach (T1 element in data)
            {
                if (filter(element, argument))
                {
                    result.Add(element);
                }
            }
            return result;
        }

        /// <summary>
        /// Сортирует информацию по делегату.
        /// </summary>
        /// <typeparam name="T">Тип данных информации.</typeparam>
        /// <param name="data">Информация.</param>
        /// <param name="sort">Делегат сортировки.</param>
        /// <returns>Отсортированная информация.</returns>
        public static List<T> SortData<T>(List<T> data, Func<T, T, bool> sort)
        {
            List<T> result = new List<T>(data);
            for (int i = 0; i < result.Count; i++)
            {
                for (int j = 1; j < result.Count; j++)
                {
                    if (sort(result[j], result[j - 1]))
                    {
                        T temp = result[j];
                        result[j] = result[j - 1];
                        result[j - 1] = temp;
                    }
                }
            }
            return result;
        }
    }
}