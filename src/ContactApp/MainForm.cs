using System;
using System.Windows.Forms;

namespace ContactApp
{
    public partial class MainForm : Form
    {
        private Contact _contact = null;

        public MainForm(Contact contact)
        {
            InitializeComponent();

            _contact = contact;
            _contact.FullNameChanged += FullNameChanged;
            _contact.PhoneNumberChanged += PhoneNumberChanged;
            _contact.AdressChanged += AdressChanged;
        }

        private void FullNameChanged(object sender, EventArgs e)
        {
            FullNameTextBox.Text = _contact.FullName;
        }

        private void PhoneNumberChanged(object sender, EventArgs e)
        {
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
        }

        private void AdressChanged(object sender, EventArgs e)
        {
            AdressTextBox.Text = _contact.Adress;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.FullName = FullNameTextBox.Text;
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.PhoneNumber = PhoneNumberTextBox.Text;
        }

        private void AdressTextBox_TextChanged(object sender, EventArgs e)
        {
            _contact.Adress = AdressTextBox.Text;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _contact.FullNameChanged -= FullNameChanged;
            _contact.PhoneNumberChanged -= PhoneNumberChanged;
            _contact.AdressChanged -= AdressChanged;
        }
    }
}