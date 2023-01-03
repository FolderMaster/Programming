using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент управления для работы с классом <see cref="PriorityOrder"/>.
    /// </summary>
    public partial class PriorityOrdersTab : UserControl
    {
        /// <summary>
        /// Генератор псевдослучайных чисел.
        /// </summary>
        private Random _random = new Random();

        /// <summary>
        /// Возращает или задаёт список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => ItemListControl.Items;
            set => ItemListControl.Items = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrdersTab"/>.
        /// </summary>
        public PriorityOrdersTab()
        {
            InitializeComponent();

            PriorityOrderCreatorControl.PriorityOrder = new PriorityOrder(new List<Item>(), new 
                Adress(), OrderStatus.New, 0, DateTime.UtcNow, PriorityOrder.DeliveryTimes[0]);
        }

        /// <summary>
        /// Обносляет список товаров.
        /// </summary>
        public void RefreshItems()
        {
            ItemListControl.UpdateList();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemListControl.SelectedIndex != -1)
            {
                PriorityOrderCreatorControl.AddItem(Items[ItemListControl.SelectedIndex]);
                PriorityOrderCreatorControl.RefreshPriorityOrder();
            }
        }

        private void RandomlyAddToCartButton_Click(object sender, EventArgs e)
        {
            if (ItemListControl.SelectedIndex != -1)
            {
                PriorityOrderCreatorControl.AddItem(Items[_random.Next(Items.Count)]);
                PriorityOrderCreatorControl.RefreshPriorityOrder();
            }
        }
    }
}