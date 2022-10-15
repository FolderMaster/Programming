using System;
using Programming.Model.Enums;
namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит информацию студента о предмете: название, количество часов, оценку, дату экзамена.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        private uint _hours;

        /// <summary>
        /// Возвращает и задаёт название.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задаёт количество часов. Должно быть неотрицательным числом.
        /// </summary>
        public int Hours
        {
            get
            {
                return (int)_hours;
            }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Hours));
                _hours = (uint)value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт оценку.
        /// </summary>
        public Mark Mark { get; set; }

        /// <summary>
        /// Возвращает и задаёт дату экзамена.
        /// </summary>
        public DateTime ExamDate { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/> по умолчанию.
        /// </summary>
        public Subject()
        {
            Name = "";
            Hours = 1;
            Mark = Mark.None;
            ExamDate = new DateTime();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name">Название.</param>
        /// <param name="hours">Количество часов. Должно быть неотрицательным числом.</param>
        /// <param name="mark">Оценка.</param>
        /// <param name="examDate">Дата экзамена.</param>
        public Subject(string name, int hours, Mark mark, DateTime examDate)
        {
            Name = name;
            Hours = hours;
            Mark = mark;
            ExamDate = examDate;
        }
    }
}