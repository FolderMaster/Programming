using System;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Controls.OrderControls
{
    /// <summary>
    /// Элемент управления для измения <see cref="Order"/>.
    /// </summary>
    public partial class OrderEditorControl : UserControl
    {
        /// <summary>
        /// Текст для <see cref="AmountLabel"/>.
        /// </summary>
        private const string AmountLabelText = "Amount: ";

        /// <summary>
        /// Делегат для обработки информации.
        /// </summary>
        private delegate void Parse();

        /// <summary>
        /// Заказ.
        /// </summary>
        private Order _order = null;

        /// <summary>
        /// Заказ приоритетного обслуживания.
        /// </summary>
        private PriorityOrder _priorityOrder = null;

        /// <summary>
        /// Возращает и задаёт заказ.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Order Order
        {
            get => _order;
            set
            {
                _order = value;
                if(Order is PriorityOrder priorityOrder)
                {
                    _priorityOrder = priorityOrder;
                }
                else
                {
                    _priorityOrder = null;
                }

                if(Order != null)
                {
                    FillInfo();
                }
                else
                {
                    ClearInfo();
                }
            }
        }

        /// <summary>
        /// Обработчик события для измения <see cref="Order.Status"/>.
        /// </summary>
        public event EventHandler StatusChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="OrderEditorControl"/> по-умолчанию.
        /// </summary>
        public OrderEditorControl()
        {
            InitializeComponent();

            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            DesiredDeliveryTimeComboBox.DataSource = PriorityOrder.DeliveryTimes;
        }

        /// <summary>
        /// Очищает информацию с элементов управления.
        /// </summary>
        private void ClearInfo()
        {
            IdTextBox.Text = CreatedDateTimeTextBox.Text = StatusComboBox.Text = null;
            AdressEditorControl.Adress = null;
            ItemListControl.Items = null;
            AmountLabel.Text = AmountLabelText;
            PriorityOptionsPanel.Visible = false;
        }

        /// <summary>
        /// Заполняет информацию в элементы управления.
        /// </summary>
        private void FillInfo()
        {
            IdTextBox.Text = Order.Id.ToString();
            CreatedDateTimeTextBox.Text = Order.CreatedDateTime.ToString();
            StatusComboBox.SelectedItem = Order.Status;
            AdressEditorControl.Adress = Order.Adress;
            ItemListControl.Items = Order.Items;
            AmountLabel.Text = AmountLabelText + Order.Amount;
            if (_priorityOrder != null)
            {
                PriorityOptionsPanel.Visible = true;
                DesiredDeliveryDateTextBox.Text =
                    _priorityOrder.DesiredDeliveryDate.ToShortDateString();
                DesiredDeliveryTimeComboBox.SelectedItem = _priorityOrder.DesiredDeliveryTime;
            }
            else
            {
                PriorityOptionsPanel.Visible = false;
            }
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Order.Status"/>.
        /// </summary>
        private void StatusParse()
        {
            Order.Status = (OrderStatus)StatusComboBox.SelectedItem;
            StatusChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="PriorityOrder.DesiredDeliveryDate"/>.
        /// </summary>
        private void DesiredDeliveryDateParse()
        {
            _priorityOrder.DesiredDeliveryDate = DateTime.Parse(DesiredDeliveryDateTextBox.Text);
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="PriorityOrder.DesiredDeliveryTime"/>.
        /// </summary>
        private void DesiredDeliveryTimeParse()
        {
            _priorityOrder.DesiredDeliveryTime = (string)DesiredDeliveryTimeComboBox.SelectedItem;
        }

        /// <summary>
        /// Обновляет свойство <see cref="Order"/>.
        /// </summary>
        /// <param name="control">Связанный с этим, элемент управления.</param>
        /// <param name="parse">Метод парсинга.</param>
        private void UpdateProperty(Control control, Parse parse)
        {
            if (Order != null)
            {
                try
                {
                    parse();
                    control.BackColor = ColorManager.CorrectColor;
                    ToolTip.RemoveAll();
                }
                catch (Exception ex)
                {
                    control.BackColor = ColorManager.ErrorColor;
                    ToolTip.SetToolTip(control, ex.Message);
                }
            }
            else
            {
                ClearInfo();
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProperty(StatusComboBox, StatusParse);
        }

        private void DesiredDeliveryDateTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(DesiredDeliveryDateTextBox, DesiredDeliveryDateParse);
        }

        private void DesiredDeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProperty(DesiredDeliveryTimeComboBox, DesiredDeliveryTimeParse);
        }
    }
}