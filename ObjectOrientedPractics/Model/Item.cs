using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Товар с названием, описанием и стоимостью.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Генератор уникального индентификатора экземпляра класса.
        /// </summary>
        private static IdGenerator _idGenerator = new IdGenerator();

        /// <summary>
        /// Уникальный индентификатор экземпляра класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание.
        /// </summary>
        private string _info;

        /// <summary>
        /// Стоимость.
        /// </summary>
        private int _cost;

        /// <summary>
        /// Возвращает уникальный индентификатор экземпляра класса.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает и задаёт название. Длина строки должна быть не больше 200 символов.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                Validator.AssertStringOnLessLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт описание. Длина строки должна быть не больше 1000 символов.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                Validator.AssertStringOnLessLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость. Должно быть от 0 до 100000.
        /// </summary>
        public int Cost
        {
            get => _cost;
            set
            {
                Validator.AssertValueInRange(value, 0, 100000, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/> по-умолчанию.
        /// </summary>
        public Item()
        {
            _id = _idGenerator.GetNextId();
            Name = "";
            Info = "";
            Cost = 0;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="info">Описание.</param>
        /// <param name="cost">Стоимость.</param>
        public Item(string name, string info, int cost)
        {
            _id = _idGenerator.GetNextId();
            Name = name;
            Info = info;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Cost}";
        }
    }
}