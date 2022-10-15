using System;
using System.Windows.Forms;

using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.Model;
using System.Collections.Generic;

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
        public List<Customer> Customers
        {
            get => CustomerListControl.Customers;
            set => CustomerListControl.Customers = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomersTab"/> по-умолчанию.
        /// </summary>
        public CustomersTab()
        {
            InitializeComponent();
        }

        private void CustomerListControl_ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomerListControl.SelectedIndex != -1)
            {
                CustomerEditorControl.Customer = CustomerListControl.Customers
                    [CustomerListControl.SelectedIndex];
            }
            else
            {
                CustomerEditorControl.Customer = null;
            }
        }

        private void CustomerListControl_RemoveButtonClick(object sender, EventArgs e)
        {
            if (CustomerListControl.SelectedIndex != -1)
            {
                CustomerEditorControl.Customer = CustomerListControl.Customers
                    [CustomerListControl.SelectedIndex];
            }
        }

        private void CustomerEditorControl_CurrentPropertyChanged(object sender, EventArgs e)
        {
            switch (CustomerEditorControl.UpdateMode)
            {
                case UpdateType.UpdateCurrentObject:
                    CustomerListControl.UpdateList();
                    break;
                case UpdateType.UpdateList:
                    CustomerListControl.UpdateListWithSort();
                    break;
            }
        }
    }
}