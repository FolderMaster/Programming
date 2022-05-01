using System;
using System.Windows.Forms;

using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class WeekdayParsingControl : UserControl
    {
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
