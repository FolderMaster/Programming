using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент управления для работы с классом <see cref="Cart"/>.
    /// </summary>
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Возращает и задаёт список экземпляров класса <see cref="Customer"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => CustomerSelectorControl.Customers;
            set => CustomerSelectorControl.Customers = value;
        }


        /// <summary>
        /// Возращает и задаёт список экземпляров класса <see cref="Item"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => ItemListControl.Items;
            set => ItemListControl.Items = value;
        }

        public event EventHandler OrderCreated;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CartsTab"/> по умолчанию.
        /// </summary>
        public CartsTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о <see cref="Customers"/>.
        /// </summary>
        public void RefreshCustomers()
        {
            CustomerSelectorControl.RefreshData();
        }

        /// <summary>
        /// Обновляет информацию о <see cref="Items"/>.
        /// </summary>
        public void RefreshItems()
        {
            ItemListControl.UpdateList();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if(ItemListControl.SelectedIndex != -1)
            {
                CartEditorControl.AddItem(ItemListControl.Items[ItemListControl.SelectedIndex]);
                CartEditorControl.RefreshCart();
            }
        }

        private void CustomerSelectorControl_SelectedCustomerChanged(object sender, EventArgs e)
        {
            CartEditorControl.Customer = CustomerSelectorControl.SelectedCustomer;
        }

        private void CartEditorControl_OrderCreated(object sender, EventArgs e)
        {
            OrderCreated?.Invoke(this, EventArgs.Empty);
        }
    }
}