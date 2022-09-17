using System;
using System.Windows.Forms;

using Programming.Model.Enums;
using Programming.Model.Classes;
using Programming.View;

namespace MovieApp.View.Controls
{
    /// <summary>
    /// Элемент управления для изменения экземпляра класса <see cref="Movie"/>.
    /// </summary>
    public partial class MovieEditorControl : UserControl
    {
        /// <summary>
        /// Экземпляр класса <see cref="Movie"/>
        /// </summary>
        private Movie _movie;

        /// <summary>
        /// Делегат для обработки информации.
        /// </summary>
        private delegate void Parse();

        /// <summary>
        /// Возвращает и задаёт экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie Movie
        {
            get
            {
                return _movie;
            }
            set
            {
                _movie = value;
                if (_movie == null)
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
        /// Возвращает и задаёт режим обновления <see cref="UpdateMode"/>.
        /// </summary>
        public UpdateType UpdateMode { set; get; }

        /// <summary>
        /// Обработчик события изменения <see cref="Movie"/>.
        /// </summary>
        public event EventHandler CurrentPropertyChanged;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MovieEditorControl"/>.
        /// </summary>
        public MovieEditorControl()
        {
            InitializeComponent();
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
        }

        /// <summary>
        /// Обрабатывает информацию для имени <see cref="Movie"/>.
        /// </summary>
        private void NameParse()
        {
            Validator.AssertValueInRange(NameTextBox.Text.Length, 0, 100, "Length of name");
            Movie.Name = NameTextBox.Text;
            UpdateMode = UpdateType.UpdateList;
        }

        /// <summary>
        /// Обрабатывает информацию для года выхода <see cref="Movie"/>.
        /// </summary>
        private void ReleaseYearParse()
        {
            Movie.ReleaseYear = int.Parse(ReleaseYearTextBox.Text);
            UpdateMode = UpdateType.UpdateCurrentObject;
        }

        /// <summary>
        /// Обрабатывает информацию для рейтинга <see cref="Movie"/>.
        /// </summary>
        private void RatingParse()
        {
            Movie.Rating = double.Parse(RatingTextBox.Text);
            UpdateMode = UpdateType.None;
        }

        /// <summary>
        /// Обрабатывает информацию для жанра <see cref="Movie"/>.
        /// </summary>
        private void GenreParse()
        {
            Movie.Genre = (Genre)GenreComboBox.SelectedItem;
            UpdateMode = UpdateType.UpdateCurrentObject;
        }

        /// <summary>
        /// Обрабатывает информацию для продолжительности в минутах <see cref="Movie"/>.
        /// </summary>
        private void DurationParse()
        {
            int value = int.Parse(DurationTextBox.Text);
            Validator.AssertValueInRange(value, 1, 300, "Duration");
            Movie.Minutes = value;
            UpdateMode = UpdateType.None;
        }

        /// <summary>
        /// Очищает информацию с элементов управления.
        /// </summary>
        private void ClearInfo()
        {
            NameTextBox.Text = ReleaseYearTextBox.Text = GenreComboBox.Text = RatingTextBox.Text =
                DurationTextBox.Text = null;
        }

        /// <summary>
        /// Заполняет информацию в элементы управления.
        /// </summary>
        private void FillInfo()
        {
            NameTextBox.Text = Movie.Name;
            ReleaseYearTextBox.Text = Movie.ReleaseYear.ToString();
            GenreComboBox.Text = Movie.Genre.ToString();
            RatingTextBox.Text = Movie.Rating.ToString();
            DurationTextBox.Text = Movie.Minutes.ToString();
        }

        /// <summary>
        /// Обновляет свойство <see cref="Movie"/>.
        /// </summary>
        /// <param name="control">Связанный с этим, элемент управления.</param>
        /// <param name="parse">Метод парсинга.</param>
        private void UpdateProperty(Control control, Parse parse)
        {
            if (Movie != null)
            {
                try
                {
                    parse();
                    control.BackColor = AppColors.CorrectColor;
                    ToolTip.RemoveAll();
                    CurrentPropertyChanged?.Invoke(this, EventArgs.Empty);
                }
                catch(Exception ex)
                {
                    control.BackColor = AppColors.ErrorColor;
                    ToolTip.SetToolTip(control, ex.Message);
                }
            }
            else
            {
                ClearInfo();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(NameTextBox, NameParse);
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(ReleaseYearTextBox, ReleaseYearParse);
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProperty(GenreComboBox, GenreParse);
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(RatingTextBox, RatingParse);
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateProperty(DurationTextBox, DurationParse);
        }
    }
}
