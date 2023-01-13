using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.View.Controls.Enums;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services.Factories;
using ObjectOrientedPractics.View.Controls.ItemControls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент управления для работы с классом <see cref="Customer"/>.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Возращает и задаёт список экземпляров класса <see cref="Customer"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => CustomerListControl.Customers;
            set => CustomerListControl.Customers = value;
        }

        /// <summary>
        /// Возращает и задаёт список экземпляров класса <see cref="Item"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items { get; set; } = new List<Item>();

        /// <summary>
        /// Обработчик для события изменения списка <see cref="Customers"/>.
        /// </summary>
        public event EventHandler CustomersChanged;

        /// <summary>
        /// Обработчик для события создания заказа.
        /// </summary>
        public event EventHandler OrderCreated;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomersTab"/> по-умолчанию.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomerListControl_ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            CustomerEditorControl.Customer = CustomerListControl.SelectedCustomer;
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CustomerListControl_RemoveButtonClick(object sender, EventArgs e)
        {
            CustomerEditorControl.Customer = CustomerListControl.SelectedCustomer;
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CustomerEditorControl_CurrentPropertyChanged(object sender, EventArgs e)
        {
            CustomerListControl.UpdateList();
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        private void CustomerListControl_AddButtonClick(object sender, EventArgs e)
        {
            CustomersChanged?.Invoke(this, EventArgs.Empty);
        }

        private void GenerateOrderButton_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerEditorControl.Customer;
            if(customer != null && Items.Count != 0)
            {
                customer.Orders.Add(OrderFactory.CreateOrder(Items, Customers, 
                    customer.IsPriority));
                OrderCreated?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}