using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        Color CorrectColor = Color.White;
        Color ErrorColor = Color.IndianRed;

        Model.Classes.Rectangle[] _rectangles;
        Model.Classes.Rectangle _currentRectangle  = new Model.Classes.Rectangle();

        Movie[] _movies;
        Movie _currentMovie = new Movie();

        public MainForm()
        {
            InitializeComponent();

            EnumListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumListBox.SelectedIndex = 0;

            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));

            int CountElements = 18;
            Random random = new Random();

            _rectangles = new Model.Classes.Rectangle[CountElements];
            for (int n = 0; n < _rectangles.Length; ++n)
            {
                _rectangles[n] = new Model.Classes.Rectangle(
                    (random.NextDouble() + 0.0001) * random.Next(1, 100), 
                    (random.NextDouble() + 0.0001) * random.Next(1, 100), 
                    ((Colour)random.Next(0, 9)).ToString());
                RectanglesListBox.Items.Add("Rectangle " + (n + 1));
            }

            _movies = new Movie[CountElements];
            for (int n = 0; n < _movies.Length; ++n)
            {
                _movies[n] = new Movie(
                    CreateRandomString(random.Next(1, 10), random),
                    (uint)random.Next(0, 500),
                    1900 + (uint)random.Next(0, 200),
                    ((Genre)random.Next(0, 6)).ToString(),
                    random.NextDouble() * random.Next(0, 10));
                MoviesListBox.Items.Add("Film " + (n + 1));
            }
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            int IndexMaxWidth = -1;
            if (rectangles.Length > 0)
            {
                IndexMaxWidth = 0;
                double Max = rectangles[IndexMaxWidth].Width;
                for (int n = 1; n < rectangles.Length; ++n)
                {
                    if (rectangles[n].Width > rectangles[IndexMaxWidth].Width)
                    {
                        IndexMaxWidth = n;
                    }
                }
            }
            return IndexMaxWidth;
        }

        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int IndexMaxRating = -1;
            if (movies.Length > 0)
            {
                IndexMaxRating = 0;
                double Max = movies[IndexMaxRating].Rating;
                for (int n = 1; n < movies.Length; ++n)
                {
                    if (movies[n].Rating > movies[IndexMaxRating].Rating)
                    {
                        IndexMaxRating = n;
                    }
                }
            }
            return IndexMaxRating;
        }

        private string CreateRandomString(int size, Random random)
        {
            string Result = ((char)random.Next(65, 91)).ToString();
            for (int n = 0; n < size - 1; ++n)
            {
                Result += (char)random.Next(97, 123);
            }
            return Result;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void EnumListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch((Enums)EnumListBox.SelectedItem)
            {
                case Enums.Weekday:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Weekday));
                    break;
                case Enums.Genre:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Genre));
                    break;
                case Enums.Colour:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Colour));
                    break;
                case Enums.StudyForm:
                    ValueListBox.DataSource = Enum.GetValues(typeof(StudyForm));
                    break;
                case Enums.SmartphoneManufacturers:
                    ValueListBox.DataSource = Enum.GetValues(typeof(SmartphoneManufacturers));
                    break;
                case Enums.Season:
                    ValueListBox.DataSource = Enum.GetValues(typeof(Season));
                    break;
                default:
                    throw new NotImplementedException();
            }
        }

        private void ValueListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ((int)ValueListBox.SelectedItem).ToString();
        }

        private void WeekParseButton_Click(object sender, EventArgs e)
        {
            Weekday day;
            if (Enum.TryParse(WeekParseTextBox.Text, out day))
            {
                WeekParseLabel.Text = $"This day of week ({day.ToString()} = {(int)day}).";
            }
            else
            {
                WeekParseLabel.Text = "There isn't such day in week!";
            }
        }

        private void SeasonButton_Click(object sender, EventArgs e)
        {
            switch ((Season)SeasonComboBox.SelectedItem)
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

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[RectanglesListBox.SelectedIndex];
            LengthRectanglesTextBox.Text = _currentRectangle.Length.ToString();
            WidthRectanglesTextBox.Text = _currentRectangle.Width.ToString();
            ColorRectanglesTextBox.Text = _currentRectangle.Color;
        }

        private void LengthRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = double.Parse(LengthRectanglesTextBox.Text);
                LengthRectanglesTextBox.BackColor = CorrectColor;
            }
            catch
            {
                LengthRectanglesTextBox.BackColor = ErrorColor;
            }
        }

        private void WidthRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = double.Parse(WidthRectanglesTextBox.Text);
                WidthRectanglesTextBox.BackColor = CorrectColor;
            }
            catch
            {
                WidthRectanglesTextBox.BackColor = ErrorColor;
            }
        }

        private void ColorRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorRectanglesTextBox.Text;
        }

        private void RectanglesButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentMovie = _movies[MoviesListBox.SelectedIndex];
            NameMoviesTextBox.Text = _currentMovie.Name;
            MinutesMoviesTextBox.Text = _currentMovie.Minutes.ToString();
            IssueYearMoviesTextBox.Text = _currentMovie.ReleaseYear.ToString();
            GenreMoviesTextBox.Text = _currentMovie.Genre;
            RatingMoviesTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void NameMoviesTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Name = NameMoviesTextBox.Text;
        }

        private void MinutesMoviesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Minutes = uint.Parse(MinutesMoviesTextBox.Text);
                MinutesMoviesTextBox.BackColor = CorrectColor;
            }
            catch
            {
                MinutesMoviesTextBox.BackColor = ErrorColor;
            }
        }

        private void RealiseYearMoviesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.ReleaseYear = uint.Parse(IssueYearMoviesTextBox.Text);
                IssueYearMoviesTextBox.BackColor = CorrectColor;
            }
            catch
            {
                IssueYearMoviesTextBox.BackColor = ErrorColor;
            }
        }

        private void GenreMoviesTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentMovie.Genre = GenreMoviesTextBox.Text;
        }

        private void RatingMoviesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentMovie.Rating = double.Parse(RatingMoviesTextBox.Text);
                RatingMoviesTextBox.BackColor = CorrectColor;
            }
            catch
            {
                RatingMoviesTextBox.BackColor = ErrorColor;
            }
        }

        private void MoviesButton_Click(object sender, EventArgs e)
        {
            MoviesListBox.SelectedIndex = FindMovieWithMaxRating(_movies);
        }
    }
}