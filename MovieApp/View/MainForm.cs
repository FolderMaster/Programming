using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

using MovieApp.View.Controls;
using Programming.Model.Classes;
using Programming.Model.Enums;

namespace MovieApp.View
{
    /// <summary>
    /// Основное окно приложения.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Название файла сохранения.
        /// </summary>
        private const string _fileName = "Movies.txt";

        /// <summary>
        /// Создаёт экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using (FileStream fileReader = File.Open(_fileName, FileMode.OpenOrCreate))
            {
                byte[] arrayBytes = new byte[fileReader.Length];
                fileReader.Read(arrayBytes, 0, arrayBytes.Length);
                string text = System.Text.Encoding.Default.GetString(arrayBytes);

                Regex regex = new Regex(@"(.*)\s+(\d+)\s+(\d+)\s+(\d+)\s+(\d+\,*\d*)");
                Match match = regex.Match(text);
                for (int n = 0; match.Success; ++n)
                {
                    MovieListControl.Movies.Add(new Movie(match.Groups[1].Value,
                        int.Parse(match.Groups[2].Value), int.Parse(match.Groups[3].Value),
                        (Genre)Enum.Parse(typeof(Genre), match.Groups[4].Value),
                        double.Parse(match.Groups[5].Value)));
                    match = match.NextMatch();
                }
                MovieListControl.UpdateList();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fileWriter = new FileStream(_fileName, FileMode.Create))
            {
                string text = "";
                for (int n = 0; n < MovieListControl.Movies.Count; ++n)
                {
                    text += MovieListControl.Movies[n].Name + "\r\n" +
                        MovieListControl.Movies[n].Minutes + "\t" +
                        MovieListControl.Movies[n].ReleaseYear + "\t" +
                        ((int)MovieListControl.Movies[n].Genre) + "\t" +
                        MovieListControl.Movies[n].Rating + "\r\n";
                }

                byte[] arrayBytes = System.Text.Encoding.Default.GetBytes(text);
                fileWriter.Write(arrayBytes, 0, arrayBytes.Length);
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

        private void MovieListControl_EditButtonClicked(object sender, EventArgs e)
        {
            MovieEditorControl.Movie = MovieListControl.SelectedMovie;
        }

        private void MovieListControl_ListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            MovieEditorControl.Movie = MovieListControl.SelectedMovie;
        }
    }
}
