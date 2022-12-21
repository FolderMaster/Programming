using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для работы с <see cref="PercentDiscount"/>.
    /// </summary>
    public partial class PercentDiscountControl : UserControl
    {
        /// <summary>
        /// Процентная скидка.
        /// </summary>
        private PercentDiscount _percentDiscount = new PercentDiscount();

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Скидка.
        /// </summary>
        private int _discount = 0;

        /// <summary>
        /// Возращает и задаёт список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => _items;
            set => _items = value;
        }

        /// <summary>
        /// Возращает и задаёт скидку.
        /// </summary>
        public int Discount
        {
            get => _discount;
            set
            {
                _discount = value;
                UpdateDiscountLabel();
            }
        }

        /// <summary>
        ///  Обработчик события при использовании <see cref="PercentDiscount.Apply(List{Item})"/>.
        /// </summary>
        public event EventHandler Applied;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PercentDiscountControl"/> по умолчанию.
        /// </summary>
        public PercentDiscountControl()
        {
            InitializeComponent();

            UpdateInfoLabel();
            UpdateDiscountLabel();
        }

        /// <summary>
        /// Обновляет скидку в метке.
        /// </summary>
        private void UpdateDiscountLabel()
        {
            DiscountAmountLabel.Text = $"Discount amount: {Discount}";
        }

        /// <summary>
        /// Обновляет информацию в метке.
        /// </summary>
        private void UpdateInfoLabel()
        {
            InfoLabel.Text = $"Info: {_percentDiscount.Info}";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Discount = _percentDiscount.Calculate(Items);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Discount = _percentDiscount.Apply(Items);
            Applied?.Invoke(this, EventArgs.Empty);
        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            _percentDiscount.Update(Items);
            UpdateInfoLabel();
        }
    }
}