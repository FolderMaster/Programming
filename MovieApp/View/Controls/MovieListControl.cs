using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Programming.Model.Classes;

namespace MovieApp.View.Controls
{
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
        /// Обработчик для события нажатия по кнопке <see cref="EditButton"/>.
        /// </summary>
        private EventHandler onEditButtonClicked;

        /// <summary>
        /// Обработчик для события изменения индекса выбранного в списке элементов
        /// <see cref="ListBox"/>.
        /// </summary>
        private EventHandler onListBoxSelectedIndexChanged;

        /// <summary>
        /// Возвращает и задаёт выбранный экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie SelectedMovie { get; set; } = null;

        /// <summary>
        /// Возвращает и задаёт список экземпляров класса <see cref="Movie"/>.
        /// </summary>
        public List<Movie> Movies { get; set; } = new List<Movie>();

        /// <summary>
        /// Добавляет и удаляет события для обработчика события нажатия по кнопке <see cref="EditButton"/>.
        /// </summary>
        public event EventHandler EditButtonClicked
        {
            add
            {
                onEditButtonClicked += value;
            }
            remove
            {
                onEditButtonClicked -= value;
            }
        }

        /// <summary>
        /// Добавляет и удаляет события для обработчика события изменения индекса выбранного в списке элементов
        /// <see cref="ListBox"/>.
        /// </summary>
        public event EventHandler ListBoxSelectedIndexChanged
        {
            add
            {
                onListBoxSelectedIndexChanged += value;
            }
            remove
            {
                onListBoxSelectedIndexChanged -= value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MovieListControl"/>.
        /// </summary>
        public MovieListControl()
        {
            InitializeComponent();

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
            SortMoviesAlphabetically();
            _bindingSource.ResetBindings(false);
            ListBox.SelectedItem = SelectedMovie;
        }

        /// <summary>
        /// Сортировка по названию в алфавитном порядке списка <see cref="Movies"/>.
        /// </summary>
        private void SortMoviesAlphabetically()
        {
            for(int n = 0; n < Movies.Count; ++n)
            {
                for(int j = 0; j < Movies.Count - 1; ++j)
                {
                    if (!IsAlphabetically(Movies[j].Name, Movies[j + 1].Name))
                    {
                        Movie movie = Movies[j + 1];
                        Movies[j + 1] = Movies[j];
                        Movies[j] = movie;
                    }
                }
            }
        }

        /// <summary>
        /// Проверяет, первый текст стоит перед вторым по алфавитному порядку.
        /// </summary>
        /// <param name="text1">Первый текст.</param>
        /// <param name="text2">Второй текст.</param>
        /// <returns>Возвращает true, когда по алфавитному порядку первый текст идёт после второго,
        /// а иначе - false.</returns>
        private bool IsAlphabetically(string text1, string text2)
        {
            for(int n = 0; n < text1.Length && n < text2.Length; ++n)
            {
                if (text1[n] > text2[n])
                {
                    return false;
                }
            }
            return text1.Length <= text2.Length;
        }

        /// <summary>
        /// Вызывает обработчик события нажатия по кнопке <see cref="EditButton"/>.
        /// </summary>
        /// <param name="e">Данные о событии.</param>
        protected virtual void OnEditButtonClicked(EventArgs e)
        {
            onEditButtonClicked?.Invoke(this, e);
        }

        /// <summary>
        /// Вызывает обработчик события изменения индекса выбранного в списке элементов
        /// <see cref="ListBox"/>.
        /// </summary>
        /// <param name="e">Данные о событии.</param>
        protected virtual void OnListBoxSelectedIndexChanged(EventArgs e)
        {
            onListBoxSelectedIndexChanged?.Invoke(this, e);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedMovie = (Movie)ListBox.SelectedItem;
            OnListBoxSelectedIndexChanged(EventArgs.Empty);
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
            SelectedMovie = new Movie();
            Movies.Add(SelectedMovie);
            _bindingSource.ResetBindings(false);
            SortUpdateList();
            if(ListBox.SelectedItem != null)
            {
                ListBox.SelectedItem = SelectedMovie;
            }
        }

        private void EditButton_MouseEnter(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.rectangle_edit_24x24;
        }

        private void EditButton_MouseLeave(object sender, EventArgs e)
        {
            EditButton.Image = Properties.Resources.rectangle_edit_24x24_uncolor;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (SelectedMovie != null)
            {
                OnEditButtonClicked(EventArgs.Empty);
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
            if (SelectedMovie != null)
            {
                Movies.Remove(SelectedMovie);
                _bindingSource.ResetBindings(false);
                if(ListBox.SelectedIndex != -1)
                {
                    SelectedMovie = (Movie)ListBox.Items[ListBox.SelectedIndex];
                }
            }
        }
    }
}