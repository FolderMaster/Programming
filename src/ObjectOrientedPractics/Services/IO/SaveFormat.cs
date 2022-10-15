using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services.IO
{
    /// <summary>
    /// Формат файла сохранения с нужными данными.
    /// </summary>
    public class SaveFormat
    {
        /// <summary>
        /// Магазин.
        /// </summary>
        private Store _store;

        /// <summary>
        /// Возращает и задаёт магазин.
        /// </summary>
        public Store Store
        {
            get => _store;
            set => _store = value;
        }


        /// <summary>
        /// Создаёт экземпляр класса <see cref="SaveFormat"/> по-умолчанию.
        /// </summary>
        public SaveFormat()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="SaveFormat"/>.
        /// </summary>
        /// <param name="store">Магазин.</param>
        public SaveFormat(Store store)
        {
            Store = store;
        }
    }
}