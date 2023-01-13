using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls.InterfaceControls
{
    /// <summary>
    /// Элемент управления для работы с интерфейсом <see cref="IComparable"/> на примере 
    /// <see cref="Item"/>.
    /// </summary>
    public partial class ICloneableControl : UserControl
    {
        /// <summary>
        /// Возращает и задаёт список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items {
            get => ItemListControl.Items;
            set => ItemListControl.Items = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ICloneableControl"/> по умолчанию.
        /// </summary>
        public ICloneableControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о <see cref="Items"/>.
        /// </summary>
        public void RefreshItems()
        {
            ItemListControl.UpdateList();
        }

        private void CloneButton_Click(object sender, EventArgs e)
        {
            if (ItemListControl.SelectedItem != null)
            {
                ItemCloneListControl.Items.Add((Item)ItemListControl.SelectedItem.Clone());
                ItemCloneListControl.UpdateList();
            }
        }
    }
}