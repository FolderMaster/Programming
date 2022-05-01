using System;
using System.Drawing;
using System.Windows.Forms;

using Programming.Model.Enums;
using Programming.Model.Classes.Geometry;

using Rectangle = Programming.Model.Classes.Geometry.Rectangle;

namespace Programming.View.Controls
{
    public partial class RectanglesControl : UserControl
    {
        private readonly Color _correctColor = Color.White;

        private readonly Color _errorColor = Color.Yellow;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        public RectanglesControl()
        {
            InitializeComponent();

            CreateRectangles(18);
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
                ListBox.Items.Add("Rectangle " + (n + 1));
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

        private void ClassesRectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = _rectangles[ListBox.SelectedIndex];

            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            CenterTextBox.Text = $"{_currentRectangle.Center.X}; {_currentRectangle.Center.Y}";
            ColorTextBox.Text = _currentRectangle.Color.ToString();
            IdTextBox.Text = _currentRectangle.Id.ToString();
        }

        private void ClassesRectanglesLengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Length = double.Parse(LengthTextBox.Text);
                    LengthTextBox.BackColor = _correctColor;
                }
                catch
                {
                    LengthTextBox.BackColor = _errorColor;
                }
            }
        }

        private void ClassesRectanglesWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if(_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Width = double.Parse(WidthTextBox.Text);
                    WidthTextBox.BackColor = _correctColor;
                }
                catch
                {
                    WidthTextBox.BackColor = _errorColor;
                }
            }
        }

        private void ClassesRectanglesColorTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Color = (Colour)Enum.Parse(typeof(Colour),
                        ColorTextBox.Text);
                    ColorTextBox.BackColor = _correctColor;
                }
                catch
                {
                    ColorTextBox.BackColor = _errorColor;
                }
            }
        }

        private void ClassesRectanglesButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedIndex = FindRectangleWithMaxWidth(_rectangles);
        }
    }
}
