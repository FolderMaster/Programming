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
        private static readonly IdGenerator _idGenerator = new IdGenerator();

        /// <summary>
        /// Уникальный индентификатор экземпляра класса.
        /// </summary>
        private readonly int _id = _idGenerator.GetNextId();

        /// <summary>
        /// Название.
        /// </summary>
        private string _name = "";

        /// <summary>
        /// Описание.
        /// </summary>
        private string _info = "";

        /// <summary>
        /// Стоимость.
        /// </summary>
        private int _cost = 0;

        /// <summary>
        /// Максимальная длина <see cref="Name"/>.
        /// </summary>
        public static int MaxNameLength { get; } = 200;

        /// <summary>
        /// Максимальная длина <see cref="Info"/>.
        /// </summary>
        public static int MaxInfoLength { get; } = 1000;

        /// <summary>
        /// Верхняя граница для <see cref="Cost"/>.
        /// </summary>
        public static int CostMax { get; } = 100000;

        /// <summary>
        /// Нижняя граница для <see cref="Cost"/>.
        /// </summary>
        public static int CostMin { get; } = 0;

        /// <summary>
        /// Возвращает уникальный индентификатор экземпляра класса.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает и задаёт название. Длина строки должна быть не больше 
        /// <see cref="MaxNameLength"/>.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                ValueValidator.AssertStringOnLessLength(value, MaxNameLength, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт описание. Длина строки должна быть не больше 
        /// <see cref="MaxInfoLength"/>.
        /// </summary>
        public string Info
        {
            get => _info;
            set
            {
                ValueValidator.AssertStringOnLessLength(value, MaxInfoLength, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт стоимость. Должно быть от <see cref="CostMin"/> до
        /// <see cref="CostMax"/>.
        /// </summary>
        public int Cost
        {
            get => _cost;
            set
            {
                ValueValidator.AssertValueInRange(value, CostMin, CostMax, nameof(Cost));
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт категорию товара.
        /// </summary>
        public Category Category { get; set; } = Category.None;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/> по-умолчанию.
        /// </summary>
        public Item()
        {
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="info">Описание.</param>
        /// <param name="cost">Стоимость.</param>
        /// <param name="category">Категория.</param>
        public Item(string name, string info, int cost, Category category)
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name} ({Id}) - {Cost}";
        }
    }
}