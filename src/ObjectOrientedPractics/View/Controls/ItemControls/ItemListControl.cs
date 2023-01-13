using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Services.Factories;
using ObjectOrientedPractics.View.Controls.Enums;

namespace ObjectOrientedPractics.View.Controls.ItemControls
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
        /// Cписок экземпляров класса <see cref="Item"/>.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Список отображаемых товаров.
        /// </summary>
        private List<Item> _displayedItems = new List<Item>();

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _selectedItem = null;

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
        /// Отображаются ли элементы управления для выборки.
        /// </summary>
        private bool _isSampling = true;

        /// <summary>
        /// Возвращает и задаёт индекс выбранного экземпляра класса <see cref="Item"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        private int SelectedIndex
        {
            get => ListBox.SelectedIndex;
            set
            {
                if(value != -1 && value < ListBox.Items.Count)
                {
                    ListBox.SelectedIndex = value;
                    SelectedItem = _displayedItems[SelectedIndex];
                }
                else if (value == -1)
                {
                    SelectedItem = null;
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт выбранный товар.
        /// </summary>
        public Item SelectedItem
        {
            get => _selectedItem;
            set
            {
                if(value != _selectedItem)
                {
                    _selectedItem = value;
                    SelectedItemChanged?.Invoke(this, EventArgs.Empty);
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

                UpdateList();
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
                UpdateVisibleControl(EditorPanel, IsEditor);
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
                UpdateVisibleControl(AddButton, IsAdding);
                UpdateVisibleControl(AddEmptyButton, IsAdding);
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
                UpdateVisibleControl(RemoveButton, IsRemoving);
                UpdateVisibleControl(ClearAllButton, IsRemoving);
            }
        }

        /// <summary>
        /// Возращает или задаёт отображаются ли элементы управления для выборки.
        /// </summary>
        public bool IsSampling
        {
            get => _isSampling;
            set
            {
                _isSampling = value;
                UpdateVisibleControl(SamplingPanel, IsSampling);
            }
        }

        /// <summary>
        /// Обработчик для события изменения выбранного товара.
        /// </summary>
        public event EventHandler SelectedItemChanged;

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

            OrderByComboBox.DataSource = Enum.GetValues(typeof(ItemSortStatus));
            ListBox.DataSource = _bindingSource;
        }

        /// <summary>
        /// Фильтарует товары по подстроке названия.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <param name="text">Подстрока названия.</param>
        /// <returns>Логическое значение, указывающее, что подстрока названия содержится в названии
        /// товара.</returns>
        private static bool FilterItemByName(Item item, string text)
        {
            return item.Name.IndexOf(text, StringComparison.OrdinalIgnoreCase) != -1;
        }

        /// <summary>
        /// Указывает нужно ли менять товары для сортировки по возрастанию цены.
        /// </summary>
        /// <param name="item1">Товар.</param>
        /// <param name="item2">Товар.</param>
        /// <returns>Логическое значение, указывающее, нужно ли менять товары.</returns>
        private static bool CompareItemByNameAscending(Item item1, Item item2)
        {
            return item1.Name.CompareTo(item2.Name) < 0;
        }

        /// <summary>
        /// Указывает нужно ли менять товары для сортировки по убыванию цены.
        /// </summary>
        /// <param name="item1">Товар.</param>
        /// <param name="item2">Товар.</param>
        /// <returns>Логическое значение, указывающее, нужно ли менять товары.</returns>
        private static bool CompareItemByNameDescending(Item item1, Item item2)
        {
            return item1.Name.CompareTo(item2.Name) > 0;
        }

        /// <summary>
        /// Указывает нужно ли менять товары для сортировки в алфавитном порядке.
        /// </summary>
        /// <param name="item1">Товар.</param>
        /// <param name="item2">Товар.</param>
        /// <returns>Логическое значение, указывающее, нужно ли менять товары.</returns>
        private static bool CompareItemByCostAscending(Item item1, Item item2)
        {
            return item1.Cost < item2.Cost;
        }

        /// <summary>
        /// Указывает нужно ли менять товары для сортировки в обратном алфавитном порядке.
        /// </summary>
        /// <param name="item1">Товар.</param>
        /// <param name="item2">Товар.</param>
        /// <returns>Логическое значение, указывающее, нужно ли менять товары.</returns>
        private static bool CompareItemByCostDescending(Item item1, Item item2)
        {
            return item1.Cost > item2.Cost;
        }

        /// <summary>
        /// Обновляет видимость для элемента управления.
        /// </summary>
        /// <param name="control">Элемент управления.</param>
        /// <param name="isVisible">Логическое значение, отображается ли элемент 
        /// управления.</param>
        private void UpdateVisibleControl(Control control, bool isVisible)
        {
            if (isVisible)
            {
                control.Visible = true;
            }
            else
            {
                control.Visible = false;
            }
        }

        /// <summary>
        /// Обновляет список видимых товаров.
        /// </summary>
        public void UpdateList()
        {
            _displayedItems = new List<Item>();
            if (Items != null)
            {
                _displayedItems.AddRange(Items);
                switch (OrderByComboBox.SelectedItem)
                {
                    case ItemSortStatus.None: break;
                    case ItemSortStatus.NameAscending:
                        _displayedItems = DataTools.SortData
                            (_displayedItems, CompareItemByNameAscending); break;
                    case ItemSortStatus.NameDescending:
                        _displayedItems = DataTools.SortData
                            (_displayedItems, CompareItemByNameDescending); break;
                    case ItemSortStatus.CostAscending:
                        _displayedItems = DataTools.SortData
                            (_displayedItems, CompareItemByCostAscending); break;
                    case ItemSortStatus.CostDescending:
                        _displayedItems = DataTools.SortData
                            (_displayedItems, CompareItemByCostDescending); break;
                    default: throw new ArgumentException();
                }
                _displayedItems = DataTools.FilterData(_displayedItems, FilterItemByName,
                    FindTextBox.Text);
            }
            _bindingSource.DataSource = _displayedItems;
            if (_displayedItems.Count == 0)
            {
                SelectedIndex = -1;
            }
            else if (SelectedItem == null || !_displayedItems.Contains(SelectedItem))
            {
                SelectedIndex = 0;
            }
            else
            {
                SelectedIndex = _displayedItems.IndexOf(SelectedItem);
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = ListBox.SelectedIndex;
        }

        private void AddEmptyButton_Click(object sender, EventArgs e)
        {
            Items.Add(new Item());
            UpdateList();
            AddToItems?.Invoke(this, EventArgs.Empty);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Items.Add(ItemFactory.CreateItem());
            UpdateList();
            AddToItems?.Invoke(this, EventArgs.Empty);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Items != null)
            {
                if (Items.Count != 0)
                {
                    Items.Remove(SelectedItem);
                    UpdateList();
                    RemoveFromItems?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        private void ClearAllButton_Click(object sender, EventArgs e)
        {
            if (Items != null)
            {
                if (Items.Count != 0)
                {
                    Items.Clear();
                    UpdateList();
                    RemoveFromItems?.Invoke(this, EventArgs.Empty);
                }
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
    }
}