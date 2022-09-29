using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace ObjectOrientedPractics.Services.IO
{
    /// <summary>
    /// Предоставляет методы Csv-десериализации данных из файла.
    /// </summary>
    public static class CsvManager
    {
        /// <summary>
        /// Делегат чтения объекта из файла.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="reader">Считыватель информации.</param>
        /// <returns>Прочитанный объект данных.</returns>
        public delegate T ReadObject<T>(CsvReader reader);

        /// <summary>
        /// Загружает данные из Csv-файла.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="filePath">Путь к файлу.</param>
        /// <param name="read">Делегат чтения объекта.</param>
        /// <returns>Список объектов данных.</returns>
        public static List<T> Load<T>(string filePath, ReadObject<T> read)
        {
            List<T> result = new List<T>();
            using (StreamReader streamReader = new StreamReader(filePath, Encoding.UTF8))
            {
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Encoding = Encoding.UTF8,
                    Delimiter = ","
                };

                using (CsvReader reader = new CsvReader(streamReader, configuration))
                {
                    reader.Read();
                    reader.ReadHeader();
                    while (reader.Read())
                    {
                        result.Add(read(reader));
                    }
                }
            }
            return result;
        }
    }
}