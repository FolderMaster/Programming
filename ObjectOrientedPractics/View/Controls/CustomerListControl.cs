using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для работы со списком <see cref="Customer"/>.
    /// </summary>
    public partial class CustomerListControl : UserControl
    {
        /// <summary>
        /// Источник данных для формы <see cref="ListBox"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Индекс выбранного экземпляра класса <see cref="Customer"/>.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Cписок экземпляров класса <see cref="Customer"/>.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Возвращает и задаёт индекс выбранного экземпляра класса <see cref="Customer"/>.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                if (value < ListBox.Items.Count)
                {
                    _selectedIndex = value;
                    ListBox.SelectedIndex = value;
                    ListBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт список экземпляров класса <see cref="Customer"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
                _bindingSource.DataSource = _customers;

                UpdateList();
                SelectedIndex = 0;
            }
        }

        // <summary>
        /// Обработчик для события изменения индекса выбранного в списке элементов
        /// <see cref="ListBox"/>.
        /// </summary>
        public event EventHandler ListBoxSelectedIndexChanged;

        /// <summary>
        /// Обработчик для события нажатия на кнопку <see cref="RemoveButton"/>.
        /// </summary>
        public event EventHandler RemoveButtonClick;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomerListControl"/> по-умолчанию.
        /// </summary>
        public CustomerListControl()
        {
            InitializeComponent();

            Customers = new List<Customer>();
            ListBox.DataSource = _bindingSource;
        }

        /// <summary>
        /// Обновляет информацию списка <see cref="Customers"/>.
        /// </summary>
        public void UpdateList()
        {
            _bindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Обновляет с сортировкой информацию списка <see cref="Customers"/>.
        /// </summary>
        public void UpdateListWithSort()
        {
            Customer item = null;
            if (SelectedIndex != -1)
            {
                item = Customers[SelectedIndex];
            }
            SortCustomers();
            _bindingSource.ResetBindings(false);
            if (SelectedIndex != -1)
            {
                SelectedIndex = Customers.IndexOf(item);
            }
        }

        /// <summary>
        /// Сортировка по <see cref="Customer.FullName"/> в алфавитном порядке списка
        /// <see cref="Customers"/>.
        /// </summary>
        private void SortCustomers()
        {
            Customers.Sort((a, b) => string.Compare(a.FullName, b.FullName));
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = ListBox.SelectedIndex;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customers.Add(new Customer());
            UpdateListWithSort();
            if (Customers.Count == 1)
            {
                SelectedIndex = 0;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Customers.Count != 0)
            {
                Customers.RemoveAt(SelectedIndex);
                UpdateList();
                RemoveButtonClick?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}