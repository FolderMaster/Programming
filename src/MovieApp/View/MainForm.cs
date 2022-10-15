using System;
using System.Windows.Forms;
using System.Collections.Generic;

using Programming.Model.Classes;

using MovieApp.Model.Classes;
using MovieApp.View.Controls;

namespace MovieApp.View
{
    /// <summary>
    /// Основное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Путь к файлу сохранения.
        /// </summary>
        private const string _filePath = "Movies.txt";

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                MovieListControl.Movies = FileManager<List<Movie>>.Load(_filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                FileManager<List<Movie>>.Save(MovieListControl.Movies, _filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void MovieListControl_ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if(MovieListControl.SelectedIndex != -1)
            {
                MovieEditorControl.Movie = MovieListControl.Movies[MovieListControl.SelectedIndex];
            }
        }

        private void MovieEditorControl_CurrentPropertyChanged(object sender, EventArgs e)
        {
            switch(MovieEditorControl.UpdateMode)
            {
                case UpdateType.UpdateCurrentObject:
                    MovieListControl.UpdateList();
                    break;
                case UpdateType.UpdateList:
                    MovieListControl.SortUpdateList();
                    break;
            }
        }

        private void MovieListControl_RemoveButtonClick(object sender, EventArgs e)
        {
            if (MovieListControl.SelectedIndex != -1)
            {
                MovieEditorControl.Movie = MovieListControl.Movies[MovieListControl.SelectedIndex];
            }
            else
            {
                MovieEditorControl.Movie = null;
            }
        }
    }
}
