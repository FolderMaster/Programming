using System;
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
            try
            {
                _store = JsonManager.Load<SaveFormat>(Settings.SavePath).Store;
                if(_store != null)
                {
                    ItemsTab.Items = _store.Items;
                    CustomersTab.Customers = _store.Customers;
                }

                CustomerFactory.Load(Settings.CustomersPath);
                ItemFactory.Load(Settings.ItemsPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
    }
}