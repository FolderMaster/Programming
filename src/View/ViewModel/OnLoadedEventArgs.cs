using System;

namespace View.ViewModel
{
    /// <summary>
    /// Аргументы обработчика события загрузки <see cref="LoadCommand{T}.OnLoaded"/>.
    /// </summary>
    /// <typeparam name="T">Тип данных.</typeparam>
    public class OnLoadedEventArgs<T> : EventArgs
    {
        /// <summary>
        /// Возвращает и задаёт данные загрузки.
        /// </summary>
        public T? Load { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OnLoadedEventArgs{T}"/>.
        /// </summary>
        /// <param name="load">Данные загрузки.</param>
        public OnLoadedEventArgs(T? load)
        {
            Load = load;
        }
    }
}