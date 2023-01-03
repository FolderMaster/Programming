using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;

namespace ObjectOrientedPractics.View.Controls.DiscountControls
{
    /// <summary>
    /// Элемент управления для выбора скидок <see cref="IDiscount"/>.
    /// </summary>
    public partial class DiscountCheckListControl : UserControl
    {
        /// <summary>
        /// Источник данных для <see cref="ListBox"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Список информации о скидках.
        /// </summary>
        private List<string> _infoList = new List<string>();

        /// <summary>
        /// Список скидок.
        /// </summary>
        private List<IDiscount> _discounts = null;

        /// <summary>
        /// Список товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Размер скидок.
        /// </summary>
        private int _discountAmount = 0;

        /// <summary>
        /// Возращает и задаёт список скидок.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<IDiscount> Discounts
        {
            get => _discounts;
            set
            {
                _discounts = value;
                if (Discounts == null)
                {
                    ClearInfo();
                }
                else
                {
                    UpdateCheckedListBox();
                }
            }
        }

        /// <summary>
        /// Возращает и задаёт список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => _items;
            set
            {
                _items = value;
                DiscountAmount = CalculateDiscounts();
            }
        }

        /// <summary>
        /// Возращает и задаёт размер скидок.
        /// </summary>
        public int DiscountAmount
        {
            get => _discountAmount;
            private set
            {
                if(DiscountAmount != value)
                {
                    _discountAmount = value;
                    DiscountAmountChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Обработчик события изменения размера скидки.
        /// </summary>
        public event EventHandler DiscountAmountChanged;

        /// <summary>
        /// Создаёт экземляр класса <see cref="DiscountCheckListControl"/> по умолчанию.
        /// </summary>
        public DiscountCheckListControl()
        {
            InitializeComponent();

            CheckedListBox.DataSource = _bindingSource;
            _bindingSource.DataSource = _infoList;
        }

        /// <summary>
        /// Очищает содержимое <see cref="CheckedListBox"/>.
        /// </summary>
        private void ClearInfo()
        {
            _infoList.Clear();
            _bindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Рассчитывает размер выделенных скидок.
        /// </summary>
        /// <returns>Возращает размер скидок.</returns>
        private int CalculateDiscounts()
        {
            int result = 0;
            foreach(int index in CheckedListBox.CheckedIndices)
            {
                result += Discounts[index].Calculate(Items);
            }
            return result;
        }

        /// <summary>
        /// Обновить содержимое <see cref="CheckedListBox"/>.
        /// </summary>
        public void UpdateCheckedListBox()
        {
            if(Discounts != null)
            {
                _infoList.Clear();
                Discounts.ForEach((d) => _infoList.Add(d.Info));
                _bindingSource.ResetBindings(false);
                for (int n = 0; n < CheckedListBox.Items.Count; ++n)
                {
                    CheckedListBox.SetItemChecked(n, true);
                }
                DiscountAmount = CalculateDiscounts();
            }
        }

        /// <summary>
        /// Применяет размер выделенных скидок.
        /// </summary>
        /// <returns>Возращает размер скидок.</returns>
        public int ApplyDiscounts()
        {
            int result = 0;
            foreach (int index in CheckedListBox.CheckedIndices)
            {
                result += Discounts[index].Apply(Items);
            }
            return result;
        }

        /// <summary>
        /// Обновляет скидки.
        /// </summary>
        public void UpdateDiscounts()
        {
            foreach(IDiscount discount in Discounts)
            {
                discount.Update(Items);
            }
        }

        private void CheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DiscountAmount = CalculateDiscounts();
        }

        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            DiscountAmount = CalculateDiscounts();
        }
    }
}