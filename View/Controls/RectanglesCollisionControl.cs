using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Programming.Model.Classes.Geometry;

using Rectangle = Programming.Model.Classes.Geometry.Rectangle;

namespace Programming.View.TabPages
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private readonly Color _correctColor = Color.White;

        private readonly Color _errorColor = Color.Yellow;

        private readonly Color _collisionColor = Color.FromArgb(127, 255, 127, 127);

        private readonly Color _noneCollisionColor = Color.FromArgb(127, 127, 255, 127);

        private Rectangle _currentRectangle;

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private BindingSource _bindingSource = new BindingSource();

        private List<Panel> _rectanglePanels = new List<Panel>();

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            CreateRectangles(5);
            _bindingSource.DataSource = _rectangles;
            ListListBox.DataSource = _bindingSource;
        }

        private void CreateRectangle()
        {
            //Visual Studio don't want to work correctly!
            Rectangle currentRectangle = RectangleFactory.Randomize(CanvasPanel.Width,
                CanvasPanel.Height);
            _currentRectangle = currentRectangle;
            _rectangles.Add(_currentRectangle);

            Panel panel = new Panel()
            {
                BackColor = _noneCollisionColor,
                Size = new Size((int)currentRectangle.Length, (int)currentRectangle.Width),
                Location = new Point(
                    (int)(currentRectangle.Center.X - currentRectangle.Length / 2),
                    (int)(currentRectangle.Center.Y - currentRectangle.Width / 2))
            };
            _rectanglePanels.Add(panel);
            CanvasPanel.Controls.Add(panel);
        }

        private void CreateRectangles(int count)
        {
            for (int n = 0; n < count; ++n)
            {
                CreateRectangle();
            }
            _bindingSource.ResetBindings(false);
            FindCollisions();
        }

        private void FindCollisions()
        {
            _rectanglePanels.ForEach(panel => panel.BackColor = _noneCollisionColor);
            bool[] isCollision = new bool[_rectangles.Count];
            for (int i = 0; i < _rectanglePanels.Count && !isCollision[i]; i++)
            {
                for (int j = 0; j < _rectanglePanels.Count; j++)
                {
                    if (i != j)
                    {
                        if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                        {
                            _rectanglePanels[i].BackColor = _collisionColor;
                            _rectanglePanels[j].BackColor = _collisionColor;

                            isCollision[i] = true;
                            isCollision[j] = true;
                        }
                    }
                }
            }
            CanvasPanel.Update();
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
            CanvasPanel.Update();
        }

        private void UpdateRectangleProperty(int index, Rectangle rectangle, Panel panel)
        {
            panel.Size = new Size((int)rectangle.Length, (int)rectangle.Width);
            panel.Location = new Point(
                (int)(rectangle.Center.X - rectangle.Length / 2),
                (int)(rectangle.Center.Y - rectangle.Width / 2));
            FindCollisions();
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            InfoIdTextBox.Text = _currentRectangle.Id.ToString();
            InfoXTextBox.Text = _currentRectangle.Center.X.ToString();
            InfoYTextBox.Text = _currentRectangle.Center.Y.ToString();
            InfoWidthTextBox.Text = _currentRectangle.Length.ToString();
            InfoHeightTextBox.Text = _currentRectangle.Width.ToString();
        }

        private void ClearRectangleInfo()
        {
            InfoIdTextBox.Text = InfoXTextBox.Text =
                    InfoYTextBox.Text = InfoWidthTextBox.Text =
                    InfoHeightTextBox.Text = "";
            InfoIdTextBox.BackColor = InfoXTextBox.BackColor =
                InfoYTextBox.BackColor = InfoWidthTextBox.BackColor =
                InfoHeightTextBox.BackColor = _correctColor;
        }

        private void ListListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = (Rectangle)ListListBox.SelectedItem;
            if (_currentRectangle == null || ListListBox.SelectedItem == null)
            {
                ClearRectangleInfo();
            }
            else
            {
                UpdateRectangleInfo(_currentRectangle);
            }
        }

        private void ActionsAddButton_Click(object sender, EventArgs e)
        {
            CreateRectangle();
            _bindingSource.ResetBindings(false);
            FindCollisions(_rectanglePanels.Count - 1);
        }

        private void ActionsAddButton_MouseEnter(object sender, EventArgs e)
        {
            ActionsAddButton.Image =
                (Image)Properties.Resources.ResourceManager.GetObject("rectangle_add_24x24");
            ActionsAddButton.FlatAppearance.BorderSize = 0;
        }

        private void ActionsAddButton_MouseLeave(object sender, EventArgs e)
        {
            ActionsAddButton.Image =
                (Image)Properties.Resources.ResourceManager.GetObject("rectangle_add_24x24_uncolor");
            ActionsAddButton.FlatAppearance.BorderSize = 1;
        }

        private void ActionsAddButton_MouseDown(object sender, MouseEventArgs e)
        {
            ActionsAddButton.Image =
                (Image)Properties.Resources.ResourceManager.GetObject("rectangle_add_24x24_uncolor");
        }

        private void ActionsAddButton_MouseUp(object sender, MouseEventArgs e)
        {
            ActionsAddButton.Image =
                (Image)Properties.Resources.ResourceManager.GetObject("rectangle_add_24x24");
            ActionsAddButton.FlatAppearance.BorderSize = 0;
        }

        private void ActionsRemoveButton_Click(object sender, EventArgs e)
        {
            if (ListListBox.SelectedIndex != -1)
            {
                CanvasPanel.Controls.RemoveAt(ListListBox.SelectedIndex);
                _rectanglePanels.RemoveAt(ListListBox.SelectedIndex);
                FindCollisions();
                _rectangles.RemoveAt(ListListBox.SelectedIndex);
                _bindingSource.ResetBindings(false);
            }
        }

        private void ActionsRemoveButton_MouseEnter(object sender, EventArgs e)
        {
            ActionsRemoveButton.Image =
                (Image)Properties.Resources.ResourceManager.GetObject("rectangle_remove_24x24");
            ActionsRemoveButton.FlatAppearance.BorderSize = 0;
        }

        private void ActionsRemoveButton_MouseLeave(object sender, EventArgs e)
        {
            ActionsRemoveButton.Image =
                (Image)Properties.Resources.ResourceManager.GetObject("rectangle_remove_24x24_uncolor");
            ActionsRemoveButton.FlatAppearance.BorderSize = 1;
        }

        private void ActionsRemoveButton_MouseDown(object sender, MouseEventArgs e)
        {
            ActionsRemoveButton.Image =
                (Image)Properties.Resources.ResourceManager.GetObject("rectangle_remove_24x24_uncolor");
        }

        private void ActionsRemoveButton_MouseUp(object sender, MouseEventArgs e)
        {
            ActionsRemoveButton.Image =
                (Image)Properties.Resources.ResourceManager.GetObject("rectangle_remove_24x24");
            ActionsRemoveButton.FlatAppearance.BorderSize = 0;
        }

        private void InfoXTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Center.X = double.Parse(InfoXTextBox.Text);
                    InfoXTextBox.BackColor = _correctColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(ListListBox.SelectedIndex,
                        _currentRectangle, _rectanglePanels[ListListBox.SelectedIndex]);
                }
                catch
                {
                    InfoXTextBox.BackColor = _errorColor;
                }
            }
        }

        private void InfoYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Center.Y = double.Parse(InfoYTextBox.Text);
                    InfoYTextBox.BackColor = _correctColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(ListListBox.SelectedIndex,
                        _currentRectangle, _rectanglePanels[ListListBox.SelectedIndex]);
                }
                catch
                {
                    InfoYTextBox.BackColor = _errorColor;
                }
            }
        }

        private void InfoWidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Length = double.Parse(InfoWidthTextBox.Text);
                    InfoWidthTextBox.BackColor = _correctColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(ListListBox.SelectedIndex,
                        _currentRectangle, _rectanglePanels[ListListBox.SelectedIndex]);
                }
                catch
                {
                    InfoWidthTextBox.BackColor = _errorColor;
                }
            }
        }

        private void InfoHeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Width = double.Parse(InfoHeightTextBox.Text);
                    InfoHeightTextBox.BackColor = _correctColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(ListListBox.SelectedIndex,
                        _currentRectangle, _rectanglePanels[ListListBox.SelectedIndex]);
                }
                catch
                {
                    InfoHeightTextBox.BackColor = _errorColor;
                }
            }
        }
    }
}
