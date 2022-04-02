
namespace Programming.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.ParseWeekdayLabel = new System.Windows.Forms.Label();
            this.ParseWeekdayButton = new System.Windows.Forms.Button();
            this.WeekParseWeekdayTextBox = new System.Windows.Forms.TextBox();
            this.WeekWeekdayLabel = new System.Windows.Forms.Label();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumsEnumListBox = new System.Windows.Forms.ListBox();
            this.IntEnumLabel = new System.Windows.Forms.Label();
            this.EnumsEnumLabel = new System.Windows.Forms.Label();
            this.IntEnumTextBox = new System.Windows.Forms.TextBox();
            this.ValueEnumListBox = new System.Windows.Forms.ListBox();
            this.ValueEnumLabel = new System.Windows.Forms.Label();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.RatingMoviesTextBox = new System.Windows.Forms.TextBox();
            this.RatingMoviesLabel = new System.Windows.Forms.Label();
            this.GenreMoviesTextBox = new System.Windows.Forms.TextBox();
            this.GenreMoviesLabel = new System.Windows.Forms.Label();
            this.MoviesButton = new System.Windows.Forms.Button();
            this.ReleaseYearMoviesLabel = new System.Windows.Forms.Label();
            this.ReleaseYearMoviesTextBox = new System.Windows.Forms.TextBox();
            this.MinutesMoviesLabel = new System.Windows.Forms.Label();
            this.MinutesMoviesTextBox = new System.Windows.Forms.TextBox();
            this.NameMoviesLabel = new System.Windows.Forms.Label();
            this.NameMoviesTextBox = new System.Windows.Forms.TextBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesButton = new System.Windows.Forms.Button();
            this.ColorRectanglesLabel = new System.Windows.Forms.Label();
            this.ColorRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.WidthRectanglesLabel = new System.Windows.Forms.Label();
            this.WidthRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.LengthRectanglesLabel = new System.Windows.Forms.Label();
            this.LengthRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.TabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekdayGroupBox.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(509, 313);
            this.TabControl.TabIndex = 0;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.EnumsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(501, 287);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Location = new System.Drawing.Point(247, 202);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(246, 77);
            this.SeasonGroupBox.TabIndex = 8;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(9, 31);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(80, 21);
            this.SeasonComboBox.TabIndex = 7;
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(94, 30);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonButton.TabIndex = 6;
            this.SeasonButton.Text = "Go";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(6, 16);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.SeasonLabel.TabIndex = 3;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Controls.Add(this.ParseWeekdayLabel);
            this.WeekdayGroupBox.Controls.Add(this.ParseWeekdayButton);
            this.WeekdayGroupBox.Controls.Add(this.WeekParseWeekdayTextBox);
            this.WeekdayGroupBox.Controls.Add(this.WeekWeekdayLabel);
            this.WeekdayGroupBox.Location = new System.Drawing.Point(8, 202);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(233, 77);
            this.WeekdayGroupBox.TabIndex = 7;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // ParseWeekdayLabel
            // 
            this.ParseWeekdayLabel.AutoSize = true;
            this.ParseWeekdayLabel.Location = new System.Drawing.Point(6, 56);
            this.ParseWeekdayLabel.Name = "ParseWeekdayLabel";
            this.ParseWeekdayLabel.Size = new System.Drawing.Size(130, 13);
            this.ParseWeekdayLabel.TabIndex = 7;
            this.ParseWeekdayLabel.Text = "This day of week (... = ...).";
            // 
            // ParseWeekdayButton
            // 
            this.ParseWeekdayButton.Location = new System.Drawing.Point(119, 30);
            this.ParseWeekdayButton.Name = "ParseWeekdayButton";
            this.ParseWeekdayButton.Size = new System.Drawing.Size(75, 23);
            this.ParseWeekdayButton.TabIndex = 6;
            this.ParseWeekdayButton.Text = "Parse";
            this.ParseWeekdayButton.UseVisualStyleBackColor = true;
            this.ParseWeekdayButton.Click += new System.EventHandler(this.WeekParseButton_Click);
            // 
            // WeekParseWeekdayTextBox
            // 
            this.WeekParseWeekdayTextBox.Location = new System.Drawing.Point(9, 32);
            this.WeekParseWeekdayTextBox.Name = "WeekParseWeekdayTextBox";
            this.WeekParseWeekdayTextBox.Size = new System.Drawing.Size(104, 20);
            this.WeekParseWeekdayTextBox.TabIndex = 5;
            // 
            // WeekWeekdayLabel
            // 
            this.WeekWeekdayLabel.AutoSize = true;
            this.WeekWeekdayLabel.Location = new System.Drawing.Point(6, 16);
            this.WeekWeekdayLabel.Name = "WeekWeekdayLabel";
            this.WeekWeekdayLabel.Size = new System.Drawing.Size(115, 13);
            this.WeekWeekdayLabel.TabIndex = 3;
            this.WeekWeekdayLabel.Text = "Type value for parsing:";
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.EnumsEnumListBox);
            this.EnumGroupBox.Controls.Add(this.IntEnumLabel);
            this.EnumGroupBox.Controls.Add(this.EnumsEnumLabel);
            this.EnumGroupBox.Controls.Add(this.IntEnumTextBox);
            this.EnumGroupBox.Controls.Add(this.ValueEnumListBox);
            this.EnumGroupBox.Controls.Add(this.ValueEnumLabel);
            this.EnumGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Size = new System.Drawing.Size(485, 190);
            this.EnumGroupBox.TabIndex = 6;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            // 
            // EnumsEnumListBox
            // 
            this.EnumsEnumListBox.FormattingEnabled = true;
            this.EnumsEnumListBox.Location = new System.Drawing.Point(6, 32);
            this.EnumsEnumListBox.Name = "EnumsEnumListBox";
            this.EnumsEnumListBox.Size = new System.Drawing.Size(130, 147);
            this.EnumsEnumListBox.TabIndex = 0;
            this.EnumsEnumListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // IntEnumLabel
            // 
            this.IntEnumLabel.AutoSize = true;
            this.IntEnumLabel.Location = new System.Drawing.Point(255, 16);
            this.IntEnumLabel.Name = "IntEnumLabel";
            this.IntEnumLabel.Size = new System.Drawing.Size(58, 13);
            this.IntEnumLabel.TabIndex = 5;
            this.IntEnumLabel.Text = "Value\'s int:";
            // 
            // EnumsEnumLabel
            // 
            this.EnumsEnumLabel.AutoSize = true;
            this.EnumsEnumLabel.Location = new System.Drawing.Point(6, 16);
            this.EnumsEnumLabel.Name = "EnumsEnumLabel";
            this.EnumsEnumLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumsEnumLabel.TabIndex = 2;
            this.EnumsEnumLabel.Text = "Choose enumeration:";
            // 
            // IntEnumTextBox
            // 
            this.IntEnumTextBox.Location = new System.Drawing.Point(258, 32);
            this.IntEnumTextBox.Name = "IntEnumTextBox";
            this.IntEnumTextBox.ReadOnly = true;
            this.IntEnumTextBox.Size = new System.Drawing.Size(55, 20);
            this.IntEnumTextBox.TabIndex = 4;
            // 
            // ValueEnumListBox
            // 
            this.ValueEnumListBox.FormattingEnabled = true;
            this.ValueEnumListBox.Location = new System.Drawing.Point(161, 32);
            this.ValueEnumListBox.Name = "ValueEnumListBox";
            this.ValueEnumListBox.Size = new System.Drawing.Size(72, 147);
            this.ValueEnumListBox.TabIndex = 1;
            this.ValueEnumListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // ValueEnumLabel
            // 
            this.ValueEnumLabel.AutoSize = true;
            this.ValueEnumLabel.Location = new System.Drawing.Point(158, 16);
            this.ValueEnumLabel.Name = "ValueEnumLabel";
            this.ValueEnumLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueEnumLabel.TabIndex = 3;
            this.ValueEnumLabel.Text = "Choose value:";
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(501, 287);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.RatingMoviesTextBox);
            this.MoviesGroupBox.Controls.Add(this.RatingMoviesLabel);
            this.MoviesGroupBox.Controls.Add(this.GenreMoviesTextBox);
            this.MoviesGroupBox.Controls.Add(this.GenreMoviesLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesButton);
            this.MoviesGroupBox.Controls.Add(this.ReleaseYearMoviesLabel);
            this.MoviesGroupBox.Controls.Add(this.ReleaseYearMoviesTextBox);
            this.MoviesGroupBox.Controls.Add(this.MinutesMoviesLabel);
            this.MoviesGroupBox.Controls.Add(this.MinutesMoviesTextBox);
            this.MoviesGroupBox.Controls.Add(this.NameMoviesLabel);
            this.MoviesGroupBox.Controls.Add(this.NameMoviesTextBox);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Location = new System.Drawing.Point(254, 6);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(239, 273);
            this.MoviesGroupBox.TabIndex = 8;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // RatingMoviesTextBox
            // 
            this.RatingMoviesTextBox.Location = new System.Drawing.Point(111, 191);
            this.RatingMoviesTextBox.Name = "RatingMoviesTextBox";
            this.RatingMoviesTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingMoviesTextBox.TabIndex = 16;
            this.RatingMoviesTextBox.TextChanged += new System.EventHandler(this.RatingMoviesTextBox_TextChanged);
            // 
            // RatingMoviesLabel
            // 
            this.RatingMoviesLabel.AutoSize = true;
            this.RatingMoviesLabel.Location = new System.Drawing.Point(111, 175);
            this.RatingMoviesLabel.Name = "RatingMoviesLabel";
            this.RatingMoviesLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingMoviesLabel.TabIndex = 15;
            this.RatingMoviesLabel.Text = "Rating:";
            // 
            // GenreMoviesTextBox
            // 
            this.GenreMoviesTextBox.Location = new System.Drawing.Point(111, 152);
            this.GenreMoviesTextBox.Name = "GenreMoviesTextBox";
            this.GenreMoviesTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreMoviesTextBox.TabIndex = 14;
            this.GenreMoviesTextBox.TextChanged += new System.EventHandler(this.GenreMoviesTextBox_TextChanged);
            // 
            // GenreMoviesLabel
            // 
            this.GenreMoviesLabel.AutoSize = true;
            this.GenreMoviesLabel.Location = new System.Drawing.Point(111, 136);
            this.GenreMoviesLabel.Name = "GenreMoviesLabel";
            this.GenreMoviesLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreMoviesLabel.TabIndex = 13;
            this.GenreMoviesLabel.Text = "Genre:";
            // 
            // MoviesButton
            // 
            this.MoviesButton.Location = new System.Drawing.Point(111, 234);
            this.MoviesButton.Name = "MoviesButton";
            this.MoviesButton.Size = new System.Drawing.Size(100, 23);
            this.MoviesButton.TabIndex = 12;
            this.MoviesButton.Text = "Find";
            this.MoviesButton.UseVisualStyleBackColor = true;
            this.MoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // ReleaseYearMoviesLabel
            // 
            this.ReleaseYearMoviesLabel.AutoSize = true;
            this.ReleaseYearMoviesLabel.Location = new System.Drawing.Point(111, 97);
            this.ReleaseYearMoviesLabel.Name = "ReleaseYearMoviesLabel";
            this.ReleaseYearMoviesLabel.Size = new System.Drawing.Size(72, 13);
            this.ReleaseYearMoviesLabel.TabIndex = 11;
            this.ReleaseYearMoviesLabel.Text = "Release year:";
            // 
            // ReleaseYearMoviesTextBox
            // 
            this.ReleaseYearMoviesTextBox.Location = new System.Drawing.Point(111, 113);
            this.ReleaseYearMoviesTextBox.Name = "ReleaseYearMoviesTextBox";
            this.ReleaseYearMoviesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ReleaseYearMoviesTextBox.TabIndex = 10;
            this.ReleaseYearMoviesTextBox.TextChanged += new System.EventHandler(this.ReleaseYearMoviesTextBox_TextChanged);
            // 
            // MinutesMoviesLabel
            // 
            this.MinutesMoviesLabel.AutoSize = true;
            this.MinutesMoviesLabel.Location = new System.Drawing.Point(111, 58);
            this.MinutesMoviesLabel.Name = "MinutesMoviesLabel";
            this.MinutesMoviesLabel.Size = new System.Drawing.Size(47, 13);
            this.MinutesMoviesLabel.TabIndex = 9;
            this.MinutesMoviesLabel.Text = "Minutes:";
            // 
            // MinutesMoviesTextBox
            // 
            this.MinutesMoviesTextBox.Location = new System.Drawing.Point(111, 74);
            this.MinutesMoviesTextBox.Name = "MinutesMoviesTextBox";
            this.MinutesMoviesTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinutesMoviesTextBox.TabIndex = 8;
            this.MinutesMoviesTextBox.TextChanged += new System.EventHandler(this.MinutesMoviesTextBox_TextChanged);
            // 
            // NameMoviesLabel
            // 
            this.NameMoviesLabel.AutoSize = true;
            this.NameMoviesLabel.Location = new System.Drawing.Point(111, 19);
            this.NameMoviesLabel.Name = "NameMoviesLabel";
            this.NameMoviesLabel.Size = new System.Drawing.Size(38, 13);
            this.NameMoviesLabel.TabIndex = 7;
            this.NameMoviesLabel.Text = "Name:";
            // 
            // NameMoviesTextBox
            // 
            this.NameMoviesTextBox.Location = new System.Drawing.Point(111, 35);
            this.NameMoviesTextBox.Name = "NameMoviesTextBox";
            this.NameMoviesTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameMoviesTextBox.TabIndex = 6;
            this.NameMoviesTextBox.TextChanged += new System.EventHandler(this.NameMoviesTextBox_TextChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(6, 19);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(72, 238);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.RectanglesButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorRectanglesLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorRectanglesTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthRectanglesLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidthRectanglesTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthRectanglesLabel);
            this.RectanglesGroupBox.Controls.Add(this.LengthRectanglesTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(8, 6);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(239, 273);
            this.RectanglesGroupBox.TabIndex = 7;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // RectanglesButton
            // 
            this.RectanglesButton.Location = new System.Drawing.Point(111, 234);
            this.RectanglesButton.Name = "RectanglesButton";
            this.RectanglesButton.Size = new System.Drawing.Size(100, 23);
            this.RectanglesButton.TabIndex = 12;
            this.RectanglesButton.Text = "Find";
            this.RectanglesButton.UseVisualStyleBackColor = true;
            this.RectanglesButton.Click += new System.EventHandler(this.RectanglesButton_Click);
            // 
            // ColorRectanglesLabel
            // 
            this.ColorRectanglesLabel.AutoSize = true;
            this.ColorRectanglesLabel.Location = new System.Drawing.Point(111, 94);
            this.ColorRectanglesLabel.Name = "ColorRectanglesLabel";
            this.ColorRectanglesLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorRectanglesLabel.TabIndex = 11;
            this.ColorRectanglesLabel.Text = "Color:";
            // 
            // ColorRectanglesTextBox
            // 
            this.ColorRectanglesTextBox.Location = new System.Drawing.Point(111, 110);
            this.ColorRectanglesTextBox.Name = "ColorRectanglesTextBox";
            this.ColorRectanglesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorRectanglesTextBox.TabIndex = 10;
            this.ColorRectanglesTextBox.TextChanged += new System.EventHandler(this.ColorRectanglesTextBox_TextChanged);
            // 
            // WidthRectanglesLabel
            // 
            this.WidthRectanglesLabel.AutoSize = true;
            this.WidthRectanglesLabel.Location = new System.Drawing.Point(111, 55);
            this.WidthRectanglesLabel.Name = "WidthRectanglesLabel";
            this.WidthRectanglesLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthRectanglesLabel.TabIndex = 9;
            this.WidthRectanglesLabel.Text = "Width:";
            // 
            // WidthRectanglesTextBox
            // 
            this.WidthRectanglesTextBox.Location = new System.Drawing.Point(111, 74);
            this.WidthRectanglesTextBox.Name = "WidthRectanglesTextBox";
            this.WidthRectanglesTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthRectanglesTextBox.TabIndex = 8;
            this.WidthRectanglesTextBox.TextChanged += new System.EventHandler(this.WidthRectanglesTextBox_TextChanged);
            // 
            // LengthRectanglesLabel
            // 
            this.LengthRectanglesLabel.AutoSize = true;
            this.LengthRectanglesLabel.Location = new System.Drawing.Point(111, 16);
            this.LengthRectanglesLabel.Name = "LengthRectanglesLabel";
            this.LengthRectanglesLabel.Size = new System.Drawing.Size(43, 13);
            this.LengthRectanglesLabel.TabIndex = 7;
            this.LengthRectanglesLabel.Text = "Length:";
            // 
            // LengthRectanglesTextBox
            // 
            this.LengthRectanglesTextBox.Location = new System.Drawing.Point(111, 32);
            this.LengthRectanglesTextBox.Name = "LengthRectanglesTextBox";
            this.LengthRectanglesTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthRectanglesTextBox.TabIndex = 6;
            this.LengthRectanglesTextBox.TextChanged += new System.EventHandler(this.LengthRectanglesTextBox_TextChanged);
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(6, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(72, 238);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 313);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming";
            this.TabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.WeekdayGroupBox.ResumeLayout(false);
            this.WeekdayGroupBox.PerformLayout();
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.ListBox ValueEnumListBox;
        private System.Windows.Forms.ListBox EnumsEnumListBox;
        private System.Windows.Forms.Label ValueEnumLabel;
        private System.Windows.Forms.Label EnumsEnumLabel;
        private System.Windows.Forms.Label IntEnumLabel;
        private System.Windows.Forms.TextBox IntEnumTextBox;
        private System.Windows.Forms.GroupBox EnumGroupBox;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.TextBox WeekParseWeekdayTextBox;
        private System.Windows.Forms.Label WeekWeekdayLabel;
        private System.Windows.Forms.Label ParseWeekdayLabel;
        private System.Windows.Forms.Button ParseWeekdayButton;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.Button RectanglesButton;
        private System.Windows.Forms.Label ColorRectanglesLabel;
        private System.Windows.Forms.TextBox ColorRectanglesTextBox;
        private System.Windows.Forms.Label WidthRectanglesLabel;
        private System.Windows.Forms.TextBox WidthRectanglesTextBox;
        private System.Windows.Forms.Label LengthRectanglesLabel;
        private System.Windows.Forms.TextBox LengthRectanglesTextBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.Button MoviesButton;
        private System.Windows.Forms.Label ReleaseYearMoviesLabel;
        private System.Windows.Forms.TextBox ReleaseYearMoviesTextBox;
        private System.Windows.Forms.Label MinutesMoviesLabel;
        private System.Windows.Forms.TextBox MinutesMoviesTextBox;
        private System.Windows.Forms.Label NameMoviesLabel;
        private System.Windows.Forms.TextBox NameMoviesTextBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.TextBox RatingMoviesTextBox;
        private System.Windows.Forms.Label RatingMoviesLabel;
        private System.Windows.Forms.TextBox GenreMoviesTextBox;
        private System.Windows.Forms.Label GenreMoviesLabel;
    }
}

