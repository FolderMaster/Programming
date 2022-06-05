using System;
using System.Collections.Generic;
using System.Windows.Forms;

using Programming.Model.Classes;

namespace MovieApp.View.Controls
{
    ///innosetup
    /// <summary>
    /// Элемент управления для работы со списком <see cref="Movie"/>.
    /// </summary>
    public partial class MovieListControl : UserControl
    {
        /// <summary>
        /// Источник данных для формы <see cref="ListBox"/>.
        /// </summary>
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Индекс выбранного экземпляра класса <see cref="Movie"/>.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Cписок экземпляров класса <see cref="Movie"/>.
        /// </summary>
        private List<Movie> _movies = new List<Movie>();

        /// <summary>
        /// Возвращает и задаёт индекс выбранного экземпляра класса <see cref="Movie"/>.
        /// </summary>
        public int SelectedIndex
        {
            get
            {
                return _selectedIndex;
            }
            set
            {
                _selectedIndex = value;

                ListBox.SelectedIndex = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт список экземпляров класса <see cref="Movie"/>.
        /// </summary>
        public List<Movie> Movies
        {
            get
            {
                return _movies;
            }
            set
            {
                _movies = value;

                _bindingSource.DataSource = Movies;
                UpdateList();
                if(_movies.Count > 0)
                {
                    SelectedIndex = 0;
                    ListBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Обработчик для события изменения индекса выбранного в списке элементов
        /// <see cref="ListBox"/>.
        /// </summary>
        public event EventHandler ListBoxSelectedIndexChanged;

        /// <summary>
        /// Обработчик для события нажатия на кнопку <see cref="RemoveButton"/>.
        /// </summary>
        public event EventHandler RemoveButtonClick;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MovieListControl"/>.
        /// </summary>
        public MovieListControl()
        {
            InitializeComponent();

            Movies = new List<Movie>();
            _bindingSource.DataSource = Movies;
            ListBox.DataSource = _bindingSource;
        }

        /// <summary>
        /// Обновляет информацию списка <see cref="Movies"/>.
        /// </summary>
        public void UpdateList()
        {
            _bindingSource.ResetBindings(false);
        }

        /// <summary>
        /// Обновляет с сортировкой информацию списка <see cref="Movies"/>.
        /// </summary>
        public void SortUpdateList()
        {
            Movie movie = null;
            if (SelectedIndex != -1)
            {
                movie = Movies[SelectedIndex];
            }
            SortMoviesAlphabetically();
            _bindingSource.ResetBindings(false);
            if (SelectedIndex != -1)
            {
                SelectedIndex = Movies.IndexOf(movie);
            }
        }

        /// <summary>
        /// Сортировка по названию в алфавитном порядке списка <see cref="Movies"/>.
        /// </summary>
        private void SortMoviesAlphabetically()
        {
            Movies.Sort((a, b) => string.Compare(a.Name, b.Name));
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndex = ListBox.SelectedIndex;

            ListBoxSelectedIndexChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AddButton_MouseEnter(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddButton_MouseLeave(object sender, EventArgs e)
        {
            AddButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Movies.Add(new Movie());

            SortUpdateList();
            if (Movies.Count == 1)
            {
                SelectedIndex = 0;
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

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (Movies.Count != 0)
            {
                Movies.RemoveAt(SelectedIndex);
                UpdateList();

                RemoveButtonClick?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}