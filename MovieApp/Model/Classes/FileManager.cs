using System.IO;

using Newtonsoft.Json;

using Programming.Model.Classes;
using Programming.Model.Enums;

namespace MovieApp.Model.Classes
{
    /// <summary>
    /// Предоставляет методы сериализации и десериализации данных в файл.
    /// </summary>
    /// <typeparam name="T">Тип данных.</typeparam>
    public static class FileManager<T>
    {
        /// <summary>
        /// Загружает данные из файла.
        /// </summary>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Объект данных, хранящийся в файле.</returns>
        public static T Load(string filePath)
        {
            using (FileStream fileReader = File.Open(filePath, FileMode.OpenOrCreate))
            {
                byte[] arrayBytes = new byte[fileReader.Length];
                fileReader.Read(arrayBytes, 0, arrayBytes.Length);
                string text = System.Text.Encoding.Default.GetString(arrayBytes);

                return JsonConvert.DeserializeObject<T>(text);
            }
        }

        /// <summary>
        /// Сохраняет данные в файл.
        /// </summary>
        /// <param name="item">Данные.</param>
        /// <param name="filePath">Путь к файлу.</param>
        public static void Save(T item, string filePath)
        {
            using (FileStream fileWriter = new FileStream(filePath, FileMode.Create))
            {
                string text = JsonConvert.SerializeObject(item);

                byte[] arrayBytes = System.Text.Encoding.Default.GetBytes(text);
                fileWriter.Write(arrayBytes, 0, arrayBytes.Length);
            }
        }
    }
}
