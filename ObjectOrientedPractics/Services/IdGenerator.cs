namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Генератор уникальных индентификаторов.
    /// </summary>
    public class IdGenerator
    {
        /// <summary>
        /// Новый уникальный индентификатор.
        /// </summary>
        int _newId = 0;

        /// <summary>
        /// Возращает новый уникальный индентификатор.
        /// </summary>
        public int NewId
        {
            get => _newId;
            private set => _newId = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="IdGenerator"/> по-умолчанию.
        /// </summary>
        public IdGenerator()
        {
            NewId = 0;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="IdGenerator"/>.
        /// </summary>
        /// <param name="beginId">Начальное значение уникального индентификатора.</param>
        public IdGenerator(int beginId)
        {
            NewId = beginId;
        }

        /// <summary>
        /// Создаёт новый уникальный индентификатор.
        /// </summary>
        /// <returns>Уникальный индентификатор.</returns>
        public int GetNextId()
        {
            return NewId++;
        }
    }
}