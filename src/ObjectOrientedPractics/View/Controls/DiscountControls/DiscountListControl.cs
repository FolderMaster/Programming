using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.View.Forms;

namespace ObjectOrientedPractics.View.Controls.DiscountControls
{
    /// <summary>
    /// Элемент управления с работой со списком скидок <see cref="IDiscount"/>.
    /// </summary>
    public partial class DiscountListControl : UserControl
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
        /// Выбранная скидка.
        /// </summary>
        private IDiscount _selectedDiscount = null;

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
                    UpdateListBox();
                }
            }
        }

        /// <summary>
        /// Возращает и задаёт выбранную скидку.
        /// </summary>
        public IDiscount SelectedDiscount
        {
            get => _selectedDiscount;
            set => _selectedDiscount = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="DiscountListControl"/> по умолчанию.
        /// </summary>
        public DiscountListControl()
        {
            InitializeComponent();

            ListBox.DataSource = _bindingSource;
            _bindingSource.DataSource = _infoList;
        }

        /// <summary>
        /// Очищает содержимое <see cref="ListBox"/>.
        /// </summary>
        private void ClearInfo()
        {
            _infoList.Clear();
            _bindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Обновить содержимое <see cref="ListBox"/>.
        /// </summary>
        public void UpdateListBox()
        {
            _infoList.Clear();
            Discounts.ForEach((d) => _infoList.Add(d.Info));
            _bindingSource.ResetBindings(false);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBox.SelectedIndex != -1)
            {
                SelectedDiscount = Discounts[ListBox.SelectedIndex];
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex != Customer.PointsDiscountIndex && 
                ListBox.SelectedIndex != Customer.BirthDateDiscountIndex && 
                Discounts != null)
            {
                Discounts.RemoveAt(ListBox.SelectedIndex);
                UpdateListBox();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (Discounts != null)
            {
                AddDiscountForm form = new AddDiscountForm();
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Discounts.Add(new PercentDiscount(form.Category, 0));
                    UpdateListBox();
                }
            }
        }
    }
}