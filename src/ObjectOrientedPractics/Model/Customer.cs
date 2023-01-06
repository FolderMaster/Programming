using System;
using System.Collections.Generic;

using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.Model.Discounts;
using System.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Покупатель с ФИО, адресом и корзиной.
    /// </summary>
    public class Customer : IEquatable<object>, ICloneable
    {
        /// <summary>
        /// Генератор уникального индентификатора экземпляра класса.
        /// </summary>
        private static IdGenerator _idGenerator = new IdGenerator();

        /// <summary>
        /// Уникальный индентификатор экземпляра класса.
        /// </summary>
        private readonly int _id = _idGenerator.GetNextId();

        /// <summary>
        /// ФИО.
        /// </summary>
        private string _fullname = "";

        /// <summary>
        /// Адрес.
        /// </summary>
        private Adress _adress = new Adress();

        /// <summary>
        /// Корзина.
        /// </summary>
        private Cart _cart = new Cart();

        /// <summary>
        /// Список заказов.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Значение, указывающее приоритетный покупатель или нет.
        /// </summary>
        private bool _isPriority = false;

        /// <summary>
        /// Дата рождения.
        /// </summary>
        private DateTime _birthDate = DateTime.UtcNow;

        /// <summary>
        /// Список скидок.
        /// </summary>
        private List<IDiscount> _discounts = new List<IDiscount>() { new PointsDiscount() };

        /// <summary>
        /// Максимальная длина <see cref="FullName"/>.
        /// </summary>
        public static int MaxFullNameLength { get; } = 200;

        /// <summary>
        /// Индекс скидки накопительных баллов в <see cref="Discounts"/>.
        /// </summary>
        public static int PointsDiscountIndex { get; } = 0;

        /// <summary>
        /// Индекс cкидки по дню рождения в <see cref="Discounts"/>.
        /// </summary>
        public static int BirthDateDiscountIndex { get; } = 1;

        /// <summary>
        /// Возвращает уникальный индентификатор экземпляра класса.
        /// </summary>
        public int Id
        {
            get => _id;
        }

        /// <summary>
        /// Возвращает и задаёт ФИО. Длина строки должна быть не больше 
        /// <see cref="MaxFullNameLength"/>.
        /// </summary>
        public string FullName
        {
            get => _fullname;
            set
            {
                ValueValidator.AssertStringOnLessLength(value, MaxFullNameLength,
                    nameof(FullName));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес.
        /// </summary>
        public Adress Adress
        {
            get => _adress;
            set => _adress = value;
        }

        /// <summary>
        /// Возращает и задаёт корзину.
        /// </summary>
        public Cart Cart
        {
            get => _cart;
            set => _cart = value;
        }

        /// <summary>
        /// Возращает и задаёт список заказов.
        /// </summary>
        public List<Order> Orders
        {
            get => _orders;
            set => _orders = value;
        }

        /// <summary>
        /// Возращает и задаёт значение, указывающее приоритетный покупатель или 
        /// нет.
        /// </summary>
        public bool IsPriority
        {
            get => _isPriority;
            set => _isPriority = value;
        }

        /// <summary>
        /// Возращает и задаёт список скидок.
        /// </summary>
        public List<IDiscount> Discounts
        {
            get => _discounts;
            set => _discounts = value;
        }

        /// <summary>
        /// Возращает и задаёт дату рождения.
        /// </summary>
        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                _birthDate = value;
                if (Discounts[BirthDateDiscountIndex] is BirthDateDiscount birthDateDiscount)
                {
                    birthDateDiscount.BirthDate = BirthDate;
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/> по-умолчанию.
        /// </summary>
        public Customer()
        {
            Discounts.Add(new BirthDateDiscount(BirthDate));
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">ФИО.</param>
        /// <param name="adress">Адрес.</param>
        /// <param name="isPriority">Значение, указывающее приоритетный покупатель или нет.</param>
        /// <param name="birthDate">Дата рождения.</param>
        public Customer(string fullName, Adress adress, bool isPriority, DateTime birthDate)
        {
            FullName = fullName;
            Adress = adress;
            IsPriority = isPriority;
            Discounts.Add(new BirthDateDiscount(birthDate));
            BirthDate = birthDate;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName">ФИО.</param>
        /// <param name="adress">Адрес.</param>
        /// <param name="isPriority">Значение, указывающее приоритетный покупатель или нет.</param>
        /// <param name="birthDate">Дата рождения.</param>
        /// <param name="cart">Корзина покупателя.</param>
        public Customer(string fullName, Adress adress, bool isPriority, DateTime birthDate, 
            Cart cart)
        {
            FullName = fullName;
            Adress = adress;
            IsPriority = isPriority;
            Discounts.Add(new BirthDateDiscount(birthDate));
            BirthDate = birthDate;
            Cart = cart;
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public override string ToString()
        {
            return $"{FullName} ({Id})";
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="other"><inheritdoc/></param>
        /// <returns><inheritdoc/></returns>
        public override bool Equals(object other)
        {
            if (other == null)
            {
                return false;
            }

            Customer customer = other as Customer;
            if (customer == null)
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return FullName == customer.FullName && Adress.Equals(customer.Adress) && 
                IsPriority == customer.IsPriority && BirthDate == customer.BirthDate &&  
                Cart.Equals(Cart) && Orders.SequenceEqual(customer.Orders) && 
                Discounts.SequenceEqual(customer.Discounts);
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <returns><inheritdoc/></returns>
        public object Clone()
        {
            Customer customer = new Customer(FullName, (Adress)Adress.Clone(), IsPriority, 
                BirthDate, (Cart)Cart.Clone());
            foreach(Order order in Orders)
            {
                customer.Orders.Add((Order)order.Clone());
            }
            for (int n = 2; n < Discounts.Count; ++n)
            {
                customer.Discounts.Add((IDiscount)Discounts[n].Clone());
            }
            return customer;
        }
    }
}