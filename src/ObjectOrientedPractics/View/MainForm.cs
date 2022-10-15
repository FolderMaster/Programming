using System;
using System.Windows.Forms;

using ObjectOrientedPractics.Services.Factories;
using ObjectOrientedPractics.Services.IO;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Основное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
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
                SaveFormat save = JsonManager.Load<SaveFormat>(Settings.SavePath);
                if(save != null)
                {
                    ItemsTab.Items = save.Items;
                    CustomersTab.Customers = save.Customers;
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
                SaveFormat save = new SaveFormat(ItemsTab.Items, CustomersTab.Customers);
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