using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls.Classes;
using ObjectOrientedPractics.View.Controls.Enums;

namespace ObjectOrientedPractics.View.Controls.OrderControls
{
    /// <summary>
    /// Элемент управления для представления заказов в таблице.
    /// </summary>
    public partial class OrderGridViewControl : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers = new List<Customer>();

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
        /// Выбранное представление заказа.
        /// </summary>
        private OrderView _selectedOrderView = null;

        /// <summary>
        /// Статус сортировки для <see cref="OrderView.Id"/>.
        /// </summary>
        private OrderSortStatus _idSortStatus = OrderSortStatus.None;

        /// <summary>
        /// Статус сортировки для <see cref="OrderView.Amount"/>.
        /// </summary>
        private OrderSortStatus _amountSortStatus = OrderSortStatus.None;

        /// <summary>
        /// Логическое значение, показывающее есть ли процесс обработки.
        /// </summary>
        private bool _isProcessing = true;

        /// <summary>
        /// Возращает и задаёт выбранное представление заказа.
        /// </summary>
        private OrderView SelectedOrderView
        {
            get => _selectedOrderView;
            set
            {
                _selectedOrderView = value;
                if (value != null)
                {
                    SelectedOrder = _selectedOrderView.Order;
                }
                else
                {
                    SelectedOrder = null;
                }
            }
        }

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
                    RefreshData();
                }
            }
        }

        /// <summary>
        /// Возращает и задаёт выбранный индекс.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get
            {
                if(DataGridView.SelectedRows.Count > 0 || DataGridView.SelectedCells.Count > 0)
                {
                    if(DataGridView.SelectedRows.Count > 0)
                    {
                        return DataGridView.SelectedRows[0].Index;
                    }
                    else
                    {
                        return DataGridView.SelectedCells[0].RowIndex;
                    }
                }
                else
                {
                    return -1;
                }
            }
            set
            {
                int selectedIndex = SelectedIndex;
                if (selectedIndex != -1)
                {
                    DataGridView.Rows[selectedIndex].Selected = false;
                }
                if (value != -1)
                {
                    DataGridView.Rows[value].Selected = true;
                }
                UpdateSelectedOrderView();
            }
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

        /// <summary>
        /// Обработчик события при изменении <see cref="SelectedOrder"/>.
        /// </summary>
        public event EventHandler SelectedOrderChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrderGridViewControl"/>.
        /// </summary>
        public OrderGridViewControl()
        {
            InitializeComponent();

            _bindingSource.DataSource = _visibleOrderViews;
            DataGridView.DataSource = _bindingSource;
        }

        /// <summary>
        /// Указывает нужно ли оставлять предсталение заказа для фильтрации по подстроке имени.
        /// </summary>
        /// <param name="orderView">Представление заказа.</param>
        /// <param name="text">Подстрока имени.</param>
        /// <returns>Логическое значение, указывающее, нужно ли оставлять представление
        /// заказа.</returns>
        private static bool FilterOrderViewByFullName(OrderView orderView, string text)
        {
            return orderView.CustomerFullName.IndexOf(text, StringComparison.OrdinalIgnoreCase)
                != -1;
        }

        /// <summary>
        /// Указывает нужно ли оставлять предсталение заказа для фильтрации по приоритетности.
        /// </summary>
        /// <param name="orderView">Представление заказа.</param>
        /// <param name="isPriority">Приоритетность представления заказа.</param>
        /// <returns>Логическое значение, указывающее, нужно ли оставлять представление
        /// заказа.</returns>
        private static bool FilterOrderViewByPriority(OrderView orderView, bool isPriority)
        {
            return orderView.IsPriority == isPriority;
        }

        /// <summary>
        /// Указывает нужно ли менять товары для сортировки по возрастанию уникального
        /// индентификатора.
        /// </summary>
        /// <param name="orderView1">Представление заказа.</param>
        /// <param name="orderView2">Представление заказа.</param>
        /// <returns>Логическое значение, указывающее, нужно ли менять представление
        /// заказа.</returns>
        private static bool CompareOrderViewByIdAscending(OrderView orderView1, OrderView
            orderView2)
        {
            return orderView1.Id < orderView2.Id;
        }

        /// <summary>
        /// Указывает нужно ли менять предсталение заказа для сортировки по убыванию уникального
        /// индентификатора.
        /// </summary>
        /// <param name="orderView1">Представление заказа.</param>
        /// <param name="orderView2">Представление заказа.</param>
        /// <returns>Логическое значение, указывающее, нужно ли менять представление
        /// заказа.</returns>
        private static bool CompareOrderViewByIdDescending(OrderView orderView1, OrderView
            orderView2)
        {
            return orderView1.Id > orderView2.Id;
        }

        /// <summary>
        /// Указывает нужно ли менять предсталение заказа для сортировки по возрастанию стоимости.
        /// </summary>
        /// <param name="orderView1">Представление заказа.</param>
        /// <param name="orderView2">Представление заказа.</param>
        /// <returns>Логическое значение, указывающее, нужно ли менять представление
        /// заказа.</returns>
        private static bool CompareOrderViewByAmountAscending(OrderView orderView1, OrderView 
            orderView2)
        {
            return orderView1.Amount < orderView2.Amount;
        }

        /// <summary>
        /// Указывает нужно ли менять предсталение заказа для сортировки по убыванию стоимости.
        /// </summary>
        /// <param name="orderView1">Представление заказа.</param>
        /// <param name="orderView2">Представление заказа.</param>
        /// <returns>Логическое значение, указывающее, нужно ли менять представление
        /// заказа.</returns>
        private static bool CompareOrderViewByAmountDescending(OrderView orderView1, OrderView
            orderView2)
        {
            return orderView1.Amount > orderView2.Amount;
        }

        /// <summary>
        /// Обновляет представление в таблице.
        /// </summary>
        private void RefreshView()
        {
            _isProcessing = true;
            _visibleOrderViews = _orderViews;

            if (ShowOnlyPriorityOrdersCheckBox.Checked)
            {
                _visibleOrderViews = DataTools.FilterData(_visibleOrderViews, 
                    FilterOrderViewByPriority, true);
            }

            _visibleOrderViews = DataTools.FilterData(_visibleOrderViews, 
                FilterOrderViewByFullName, FindTextBox.Text);

            switch(_idSortStatus)
            {
                case OrderSortStatus.Ascending:
                    _visibleOrderViews = DataTools.SortData(_visibleOrderViews, 
                        CompareOrderViewByIdAscending); break;
                case OrderSortStatus.Descending:
                    _visibleOrderViews = DataTools.SortData(_visibleOrderViews,
                        CompareOrderViewByIdDescending); break;
            }

            switch (_amountSortStatus)
            {
                case OrderSortStatus.Ascending:
                    _visibleOrderViews = DataTools.SortData(_visibleOrderViews, 
                        CompareOrderViewByAmountAscending); break;
                case OrderSortStatus.Descending:
                    _visibleOrderViews = DataTools.SortData(_visibleOrderViews, 
                        CompareOrderViewByAmountDescending); break;
            }
            
            _bindingSource.DataSource = _visibleOrderViews;

            if (_visibleOrderViews.Count == 0)
            {
                SelectedIndex = -1;
            }
            else if (SelectedOrderView == null || !_visibleOrderViews.Contains(SelectedOrderView))
            {
                SelectedIndex = 0;
            }
            else
            {
                SelectedIndex = _visibleOrderViews.IndexOf(SelectedOrderView);
            }
            _isProcessing = false;
        }

        /// <summary>
        /// Обновить <see cref="SelectedOrderView"/>.
        /// </summary>
        private void UpdateSelectedOrderView()
        {
            int selectedIndex = SelectedIndex;
            if (selectedIndex != -1)
            {
                SelectedOrderView = _visibleOrderViews[selectedIndex];
            }
            else
            {
                SelectedOrderView = null;
            }
        }

        /// <summary>
        /// Обновляет информацию.
        /// </summary>
        public void RefreshData()
        {
            _isProcessing = true;
            _orderViews.Clear();
            foreach (Customer customer in Customers)
            {
                string customerFullName = customer.FullName;
                {
                    foreach (Order order in customer.Orders)
                    {
                        _orderViews.Add(new OrderView(order, customer));
                    }
                }
            }
            _isProcessing = false;
            RefreshView();
        }

        /// <summary>
        /// Обновляет выбранный заказ.
        /// </summary>
        public void RefreshSelectedOrder()
        {
            RefreshView();
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(!_isProcessing)
            {
                UpdateSelectedOrderView();
            }
        }

        private void DataGridView_ColumnHeaderMouseClick(object sender, 
            DataGridViewCellMouseEventArgs e)
        {
            if(DataGridView.Columns[e.ColumnIndex].Name == nameof(OrderView.Id))
            {
                switch (_idSortStatus)
                {
                    case OrderSortStatus.Ascending: _idSortStatus = OrderSortStatus.Descending; break;
                    case OrderSortStatus.None: _idSortStatus = OrderSortStatus.Ascending; break;
                    case OrderSortStatus.Descending: _idSortStatus = OrderSortStatus.None; break;
                    default: throw new ArgumentException();
                }
                RefreshView();
            }
            else if (DataGridView.Columns[e.ColumnIndex].Name == nameof(OrderView.Amount))
            {
                switch (_amountSortStatus)
                {
                    case OrderSortStatus.Ascending: _amountSortStatus = OrderSortStatus.Descending; break;
                    case OrderSortStatus.None: _amountSortStatus = OrderSortStatus.Ascending; break;
                    case OrderSortStatus.Descending: _amountSortStatus = OrderSortStatus.None; break;
                    default: throw new ArgumentException();
                }
                RefreshView();
            }
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void OrderGridViewControl_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}