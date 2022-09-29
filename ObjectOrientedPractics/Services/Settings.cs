using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Настройки приложения.
    /// </summary>
    public static class Settings
    {
        /// <summary>
        /// Путь к файлу сохранения.
        /// </summary>
        public static string SavePath { get; } = "Save.txt";

        /// <summary>
        /// Путь к файлу хранения <see cref="Item"/>.
        /// </summary>
        public static string ItemsPath { get; } = "Items.csv";

        /// <summary>
        /// Путь к файлу хранения <see cref="Customer"/>.
        /// </summary>
        public static string CustomersPath { get; } = "Customers.csv";
    }
}