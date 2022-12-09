using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Элемент управления для работы с классом <see cref="Order"/>.
    /// </summary>
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Возращает и задаёт покупателей.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => OrdersViewControl.Customers;
            set => OrdersViewControl.Customers = value;
        }

        /// <summary>
        /// Создаёт экемпляр класса <see cref="OrdersTab"/> по-умолчанию.
        /// </summary>
        public OrdersTab()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        public void RefreshData()
        {
            OrdersViewControl.RefreshData();
        }

        private void OrderEditorControl_StatusChanged(object sender, EventArgs e)
        {
            OrdersViewControl.RefreshSelectedOrder();
        }

        private void OrdersViewControl_SelectedOrderChanged(object sender, EventArgs e)
        {
            OrderEditorControl.Order = OrdersViewControl.SelectedOrder;
        }
    }
}