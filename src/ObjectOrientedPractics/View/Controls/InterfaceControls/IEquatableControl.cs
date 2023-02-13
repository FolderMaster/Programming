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
            Item item1 = ItemListControl1.SelectedItem;
            Item item2 = ItemListControl2.SelectedItem;
            if (item1 == null || item2 == null)
            {
                SignLabel.Text = "?";
            }
            else
            {
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