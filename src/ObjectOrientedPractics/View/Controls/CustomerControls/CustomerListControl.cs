using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Services.Factories;
using ObjectOrientedPractics.View.Controls.Enums;

namespace ObjectOrientedPractics.View.Controls.CustomerControls
{
    /// <summary>
    /// Элемент управления для работы со списком <see cref="Customer"/>.
    /// </summary>
    public partial class CustomerListControl : UserControl
    {
        /// <summary>
        /// Источник данных для <see cref="ListBox"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Cписок экземпляров класса <see cref="Customer"/>.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Список отображаемых покупателей.
        /// </summary>
        private List<Customer> _displayedCustomers = new List<Customer>();

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _selectedCustomer = null;

        /// <summary>
        /// Возвращает и задаёт индекс выбранного экземпляра класса <see cref="Customer"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get => ListBox.SelectedIndex;
            set
            {
                if (value != -1 && value < ListBox.Items.Count)
                {
                    ListBox.SelectedIndex = value;
                    SelectedCustomer = _displayedCustomers[SelectedIndex];
                }
                else if (value == -1)
                {
                    SelectedCustomer = null;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт выбранного покупателя.
        /// </summary>
        public Customer SelectedCustomer
        {
            get => _selectedCustomer;
            set
            {
                if (value != _selectedCustomer)
                {
                    _selectedCustomer = value;
                    SelectedCustomerChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт список экземпляров класса <see cref="Customer"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;

                UpdateList();
            }
        }

        /// <summary>
        /// Обработчик для события изменения выбранного покупателя.
        /// </summary>
        public event EventHandler SelectedCustomerChanged;

        /// <summary>
        /// Обработчик для события удаления элемента из <see cref="Customers"/>.
        /// </summary>
        public event EventHandler RemoveFromCustomers;

        /// <summary>
        /// Обработчик для события добавления элемента в <see cref="Customers"/>.
        /// </summary>
        public event EventHandler AddToCustomers;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomerListControl"/> по-умолчанию.
        /// </summary>
        public CustomerListControl()
        {
            InitializeComponent();

            OrderByComboBox.DataSource = Enum.GetValues(typeof(CustomerSortStatus));
            ListBox.DataSource = _bindingSource;
        }

        /// <summary>
        /// Фильтарует покупателей по подстроке имени.
        /// </summary>
        /// <param name="customer">Покупатель.</param>
        /// <param name="text">Подстрока имени.</param>
        /// <returns>Логическое значение, указывающее, что подстрока названия содержится в названии
        /// покупателей.</returns>
        private static bool FilterCustomerByFullName(Customer customer, string text)
        {
            return customer.FullName.IndexOf(text, StringComparison.OrdinalIgnoreCase) != -1;
        }

        /// <summary>
        /// Указывает нужно ли оставлять покупателя по приоритетности.
        /// </summary>
        /// <param name="customer">Покупатель.</param>
        /// <param name="isPriority">Приоритетность покупателей.</param>
        /// <returns>Логическое значение, указывающее, что покупатель обладает данной
        /// приоритетностью.</returns>
        private static bool FilterCustomerByIsPriority(Customer customer, bool isPriority)
        {
            return customer.IsPriority == isPriority;
        }

        /// <summary>
        /// Указывает нужно ли менять покупателей для сортировки по возрастанию даты рождения.
        /// </summary>
        /// <param name="customer1">Покупатель.</param>
        /// <param name="customer2">Покупатель.</param>
        /// <returns>Логическое значение, указывающее, нужно ли менять покупателей.</returns>
        private static bool SortCustomerByBirthDateAscending(Customer customer1, Customer 
            customer2)
        {
            return customer1.BirthDate < customer2.BirthDate;
        }

        /// <summary>
        /// Указывает нужно ли менять покупателей для сортировки по возрастанию даты рождения.
        /// </summary>
        /// <param name="customer1">Покупатель.</param>
        /// <param name="customer2">Покупатель.</param>
        /// <returns>Логическое значение, указывающее, нужно ли менять покупателей.</returns>
        private static bool SortCustomerByBirthDateDescending(Customer customer1, Customer
            customer2)
        {
            return customer1.BirthDate > customer2.BirthDate;
        }

        /// <summary>
        /// Обновляет информацию списка <see cref="Customers"/>.
        /// </summary>
        public void UpdateList()
        {
            _displayedCustomers = new List<Customer>();
            if (Customers != null)
            {
                _displayedCustomers.AddRange(Customers);
                switch (OrderByComboBox.SelectedItem)
                {
                    case CustomerSortStatus.None: break;
                    case CustomerSortStatus.BirthDateAscending: _displayedCustomers = 
                            DataTools.SortData(_displayedCustomers, 
                            SortCustomerByBirthDateAscending); break;
                    case CustomerSortStatus.BirthDateDescending: _displayedCustomers =
                            DataTools.SortData(_displayedCustomers,
                            SortCustomerByBirthDateDescending); break;
                    default: throw new ArgumentException();
                }
                if(PriorityCustomersCheckBox.Checked)
                {
                    _displayedCustomers = DataTools.FilterData(_displayedCustomers,
                        FilterCustomerByIsPriority, true);
                }
                _displayedCustomers = DataTools.FilterData(_displayedCustomers,
                    FilterCustomerByFullName, FindTextBox.Text);
            }
            _bindingSource.DataSource = _displayedCustomers;
            if (_displayedCustomers.Count == 0)
            {
                SelectedIndex = -1;
            }
            else if (SelectedCustomer == null || !_displayedCustomers.Contains(SelectedCustomer))
            {
                SelectedIndex = 0;
            }
            else
            {
                SelectedIndex = _displayedCustomers.IndexOf(SelectedCustomer);
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = ListBox.SelectedIndex;
        }

        private void AddEmptyButton_Click(object sender, EventArgs e)
        {
            Customers.Add(new Customer());
            UpdateList();
            AddToCustomers?.Invoke(this, EventArgs.Empty);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customers.Add(CustomerFactory.CreateCustomer());
            UpdateList();
            AddToCustomers?.Invoke(this, EventArgs.Empty);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Customers.Count != 0)
            {
                Customers.RemoveAt(SelectedIndex);
                UpdateList();
                RemoveFromCustomers?.Invoke(this, EventArgs.Empty);
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void PriorityCustomersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}