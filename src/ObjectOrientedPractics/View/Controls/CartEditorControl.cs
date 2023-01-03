using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для изменения экземпляра класса <see cref="Cart"/>.
    /// </summary>
    public partial class CartEditorControl : UserControl
    {
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
                    ItemListControl.Items = DiscountCheckListControl.Items = Cart.Items;
                    DiscountCheckListControl.Discounts = Customer.Discounts;
                }
                else
                {
                    ClearInfo();
                }
            }
        }

        /// <summary>
        /// Стоимость товаров.
        /// </summary>
        private int Amount
        {
            get => Cart.Amount;
        }

        /// <summary>
        /// Размер скидки.
        /// </summary>
        private int DiscountAmount
        {
            get => DiscountCheckListControl.DiscountAmount;
        }

        /// <summary>
        /// Итоговая стоимость заказа.
        /// </summary>
        private int Total
        {
            get => Amount - DiscountAmount;
        }

        /// <summary>
        /// Обработчик события создания заказа.
        /// </summary>
        public event EventHandler OrderCreated;

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
            if(Customer != null)
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
                DiscountCheckListControl.UpdateCheckedListBox();
                AmountLabel.Text = $"Amount: {Amount}";
                DiscountAmountLabel.Text = $"Discount amount: {DiscountAmount}";
                TotalLabel.Text = $"Total: {Total}";
            }
        }

        /// <summary>
        /// Очищает информацию.
        /// </summary>
        private void ClearInfo()
        {
            ItemListControl.Items = null;
            AmountLabel.Text = "Amount:";
            DiscountAmountLabel.Text = "Discount amount:";
            TotalLabel.Text = "Total:";
            DiscountCheckListControl.Discounts = null;
        }

        private void ItemListControl_RemoveFromItems(object sender, EventArgs e)
        {
            RefreshCart();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            if (Customer != null)
            {
                int discountAmount = DiscountCheckListControl.ApplyDiscounts();
                if(Customer.IsPriority)
                {
                    Customer.Orders.Add(new PriorityOrder(new List<Item>(Cart.Items),
                        Customer.Adress, OrderStatus.New, discountAmount, DateTime.UtcNow, 
                        PriorityOrder.DeliveryTimes[0]));
                }
                else
                {
                    Customer.Orders.Add(new Order(new List<Item>(Cart.Items), Customer.Adress,
                        OrderStatus.New, discountAmount));
                }
                DiscountCheckListControl.UpdateDiscounts();
                Cart.Items.Clear();
                RefreshCart();
                OrderCreated?.Invoke(this, EventArgs.Empty);
            }
        }

        private void DiscountCheckListControl_DiscountAmountChanged(object sender, EventArgs e)
        {
            DiscountAmountLabel.Text = $"Discount amount: {DiscountAmount}";
            TotalLabel.Text = $"Total: {Total}";
        }
    }
}