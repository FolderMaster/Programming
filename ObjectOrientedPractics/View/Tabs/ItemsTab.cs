using System;
using System.Windows.Forms;
using System.Collections.Generic;

using ObjectOrientedPractics.View.Controls;
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
        public List<Item> Items
        {
            get => ItemListControl.Items;
            set => ItemListControl.Items = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ItemsTab"/> по-умолчанию.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
        }

        private void ItemListControl_RemoveButtonClick(object sender, EventArgs e)
        {
            if (ItemListControl.SelectedIndex != -1)
            {
                ItemEditorControl.Item = ItemListControl.Items[ItemListControl.SelectedIndex];
            }
            else
            {
                ItemEditorControl.Item = null;
            }
        }

        private void ItemListControl_ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemListControl.SelectedIndex != -1)
            {
                ItemEditorControl.Item = ItemListControl.Items[ItemListControl.SelectedIndex];
            }
        }

        private void ItemEditorControl_CurrentPropertyChanged(object sender, EventArgs e)
        {
            switch (ItemEditorControl.UpdateMode)
            {
                case UpdateType.UpdateCurrentObject:
                    ItemListControl.UpdateList();
                    break;
                case UpdateType.UpdateList:
                    ItemListControl.UpdateListWithSort();
                    break;
            }
        }
    }
}