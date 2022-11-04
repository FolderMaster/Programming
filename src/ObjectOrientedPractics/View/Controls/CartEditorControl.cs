using System;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;

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
        private const string AmountText = "Amount: ";

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
        public Cart Cart
        {
            get => _cart;
            private set
            {
                _cart = value;
                UpdateCart();
            }
        }

        /// <summary>
        /// Возращает и задаёт покупателя.
        /// </summary>
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
        public void UpdateCart()
        {
            if(Cart != null)
            {
                ItemListControl.UpdateList();
                AmountLabel.Text = AmountText + Cart.Amount;
            }
        }

        /// <summary>
        /// Очищает информацию.
        /// </summary>
        private void ClearInfo()
        {
            ItemListControl.Items = null;
            AmountLabel.Text = AmountText;
        }

        private void ItemListControl_RemoveFromItems(object sender, EventArgs e)
        {
            UpdateCart();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            Customer.Orders.Add(new Order(Cart.Items, Customer.Adress, OrderStatus.New));
            Cart.Items.Clear();
            UpdateCart();
        }
    }
}