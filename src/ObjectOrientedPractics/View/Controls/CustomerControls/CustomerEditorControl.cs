﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Controls.Enums;

namespace ObjectOrientedPractics.View.Controls.CustomerControls
{
    /// <summary>
    /// Элемент управления для изменения экземпляра класса <see cref="Customer"/>.
    /// </summary>
    public partial class CustomerEditorControl : UserControl
    {
        /// <summary>
        /// Экземпляр класса <see cref="Customer"/>.
        /// </summary>
        private Customer _customer;

        /// <summary>
        /// Делегат для обработки информации.
        /// </summary>
        private delegate void Parse();

        /// <summary>
        /// Возвращает и задаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Customer Customer
        {
            get => _customer;
            set
            {
                _customer = value;
                if (_customer == null)
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
        /// Обработчик события изменения <see cref="Customer"/>.
        /// </summary>
        public event EventHandler CurrentPropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CustomerEditorControl"/> по-умолчанию.
        /// </summary>
        public CustomerEditorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Customer.FullName"/>.
        /// </summary>
        private void FullNameParse()
        {
            Customer.FullName = FullNameTextBox.Text;
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Customer.IsPriority"/>.
        /// </summary>
        private void IsPriorityParse()
        {
            Customer.IsPriority = IsPriorityCheckBox.Checked;
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Customer.BirthDate"/>.
        /// </summary>
        private void BirthDateParse()
        {
            Customer.BirthDate = DateTime.Parse(BirthDateTextBox.Text);
            DiscountListControl.UpdateListBox();
        }

        /// <summary>
        /// Очищает информацию с элементов управления.
        /// </summary>
        private void ClearInfo()
        {
            IdTextBox.Text = FullNameTextBox.Text = null;
            AdressEditorControl.Adress = null;
            IsPriorityCheckBox.Checked = false;
            DiscountListControl.Discounts = null;
            BirthDateTextBox.Text = null;
        }

        /// <summary>
        /// Заполняет информацию в элементы управления.
        /// </summary>
        private void FillInfo()
        {
            IdTextBox.Text = Customer.Id.ToString();
            FullNameTextBox.Text = Customer.FullName;
            AdressEditorControl.Adress = Customer.Adress;
            IsPriorityCheckBox.Checked = Customer.IsPriority;
            DiscountListControl.Discounts = Customer.Discounts;
            BirthDateTextBox.Text = Customer.BirthDate.ToShortDateString();
        }

        /// <summary>
        /// Обновляет свойство <see cref="Customer"/>.
        /// </summary>
        /// <param name="control">Связанный с этим, элемент управления.</param>
        /// <param name="parse">Метод парсинга.</param>
        private void UpdateProperty(Control control, Parse parse)
        {
            if (Customer != null)
            {
                try
                {
                    parse();
                    control.BackColor = ColorManager.CorrectColor;
                    ToolTip.RemoveAll();
                    CurrentPropertyChanged?.Invoke(this, EventArgs.Empty);
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

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(FullNameTextBox, FullNameParse);
        }

        private void AdressEditorControl_CurrentPropertyChanged(object sender, EventArgs e)
        {
            Customer.Adress = AdressEditorControl.Adress;
        }

        private void IsPriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateProperty(IsPriorityCheckBox, IsPriorityParse);
        }

        private void BirthDateTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(BirthDateTextBox, BirthDateParse);
        }
    }
}