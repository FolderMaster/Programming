using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Programming.Model.Classes.Geometry;

using Rectangle = Programming.Model.Classes.Geometry.Rectangle;

namespace Programming.View.TabPages
{
    /// <summary>
    /// Элемент управления для работы с коллизией прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Выбранный экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Лист экземпляров класса <see cref="Rectangle"/>.
        /// </summary>
        private List<Rectangle> _rectangles = new List<Rectangle>();

        /// <summary>
        /// 
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Лист экземпляров класса <see cref="Panel"/> для отображения прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels = new List<Panel>();

        /// <summary>
        /// Создаёт экземляр класса <see cref="RectangleCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            CreateRectangles(5);
            _bindingSource.DataSource = _rectangles;
            ListBox.DataSource = _bindingSource;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/> для <see cref="_rectangles"/>,
        /// создаёт ассоциативный <see cref="Panel"/> для <see cref="_rectanglePanels"/>.
        /// </summary>
        private void CreateRectangle()
        {
            //Visual Studio don't want to work correctly!
            Rectangle currentRectangle = RectangleFactory.Randomize(Panel.Width,
                Panel.Height);
            _currentRectangle = currentRectangle;
            _rectangles.Add(_currentRectangle);

            Panel panel = new Panel()
            {
                BackColor = AppColors.NoneCollisionColor,
                Size = new Size((int)currentRectangle.Length, (int)currentRectangle.Width),
                Location = new Point(
                    (int)(currentRectangle.Center.X - currentRectangle.Length / 2),
                    (int)(currentRectangle.Center.Y - currentRectangle.Width / 2))
            };
            _rectanglePanels.Add(panel);
            Panel.Controls.Add(panel);
        }

        /// <summary>
        /// Реализует логику <see cref="CreateRectangle"/> для множества объектов.
        /// </summary>
        /// <param name="count">Количество элементов листа.</param>
        private void CreateRectangles(int count)
        {
            for (int n = 0; n < count; ++n)
            {
                CreateRectangle();
            }
            _bindingSource.ResetBindings(false);
            FindCollisions();
        }

        /// <summary>
        /// Ищет коллизии прямоугольников:
        /// окрашивает в <see cref="AppColors.CollisionColor"/> при коллизии,
        /// а иначе в <see cref="AppColors.NoneCollisionColor"/>.
        /// </summary>
        private void FindCollisions()
        {
            _rectanglePanels.ForEach(panel => panel.BackColor = AppColors.NoneCollisionColor);
            bool[] isCollision = new bool[_rectangles.Count];
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                if(!isCollision[i])
                {
                    for (int j = 0; j < _rectanglePanels.Count; j++)
                    {
                        if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]) && i != j)
                        {
                            _rectanglePanels[i].BackColor = AppColors.CollisionColor;
                            _rectanglePanels[j].BackColor = AppColors.CollisionColor;

                            isCollision[i] = true;
                            isCollision[j] = true;
                        }
                    }
                }
            }
            Panel.Update();
        }

        /// <summary>
        /// Ищет коллизии прямоугольников относительно одного элемента:
        /// окрашивает в <see cref="AppColors.CollisionColor"/> при коллизии,
        /// а иначе в <see cref="AppColors.NoneCollisionColor"/>.
        /// </summary>
        /// <param name="index">Индекс элемента, относительно которого проверяется коллизия.</param>
        private void FindCollisionsWith(int index)
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                if (CollisionManager.IsCollision(_rectangles[i], _rectangles[index]) && i != index)
                {
                    _rectanglePanels[i].BackColor = AppColors.CollisionColor;
                    _rectanglePanels[index].BackColor = AppColors.CollisionColor;
                }
            }
            Panel.Update();
        }

        /// <summary>
        /// Обновляет свойства прямоугольника для отображения.
        /// </summary>
        /// <param name="rectangle">Обновляемый прямоугольник.</param>
        /// <param name="panel">Панель, ассоциируемая с данным прямоугольником.</param>
        private void UpdateRectangleProperty(Rectangle rectangle, Panel panel)
        {
            panel.Size = new Size((int)rectangle.Length, (int)rectangle.Width);
            panel.Location = new Point(
                (int)(rectangle.Center.X - rectangle.Length / 2),
                (int)(rectangle.Center.Y - rectangle.Width / 2));
            FindCollisions();
        }

        /// <summary>
        /// Обновляет для элементов управления информацию о выбранном прямоугольнике.
        /// </summary>
        private void UpdateRectangleInfo()
        {
            IdTextBox.Text = _currentRectangle.Id.ToString();
            XTextBox.Text = _currentRectangle.Center.X.ToString();
            YTextBox.Text = _currentRectangle.Center.Y.ToString();
            WidthTextBox.Text = _currentRectangle.Length.ToString();
            HeightTextBox.Text = _currentRectangle.Width.ToString();
        }

        /// <summary>
        /// Очищает для элементов управления информацию о прямоугольнике.
        /// </summary>
        private void ClearRectangleInfo()
        {
            IdTextBox.Text = XTextBox.Text =
                    YTextBox.Text = WidthTextBox.Text =
                    HeightTextBox.Text = "";
            IdTextBox.BackColor = XTextBox.BackColor =
                YTextBox.BackColor = WidthTextBox.BackColor =
                HeightTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentRectangle = (Rectangle)ListBox.SelectedItem;
            if (_currentRectangle == null || ListBox.SelectedItem == null)
            {
                ClearRectangleInfo();
            }
            else
            {
                UpdateRectangleInfo();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateRectangle();
            _bindingSource.ResetBindings(false);
            FindCollisionsWith(_rectanglePanels.Count - 1);
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void AddButton_MouseDown(object sender, MouseEventArgs e)
        {
            AddButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void AddButton_MouseUp(object sender, MouseEventArgs e)
        {
            AddButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex != -1)
            {
                Panel.Controls.RemoveAt(ListBox.SelectedIndex);
                _rectanglePanels.RemoveAt(ListBox.SelectedIndex);
                _rectangles.RemoveAt(ListBox.SelectedIndex);
                _bindingSource.ResetBindings(false);
                FindCollisions();
            }
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RemoveButton_MouseDown(object sender, MouseEventArgs e)
        {
            RemoveButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void RemoveButton_MouseUp(object sender, MouseEventArgs e)
        {
            RemoveButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void XTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Center.X = double.Parse(XTextBox.Text);
                    XTextBox.BackColor = AppColors.CorrectColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(_currentRectangle,
                        _rectanglePanels[ListBox.SelectedIndex]);
                }
                catch
                {
                    XTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void YTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Center.Y = double.Parse(YTextBox.Text);
                    YTextBox.BackColor = AppColors.CorrectColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(_currentRectangle,
                        _rectanglePanels[ListBox.SelectedIndex]);
                }
                catch
                {
                    YTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Length = double.Parse(WidthTextBox.Text);
                    WidthTextBox.BackColor = AppColors.CorrectColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(_currentRectangle,
                        _rectanglePanels[ListBox.SelectedIndex]);
                }
                catch
                {
                    WidthTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }

        private void HeightTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                try
                {
                    _currentRectangle.Width = double.Parse(HeightTextBox.Text);
                    HeightTextBox.BackColor = AppColors.CorrectColor;
                    _bindingSource.ResetBindings(false);
                    UpdateRectangleProperty(_currentRectangle,
                        _rectanglePanels[ListBox.SelectedIndex]);
                }
                catch
                {
                    HeightTextBox.BackColor = AppColors.ErrorColor;
                }
            }
        }
    }
}
