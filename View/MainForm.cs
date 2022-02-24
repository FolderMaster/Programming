using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming
{
    public partial class MainForm : Form
    {
        public enum Enums
        {
            Weekday,
            Genre,
            Colour,
            Studyform,
            SmartphoneManufacturers,
            Season
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumListBox.Items.AddRange(Enum.GetNames(typeof(Enums)));
            EnumListBox.SelectedIndex = 0;

            SeasonComboBox.Items.AddRange(Enum.GetNames(typeof(Season)));
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueListBox.Items.Clear();
            switch((Enums)EnumListBox.SelectedIndex)
            {
                case Enums.Weekday:
                    ValueListBox.Items.AddRange(Enum.GetNames(typeof(Weekday)));
                    break;
                case Enums.Genre:
                    ValueListBox.Items.AddRange(Enum.GetNames(typeof(Genre)));
                    break;
                case Enums.Colour:
                    ValueListBox.Items.AddRange(Enum.GetNames(typeof(Colour)));
                    break;
                case Enums.Studyform:
                    ValueListBox.Items.AddRange(Enum.GetNames(typeof(Studyform)));
                    break;
                case Enums.SmartphoneManufacturers:
                    ValueListBox.Items.AddRange(Enum.GetNames(typeof(SmartphoneManufacturers)));
                    break;
                case Enums.Season:
                    ValueListBox.Items.AddRange(Enum.GetNames(typeof(Season)));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ValueListBox.SelectedIndex.ToString();
        }

        private void WeekParseButton_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(WeekParseTextBox.Text, out day))
            {
                WeekParseLabel.Text = $"This day of week ({(int)day + 1} = {day.ToString()}).";
            }
            else
            {
                WeekParseLabel.Text = "There isn't such day in week!";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch ((Season)SeasonComboBox.SelectedIndex)
            {
                case Season.Winter:
                    MessageBox.Show("Br-r-r! Coldly!", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    break;
                case Season.Spring:
                    BackColor = Color.LightGreen;
                    break;
                case Season.Summer:
                    MessageBox.Show("Hooray! Sun!", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    break;
                case Season.Autumn:
                    BackColor = Color.Orange;
                    break;
                default:
                    MessageBox.Show("Not selected season!", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}