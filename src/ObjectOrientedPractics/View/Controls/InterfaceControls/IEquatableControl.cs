using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls.InterfaceControls
{
    /// <summary>
    /// Элемент управления для работы с интерфейсом <see cref="IEquatable{T}"/> на примере 
    /// <see cref="Item"/>.
    /// </summary>
    public partial class IEquatableControl : UserControl
    {
        /// <summary>
        /// Возращает и задаёт список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => ItemListControl1.Items;
            set
            {
                ItemListControl1.Items = ItemListControl2.Items = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="IEquatableControl"/> по умолчанию.
        /// </summary>
        public IEquatableControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Использует интерфейс <see cref="IEquatable{T}"/> для определения равенства между 
        /// объектами.
        /// </summary>
        private void UseIEquatable()
        {
            if(ItemListControl1.SelectedIndex == -1 || ItemListControl2.SelectedIndex == -1 ||
                ItemListControl1.Items.Count == 0 || ItemListControl2.Items.Count == 0)
            {
                SignLabel.Text = "?";
            }
            else
            {
                Item item1 = ItemListControl1.Items[ItemListControl1.SelectedIndex];
                Item item2 = ItemListControl2.Items[ItemListControl2.SelectedIndex];
                if(item1.Equals(item2))
                {
                    SignLabel.Text = "==";
                }
                else
                {
                    SignLabel.Text = "!=";
                }
            }
        }

        /// <summary>
        /// Обновляет информацию о <see cref="Items"/>.
        /// </summary>
        public void RefreshItems()
        {
            ItemListControl1.UpdateList();
            ItemListControl2.UpdateList();
        }

        private void ItemListControl1_ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            UseIEquatable();
        }

        private void ItemListControl2_ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            UseIEquatable();
        }
    }
}