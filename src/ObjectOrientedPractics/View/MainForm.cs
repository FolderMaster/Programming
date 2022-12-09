﻿using System;
using System.Windows.Forms;

using ObjectOrientedPractics.Services.Factories;
using ObjectOrientedPractics.Services.IO;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Основное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Магазин.
        /// </summary>
        Store _store = new Store();

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/> по-умолчанию.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Store store = null;
            try
            {
                store = JsonManager.Load<SaveFormat>(Settings.SavePath).Store;

                CustomerFactory.Load(Settings.CustomersPath);
                ItemFactory.Load(Settings.ItemsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                _store = store == null ? _store : store;

                ItemsTab.Items = _store.Items;
                CartsTab.Items = _store.Items;
                CustomersTab.Items = _store.Items;
                CustomersTab.Customers = _store.Customers;
                CartsTab.Customers = _store.Customers;
                OrdersTab.Customers = _store.Customers;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                SaveFormat save = new SaveFormat(_store);
                JsonManager.Save(save, Settings.SavePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void ItemsTab_ItemsChanged(object sender, EventArgs e)
        {
            CartsTab.RefreshItems();
        }

        private void CustomersTab_CustomersChanged(object sender, EventArgs e)
        {
            CartsTab.RefreshCustomers();
        }

        private void CustomersTab_OrderCreated(object sender, EventArgs e)
        {
            OrdersTab.RefreshData();
        }

        private void CartsTab_OrderCreated(object sender, EventArgs e)
        {
            OrdersTab.RefreshData();
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabControl.SelectedIndex == 2)
            {
                CartsTab.RefreshItems();
                CartsTab.RefreshCustomers();
            }
            else if(TabControl.SelectedIndex == 3)
            {
                OrdersTab.RefreshData();
            }
        }
    }
}