using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Collections.Generic;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент управления для работы с классом <see cref="Item"/>.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Возращает и задаёт список экземпляров класса <see cref="Item"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => ItemListControl.Items;
            set => ItemListControl.Items = value;
        }


        /// <summary>
        /// Обработчик для события изменения списка <see cref="Items"/>.
        /// </summary>
        public event EventHandler ItemsChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ItemsTab"/> по-умолчанию.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ItemListControl_RemoveButtonClick(object sender, EventArgs e)
        {
            ItemEditorControl.Item = ItemListControl.SelectedItem;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ItemListControl_ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            ItemEditorControl.Item = ItemListControl.SelectedItem;
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ItemEditorControl_CurrentPropertyChanged(object sender, EventArgs e)
        {
            ItemListControl.UpdateList();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ItemListControl_AddButtonClick(object sender, EventArgs e)
        {
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}