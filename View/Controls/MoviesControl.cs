using System;
using System.Drawing;
using System.Windows.Forms;

using Programming.Model.Enums;
using Programming.Model.Classes;

namespace Programming.View.Controls
{
    /// <summary>
    /// Элемент управления длля работы с массивом экземпляров класса <see cref="Movie"/>.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Массив экземпляров класса <see cref="Movie"/>.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Выбранный экземпляр класса <see cref="Movie"/>.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MoviesControl"/>.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            CreateMovies(18);
        }

        /// <summary>
        /// Создаёт массив экземпляров класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="count">Количество элементов массива.</param>
        private void CreateMovies(int count)
        {
            Random random = new Random();
            _movies = new Movie[count];
            for (int n = 0; n < _movies.Length; ++n)
            {
                _movies[n] = new Movie(
                    CreateRandomString(random.Next(1, 10), random),
                    random.Next(0, 500),
                    1900 + random.Next(0, DateTime.Now.Year - 1900),
                    (Genre)random.Next(0, 7),
                    Math.Round(random.NextDouble() * random.Next(0, 10), 10));
                ListBox.Items.Add("Movie " + (n + 1));
            }
        }

        /// <summary>
        /// Находит в массиве экземпляров класса <see cref="Movie"/>
        /// элемент с максимальным <see cref="Movie.Rating"/>.
        /// </summary>
        /// <param name="movies">Массив экземпляров класса <see cref="Movie"/>.</param>
        /// <returns>Индекс элемента с максимальным <see cref="Movie.Rating"/>.</returns>
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int indexMaxRating = -1;
            if (movies.Length > 0)
            {
                indexMaxRating = 0;
                for (int n = 1; n < movies.Length; ++n)
                {
                    if (movies[n].Rating > movies[indexMaxRating].Rating)
                    {
                        indexMaxRating = n;
                    }
                }
            }
            return indexMaxRating;
        }

        /// <summary>
        /// Создаёт строку с случайными буквами латинского алфавита.
        /// </summary>
        /// <param name="size">Размер строки.</param>
        /// <param name="random">Экземпляр генератора случайных чисел.</param>
        /// <returns>Строка, состоящая из случайных букв латинского алфавита.</returns>
        private string CreateRandomString(int size, Random random)
        {
            string result = ((char)random.Next(65, 91)).ToString();
            for (int n = 0; n < size - 1; ++n)
            {
                result += (char)random.Next(97, 123);
            }
            return result;
        }

        private void ClassesMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[ListBox.SelectedIndex];

            NameTextBox.Text = _currentMovie.Name;
            MinutesTextBox.Text = _currentMovie.Minutes.ToString();
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            GenreTextBox.Text = _currentMovie.Genre.ToString();
            RatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void ClassesMoviesNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(_currentMovie != null)
            {
                _currentMovie.Name = NameTextBox.Text;
            }
        }

        private void ClassesMoviesMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                try
                {
                    _currentMovie.Minutes = int.Parse(MinutesTextBox.Text);
                    MinutesTextBox.BackColor = AppColors.CorrectColor;
                }
                catch
                {
                    MinutesTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void ClassesMoviesReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                try
                {
                    _currentMovie.ReleaseYear = int.Parse(ReleaseYearTextBox.Text);
                    ReleaseYearTextBox.BackColor = AppColors.CorrectColor;
                }
                catch
                {
                    ReleaseYearTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void ClassesMoviesGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                try
                {
                    _currentMovie.Genre = (Genre)Enum.Parse(typeof(Genre),
                        GenreTextBox.Text);
                    GenreTextBox.BackColor = AppColors.CorrectColor;
                }
                catch
                {
                    GenreTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void ClassesMoviesRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentMovie != null)
            {
                try
                {
                    _currentMovie.Rating = double.Parse(RatingTextBox.Text);
                    RatingTextBox.BackColor = AppColors.CorrectColor;
                }
                catch
                {
                    RatingTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void ClassesMoviesButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}
