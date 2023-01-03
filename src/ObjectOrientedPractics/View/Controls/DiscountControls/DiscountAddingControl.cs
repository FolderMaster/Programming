using System;
using System.Windows.Forms;

using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Controls.DiscountControls
{
    /// <summary>
    /// Элемент управления для добавления скидки <see cref="PercentDiscount"/>.
    /// </summary>
    public partial class DiscountAddingControl : UserControl
    {
        /// <summary>
        /// Возращает выбранную категорию товара.
        /// </summary>
        public ItemCategory Category
        {
            get => (ItemCategory)ComboBox.SelectedItem;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="DiscountAddingControl"/> по умолчанию.
        /// </summary>
        public DiscountAddingControl()
        {
            InitializeComponent();

            ComboBox.DataSource = Enum.GetValues(typeof(ItemCategory));
        }
    }
}