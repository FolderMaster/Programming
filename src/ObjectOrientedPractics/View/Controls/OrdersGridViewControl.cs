using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для представления заказов в таблице.
    /// </summary>
    public partial class OrdersGridViewControl : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Список представлений заказов.
        /// </summary>
        private List<OrderView> _orderViews = new List<OrderView>();

        /// <summary>
        /// Список видимых представлений заказов.
        /// </summary>
        private List<OrderView> _visibleOrderViews = new List<OrderView>();

        /// <summary>
        /// Источник данных для <see cref="DataGridView"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Выбранный заказ.
        /// </summary>
        private Order _selectedOrder = null;

        /// <summary>
        /// Статус сортировки для <see cref="OrderView.Id"/>.
        /// </summary>
        private SortStatus _idSortStatus = SortStatus.None;

        /// <summary>
        /// Статус сортировки для <see cref="OrderView.Amount"/>.
        /// </summary>
        private SortStatus _amountSortStatus = SortStatus.None;

        /// <summary>
        /// Выбранный уникальный индентификатор.
        /// </summary>
        private int _selectedId = -1;

        /// <summary>
        /// Возращает и задаёт список покупателей.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;
                if (value != null)
                {
                    RefreshData();
                }
            }
        }

        /// <summary>
        /// Возращает и задаёт выбранный уникальный индентификатор.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedId
        {
            get => _selectedId;
            set
            {
                _selectedId = value;
                if (SelectedId != -1)
                {
                    SelectedOrder = _orders.Where((o) => o.Id == SelectedId).FirstOrDefault();
                }
                else
                {
                    SelectedOrder = null;
                }
            }
        }

        /// <summary>
        /// Текст поиска.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string FindText
        {
            get => FindTextBox.Text;
        }

        /// <summary>
        /// Возращает и задаёт выбранный заказ.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Order SelectedOrder
        {
            get => _selectedOrder;
            set
            {
                if (value != _selectedOrder)
                {
                    _selectedOrder = value;
                    SelectedOrderChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        bool ShowOnlyPriorityOrders
        {
            get => ShowOnlyPriorityOrdersCheckBox.Checked;
        }

        /// <summary>
        /// Обработчик события при изменении <see cref="SelectedOrder"/>.
        /// </summary>
        public event EventHandler SelectedOrderChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrdersGridViewControl"/>.
        /// </summary>
        public OrdersGridViewControl()
        {
            InitializeComponent();

            _bindingSource.DataSource = _visibleOrderViews;
            DataGridView.DataSource = _bindingSource;
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        public void RefreshData()
        {
            _orders.Clear();
            _orderViews.Clear();
            foreach (Customer customer in Customers)
            {
                string customerFullName = customer.FullName;
                {
                    foreach (Order order in customer.Orders)
                    {
                        _orders.Add(order);
                        int id = order.Id;
                        DateTime lastChangedStatusDateTime = order.LastChangedStatusDateTime;
                        OrderStatus status = order.Status;
                        int amount = order.Amount;
                        Adress adress = order.Adress;
                        bool isPriority = order as PriorityOrder != null ? true : false;
                        _orderViews.Add(new OrderView(id, status, lastChangedStatusDateTime, 
                            amount, customerFullName, adress, isPriority));
                    }
                }
            }
            RefreshView();
        }

        /// <summary>
        /// Обновляет выбранный заказ.
        /// </summary>
        public void RefreshSelectedOrder()
        {
            OrderView orderView = _orderViews.FirstOrDefault((ov) => ov.Id == SelectedId);
            orderView.Status = _selectedOrder.Status;
            orderView.LastChangedStatusDateTime = _selectedOrder.LastChangedStatusDateTime;
            RefreshData();
        }

        /// <summary>
        /// Обновляет представление в таблице.
        /// </summary>
        private void RefreshView()
        {
            _visibleOrderViews = _orderViews;

            if (ShowOnlyPriorityOrders)
            {
                _visibleOrderViews = _visibleOrderViews.Where((ov) => ov.IsPriority).ToList();
            }

            _visibleOrderViews = _visibleOrderViews.Where((ov) => ov.CustomerFullName.IndexOf(
                FindText, StringComparison.OrdinalIgnoreCase) != -1).ToList();

            switch(_idSortStatus)
            {
                case SortStatus.Ascending:
                    _visibleOrderViews = _visibleOrderViews.OrderBy((ov) => ov.Id).ToList();
                    break;
                case SortStatus.Descending:
                    _visibleOrderViews = _visibleOrderViews.OrderByDescending((ov) => ov.Id).
                        ToList();
                    break;
            }

            switch (_amountSortStatus)
            {
                case SortStatus.Ascending:
                    _visibleOrderViews = _visibleOrderViews.OrderBy((ov) => ov.Amount).ToList();
                    break;
                case SortStatus.Descending:
                    _visibleOrderViews = _visibleOrderViews.OrderByDescending((ov) => ov.Amount).
                        ToList();
                    break;
            }

            _bindingSource.DataSource = _visibleOrderViews;

            if(_visibleOrderViews.Count == 0)
            {
                SelectedId = -1;
            }
            else
            {
                DataGridView.Columns[0].Selected = true;
                SelectedId = _visibleOrderViews[0].Id;
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridView.SelectedRows.Count > 0)
            {
                SelectedId = (int)DataGridView.SelectedRows[0].Cells[nameof(OrderView.Id)].Value;
            }
        }

        private void DataGridView_ColumnHeaderMouseClick(object sender, 
            DataGridViewCellMouseEventArgs e)
        {
            if(DataGridView.Columns[e.ColumnIndex].Name == nameof(OrderView.Id))
            {
                switch (_idSortStatus)
                {
                    case SortStatus.Ascending: _idSortStatus = SortStatus.Descending; break;
                    case SortStatus.None: _idSortStatus = SortStatus.Ascending; break;
                    case SortStatus.Descending: _idSortStatus = SortStatus.None; break;
                    default: throw new ArgumentException();
                }
                RefreshView();
            }
            else if (DataGridView.Columns[e.ColumnIndex].Name == nameof(OrderView.Amount))
            {
                switch (_amountSortStatus)
                {
                    case SortStatus.Ascending: _amountSortStatus = SortStatus.Descending; break;
                    case SortStatus.None: _amountSortStatus = SortStatus.Ascending; break;
                    case SortStatus.Descending: _amountSortStatus = SortStatus.None; break;
                    default: throw new ArgumentException();
                }
                RefreshView();
            }
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
        }
    }
}