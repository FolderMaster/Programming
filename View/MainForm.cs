using System;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Enums;
using Programming.Model.Classes;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            int size = 18;
            Random random = new Random();

            _rectangles = new Model.Classes.Rectangle[size];
            for (int n = 0; n < _rectangles.Length; ++n)
            {
                _rectangles[n] = new Model.Classes.Rectangle((float)(random.NextDouble() + 0.0001) * random.Next(1, 100), (float)(random.NextDouble() + 0.0001) * random.Next(1, 100), ((Colour)random.Next(0, 9)).ToString());
                RectanglesListBox.Items.Add("Rectangle " + (n + 1));
            }

            _films = new Film[size];
            for (int n = 0; n < _films.Length; ++n)
            {
                _films[n] = new Film(RandomString(random.Next(1, 10), random), (uint)random.Next(0, 500), 1900 + (uint)random.Next(0, 200), ((Genre)random.Next(0, 6)).ToString(), (float)random.NextDouble() * random.Next(0, 10));
                FilmsListBox.Items.Add("Film " + (n + 1));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumListBox.SelectedIndex = 0;

            SeasonComboBox.DataSource = Enum.GetValues(typeof(Season));
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

        Model.Classes.Rectangle[] _rectangles;
        Model.Classes.Rectangle _currentRectangle;

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
                _currentRectangle.Length = float.Parse(LengthRectanglesTextBox.Text);
                LengthRectanglesTextBox.BackColor = Color.White;
            }
            catch
            {
                LengthRectanglesTextBox.BackColor = Color.Red;
            }
        }

        private void WidthRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Width = float.Parse(WidthRectanglesTextBox.Text);
                WidthRectanglesTextBox.BackColor = Color.White;
            }
            catch
            {
                WidthRectanglesTextBox.BackColor = Color.Red;
            }
        }

        private void ColorRectanglesTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorRectanglesTextBox.Text;
        }

        private int FindRectangleWithMaxWidth(Model.Classes.Rectangle[] rectangles)
        {
            int IndexMax = -1;
            if(rectangles.Length > 0)
            {
                IndexMax = 0;
                float Max = rectangles[IndexMax].Width;
                for (int n = 1; n < rectangles.Length; ++n)
                {
                    if(rectangles[n].Width > rectangles[IndexMax].Width)
                    {
                        IndexMax = n;
                    }
                }
            }
            return IndexMax;
        }

        private void RectanglesButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }

        Film[] _films;
        Film _currentFilm;

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentFilm = _films[FilmsListBox.SelectedIndex];
            NameFilmsTextBox.Text = _currentFilm.Name;
            MinutesFilmsTextBox.Text = _currentFilm.Minutes.ToString();
            IssueYearFilmsTextBox.Text = _currentFilm.IssueYear.ToString();
            GenreFilmsTextBox.Text = _currentFilm.Genre;
            RatingFilmsTextBox.Text = _currentFilm.Rating.ToString();
        }

        private void NameFilmsTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Name = NameFilmsTextBox.Text;
        }

        private void MinutesFilmsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Minutes = uint.Parse(MinutesFilmsTextBox.Text);
                MinutesFilmsTextBox.BackColor = Color.White;
            }
            catch
            {
                MinutesFilmsTextBox.BackColor = Color.Red;
            }
        }

        private void IssueYearFilmsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.IssueYear = uint.Parse(IssueYearFilmsTextBox.Text);
                IssueYearFilmsTextBox.BackColor = Color.White;
            }
            catch
            {
                IssueYearFilmsTextBox.BackColor = Color.Red;
            }
        }

        private void GenreFilmsTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreFilmsTextBox.Text;
        }

        private void RatingFilmsTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentFilm.Rating = float.Parse(RatingFilmsTextBox.Text);
                RatingFilmsTextBox.BackColor = Color.White;
            }
            catch
            {
                RatingFilmsTextBox.BackColor = Color.Red;
            }
        }

        private int FindFilmWithMaxRating(Film[] films)
        {
            int IndexMax = -1;
            if (films.Length > 0)
            {
                IndexMax = 0;
                float Max = films[IndexMax].Rating;
                for (int n = 1; n < films.Length; ++n)
                {
                    if (films[n].Rating > films[IndexMax].Rating)
                    {
                        IndexMax = n;
                    }
                }
            }
            return IndexMax;
        }

        private void FilmsButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating(_films);
        }

        private string RandomString(int size, Random random)
        {
            string Result = ((char)random.Next(65, 91)).ToString();
            for(int n = 0; n < size - 1; ++n)
            {
                Result += (char)random.Next(97, 123);
            }
            return Result;
        }
    }
}