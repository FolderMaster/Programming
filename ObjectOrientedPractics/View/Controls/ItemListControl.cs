using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для работы со списком <see cref="Item"/>.
    /// </summary>
    public partial class ItemListControl : UserControl
    {
        /// <summary>
        /// Источник данных для формы <see cref="ListBox"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Индекс выбранного экземпляра класса <see cref="Item"/>.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Cписок экземпляров класса <see cref="Item"/>.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возвращает и задаёт индекс выбранного экземпляра класса <see cref="Item"/>.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                if(value < ListBox.Items.Count)
                {
                    _selectedIndex = value;
                    ListBox.SelectedIndex = value;
                    ListBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт список экземпляров класса <see cref="Item"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
                _bindingSource.DataSource = _items;

                UpdateList();
                SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Обработчик для события изменения индекса выбранного в списке элементов
        /// <see cref="ListBox"/>.
        /// </summary>
        public event EventHandler ListBoxSelectedIndexChanged;

        /// <summary>
        /// Обработчик для события нажатия на кнопку <see cref="RemoveButton"/>.
        /// </summary>
        public event EventHandler RemoveButtonClick;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ItemListControl"/> по-умолчанию.
        /// </summary>
        public ItemListControl()
        {
            InitializeComponent();

            Items = new List<Item>();
            ListBox.DataSource = _bindingSource;
        }

        /// <summary>
        /// Обновляет информацию списка <see cref="Items"/>.
        /// </summary>
        public void UpdateList()
        {
            _bindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Обновляет с сортировкой информацию списка <see cref="Items"/>.
        /// </summary>
        public void UpdateListWithSort()
        {
            Item item = null;
            if (SelectedIndex != -1)
            {
                item = Items[SelectedIndex];
            }
            SortItems();
            _bindingSource.ResetBindings(false);
            if (SelectedIndex != -1)
            {
                SelectedIndex = Items.IndexOf(item);
            }
        }

        /// <summary>
        /// Сортировка по названию<see cref="Item.Name"/> в алфавитном порядке списка
        /// <see cref="Items"/>.
        /// </summary>
        private void SortItems()
        {
            Items.Sort((a, b) => string.Compare(a.Name, b.Name));
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = ListBox.SelectedIndex;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Items.Add(new Item());
            UpdateListWithSort();
            if (Items.Count == 1)
            {
                SelectedIndex = 0;
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Items.Count != 0)
            {
                Items.RemoveAt(SelectedIndex);
                UpdateList();
                RemoveButtonClick?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}