using System;
using System.Windows.Forms;

using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент управления для добавления скидки <see cref="PercentDiscount"/>.
    /// </summary>
    public partial class AddDiscountTab : UserControl
    {
        /// <summary>
        /// Возращает выбранную категорию товара.
        /// </summary>
        public ItemCategory Category
        {
            get => (ItemCategory)ComboBox.SelectedItem;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AddDiscountTab"/> по умолчанию.
        /// </summary>
        public AddDiscountTab()
        {
            InitializeComponent();

            ComboBox.DataSource = Enum.GetValues(typeof(ItemCategory));
        }
    }
}