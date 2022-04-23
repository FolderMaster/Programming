using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

using Programming.Model.Enums;
using Programming.Model.Classes;
using Programming.Model.Classes.Geometry;

using Rectangle = Programming.Model.Classes.Geometry.Rectangle;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private readonly Color _correctColor = Color.White;

        private readonly Color _errorColor = Color.Yellow;

        private readonly Color _collisionColor = Color.FromArgb(127, 255, 127, 127);

        private readonly Color _noneCollisionColor = Color.FromArgb(127, 127, 255, 127);

        private Movie[] _movies;

        private Movie _currentMovie = new Movie();

        private Rectangle _currentRectangle = new Rectangle();

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private BindingSource _bindingSource = new BindingSource();

        private List<Panel> _rectanglePanels = new List<Panel>();

        public MainForm()
        {
            InitializeComponent();

            EnumsEnumsListBox.DataSource = Enum.GetValues(typeof(Enums));
            EnumsEnumsListBox.SelectedIndex = 0;

            EnumsSeasonComboBox.DataSource = Enum.GetValues(typeof(Season));

            int count = 5;
            CreateRectangles(count);
            CreateMovies(count);

            _bindingSource.DataSource = _rectangles;
            RectanglesListListBox.DataSource = _bindingSource;
            ClassesRectanglesListBox.DataSource = _bindingSource;
        }
        private void CreateRectangle()
        {
            //Visual Studio don't want to work correctly!
            Rectangle currentRectangle = RectangleFactory.Randomize(RectanglesCanvasPanel.Width, RectanglesCanvasPanel.Height);
            _currentRectangle = currentRectangle;
            _rectangles.Add(_currentRectangle);
            _bindingSource.ResetBindings(false);

            Panel panel = new Panel()
            {
                BackColor = _noneCollisionColor,
                Size = new Size((int)currentRectangle.Length, (int)currentRectangle.Width),
                Location = new Point(
                    (int)(currentRectangle.Center.X - currentRectangle.Length / 2),
                    (int)(currentRectangle.Center.Y - currentRectangle.Width / 2))
            };
            _rectanglePanels.Add(panel);
            RectanglesCanvasPanel.Controls.Add(panel);
        }

        private void CreateRectangles(int count)
        {
            for (int n = 0; n < count; ++n)
            {
                CreateRectangle();
            }
            FindCollisions();
        }

        private void FindCollisions()
        {
            _rectanglePanels.ForEach(panel => panel.BackColor = _noneCollisionColor);
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (i != j)
                    {
                        if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                        {
                            _rectanglePanels[i].BackColor = _collisionColor;
                            _rectanglePanels[j].BackColor = _collisionColor;
                        }
                    }
                }
            }
            RectanglesCanvasPanel.Update();
        }

        private void FindCollisions(int index)
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                if (i != index)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[index]))
                    {
                        _rectanglePanels[i].BackColor = _collisionColor;
                        _rectanglePanels[index].BackColor = _collisionColor;
                    }
                }
            }
            RectanglesCanvasPanel.Update();
        }

        private void UpdateRectangleProperty(int index, Rectangle rectangle, Panel panel)
        {
            panel.Size = new Size((int)rectangle.Length, (int)rectangle.Width);
            panel.Location = new Point(
                (int)(_currentRectangle.Center.X - _currentRectangle.Length / 2),
                (int)(_currentRectangle.Center.Y - _currentRectangle.Width / 2));
            FindCollisions(index);
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            RectanglesInfoIdTextBox.Text = _currentRectangle.Id.ToString();
            RectanglesInfoXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectanglesInfoYTextBox.Text = _currentRectangle.Center.Y.ToString();
            RectanglesInfoWidthTextBox.Text = _currentRectangle.Length.ToString();
            RectanglesInfoHeightTextBox.Text = _currentRectangle.Width.ToString();
        }

        private void ClearRectangleInfo()
        {
            RectanglesInfoIdTextBox.Text = RectanglesInfoXTextBox.Text =
                    RectanglesInfoYTextBox.Text = RectanglesInfoWidthTextBox.Text =
                    RectanglesInfoHeightTextBox.Text = "";
            RectanglesInfoIdTextBox.BackColor = RectanglesInfoXTextBox.BackColor =
                RectanglesInfoYTextBox.BackColor = RectanglesInfoWidthTextBox.BackColor =
                RectanglesInfoHeightTextBox.BackColor = _correctColor;
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

        private int FindRectangleWithMaxWidth(List<Rectangle> rectangles)
        {
            int indexMaxWidth = -1;
            if (rectangles.Count > 0)
            {
                indexMaxWidth = 0;
                for (int n = 1; n < rectangles.Count; ++n)
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
            _currentRectangle = (Rectangle)ClassesRectanglesListBox.SelectedItem;
            if(_currentRectangle != null)
            {
                ClassesRectanglesLengthTextBox.Text = _currentRectangle.Length.ToString();
                ClassesRectanglesWidthTextBox.Text = _currentRectangle.Width.ToString();
                ClassesRectanglesCenterTextBox.Text = $"{_currentRectangle.Center.X}; {_currentRectangle.Center.Y}";
                ClassesRectanglesColorTextBox.Text = _currentRectangle.Color.ToString();
                ClassesRectanglesIdTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void ClassesRectanglesLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentRectangle.Length = double.Parse(ClassesRectanglesLengthTextBox.Text);
                ClassesRectanglesLengthTextBox.BackColor = _correctColor;
                _bindingSource.ResetBindings(false);
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
                _bindingSource.ResetBindings(false);
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
                _bindingSource.ResetBindings(false);
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

        private void RectanglesListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = (Rectangle)RectanglesListListBox.SelectedItem;
            if(_currentRectangle == null || RectanglesListListBox.SelectedItem == null)
            {
                ClearRectangleInfo();
            }
            else
            {
                UpdateRectangleInfo(_currentRectangle);
            }
        }

        private void RectanglesActionsAddButton_Click(object sender, EventArgs e)
        {
            CreateRectangle();
            FindCollisions(_rectanglePanels.Count - 1);
        }

        private void RectanglesActionsRemoveButton_Click(object sender, EventArgs e)
        {
            if (_currentRectangle != null && RectanglesListListBox.SelectedIndex != -1)
            {
                RectanglesCanvasPanel.Controls.RemoveAt(RectanglesListListBox.SelectedIndex);
                _rectanglePanels.RemoveAt(RectanglesListListBox.SelectedIndex);
                FindCollisions();
                _rectangles.Remove(_currentRectangle);
                _bindingSource.ResetBindings(false);
            }
        }

        private void RectanglesInfoXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Center.X = double.Parse(RectanglesInfoXTextBox.Text);
                    RectanglesInfoXTextBox.BackColor = _correctColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(RectanglesListListBox.SelectedIndex, _currentRectangle, _rectanglePanels[RectanglesListListBox.SelectedIndex]);
                }
                catch
                {
                    RectanglesInfoXTextBox.BackColor = _errorColor;
                }
            }
        }

        private void RectanglesInfoYTextBox_TextChanged(object sender, EventArgs e)
        {
            if(_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Center.Y = double.Parse(RectanglesInfoYTextBox.Text);
                    RectanglesInfoYTextBox.BackColor = _correctColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(RectanglesListListBox.SelectedIndex, _currentRectangle, _rectanglePanels[RectanglesListListBox.SelectedIndex]);
                }
                catch
                {
                    RectanglesInfoYTextBox.BackColor = _errorColor;
                }
            }
        }

        private void RectanglesInfoWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Length = double.Parse(RectanglesInfoWidthTextBox.Text);
                    RectanglesInfoWidthTextBox.BackColor = _correctColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(RectanglesListListBox.SelectedIndex, _currentRectangle, _rectanglePanels[RectanglesListListBox.SelectedIndex]);
                }
                catch
                {
                    RectanglesInfoWidthTextBox.BackColor = _errorColor;
                }
            }
        }

        private void RectanglesInfoHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Width = double.Parse(RectanglesInfoHeightTextBox.Text);
                    RectanglesInfoHeightTextBox.BackColor = _correctColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(RectanglesListListBox.SelectedIndex, _currentRectangle, _rectanglePanels[RectanglesListListBox.SelectedIndex]);
                }
                catch
                {
                    RectanglesInfoHeightTextBox.BackColor = _errorColor;
                }
            }
        }

        private void RectanglesActionsAddButton_MouseEnter(object sender, EventArgs e)
        {
            RectanglesActionsAddButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("rectangle_add_24x24");
            RectanglesActionsAddButton.FlatAppearance.BorderSize = 0;
        }

        private void RectanglesActionsAddButton_MouseLeave(object sender, EventArgs e)
        {
            RectanglesActionsAddButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("rectangle_add_24x24_uncolor");
            RectanglesActionsAddButton.FlatAppearance.BorderSize = 1;
        }

        private void RectanglesActionsAddButton_MouseDown(object sender, MouseEventArgs e)
        {
            RectanglesActionsAddButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("rectangle_add_24x24_uncolor");
        }

        private void RectanglesActionsRemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RectanglesActionsRemoveButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("rectangle_remove_24x24");
            RectanglesActionsRemoveButton.FlatAppearance.BorderSize = 0;
        }

        private void RectanglesActionsRemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RectanglesActionsRemoveButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("rectangle_remove_24x24_uncolor");
            RectanglesActionsRemoveButton.FlatAppearance.BorderSize = 1;
        }

        private void RectanglesActionsRemoveButton_MouseDown(object sender, MouseEventArgs e)
        {
            RectanglesActionsRemoveButton.Image = (Image)Properties.Resources.ResourceManager.GetObject("rectangle_remove_24x24_uncolor");
        }
    }
}