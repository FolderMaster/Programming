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
        public List<Item> Items
        {
            get => ItemListControl.Items;
            set => ItemListControl.Items = value;
        }

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
        public void UpdateCustomers()
        {
            CustomerSelectorControl.RefreshData();
        }

        /// <summary>
        /// Обновляет информацию о <see cref="Items"/>.
        /// </summary>
        public void UpdateItems()
        {
            ItemListControl.UpdateList();
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            CartEditorControl.AddItem(ItemListControl.Items[ItemListControl.SelectedIndex]);
            CartEditorControl.UpdateCart();
        }

        private void CustomerSelectorControl_SelectedCustomerChanged(object sender, EventArgs e)
        {
            CartEditorControl.Customer = CustomerSelectorControl.SelectedCustomer;
        }
    }
}