using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services.Factories;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для работы со списком <see cref="Item"/>.
    /// </summary>
    public partial class ItemListControl : UserControl
    {
        /// <summary>
        /// Источник данных для <see cref="ListBox"/>.
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
        /// Отображаются ли кнопки для редактирования.
        /// </summary>
        private bool _isEditor = true;

        /// <summary>
        /// Отображаются ли кнопки для добавления.
        /// </summary>
        private bool _isAdding = true;

        /// <summary>
        /// Отображаются ли кнопки для удаления.
        /// </summary>
        private bool _isRemoving = true;

        /// <summary>
        /// Возвращает и задаёт индекс выбранного экземпляра класса <see cref="Item"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get => _selectedIndex;
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
            get => _items;
            set
            {
                _items = value;
                _bindingSource.DataSource = _items;

                UpdateList();
                SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Возращает или задаёт отображаются ли кнопки для редактирования.
        /// </summary>
        public bool IsEditor
        {
            get => _isEditor;
            set
            {
                _isEditor = value;
                if (IsAdding && IsEditor)
                {
                    AddButton.Visible = true;
                    AddEmptyButton.Visible = true;
                }
                else
                {
                    AddButton.Visible = false;
                    AddEmptyButton.Visible = false;
                }

                if (IsRemoving && IsEditor)
                {
                    RemoveButton.Visible = true;
                    ClearAllButton.Visible = true;
                }
                else
                {
                    RemoveButton.Visible = false;
                    ClearAllButton.Visible = false;
                }

                if (IsEditor)
                {
                    ListBox.Dock = DockStyle.None;
                }
                else
                {
                    ListBox.Dock = DockStyle.Fill;
                }
            }
        }

        /// <summary>
        /// Возращает или задаёт отображаются ли кнопки для добавления.
        /// </summary>
        public bool IsAdding
        {
            get => _isAdding;
            set
            {
                _isAdding = value;
                if (IsAdding && IsEditor)
                {
                    AddButton.Visible = true;
                    AddEmptyButton.Visible = true;
                }
                else
                {
                    AddButton.Visible = false;
                    AddEmptyButton.Visible = false;
                }
            }
        }

        /// <summary>
        /// Возращает или задаёт отображаются ли кнопки для удаления.
        /// </summary>
        public bool IsRemoving
        {
            get => _isRemoving;
            set
            {
                _isRemoving = value;
                if (IsRemoving && IsEditor)
                {
                    RemoveButton.Visible = true;
                    ClearAllButton.Visible = true;
                }
                else
                {
                    RemoveButton.Visible = false;
                    ClearAllButton.Visible = false;
                }
            }
        }

        /// <summary>
        /// Обработчик для события изменения индекса выбранного в списке элементов
        /// <see cref="ListBox"/>.
        /// </summary>
        public event EventHandler ListBoxSelectedIndexChanged;

        /// <summary>
        /// Обработчик для события удаления элемента из <see cref="Items"/>.
        /// </summary>
        public event EventHandler RemoveFromItems;

        /// <summary>
        /// Обработчик для события добавления элемента в <see cref="Items"/>.
        /// </summary>
        public event EventHandler AddToItems;

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

        private void AddEmptyButton_Click(object sender, EventArgs e)
        {
            Items.Add(new Item());
            UpdateListWithSort();
            if (Items.Count == 1)
            {
                SelectedIndex = 0;
            }
            AddToItems?.Invoke(this, EventArgs.Empty);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Items.Add(ItemFactory.CreateItem());
            UpdateListWithSort();
            if (Items.Count == 1)
            {
                SelectedIndex = 0;
            }
            AddToItems?.Invoke(this, EventArgs.Empty);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Items.Count != 0)
            {
                Items.RemoveAt(SelectedIndex);
                UpdateList();
                RemoveFromItems?.Invoke(this, EventArgs.Empty);
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            Items.Clear();
            UpdateList();
            RemoveFromItems?.Invoke(this, EventArgs.Empty);
        }
    }
}