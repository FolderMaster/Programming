namespace View.Model
{
    /// <summary>
    /// Класс присвоения.
    /// </summary>
    interface IAssignable
    {
        /// <summary>
        /// Присваивает объект текущему экземпляру.
        /// </summary>
        /// <param name="obj">Объект присвоения.</param>
        void Assign(object obj);
    }
}