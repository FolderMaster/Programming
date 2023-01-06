using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls.InterfaceControls
{
    /// <summary>
    /// Элемент управления для работы с интерфейсом <see cref="IComparable{T}"/> на примере 
    /// <see cref="Item"/>.
    /// </summary>
    public partial class IComparableControl : UserControl
    {
        /// <summary>
        /// Cписок товаров.
        /// </summary>
        private List<Item> _items = new List<Item>();

        /// <summary>
        /// Возращает и задаёт список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => ItemListControl.Items;
            set
            {
                _items = value;
                ItemListControl.Items = _items;
                RefreshItems();
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="IComparableControl"/> по умолчанию.
        /// </summary>
        public IComparableControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о <see cref="Items"/>.
        /// </summary>
        public void RefreshItems()
        {
            ItemListControl.UpdateList();
            SortedItemListControl.Items = new List<Item>(_items);
            SortedItemListControl.Items.Sort();
            SortedItemListControl.UpdateList();
        }
    }
}