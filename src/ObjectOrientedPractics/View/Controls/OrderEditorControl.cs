using System;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
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
        /// Заказ.
        /// </summary>
        private Order _order = null;

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
                if(Order != null)
                {
                    RefreshOrder();
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
        }

        /// <summary>
        /// Очищает информацию.
        /// </summary>
        private void ClearInfo()
        {
            IdTextBox.Text = CreatedDateTimeTextBox.Text = StatusComboBox.Text = null;
            AdressEditorControl.Adress = null;
            ItemListControl.Items = null;
            AmountLabel.Text = AmountLabelText;
        }

        /// <summary>
        /// Обновляет заказ.
        /// </summary>
        public void RefreshOrder()
        {
            IdTextBox.Text = Order.Id.ToString();
            CreatedDateTimeTextBox.Text = Order.CreatedDateTime.ToString();
            StatusComboBox.SelectedItem = Order.Status;
            AdressEditorControl.Adress = Order.Adress;
            ItemListControl.Items = Order.Items;
            AmountLabel.Text = AmountLabelText + Order.Amount;
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(Order != null)
            {
                Order.Status = (OrderStatus)StatusComboBox.SelectedItem;
                StatusChanged?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                StatusComboBox.Text = null;
            }
        }
    }
}