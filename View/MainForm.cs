using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;

using Rectangle = Programming.Model.Classes.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly Color _correctColor = Color.White;

        private readonly Color _errorColor = Color.Yellow;

        private Rectangle[] _rectangles;
        
        private Rectangle _currentRectangle  = new Rectangle();

        private Movie[] _movies;

        private Movie _currentMovie = new Movie();

        public MainForm()
        {
            InitializeComponent();

            EnumsEnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsEnumsListBox.SelectedIndex = 0;

            EnumsSeasonComboBox.DataSource = Enum.GetValues(typeof(Season));

            int count = 18;
            CreateRectangles(count);
            CreateMovies(count);
        }

        private void CreateRectangles(int count)
        {
            Random random = new Random();
            _rectangles = new Rectangle[count];
            for (int n = 0; n < _rectangles.Length; ++n)
            {
                _rectangles[n] = new Rectangle(
                    Math.Round((random.NextDouble() + 0.0001) * random.Next(1, 100), 10),
                    Math.Round((random.NextDouble() + 0.0001) * random.Next(1, 100), 10),
                    new Point2D(
                        Math.Round((random.NextDouble() + 0.0001) * random.Next(1, 100), 3),
                        Math.Round((random.NextDouble() + 0.0001) * random.Next(1, 100), 3)),
                    (Colour)random.Next(0, 9));
                ClassesRectanglesListBox.Items.Add("Rectangle " + (n + 1));
            }
        }

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
                ClassesMoviesListBox.Items.Add("Movie " + (n + 1));
            }
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int indexMaxWidth = -1;
            if (rectangles.Length > 0)
            {
                indexMaxWidth = 0;
                for (int n = 1; n < rectangles.Length; ++n)
                {
                    if (rectangles[n].Width > rectangles[indexMaxWidth].Width)
                    {
                        indexMaxWidth = n;
                    }
                }
            }
            return indexMaxWidth;
        }

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

        private string CreateRandomString(int size, Random random)
        {
            string result = ((char)random.Next(65, 91)).ToString();
            for (int n = 0; n < size - 1; ++n)
            {
                result += (char)random.Next(97, 123);
            }
            return result;
        }

        private void EnumsEnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((Enums)EnumsEnumsListBox.SelectedItem)
            {
                case Enums.Weekday:
                    EnumsValueListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Genre:
                    EnumsValueListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Colour:
                    EnumsValueListBox.DataSource = Enum.GetValues(typeof(Colour));
                    break;
                case Enums.StudyForm:
                    EnumsValueListBox.DataSource = Enum.GetValues(typeof(StudyForm));
                    break;
                case Enums.SmartphoneManufacturers:
                    EnumsValueListBox.DataSource = Enum.GetValues(typeof(SmartphoneManufacturers));
                    break;
                case Enums.Season:
                    EnumsValueListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void EnumsValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnumIntTextBox.Text = ((int)EnumsValueListBox.SelectedItem).ToString();
        }

        private void EnumsWeekdayParseButton_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(EnumsWeekdayParseTextBox.Text, out day))
            {
                EnumsWeekdayParseLabel.Text = $"This day of week ({day.ToString()} = {(int)day}).";
            }
            else
            {
                EnumsWeekdayParseLabel.Text = "There isn't such day in week!";
            }
        }

        private void EnumsSeasonButton_Click(object sender, EventArgs e)
        {
            switch ((Season)EnumsSeasonComboBox.SelectedItem)
            {
                case Season.Winter:
                    MessageBox.Show("Br-r-r! Coldly!", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    break;
                case Season.Spring:
                    BackColor = Color.LightGreen;
                    break;
                case Season.Summer:
                    MessageBox.Show("Hooray! Sun!", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    break;
                case Season.Autumn:
                    BackColor = Color.Orange;
                    break;
                default:
                    MessageBox.Show("Not selected season!", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void ClassesRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[ClassesRectanglesListBox.SelectedIndex];
            ClassesRectanglesLengthTextBox.Text = _currentRectangle.Length.ToString();
            ClassesRectanglesWidthTextBox.Text = _currentRectangle.Width.ToString();
            ClassesRectanglesCenterTextBox.Text = $"{_currentRectangle.Center.X}; {_currentRectangle.Center.Y}";
            ClassesRectanglesColorTextBox.Text = _currentRectangle.Color.ToString();
            ClassesRectanglesIdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void ClassesRectanglesLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = double.Parse(ClassesRectanglesLengthTextBox.Text);
                ClassesRectanglesLengthTextBox.BackColor = _correctColor;
            }
            catch
            {
                ClassesRectanglesLengthTextBox.BackColor = _errorColor;
            }
        }

        private void ClassesRectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = double.Parse(ClassesRectanglesWidthTextBox.Text);
                ClassesRectanglesWidthTextBox.BackColor = _correctColor;
            }
            catch
            {
                ClassesRectanglesWidthTextBox.BackColor = _errorColor;
            }
        }

        private void ClassesRectanglesColorTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Color = (Colour)Enum.Parse(typeof(Colour), ClassesRectanglesColorTextBox.Text);
                ClassesRectanglesColorTextBox.BackColor = _correctColor;
            }
            catch
            {
                ClassesRectanglesColorTextBox.BackColor = _errorColor;
            }
        }

        private void ClassesRectanglesButton_Click(object sender, EventArgs e)
        {
            ClassesRectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void ClassesMoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[ClassesMoviesListBox.SelectedIndex];

            ClassesMoviesNameTextBox.Text = _currentMovie.Name;
            ClassesMoviesMinutesTextBox.Text = _currentMovie.Minutes.ToString();
            ClassesMoviesReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            ClassesMoviesGenreTextBox.Text = _currentMovie.Genre.ToString();
            ClassesMoviesRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void ClassesMoviesNameTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = ClassesMoviesNameTextBox.Text;
        }

        private void ClassesMoviesMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Minutes = int.Parse(ClassesMoviesMinutesTextBox.Text);
                ClassesMoviesMinutesTextBox.BackColor = _correctColor;
            }
            catch
            {
                ClassesMoviesMinutesTextBox.BackColor = _errorColor;
            }
        }

        private void ClassesMoviesReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseYear = int.Parse(ClassesMoviesReleaseYearTextBox.Text);
                ClassesMoviesReleaseYearTextBox.BackColor = _correctColor;
            }
            catch
            {
                ClassesMoviesReleaseYearTextBox.BackColor = _errorColor;
            }
        }

        private void ClassesMoviesGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Genre = (Genre)Enum.Parse(typeof(Genre), ClassesMoviesGenreTextBox.Text);
                ClassesMoviesGenreTextBox.BackColor = _correctColor;
            }
            catch
            {
                ClassesMoviesGenreTextBox.BackColor = _errorColor;
            }
        }

        private void ClassesMoviesRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = double.Parse(ClassesMoviesRatingTextBox.Text);
                ClassesMoviesRatingTextBox.BackColor = _correctColor;
            }
            catch
            {
                ClassesMoviesRatingTextBox.BackColor = _errorColor;
            }
        }

        private void ClassesMoviesButton_Click(object sender, EventArgs e)
        {
            ClassesMoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}