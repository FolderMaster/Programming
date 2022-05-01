namespace Programming.View.Controls
{
    partial class MoviesControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.Button = new System.Windows.Forms.Button();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.MinutesLabel = new System.Windows.Forms.Label();
            this.MinutesTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(105, 172);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingTextBox.TabIndex = 24;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.ClassesMoviesRatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(105, 156);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 27;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(105, 133);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 22;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.ClassesMoviesGenreTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(105, 117);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 25;
            this.GenreLabel.Text = "Genre:";
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(105, 215);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(100, 23);
            this.Button.TabIndex = 26;
            this.Button.Text = "Find";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.ClassesMoviesButton_Click);
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(105, 78);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(72, 13);
            this.ReleaseYearLabel.TabIndex = 23;
            this.ReleaseYearLabel.Text = "Release year:";
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(105, 94);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReleaseYearTextBox.TabIndex = 21;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ClassesMoviesReleaseYearTextBox_TextChanged);
            // 
            // MinutesLabel
            // 
            this.MinutesLabel.AutoSize = true;
            this.MinutesLabel.Location = new System.Drawing.Point(105, 39);
            this.MinutesLabel.Name = "MinutesLabel";
            this.MinutesLabel.Size = new System.Drawing.Size(47, 13);
            this.MinutesLabel.TabIndex = 19;
            this.MinutesLabel.Text = "Minutes:";
            // 
            // MinutesTextBox
            // 
            this.MinutesTextBox.Location = new System.Drawing.Point(105, 55);
            this.MinutesTextBox.Name = "MinutesTextBox";
            this.MinutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinutesTextBox.TabIndex = 20;
            this.MinutesTextBox.TextChanged += new System.EventHandler(this.ClassesMoviesMinutesTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(105, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(105, 16);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 18;
            this.NameTextBox.TextChanged += new System.EventHandler(this.ClassesMoviesNameTextBox_TextChanged);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(0, 0);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(72, 238);
            this.ListBox.TabIndex = 17;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ClassesMoviesListBox_SelectedIndexChanged);
            // 
            // MoviesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RatingTextBox);
            this.Controls.Add(this.RatingLabel);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.GenreLabel);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ReleaseYearLabel);
            this.Controls.Add(this.ReleaseYearTextBox);
            this.Controls.Add(this.MinutesLabel);
            this.Controls.Add(this.MinutesTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ListBox);
            this.Name = "MoviesControl";
            this.Size = new System.Drawing.Size(204, 239);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.TextBox ReleaseYearTextBox;
        private System.Windows.Forms.Label MinutesLabel;
        private System.Windows.Forms.TextBox MinutesTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.ListBox ListBox;
    }
}
