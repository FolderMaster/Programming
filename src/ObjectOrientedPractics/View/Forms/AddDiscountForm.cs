using System.Windows.Forms;

using ObjectOrientedPractics.View.Controls.DiscountControls;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Forms
{
    /// <summary>
    /// Окно добавления скидки <see cref="PercentDiscount"/>.
    /// </summary>
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возращает выбранную категорию товара.
        /// </summary>
        public ItemCategory Category
        {
            get => AddDiscountControl.Category;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AddDiscountForm"/> по умолчанию.
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
        }
    }
}