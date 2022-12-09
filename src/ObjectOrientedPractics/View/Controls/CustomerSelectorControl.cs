using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для выбора экземпляра класса <see cref="Customer"/>.
    /// </summary>
    public partial class CustomerSelectorControl : UserControl
    {
        /// <summary>
        /// Источник данных для формы <see cref="ComboBox"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _selectedCustomer = null;

        /// <summary>
        /// Возращает и задаёт список покупателей.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                _bindingSource.DataSource = Customers;
                if(Customers.Count > 0)
                {
                    SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Возращает и задаёт выбранного покупателя <see cref="ComboBox"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            private set
            {
                if(value != _selectedCustomer)
                {
                    _selectedCustomer = value;
                    SelectedCustomerChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возращает и задаёт выбранный индекс <see cref="ComboBox"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get => ComboBox.SelectedIndex;
            set
            {
                ComboBox.SelectedIndex = value;
                SelectedCustomer = (Customer)ComboBox.SelectedItem;
            }
        }

        /// <summary>
        /// Обработчик события при изменении <see cref="SelectedCustomer"/>.
        /// </summary>
        public event EventHandler SelectedCustomerChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomerSelectorControl"/> по-умолчанию.
        /// </summary>
        public CustomerSelectorControl()
        {
            InitializeComponent();

            ComboBox.DataSource = _bindingSource;
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        public void RefreshData()
        {
            _bindingSource.ResetBindings(false);
            SelectedCustomer = (Customer)ComboBox.SelectedItem;
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedCustomer = (Customer)ComboBox.SelectedItem;
        }
    }
}