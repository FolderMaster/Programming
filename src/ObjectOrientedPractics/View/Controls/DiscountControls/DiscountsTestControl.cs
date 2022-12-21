using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls.DiscountControls
{
    /// <summary>
    /// Элемент управления для теста <see cref="PointsDiscount"/> и <see cref="PercentDiscount"/>.
    /// </summary>
    public partial class DiscountsTestControl : UserControl
    {
        /// <summary>
        /// Стоимость товара.
        /// </summary>
        private int _amount = 0;

        /// <summary>
        /// Возращает и задаёт стоимость товара.
        /// </summary>
        public int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                UpdateAmountLabel();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="DiscountsTestControl"/> по умолчанию.
        /// </summary>
        public DiscountsTestControl()
        {
            InitializeComponent();

            PointsDiscountControl.Items = ItemListControl.Items;
            PercentDiscountControl.Items = ItemListControl.Items;
            UpdateAmountLabel();
        }

        /// <summary>
        /// Обновляет стоимость на метке.
        /// </summary>
        private void UpdateAmountLabel()
        {
            AmountLabel.Text = $"Amount: {_amount}";
        }

        /// <summary>
        /// Обновляет стоимоть товаров.
        /// </summary>
        private void UpdateItemAmount()
        {
            Amount = ItemListControl.Items.Select((i) => i.Cost).Sum();
        }

        /// <summary>
        /// Обновляет товары.
        /// </summary>
        public void RefreshItems()
        {
            ItemListControl.UpdateList();
        }

        /// <summary>
        /// Добавляет товар в список товаров.
        /// </summary>
        /// <param name="item">Товар.</param>
        public void AddItem(Item item)
        {
            ItemListControl.Items.Add(item);
            ItemListControl.UpdateList();
            UpdateItemAmount();
        }

        private void PercentDiscountControl_Applied(object sender, EventArgs e)
        {
            Amount -= PercentDiscountControl.Discount;
        }

        private void PointsDiscountControl_Applied(object sender, EventArgs e)
        {
            Amount -= PointsDiscountControl.Discount;
        }

        private void ItemListControl_RemoveFromItems(object sender, EventArgs e)
        {
            UpdateItemAmount();
        }
    }
}