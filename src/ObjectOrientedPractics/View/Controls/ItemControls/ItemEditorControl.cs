﻿using System;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.View.Controls.Enums;

namespace ObjectOrientedPractics.View.Controls.ItemControls
{
    /// <summary>
    /// Элемент управления для изменения экземпляра класса <see cref="Item"/>.
    /// </summary>
    public partial class ItemEditorControl : UserControl
    {
        /// <summary>
        /// Экземпляр класса <see cref="Item"/>.
        /// </summary>
        private Item _item;

        /// <summary>
        /// Делегат для обработки информации.
        /// </summary>
        private delegate void Parse();

        /// <summary>
        /// Возвращает и задаёт экземпляр класса <see cref="Item"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Item Item
        {
            get => _item;
            set
            {
                _item = value;
                if (_item == null)
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
        /// Обработчик события изменения <see cref="Item"/>.
        /// </summary>
        public event EventHandler CurrentPropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ItemEditorControl"/> по-умолчанию.
        /// </summary>
        public ItemEditorControl()
        {
            InitializeComponent();

            CategoryComboBox.DataSource = Enum.GetValues(typeof(ItemCategory));
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Item.Cost"/>.
        /// </summary>
        private void CostParse()
        {
            Item.Cost = int.Parse(CostTextBox.Text);
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Item.Name"/>.
        /// </summary>
        private void NameParse()
        {
            Item.Name = NameTextBox.Text;
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Item.Info"/>.
        /// </summary>
        private void InfoParse()
        {
            Item.Info = InfoTextBox.Text;
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Item.Category"/>.
        /// </summary>
        private void CategoryParse()
        {
            Item.Category = (ItemCategory)CategoryComboBox.SelectedIndex;
        }

        /// <summary>
        /// Очищает информацию с элементов управления.
        /// </summary>
        private void ClearInfo()
        {
            IdTextBox.Text = CostTextBox.Text = NameTextBox.Text = InfoTextBox.Text =
                CategoryComboBox.Text = null;
        }

        /// <summary>
        /// Заполняет информацию в элементы управления.
        /// </summary>
        private void FillInfo()
        {
            IdTextBox.Text = Item.Id.ToString();
            CostTextBox.Text = Item.Cost.ToString();
            NameTextBox.Text = Item.Name.ToString();
            InfoTextBox.Text = Item.Info.ToString();
            CategoryComboBox.Text = Item.Category.ToString();
        }

        /// <summary>
        /// Обновляет свойство <see cref="Item"/>.
        /// </summary>
        /// <param name="control">Связанный с этим, элемент управления.</param>
        /// <param name="parse">Метод парсинга.</param>
        private void UpdateProperty(Control control, Parse parse)
        {
            if (Item != null)
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

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(CostTextBox, CostParse);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(NameTextBox, NameParse);
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(InfoTextBox, InfoParse);
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProperty(CategoryComboBox, CategoryParse);
        }
    }
}