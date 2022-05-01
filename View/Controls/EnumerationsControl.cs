using System;
using System.Windows.Forms;

using Programming.Model.Enums;

namespace Programming.View.Controls
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();

            EnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsEnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((Enums)EnumsListBox.SelectedItem)
            {
                case Enums.Weekday:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Genre:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Colour:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Colour));
                    break;
                case Enums.StudyForm:
                    ValueListBox.DataSource = Enum.GetValues(typeof(StudyForm));
                    break;
                case Enums.SmartphoneManufacturers:
                    ValueListBox.DataSource = Enum.GetValues(typeof(SmartphoneManufacturers));
                    break;
                case Enums.Season:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void EnumsValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ((int)ValueListBox.SelectedItem).ToString();
        }
    }
}
