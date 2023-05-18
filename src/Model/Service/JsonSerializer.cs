using System.IO;
using Newtonsoft.Json;

namespace Model.Service
{
    /// <summary>
    /// Класс сериализации, представляющий методы Json-сериализации и десериализации данных в файл.
    /// </summary>
    public static class JsonSerializer
    {
        /// <summary>
        /// Настройки Json-сериализатора.
        /// </summary>
        private static readonly JsonSerializerSettings _jsonSerializerSettings =
            new JsonSerializerSettings()
            {
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                TypeNameHandling = TypeNameHandling.All
            };

        /// <summary>
        /// Проверяет существование директории, и если директория не существует, то создаёт её.
        /// </summary>
        /// <param name="directoryPath">Путь директории.</param>
        private static void CheckDirectory(string directoryPath)
        {
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);
            }
        }

        /// <summary>
        /// Загружает данные из Json-файла.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="filePath">Путь к файлу.</param>
        /// <returns>Объект данных, хранящийся в файле.</returns>
        public static T? Load<T>(string filePath)
        {
            CheckDirectory(filePath.Substring(0, filePath.LastIndexOf('\\')));
            using (FileStream fileReader = File.Open(filePath, FileMode.OpenOrCreate,
                FileAccess.ReadWrite))
            {
                byte[] arrayBytes = new byte[fileReader.Length];
                fileReader.Read(arrayBytes, 0, arrayBytes.Length);
                string text = System.Text.Encoding.Default.GetString(arrayBytes);

                return JsonConvert.DeserializeObject<T>(text, _jsonSerializerSettings);
            }
        }

        /// <summary>
        /// Сохраняет данные в Json-файл.
        /// </summary>
        /// <typeparam name="T">Тип данных.</typeparam>
        /// <param name="data">Данные.</param>
        /// <param name="filePath">Путь к файлу.</param>
        public static void Save<T>(T data, string filePath)
        {
            CheckDirectory(filePath.Substring(0, filePath.LastIndexOf('\\')));
            using (FileStream fileWriter = new FileStream(filePath, FileMode.Create,
                FileAccess.Write))
            {
                string text = JsonConvert.SerializeObject(data, _jsonSerializerSettings);

                byte[] arrayBytes = System.Text.Encoding.Default.GetBytes(text);
                fileWriter.Write(arrayBytes, 0, arrayBytes.Length);
            }
        }
    }
}