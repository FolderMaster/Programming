using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент управления для работы с <see cref="PointsDiscount"/> и 
    /// <see cref="PercentDiscount"/>.
    /// </summary>
    public partial class DiscountsTab : UserControl
    {
        /// <summary>
        /// Возращает и задаёт список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => ItemListControl.Items;
            set => ItemListControl.Items = value;
        }

        /// <summary>
        /// Создаёт экземляр класса <see cref="DiscountsTab"/> по умолчанию.
        /// </summary>
        public DiscountsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет список товаров.
        /// </summary>
        public void RefreshItems()
        {
            ItemListControl.UpdateList();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemListControl.SelectedItem != null)
            {
                DiscountsTestControl.AddItem(ItemListControl.SelectedItem);
                DiscountsTestControl.RefreshItems();
            }
        }
    }
}