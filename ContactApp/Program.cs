using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ContactApp
{
    internal class Program : ApplicationContext
    {
        private MainForm _mainForm1 = null;

        private MainForm _mainForm2 = null;

        private MainForm _mainForm3 = null;

        private int _formCount = 0;

        public Program()
        {
            Contact contact = new Contact();

            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            _mainForm1 = new MainForm(contact);
            _mainForm1.Closed += new EventHandler(OnFormClosed);
            _mainForm1.Closing += new CancelEventHandler(OnFormClosing);
            _formCount++;

            _mainForm2 = new MainForm(contact);
            _mainForm2.Closed += new EventHandler(OnFormClosed);
            _mainForm2.Closing += new CancelEventHandler(OnFormClosing);
            _formCount++;

            _mainForm3 = new MainForm(contact);
            _mainForm3.Closed += new EventHandler(OnFormClosed);
            _mainForm3.Closing += new CancelEventHandler(OnFormClosing);
            _formCount++;

            _mainForm1.Show();
            _mainForm2.Show();
            _mainForm3.Show();
        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
        }

        private void OnFormClosing(object sender, CancelEventArgs e)
        {
        }

        private void OnFormClosed(object sender, EventArgs e)
        {
            _formCount--;
            if (_formCount == 0)
            {
                ExitThread();
            }
        }

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Program());
            
        }
    }
}
