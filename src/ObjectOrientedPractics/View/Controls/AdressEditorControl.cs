using System;
using System.ComponentModel;
using System.Windows.Forms;

using ObjectOrientedPractics.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Элемент управления для изменения экземпляра класса <see cref="Model.Adress"/>.
    /// </summary>
    public partial class AdressEditorControl : UserControl
    {
        /// <summary>
        /// Экземпляр класса <see cref="Model.Adress"/>.
        /// </summary>
        private Adress _adress;

        /// <summary>
        /// Значение, указывающее, что элемент управления прездназначен только для чтения.
        /// </summary>
        private bool _isReadOnly = false;

        /// <summary>
        /// Делегат для обработки информации.
        /// </summary>
        private delegate void Parse();

        /// <summary>
        /// Возвращает и задаёт экземпляр класса <see cref="Model.Adress"/>.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Adress Adress
        {
            get => _adress;
            set
            {
                _adress = value;
                if (_adress == null)
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
        /// Возвращает и задаёт значение, указывающее, что элемент управления прездназначен только для чтения.
        /// </summary>
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsReadOnly
        {
            get => _isReadOnly;
            set
            {
                _isReadOnly = value;
                PostIndexTextBox.ReadOnly = CountryTextBox.ReadOnly = CityTextBox.ReadOnly =
                        StreetTextBox.ReadOnly = BuildingTextBox.ReadOnly =
                        ApartmentTextBox.ReadOnly = value;
            }
        }

        /// <summary>
        /// Обработчик события изменения <see cref="Model.Adress"/>.
        /// </summary>
        public event EventHandler CurrentPropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="AdressEditorControl"/> по-умолчанию.
        /// </summary>
        public AdressEditorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Adress.Index"/>.
        /// </summary>
        private void PostIndexParse()
        {
            Adress.Index = int.Parse(PostIndexTextBox.Text);
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Adress.Country"/>.
        /// </summary>
        private void CountryParse()
        {
            Adress.Country = CountryTextBox.Text;
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Adress.City"/>.
        /// </summary>
        private void CityParse()
        {
            Adress.City = CityTextBox.Text;
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Adress.Street"/>.
        /// </summary>
        private void StreetParse()
        {
            Adress.Street = StreetTextBox.Text;
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Adress.Building"/>.
        /// </summary>
        private void BuildingParse()
        {
            Adress.Building = BuildingTextBox.Text;
        }

        /// <summary>
        /// Обрабатывает информацию для <see cref="Adress.Apartment"/>.
        /// </summary>
        private void ApartmentParse()
        {
            Adress.Apartment = ApartmentTextBox.Text;
        }

        /// <summary>
        /// Очищает информацию с элементов управления.
        /// </summary>
        private void ClearInfo()
        {
            PostIndexTextBox.Text = CountryTextBox.Text = CityTextBox.Text = StreetTextBox.Text =
                BuildingTextBox.Text = ApartmentTextBox.Text = null;
        }

        /// <summary>
        /// Заполняет информацию в элементы управления.
        /// </summary>
        private void FillInfo()
        {
            PostIndexTextBox.Text = Adress.Index.ToString();
            CountryTextBox.Text = Adress.Country;
            CityTextBox.Text = Adress.City;
            StreetTextBox.Text = Adress.Street;
            BuildingTextBox.Text = Adress.Building;
            ApartmentTextBox.Text = Adress.Apartment;
        }

        /// <summary>
        /// Обновляет свойство <see cref="Customer"/>.
        /// </summary>
        /// <param name="control">Связанный с этим, элемент управления.</param>
        /// <param name="parse">Метод парсинга.</param>
        private void UpdateProperty(Control control, Parse parse)
        {
            if (Adress != null)
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

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(PostIndexTextBox, PostIndexParse);
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(CountryTextBox, CountryParse);
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(CityTextBox, CityParse);
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(StreetTextBox, StreetParse);
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(BuildingTextBox, BuildingParse);
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(ApartmentTextBox, ApartmentParse);
        }
    }
}