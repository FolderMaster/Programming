using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services.Factories;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для изменения экземпляра класса <see cref="Cart"/>.
    /// </summary>
    public partial class CartEditorControl : UserControl
    {
        /// <summary>
        /// Текст для <see cref="AmountLabel"/>.
        /// </summary>
        private const string AmountLabelText = "Amount: ";

        /// <summary>
        /// Корзина покупателя.
        /// </summary>
        private Cart _cart = null;

        /// <summary>
        /// Покупатель.
        /// </summary>
        private Customer _customer = null;

        /// <summary>
        /// Возращает и задаёт корзину покупателя.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Cart Cart
        {
            get => _cart;
            private set
            {
                _cart = value;
                RefreshCart();
            }
        }

        /// <summary>
        /// Возращает и задаёт покупателя.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Customer Customer
        {
            get => _customer;
            set
            {
                _customer = value;
                if(Customer != null)
                {
                    Cart = Customer.Cart;
                    ItemListControl.Items = Cart.Items;
                }
                else
                {
                    ClearInfo();
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="CartEditorControl"/> по умолчанию.
        /// </summary>
        public CartEditorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Добавляет товар в корзину покупателя.
        /// </summary>
        /// <param name="item">Товар.</param>
        public void AddItem(Item item)
        {
            if(Cart != null)
            {
                Cart.Items.Add(item);
                ItemListControl.UpdateList();
                if (ItemListControl.Items.Count == 1)
                {
                    ItemListControl.SelectedIndex = 0;
                }
            }
        }

        /// <summary>
        /// Обновляет корзину.
        /// </summary>
        public void RefreshCart()
        {
            if(Cart != null)
            {
                ItemListControl.UpdateList();
                AmountLabel.Text = AmountLabelText + Cart.Amount;
            }
        }

        /// <summary>
        /// Очищает информацию.
        /// </summary>
        private void ClearInfo()
        {
            ItemListControl.Items = null;
            AmountLabel.Text = AmountLabelText;
        }

        private void ItemListControl_RemoveFromItems(object sender, EventArgs e)
        {
            RefreshCart();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Customer.Orders.Add(new Order(new List<Item>(Cart.Items), Customer.Adress, OrderStatus.New));
            Cart.Items.Clear();
            RefreshCart();
        }
    }
}