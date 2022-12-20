using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для редактирования созданного <see cref="PriorityOrder"/>.
    /// </summary>
    public partial class PriorityOrderCreatorControl : UserControl
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
        /// Заказ приоритетного обслуживания.
        /// </summary>
        private PriorityOrder _priorityOrder = null;

        /// <summary>
        /// Возращает или задаёт заказ приоритетного обслуживания.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public PriorityOrder PriorityOrder
        {
            get => _priorityOrder;
            set
            {
                _priorityOrder = value;
                if (_priorityOrder == null)
                {
                    ClearInfo();
                }
                else
                {
                    FillInfo();
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrderCreatorControl"/> по умолчанию.
        /// </summary>
        public PriorityOrderCreatorControl()
        {
            InitializeComponent();

            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));
            DesiredDeliveryTimeComboBox.DataSource = PriorityOrder.DeliveryTimes;
        }

        /// <summary>
        /// Очищает информацию.
        /// </summary>
        private void ClearInfo()
        {
            IdTextBox.Text = CreatedDateTimeTextBox.Text = StatusComboBox.Text = 
                DesiredDeliveryDateTextBox.Text = DesiredDeliveryTimeComboBox.Text = null;
            AdressEditorControl.Adress = null;
            ItemListControl.Items = null;
        }

        /// <summary>
        /// Заполняет информацию.
        /// </summary>
        private void FillInfo()
        {
            IdTextBox.Text = PriorityOrder.Id.ToString();
            CreatedDateTimeTextBox.Text = PriorityOrder.CreatedDateTime.ToString();
            StatusComboBox.SelectedItem = PriorityOrder.Status;
            DesiredDeliveryDateTextBox.Text = PriorityOrder.CreatedDateTime.ToShortDateString();
            DesiredDeliveryTimeComboBox.SelectedItem = PriorityOrder.DesiredDeliveryTime;
            AdressEditorControl.Adress = PriorityOrder.Adress;
            ItemListControl.Items = PriorityOrder.Items;
            AmountLabel.Text = AmountLabelText + PriorityOrder.Amount;
        }

        /// <summary>
        /// Обновляет стоимость.
        /// </summary>
        private void UpdateAmount()
        {
            AmountLabel.Text = AmountLabelText + PriorityOrder.Amount.ToString();
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="PriorityOrder.Status"/>.
        /// </summary>
        private void StatusParse()
        {
            PriorityOrder.Status = (OrderStatus)StatusComboBox.SelectedItem;
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="PriorityOrder.DesiredDeliveryDate"/>.
        /// </summary>
        private void DesiredDeliveryDateParse()
        {
            PriorityOrder.DesiredDeliveryDate = DateTime.Parse(DesiredDeliveryDateTextBox.Text);
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="PriorityOrder.DesiredDeliveryTime"/>.
        /// </summary>
        private void DesiredDeliveryTimeParse()
        {
            PriorityOrder.DesiredDeliveryTime = (string)DesiredDeliveryTimeComboBox.SelectedItem;
        }

        /// <summary>
        /// Обновляет свойство <see cref="PriorityOrder"/>.
        /// </summary>
        /// <param name="control">Связанный с этим, элемент управления.</param>
        /// <param name="parse">Метод парсинга.</param>
        private void UpdateProperty(Control control, Parse parse)
        {
            if (PriorityOrder != null)
            {
                try
                {
                    parse();
                    control.BackColor = ColorManager.CorrectColor;
                    ToolTip.RemoveAll();
                }
                catch(Exception ex)
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

        /// <summary>
        /// Добавляет товар в заказ.
        /// </summary>
        /// <param name="item">Товар.</param>
        public void AddItem(Item item)
        {
            if (PriorityOrder != null)
            {
                PriorityOrder.Items.Add(item);
                ItemListControl.UpdateList();
                if (ItemListControl.Items.Count == 1)
                {
                    ItemListControl.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Обновляет приоритетный заказ.
        /// </summary>
        public void RefreshPriorityOrder()
        {
            if (PriorityOrder != null)
            {
                ItemListControl.UpdateList();
                AmountLabel.Text = AmountLabelText + PriorityOrder.Amount;
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

        private void AdressEditorControl_CurrentPropertyChanged(object sender, EventArgs e)
        {
            PriorityOrder.Adress = AdressEditorControl.Adress;
        }

        private void ItemListControl_RemoveFromItems(object sender, EventArgs e)
        {
            UpdateAmount();
        }

        private void ItemListControl_AddToItems(object sender, EventArgs e)
        {
            UpdateAmount();
        }

        private void ClearOrderButton_Click(object sender, EventArgs e)
        {
            PriorityOrder = new PriorityOrder(new List<Item>(), new Adress(), OrderStatus.New,
                DateTime.UtcNow, PriorityOrder.DeliveryTimes[0]);
        }
    }
}