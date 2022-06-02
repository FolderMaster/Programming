using System;
using System.Drawing;
using System.Windows.Forms;

using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Элемент управления для работы с перечислением <see cref="Season"/>.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="SeasonHandleControl"/>.
        /// </summary>
        public SeasonHandleControl()
        {
            InitializeComponent();

            ComboBox.DataSource = Enum.GetValues(typeof(Season));
        }

        private void EnumsSeasonButton_Click(object sender, EventArgs e)
        {
            switch ((Season)ComboBox.SelectedItem)
            {
                case Season.Winter:
                    MessageBox.Show("Br-r-r! Coldly!", "Message",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    break;
                case Season.Spring:
                    Button.BackColor = AppColors.SpringColor;
                    break;
                case Season.Summer:
                    MessageBox.Show("Hooray! Sun!", "Message",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    break;
                case Season.Autumn:
                    Button.BackColor = AppColors.AutumnColor;
                    break;
                default:
                    MessageBox.Show("Not selected season!", "Warning!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
