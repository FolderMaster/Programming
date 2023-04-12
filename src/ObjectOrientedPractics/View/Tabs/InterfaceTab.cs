using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент управления для работы с интерфейсами <see cref="ICloneable"/>, 
    /// <see cref="IComparable{T}"/> и <see cref="IEquatable{T}"/> на примере <see cref="Item"/>.
    /// </summary>
    public partial class InterfaceTab : UserControl
    {
        /// <summary>
        /// Возращает и задаёт список товаров.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Item> Items
        {
            get => ICloneableControl.Items;
            set
            {
                ICloneableControl.Items = value;
                IComparableControl.Items = value;
                IEquatableControl.Items = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="InterfaceTab"/> по умолчанию.
        /// </summary>
        public InterfaceTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию о <see cref="Items"/>.
        /// </summary>
        public void RefreshItems()
        {
            ICloneableControl.RefreshItems();
            IComparableControl.RefreshItems();
            IEquatableControl.RefreshItems();
        }
    }
}