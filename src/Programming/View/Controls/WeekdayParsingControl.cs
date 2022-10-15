using System;
using System.Windows.Forms;

using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Элемемент управления для работы с парсингом перечисления <see cref="Weekday"/>.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="WeekdayParsingControl"/>.
        /// </summary>
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void EnumsWeekdayParseButton_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(ParseTextBox.Text, out day))
            {
                ParseLabel.Text = $"This day of week ({day} = {(int)day}).";
            }
            else
            {
                ParseLabel.Text = "There isn't such day in week!";
            }
        }
    }
}
