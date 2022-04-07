
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
            this.EnumsSeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumsSeasonComboBox = new System.Windows.Forms.ComboBox();
            this.EnumsSeasonButton = new System.Windows.Forms.Button();
            this.EnumsSeasonLabel = new System.Windows.Forms.Label();
            this.EnumsWeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumsWeekdayParseLabel = new System.Windows.Forms.Label();
            this.EnumsWeekdayParseButton = new System.Windows.Forms.Button();
            this.EnumsWeekdayParseTextBox = new System.Windows.Forms.TextBox();
            this.EnumsWeekdayLabel = new System.Windows.Forms.Label();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumsEnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumsIntLabel = new System.Windows.Forms.Label();
            this.EnumsEnumsLabel = new System.Windows.Forms.Label();
            this.EnumIntTextBox = new System.Windows.Forms.TextBox();
            this.EnumsValueListBox = new System.Windows.Forms.ListBox();
            this.EnumsValueLabel = new System.Windows.Forms.Label();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesMoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassesMoviesRatingTextBox = new System.Windows.Forms.TextBox();
            this.ClassesMoviesRatingLabel = new System.Windows.Forms.Label();
            this.ClassesMoviesGenreTextBox = new System.Windows.Forms.TextBox();
            this.ClassesMoviesGenreLabel = new System.Windows.Forms.Label();
            this.ClassesMoviesButton = new System.Windows.Forms.Button();
            this.ClassesMoviesReleaseYearLabel = new System.Windows.Forms.Label();
            this.ClassesMoviesReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.ClassesMoviesMinutesLabel = new System.Windows.Forms.Label();
            this.ClassesMoviesMinutesTextBox = new System.Windows.Forms.TextBox();
            this.ClassesMoviesNameLabel = new System.Windows.Forms.Label();
            this.ClassesMoviesNameTextBox = new System.Windows.Forms.TextBox();
            this.ClassesMoviesListBox = new System.Windows.Forms.ListBox();
            this.ClassesRectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.ClassesRectanglesCenterLabel = new System.Windows.Forms.Label();
            this.ClassesRectanglesCenterTextBox = new System.Windows.Forms.TextBox();
            this.ClassesRectanglesButton = new System.Windows.Forms.Button();
            this.ClassesRectanglesColorLabel = new System.Windows.Forms.Label();
            this.ClassesRectanglesColorTextBox = new System.Windows.Forms.TextBox();
            this.ClassesRectanglesWidthLabel = new System.Windows.Forms.Label();
            this.ClassesRectanglesWidthTextBox = new System.Windows.Forms.TextBox();
            this.ClassesRectanglesLengthLabel = new System.Windows.Forms.Label();
            this.ClassesRectanglesLengthTextBox = new System.Windows.Forms.TextBox();
            this.ClassesRectanglesListBox = new System.Windows.Forms.ListBox();
            this.ClassesRectanglesIdTextBox = new System.Windows.Forms.TextBox();
            this.ClassesRectanglesIdLabel = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.EnumsSeasonGroupBox.SuspendLayout();
            this.EnumsWeekdayGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.ClassesMoviesGroupBox.SuspendLayout();
            this.ClassesRectanglesGroupBox.SuspendLayout();
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
            this.EnumsTabPage.Controls.Add(this.EnumsSeasonGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumsWeekdayGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumsGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(501, 287);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnumsSeasonGroupBox
            // 
            this.EnumsSeasonGroupBox.Controls.Add(this.EnumsSeasonComboBox);
            this.EnumsSeasonGroupBox.Controls.Add(this.EnumsSeasonButton);
            this.EnumsSeasonGroupBox.Controls.Add(this.EnumsSeasonLabel);
            this.EnumsSeasonGroupBox.Location = new System.Drawing.Point(247, 202);
            this.EnumsSeasonGroupBox.Name = "EnumsSeasonGroupBox";
            this.EnumsSeasonGroupBox.Size = new System.Drawing.Size(246, 77);
            this.EnumsSeasonGroupBox.TabIndex = 8;
            this.EnumsSeasonGroupBox.TabStop = false;
            this.EnumsSeasonGroupBox.Text = "Season Handle";
            // 
            // EnumsSeasonComboBox
            // 
            this.EnumsSeasonComboBox.FormattingEnabled = true;
            this.EnumsSeasonComboBox.Location = new System.Drawing.Point(9, 31);
            this.EnumsSeasonComboBox.Name = "EnumsSeasonComboBox";
            this.EnumsSeasonComboBox.Size = new System.Drawing.Size(80, 21);
            this.EnumsSeasonComboBox.TabIndex = 7;
            // 
            // EnumsSeasonButton
            // 
            this.EnumsSeasonButton.Location = new System.Drawing.Point(94, 30);
            this.EnumsSeasonButton.Name = "EnumsSeasonButton";
            this.EnumsSeasonButton.Size = new System.Drawing.Size(75, 23);
            this.EnumsSeasonButton.TabIndex = 6;
            this.EnumsSeasonButton.Text = "Go";
            this.EnumsSeasonButton.UseVisualStyleBackColor = true;
            this.EnumsSeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // EnumsSeasonLabel
            // 
            this.EnumsSeasonLabel.AutoSize = true;
            this.EnumsSeasonLabel.Location = new System.Drawing.Point(6, 16);
            this.EnumsSeasonLabel.Name = "EnumsSeasonLabel";
            this.EnumsSeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.EnumsSeasonLabel.TabIndex = 3;
            this.EnumsSeasonLabel.Text = "Choose season:";
            // 
            // EnumsWeekdayGroupBox
            // 
            this.EnumsWeekdayGroupBox.Controls.Add(this.EnumsWeekdayParseLabel);
            this.EnumsWeekdayGroupBox.Controls.Add(this.EnumsWeekdayParseButton);
            this.EnumsWeekdayGroupBox.Controls.Add(this.EnumsWeekdayParseTextBox);
            this.EnumsWeekdayGroupBox.Controls.Add(this.EnumsWeekdayLabel);
            this.EnumsWeekdayGroupBox.Location = new System.Drawing.Point(8, 202);
            this.EnumsWeekdayGroupBox.Name = "EnumsWeekdayGroupBox";
            this.EnumsWeekdayGroupBox.Size = new System.Drawing.Size(233, 77);
            this.EnumsWeekdayGroupBox.TabIndex = 7;
            this.EnumsWeekdayGroupBox.TabStop = false;
            this.EnumsWeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // EnumsWeekdayParseLabel
            // 
            this.EnumsWeekdayParseLabel.AutoSize = true;
            this.EnumsWeekdayParseLabel.Location = new System.Drawing.Point(6, 56);
            this.EnumsWeekdayParseLabel.Name = "EnumsWeekdayParseLabel";
            this.EnumsWeekdayParseLabel.Size = new System.Drawing.Size(130, 13);
            this.EnumsWeekdayParseLabel.TabIndex = 7;
            this.EnumsWeekdayParseLabel.Text = "This day of week (... = ...).";
            // 
            // EnumsWeekdayParseButton
            // 
            this.EnumsWeekdayParseButton.Location = new System.Drawing.Point(119, 30);
            this.EnumsWeekdayParseButton.Name = "EnumsWeekdayParseButton";
            this.EnumsWeekdayParseButton.Size = new System.Drawing.Size(75, 23);
            this.EnumsWeekdayParseButton.TabIndex = 6;
            this.EnumsWeekdayParseButton.Text = "Parse";
            this.EnumsWeekdayParseButton.UseVisualStyleBackColor = true;
            this.EnumsWeekdayParseButton.Click += new System.EventHandler(this.WeekParseButton_Click);
            // 
            // EnumsWeekdayParseTextBox
            // 
            this.EnumsWeekdayParseTextBox.Location = new System.Drawing.Point(9, 32);
            this.EnumsWeekdayParseTextBox.Name = "EnumsWeekdayParseTextBox";
            this.EnumsWeekdayParseTextBox.Size = new System.Drawing.Size(104, 20);
            this.EnumsWeekdayParseTextBox.TabIndex = 5;
            // 
            // EnumsWeekdayLabel
            // 
            this.EnumsWeekdayLabel.AutoSize = true;
            this.EnumsWeekdayLabel.Location = new System.Drawing.Point(6, 16);
            this.EnumsWeekdayLabel.Name = "EnumsWeekdayLabel";
            this.EnumsWeekdayLabel.Size = new System.Drawing.Size(115, 13);
            this.EnumsWeekdayLabel.TabIndex = 3;
            this.EnumsWeekdayLabel.Text = "Type value for parsing:";
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.EnumsEnumsListBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsIntLabel);
            this.EnumsGroupBox.Controls.Add(this.EnumsEnumsLabel);
            this.EnumsGroupBox.Controls.Add(this.EnumIntTextBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsValueListBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsValueLabel);
            this.EnumsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(485, 190);
            this.EnumsGroupBox.TabIndex = 6;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // EnumsEnumsListBox
            // 
            this.EnumsEnumsListBox.FormattingEnabled = true;
            this.EnumsEnumsListBox.Location = new System.Drawing.Point(6, 32);
            this.EnumsEnumsListBox.Name = "EnumsEnumsListBox";
            this.EnumsEnumsListBox.Size = new System.Drawing.Size(130, 147);
            this.EnumsEnumsListBox.TabIndex = 0;
            this.EnumsEnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // EnumsIntLabel
            // 
            this.EnumsIntLabel.AutoSize = true;
            this.EnumsIntLabel.Location = new System.Drawing.Point(255, 16);
            this.EnumsIntLabel.Name = "EnumsIntLabel";
            this.EnumsIntLabel.Size = new System.Drawing.Size(58, 13);
            this.EnumsIntLabel.TabIndex = 5;
            this.EnumsIntLabel.Text = "Value\'s int:";
            // 
            // EnumsEnumsLabel
            // 
            this.EnumsEnumsLabel.AutoSize = true;
            this.EnumsEnumsLabel.Location = new System.Drawing.Point(6, 16);
            this.EnumsEnumsLabel.Name = "EnumsEnumsLabel";
            this.EnumsEnumsLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumsEnumsLabel.TabIndex = 2;
            this.EnumsEnumsLabel.Text = "Choose enumeration:";
            // 
            // EnumIntTextBox
            // 
            this.EnumIntTextBox.Location = new System.Drawing.Point(258, 32);
            this.EnumIntTextBox.Name = "EnumIntTextBox";
            this.EnumIntTextBox.ReadOnly = true;
            this.EnumIntTextBox.Size = new System.Drawing.Size(55, 20);
            this.EnumIntTextBox.TabIndex = 4;
            // 
            // EnumsValueListBox
            // 
            this.EnumsValueListBox.FormattingEnabled = true;
            this.EnumsValueListBox.Location = new System.Drawing.Point(161, 32);
            this.EnumsValueListBox.Name = "EnumsValueListBox";
            this.EnumsValueListBox.Size = new System.Drawing.Size(72, 147);
            this.EnumsValueListBox.TabIndex = 1;
            this.EnumsValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // EnumsValueLabel
            // 
            this.EnumsValueLabel.AutoSize = true;
            this.EnumsValueLabel.Location = new System.Drawing.Point(158, 16);
            this.EnumsValueLabel.Name = "EnumsValueLabel";
            this.EnumsValueLabel.Size = new System.Drawing.Size(75, 13);
            this.EnumsValueLabel.TabIndex = 3;
            this.EnumsValueLabel.Text = "Choose value:";
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesMoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.ClassesRectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(501, 287);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesMoviesGroupBox
            // 
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesRatingTextBox);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesRatingLabel);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesGenreTextBox);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesGenreLabel);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesButton);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesReleaseYearLabel);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesReleaseYearTextBox);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesMinutesLabel);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesMinutesTextBox);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesNameLabel);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesNameTextBox);
            this.ClassesMoviesGroupBox.Controls.Add(this.ClassesMoviesListBox);
            this.ClassesMoviesGroupBox.Location = new System.Drawing.Point(254, 6);
            this.ClassesMoviesGroupBox.Name = "ClassesMoviesGroupBox";
            this.ClassesMoviesGroupBox.Size = new System.Drawing.Size(239, 273);
            this.ClassesMoviesGroupBox.TabIndex = 8;
            this.ClassesMoviesGroupBox.TabStop = false;
            this.ClassesMoviesGroupBox.Text = "Movies";
            // 
            // ClassesMoviesRatingTextBox
            // 
            this.ClassesMoviesRatingTextBox.Location = new System.Drawing.Point(111, 191);
            this.ClassesMoviesRatingTextBox.Name = "ClassesMoviesRatingTextBox";
            this.ClassesMoviesRatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesMoviesRatingTextBox.TabIndex = 16;
            this.ClassesMoviesRatingTextBox.TextChanged += new System.EventHandler(this.RatingMoviesTextBox_TextChanged);
            // 
            // ClassesMoviesRatingLabel
            // 
            this.ClassesMoviesRatingLabel.AutoSize = true;
            this.ClassesMoviesRatingLabel.Location = new System.Drawing.Point(111, 175);
            this.ClassesMoviesRatingLabel.Name = "ClassesMoviesRatingLabel";
            this.ClassesMoviesRatingLabel.Size = new System.Drawing.Size(41, 13);
            this.ClassesMoviesRatingLabel.TabIndex = 15;
            this.ClassesMoviesRatingLabel.Text = "Rating:";
            // 
            // ClassesMoviesGenreTextBox
            // 
            this.ClassesMoviesGenreTextBox.Location = new System.Drawing.Point(111, 152);
            this.ClassesMoviesGenreTextBox.Name = "ClassesMoviesGenreTextBox";
            this.ClassesMoviesGenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesMoviesGenreTextBox.TabIndex = 14;
            this.ClassesMoviesGenreTextBox.TextChanged += new System.EventHandler(this.GenreMoviesTextBox_TextChanged);
            // 
            // ClassesMoviesGenreLabel
            // 
            this.ClassesMoviesGenreLabel.AutoSize = true;
            this.ClassesMoviesGenreLabel.Location = new System.Drawing.Point(111, 136);
            this.ClassesMoviesGenreLabel.Name = "ClassesMoviesGenreLabel";
            this.ClassesMoviesGenreLabel.Size = new System.Drawing.Size(39, 13);
            this.ClassesMoviesGenreLabel.TabIndex = 13;
            this.ClassesMoviesGenreLabel.Text = "Genre:";
            // 
            // ClassesMoviesButton
            // 
            this.ClassesMoviesButton.Location = new System.Drawing.Point(111, 234);
            this.ClassesMoviesButton.Name = "ClassesMoviesButton";
            this.ClassesMoviesButton.Size = new System.Drawing.Size(100, 23);
            this.ClassesMoviesButton.TabIndex = 12;
            this.ClassesMoviesButton.Text = "Find";
            this.ClassesMoviesButton.UseVisualStyleBackColor = true;
            this.ClassesMoviesButton.Click += new System.EventHandler(this.MoviesButton_Click);
            // 
            // ClassesMoviesReleaseYearLabel
            // 
            this.ClassesMoviesReleaseYearLabel.AutoSize = true;
            this.ClassesMoviesReleaseYearLabel.Location = new System.Drawing.Point(111, 97);
            this.ClassesMoviesReleaseYearLabel.Name = "ClassesMoviesReleaseYearLabel";
            this.ClassesMoviesReleaseYearLabel.Size = new System.Drawing.Size(72, 13);
            this.ClassesMoviesReleaseYearLabel.TabIndex = 11;
            this.ClassesMoviesReleaseYearLabel.Text = "Release year:";
            // 
            // ClassesMoviesReleaseYearTextBox
            // 
            this.ClassesMoviesReleaseYearTextBox.Location = new System.Drawing.Point(111, 113);
            this.ClassesMoviesReleaseYearTextBox.Name = "ClassesMoviesReleaseYearTextBox";
            this.ClassesMoviesReleaseYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesMoviesReleaseYearTextBox.TabIndex = 10;
            this.ClassesMoviesReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearMoviesTextBox_TextChanged);
            // 
            // ClassesMoviesMinutesLabel
            // 
            this.ClassesMoviesMinutesLabel.AutoSize = true;
            this.ClassesMoviesMinutesLabel.Location = new System.Drawing.Point(111, 58);
            this.ClassesMoviesMinutesLabel.Name = "ClassesMoviesMinutesLabel";
            this.ClassesMoviesMinutesLabel.Size = new System.Drawing.Size(47, 13);
            this.ClassesMoviesMinutesLabel.TabIndex = 9;
            this.ClassesMoviesMinutesLabel.Text = "Minutes:";
            // 
            // ClassesMoviesMinutesTextBox
            // 
            this.ClassesMoviesMinutesTextBox.Location = new System.Drawing.Point(111, 74);
            this.ClassesMoviesMinutesTextBox.Name = "ClassesMoviesMinutesTextBox";
            this.ClassesMoviesMinutesTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesMoviesMinutesTextBox.TabIndex = 8;
            this.ClassesMoviesMinutesTextBox.TextChanged += new System.EventHandler(this.MinutesMoviesTextBox_TextChanged);
            // 
            // ClassesMoviesNameLabel
            // 
            this.ClassesMoviesNameLabel.AutoSize = true;
            this.ClassesMoviesNameLabel.Location = new System.Drawing.Point(111, 19);
            this.ClassesMoviesNameLabel.Name = "ClassesMoviesNameLabel";
            this.ClassesMoviesNameLabel.Size = new System.Drawing.Size(38, 13);
            this.ClassesMoviesNameLabel.TabIndex = 7;
            this.ClassesMoviesNameLabel.Text = "Name:";
            // 
            // ClassesMoviesNameTextBox
            // 
            this.ClassesMoviesNameTextBox.Location = new System.Drawing.Point(111, 35);
            this.ClassesMoviesNameTextBox.Name = "ClassesMoviesNameTextBox";
            this.ClassesMoviesNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesMoviesNameTextBox.TabIndex = 6;
            this.ClassesMoviesNameTextBox.TextChanged += new System.EventHandler(this.NameMoviesTextBox_TextChanged);
            // 
            // ClassesMoviesListBox
            // 
            this.ClassesMoviesListBox.FormattingEnabled = true;
            this.ClassesMoviesListBox.Location = new System.Drawing.Point(6, 19);
            this.ClassesMoviesListBox.Name = "ClassesMoviesListBox";
            this.ClassesMoviesListBox.Size = new System.Drawing.Size(72, 238);
            this.ClassesMoviesListBox.TabIndex = 0;
            this.ClassesMoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // ClassesRectanglesGroupBox
            // 
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesIdLabel);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesIdTextBox);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesCenterLabel);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesCenterTextBox);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesButton);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesColorLabel);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesColorTextBox);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesWidthLabel);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesWidthTextBox);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesLengthLabel);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesLengthTextBox);
            this.ClassesRectanglesGroupBox.Controls.Add(this.ClassesRectanglesListBox);
            this.ClassesRectanglesGroupBox.Location = new System.Drawing.Point(8, 6);
            this.ClassesRectanglesGroupBox.Name = "ClassesRectanglesGroupBox";
            this.ClassesRectanglesGroupBox.Size = new System.Drawing.Size(239, 273);
            this.ClassesRectanglesGroupBox.TabIndex = 7;
            this.ClassesRectanglesGroupBox.TabStop = false;
            this.ClassesRectanglesGroupBox.Text = "Rectangles";
            // 
            // ClassesRectanglesCenterLabel
            // 
            this.ClassesRectanglesCenterLabel.AutoSize = true;
            this.ClassesRectanglesCenterLabel.Location = new System.Drawing.Point(111, 97);
            this.ClassesRectanglesCenterLabel.Name = "ClassesRectanglesCenterLabel";
            this.ClassesRectanglesCenterLabel.Size = new System.Drawing.Size(41, 13);
            this.ClassesRectanglesCenterLabel.TabIndex = 14;
            this.ClassesRectanglesCenterLabel.Text = "Center:";
            // 
            // ClassesRectanglesCenterTextBox
            // 
            this.ClassesRectanglesCenterTextBox.Location = new System.Drawing.Point(111, 113);
            this.ClassesRectanglesCenterTextBox.Name = "ClassesRectanglesCenterTextBox";
            this.ClassesRectanglesCenterTextBox.ReadOnly = true;
            this.ClassesRectanglesCenterTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesRectanglesCenterTextBox.TabIndex = 13;
            // 
            // ClassesRectanglesButton
            // 
            this.ClassesRectanglesButton.Location = new System.Drawing.Point(111, 234);
            this.ClassesRectanglesButton.Name = "ClassesRectanglesButton";
            this.ClassesRectanglesButton.Size = new System.Drawing.Size(100, 23);
            this.ClassesRectanglesButton.TabIndex = 12;
            this.ClassesRectanglesButton.Text = "Find";
            this.ClassesRectanglesButton.UseVisualStyleBackColor = true;
            this.ClassesRectanglesButton.Click += new System.EventHandler(this.RectanglesButton_Click);
            // 
            // ClassesRectanglesColorLabel
            // 
            this.ClassesRectanglesColorLabel.AutoSize = true;
            this.ClassesRectanglesColorLabel.Location = new System.Drawing.Point(111, 136);
            this.ClassesRectanglesColorLabel.Name = "ClassesRectanglesColorLabel";
            this.ClassesRectanglesColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ClassesRectanglesColorLabel.TabIndex = 11;
            this.ClassesRectanglesColorLabel.Text = "Color:";
            // 
            // ClassesRectanglesColorTextBox
            // 
            this.ClassesRectanglesColorTextBox.Location = new System.Drawing.Point(111, 152);
            this.ClassesRectanglesColorTextBox.Name = "ClassesRectanglesColorTextBox";
            this.ClassesRectanglesColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesRectanglesColorTextBox.TabIndex = 10;
            this.ClassesRectanglesColorTextBox.TextChanged += new System.EventHandler(this.ColorRectanglesTextBox_TextChanged);
            // 
            // ClassesRectanglesWidthLabel
            // 
            this.ClassesRectanglesWidthLabel.AutoSize = true;
            this.ClassesRectanglesWidthLabel.Location = new System.Drawing.Point(111, 55);
            this.ClassesRectanglesWidthLabel.Name = "ClassesRectanglesWidthLabel";
            this.ClassesRectanglesWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.ClassesRectanglesWidthLabel.TabIndex = 9;
            this.ClassesRectanglesWidthLabel.Text = "Width:";
            // 
            // ClassesRectanglesWidthTextBox
            // 
            this.ClassesRectanglesWidthTextBox.Location = new System.Drawing.Point(111, 74);
            this.ClassesRectanglesWidthTextBox.Name = "ClassesRectanglesWidthTextBox";
            this.ClassesRectanglesWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesRectanglesWidthTextBox.TabIndex = 8;
            this.ClassesRectanglesWidthTextBox.TextChanged += new System.EventHandler(this.WidthRectanglesTextBox_TextChanged);
            // 
            // ClassesRectanglesLengthLabel
            // 
            this.ClassesRectanglesLengthLabel.AutoSize = true;
            this.ClassesRectanglesLengthLabel.Location = new System.Drawing.Point(111, 16);
            this.ClassesRectanglesLengthLabel.Name = "ClassesRectanglesLengthLabel";
            this.ClassesRectanglesLengthLabel.Size = new System.Drawing.Size(43, 13);
            this.ClassesRectanglesLengthLabel.TabIndex = 7;
            this.ClassesRectanglesLengthLabel.Text = "Length:";
            // 
            // ClassesRectanglesLengthTextBox
            // 
            this.ClassesRectanglesLengthTextBox.Location = new System.Drawing.Point(111, 32);
            this.ClassesRectanglesLengthTextBox.Name = "ClassesRectanglesLengthTextBox";
            this.ClassesRectanglesLengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesRectanglesLengthTextBox.TabIndex = 6;
            this.ClassesRectanglesLengthTextBox.TextChanged += new System.EventHandler(this.LengthRectanglesTextBox_TextChanged);
            // 
            // ClassesRectanglesListBox
            // 
            this.ClassesRectanglesListBox.FormattingEnabled = true;
            this.ClassesRectanglesListBox.Location = new System.Drawing.Point(6, 19);
            this.ClassesRectanglesListBox.Name = "ClassesRectanglesListBox";
            this.ClassesRectanglesListBox.Size = new System.Drawing.Size(72, 238);
            this.ClassesRectanglesListBox.TabIndex = 0;
            this.ClassesRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // ClassesRectanglesIdTextBox
            // 
            this.ClassesRectanglesIdTextBox.Location = new System.Drawing.Point(111, 191);
            this.ClassesRectanglesIdTextBox.Name = "ClassesRectanglesIdTextBox";
            this.ClassesRectanglesIdTextBox.ReadOnly = true;
            this.ClassesRectanglesIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.ClassesRectanglesIdTextBox.TabIndex = 15;
            // 
            // ClassesRectanglesIdLabel
            // 
            this.ClassesRectanglesIdLabel.AutoSize = true;
            this.ClassesRectanglesIdLabel.Location = new System.Drawing.Point(108, 175);
            this.ClassesRectanglesIdLabel.Name = "ClassesRectanglesIdLabel";
            this.ClassesRectanglesIdLabel.Size = new System.Drawing.Size(19, 13);
            this.ClassesRectanglesIdLabel.TabIndex = 16;
            this.ClassesRectanglesIdLabel.Text = "Id:";
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
            this.EnumsSeasonGroupBox.ResumeLayout(false);
            this.EnumsSeasonGroupBox.PerformLayout();
            this.EnumsWeekdayGroupBox.ResumeLayout(false);
            this.EnumsWeekdayGroupBox.PerformLayout();
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesMoviesGroupBox.ResumeLayout(false);
            this.ClassesMoviesGroupBox.PerformLayout();
            this.ClassesRectanglesGroupBox.ResumeLayout(false);
            this.ClassesRectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.ListBox EnumsValueListBox;
        private System.Windows.Forms.ListBox EnumsEnumsListBox;
        private System.Windows.Forms.Label EnumsValueLabel;
        private System.Windows.Forms.Label EnumsEnumsLabel;
        private System.Windows.Forms.Label EnumsIntLabel;
        private System.Windows.Forms.TextBox EnumIntTextBox;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.GroupBox EnumsWeekdayGroupBox;
        private System.Windows.Forms.TextBox EnumsWeekdayParseTextBox;
        private System.Windows.Forms.Label EnumsWeekdayLabel;
        private System.Windows.Forms.Label EnumsWeekdayParseLabel;
        private System.Windows.Forms.Button EnumsWeekdayParseButton;
        private System.Windows.Forms.GroupBox EnumsSeasonGroupBox;
        private System.Windows.Forms.Button EnumsSeasonButton;
        private System.Windows.Forms.Label EnumsSeasonLabel;
        private System.Windows.Forms.ComboBox EnumsSeasonComboBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox ClassesRectanglesGroupBox;
        private System.Windows.Forms.Button ClassesRectanglesButton;
        private System.Windows.Forms.Label ClassesRectanglesColorLabel;
        private System.Windows.Forms.TextBox ClassesRectanglesColorTextBox;
        private System.Windows.Forms.Label ClassesRectanglesWidthLabel;
        private System.Windows.Forms.TextBox ClassesRectanglesWidthTextBox;
        private System.Windows.Forms.Label ClassesRectanglesLengthLabel;
        private System.Windows.Forms.TextBox ClassesRectanglesLengthTextBox;
        private System.Windows.Forms.ListBox ClassesRectanglesListBox;
        private System.Windows.Forms.GroupBox ClassesMoviesGroupBox;
        private System.Windows.Forms.Button ClassesMoviesButton;
        private System.Windows.Forms.Label ClassesMoviesReleaseYearLabel;
        private System.Windows.Forms.TextBox ClassesMoviesReleaseYearTextBox;
        private System.Windows.Forms.Label ClassesMoviesMinutesLabel;
        private System.Windows.Forms.TextBox ClassesMoviesMinutesTextBox;
        private System.Windows.Forms.Label ClassesMoviesNameLabel;
        private System.Windows.Forms.TextBox ClassesMoviesNameTextBox;
        private System.Windows.Forms.ListBox ClassesMoviesListBox;
        private System.Windows.Forms.TextBox ClassesMoviesRatingTextBox;
        private System.Windows.Forms.Label ClassesMoviesRatingLabel;
        private System.Windows.Forms.TextBox ClassesMoviesGenreTextBox;
        private System.Windows.Forms.Label ClassesMoviesGenreLabel;
        private System.Windows.Forms.Label ClassesRectanglesCenterLabel;
        private System.Windows.Forms.TextBox ClassesRectanglesCenterTextBox;
        private System.Windows.Forms.Label ClassesRectanglesIdLabel;
        private System.Windows.Forms.TextBox ClassesRectanglesIdTextBox;
    }
}

