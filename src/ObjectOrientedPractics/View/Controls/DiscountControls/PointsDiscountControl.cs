using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Controls.DiscountControls
{
    /// <summary>
    /// Элемент управления для работы с <see cref="PointsDiscount"/>.
    /// </summary>
    public partial class PointsDiscountControl : UserControl
    {
        /// <summary>
        /// Скидка накопительных баллов.
        /// </summary>
        private PointsDiscount _pointsDiscount = new PointsDiscount();

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
        /// Обработчик события при использовании <see cref="PointsDiscount.Apply(List{Item})"/>.
        /// </summary>
        public event EventHandler Applied;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PointsDiscountControl"/> по умолчанию.
        /// </summary>
        public PointsDiscountControl()
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
            InfoLabel.Text = $"Info: {_pointsDiscount.Info}";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Discount = _pointsDiscount.Calculate(Items);
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            Discount = _pointsDiscount.Apply(Items);
            UpdateInfoLabel();
            Applied?.Invoke(this, EventArgs.Empty);
        }

        private void UpgradeButton_Click(object sender, EventArgs e)
        {
            _pointsDiscount.Update(Items);
            UpdateInfoLabel();
        }
    }
}