
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.WeekGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekParseLabel = new System.Windows.Forms.Label();
            this.WeekParseButton = new System.Windows.Forms.Button();
            this.WeekParseTextBox = new System.Windows.Forms.TextBox();
            this.WeekLabel = new System.Windows.Forms.Label();
            this.EnumGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumListBox = new System.Windows.Forms.ListBox();
            this.IntLabel = new System.Windows.Forms.Label();
            this.EnumLabel = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesButton = new System.Windows.Forms.Button();
            this.ColorRectanglesLabel = new System.Windows.Forms.Label();
            this.ColorRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.WidthRectanglesLabel = new System.Windows.Forms.Label();
            this.WidthRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.LengthRectanglesLabel = new System.Windows.Forms.Label();
            this.LengthRectanglesTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.FilmsButton = new System.Windows.Forms.Button();
            this.IssueYearFilmsLabel = new System.Windows.Forms.Label();
            this.IssueYearFilmsTextBox = new System.Windows.Forms.TextBox();
            this.MinutesFilmsLabel = new System.Windows.Forms.Label();
            this.MinutesFilmsTextBox = new System.Windows.Forms.TextBox();
            this.NameFilmsLabel = new System.Windows.Forms.Label();
            this.NameFilmsTextBox = new System.Windows.Forms.TextBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.GenreFilmsLabel = new System.Windows.Forms.Label();
            this.GenreFilmsTextBox = new System.Windows.Forms.TextBox();
            this.RatingFilmsLabel = new System.Windows.Forms.Label();
            this.RatingFilmsTextBox = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.WeekGroupBox.SuspendLayout();
            this.EnumGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.FilmsGroupBox.SuspendLayout();
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
            this.EnumsTabPage.Controls.Add(this.WeekGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(501, 287);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonGroupBox.Location = new System.Drawing.Point(247, 202);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Size = new System.Drawing.Size(248, 79);
            this.SeasonGroupBox.TabIndex = 8;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(9, 34);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(112, 21);
            this.SeasonComboBox.TabIndex = 7;
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(147, 32);
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
            // WeekGroupBox
            // 
            this.WeekGroupBox.Controls.Add(this.WeekParseLabel);
            this.WeekGroupBox.Controls.Add(this.WeekParseButton);
            this.WeekGroupBox.Controls.Add(this.WeekParseTextBox);
            this.WeekGroupBox.Controls.Add(this.WeekLabel);
            this.WeekGroupBox.Location = new System.Drawing.Point(8, 202);
            this.WeekGroupBox.Name = "WeekGroupBox";
            this.WeekGroupBox.Size = new System.Drawing.Size(233, 79);
            this.WeekGroupBox.TabIndex = 7;
            this.WeekGroupBox.TabStop = false;
            this.WeekGroupBox.Text = "Weekday Parsing";
            // 
            // WeekParseLabel
            // 
            this.WeekParseLabel.AutoSize = true;
            this.WeekParseLabel.Location = new System.Drawing.Point(6, 55);
            this.WeekParseLabel.Name = "WeekParseLabel";
            this.WeekParseLabel.Size = new System.Drawing.Size(130, 13);
            this.WeekParseLabel.TabIndex = 7;
            this.WeekParseLabel.Text = "This day of week (... = ...).";
            // 
            // WeekParseButton
            // 
            this.WeekParseButton.Location = new System.Drawing.Point(142, 32);
            this.WeekParseButton.Name = "WeekParseButton";
            this.WeekParseButton.Size = new System.Drawing.Size(75, 23);
            this.WeekParseButton.TabIndex = 6;
            this.WeekParseButton.Text = "Parse";
            this.WeekParseButton.UseVisualStyleBackColor = true;
            this.WeekParseButton.Click += new System.EventHandler(this.WeekParseButton_Click);
            // 
            // WeekParseTextBox
            // 
            this.WeekParseTextBox.Location = new System.Drawing.Point(6, 32);
            this.WeekParseTextBox.Name = "WeekParseTextBox";
            this.WeekParseTextBox.Size = new System.Drawing.Size(115, 20);
            this.WeekParseTextBox.TabIndex = 5;
            // 
            // WeekLabel
            // 
            this.WeekLabel.AutoSize = true;
            this.WeekLabel.Location = new System.Drawing.Point(6, 16);
            this.WeekLabel.Name = "WeekLabel";
            this.WeekLabel.Size = new System.Drawing.Size(115, 13);
            this.WeekLabel.TabIndex = 3;
            this.WeekLabel.Text = "Type value for parsing:";
            // 
            // EnumGroupBox
            // 
            this.EnumGroupBox.Controls.Add(this.EnumListBox);
            this.EnumGroupBox.Controls.Add(this.IntLabel);
            this.EnumGroupBox.Controls.Add(this.EnumLabel);
            this.EnumGroupBox.Controls.Add(this.IntTextBox);
            this.EnumGroupBox.Controls.Add(this.ValueListBox);
            this.EnumGroupBox.Controls.Add(this.ValueLabel);
            this.EnumGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumGroupBox.Name = "EnumGroupBox";
            this.EnumGroupBox.Size = new System.Drawing.Size(487, 190);
            this.EnumGroupBox.TabIndex = 6;
            this.EnumGroupBox.TabStop = false;
            this.EnumGroupBox.Text = "Enumerations";
            // 
            // EnumListBox
            // 
            this.EnumListBox.FormattingEnabled = true;
            this.EnumListBox.Location = new System.Drawing.Point(6, 32);
            this.EnumListBox.Name = "EnumListBox";
            this.EnumListBox.Size = new System.Drawing.Size(153, 147);
            this.EnumListBox.TabIndex = 0;
            this.EnumListBox.SelectedIndexChanged += new System.EventHandler(this.EnumListBox_SelectedIndexChanged);
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.Location = new System.Drawing.Point(325, 16);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(58, 13);
            this.IntLabel.TabIndex = 5;
            this.IntLabel.Text = "Value\'s int:";
            // 
            // EnumLabel
            // 
            this.EnumLabel.AutoSize = true;
            this.EnumLabel.Location = new System.Drawing.Point(6, 16);
            this.EnumLabel.Name = "EnumLabel";
            this.EnumLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumLabel.TabIndex = 2;
            this.EnumLabel.Text = "Choose enumeration:";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(328, 32);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.ReadOnly = true;
            this.IntTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntTextBox.TabIndex = 4;
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(179, 32);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(120, 147);
            this.ValueListBox.TabIndex = 1;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.ValueListBox_SelectedIndexChanged);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(176, 16);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 3;
            this.ValueLabel.Text = "Choose value:";
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.FilmsGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(501, 287);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
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
            this.RectanglesGroupBox.Location = new System.Drawing.Point(6, 6);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(235, 273);
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
            this.WidthRectanglesTextBox.Location = new System.Drawing.Point(111, 71);
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
            this.RectanglesListBox.Size = new System.Drawing.Size(99, 238);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.RatingFilmsTextBox);
            this.FilmsGroupBox.Controls.Add(this.RatingFilmsLabel);
            this.FilmsGroupBox.Controls.Add(this.GenreFilmsTextBox);
            this.FilmsGroupBox.Controls.Add(this.GenreFilmsLabel);
            this.FilmsGroupBox.Controls.Add(this.FilmsButton);
            this.FilmsGroupBox.Controls.Add(this.IssueYearFilmsLabel);
            this.FilmsGroupBox.Controls.Add(this.IssueYearFilmsTextBox);
            this.FilmsGroupBox.Controls.Add(this.MinutesFilmsLabel);
            this.FilmsGroupBox.Controls.Add(this.MinutesFilmsTextBox);
            this.FilmsGroupBox.Controls.Add(this.NameFilmsLabel);
            this.FilmsGroupBox.Controls.Add(this.NameFilmsTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmsGroupBox.Location = new System.Drawing.Point(258, 6);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(235, 273);
            this.FilmsGroupBox.TabIndex = 8;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // FilmsButton
            // 
            this.FilmsButton.Location = new System.Drawing.Point(111, 234);
            this.FilmsButton.Name = "FilmsButton";
            this.FilmsButton.Size = new System.Drawing.Size(100, 23);
            this.FilmsButton.TabIndex = 12;
            this.FilmsButton.Text = "Find";
            this.FilmsButton.UseVisualStyleBackColor = true;
            this.FilmsButton.Click += new System.EventHandler(this.FilmsButton_Click);
            // 
            // IssueYearFilmsLabel
            // 
            this.IssueYearFilmsLabel.AutoSize = true;
            this.IssueYearFilmsLabel.Location = new System.Drawing.Point(111, 97);
            this.IssueYearFilmsLabel.Name = "IssueYearFilmsLabel";
            this.IssueYearFilmsLabel.Size = new System.Drawing.Size(71, 13);
            this.IssueYearFilmsLabel.TabIndex = 11;
            this.IssueYearFilmsLabel.Text = "Year of issue:";
            // 
            // IssueYearFilmsTextBox
            // 
            this.IssueYearFilmsTextBox.Location = new System.Drawing.Point(111, 113);
            this.IssueYearFilmsTextBox.Name = "IssueYearFilmsTextBox";
            this.IssueYearFilmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.IssueYearFilmsTextBox.TabIndex = 10;
            this.IssueYearFilmsTextBox.TextChanged += new System.EventHandler(this.IssueYearFilmsTextBox_TextChanged);
            // 
            // MinutesFilmsLabel
            // 
            this.MinutesFilmsLabel.AutoSize = true;
            this.MinutesFilmsLabel.Location = new System.Drawing.Point(111, 58);
            this.MinutesFilmsLabel.Name = "MinutesFilmsLabel";
            this.MinutesFilmsLabel.Size = new System.Drawing.Size(47, 13);
            this.MinutesFilmsLabel.TabIndex = 9;
            this.MinutesFilmsLabel.Text = "Minutes:";
            // 
            // MinutesFilmsTextBox
            // 
            this.MinutesFilmsTextBox.Location = new System.Drawing.Point(111, 74);
            this.MinutesFilmsTextBox.Name = "MinutesFilmsTextBox";
            this.MinutesFilmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.MinutesFilmsTextBox.TabIndex = 8;
            this.MinutesFilmsTextBox.TextChanged += new System.EventHandler(this.MinutesFilmsTextBox_TextChanged);
            // 
            // NameFilmsLabel
            // 
            this.NameFilmsLabel.AutoSize = true;
            this.NameFilmsLabel.Location = new System.Drawing.Point(111, 19);
            this.NameFilmsLabel.Name = "NameFilmsLabel";
            this.NameFilmsLabel.Size = new System.Drawing.Size(38, 13);
            this.NameFilmsLabel.TabIndex = 7;
            this.NameFilmsLabel.Text = "Name:";
            // 
            // NameFilmsTextBox
            // 
            this.NameFilmsTextBox.Location = new System.Drawing.Point(111, 35);
            this.NameFilmsTextBox.Name = "NameFilmsTextBox";
            this.NameFilmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameFilmsTextBox.TabIndex = 6;
            this.NameFilmsTextBox.TextChanged += new System.EventHandler(this.NameFilmsTextBox_TextChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.Location = new System.Drawing.Point(6, 19);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(99, 238);
            this.FilmsListBox.TabIndex = 0;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // GenreFilmsLabel
            // 
            this.GenreFilmsLabel.AutoSize = true;
            this.GenreFilmsLabel.Location = new System.Drawing.Point(111, 136);
            this.GenreFilmsLabel.Name = "GenreFilmsLabel";
            this.GenreFilmsLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreFilmsLabel.TabIndex = 13;
            this.GenreFilmsLabel.Text = "Genre:";
            // 
            // GenreFilmsTextBox
            // 
            this.GenreFilmsTextBox.Location = new System.Drawing.Point(111, 152);
            this.GenreFilmsTextBox.Name = "GenreFilmsTextBox";
            this.GenreFilmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreFilmsTextBox.TabIndex = 14;
            this.GenreFilmsTextBox.TextChanged += new System.EventHandler(this.GenreFilmsTextBox_TextChanged);
            // 
            // RatingFilmsLabel
            // 
            this.RatingFilmsLabel.AutoSize = true;
            this.RatingFilmsLabel.Location = new System.Drawing.Point(111, 175);
            this.RatingFilmsLabel.Name = "RatingFilmsLabel";
            this.RatingFilmsLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingFilmsLabel.TabIndex = 15;
            this.RatingFilmsLabel.Text = "Rating:";
            // 
            // RatingFilmsTextBox
            // 
            this.RatingFilmsTextBox.Location = new System.Drawing.Point(111, 191);
            this.RatingFilmsTextBox.Name = "RatingFilmsTextBox";
            this.RatingFilmsTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingFilmsTextBox.TabIndex = 16;
            this.RatingFilmsTextBox.TextChanged += new System.EventHandler(this.RatingFilmsTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 313);
            this.Controls.Add(this.TabControl);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.TabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.WeekGroupBox.ResumeLayout(false);
            this.WeekGroupBox.PerformLayout();
            this.EnumGroupBox.ResumeLayout(false);
            this.EnumGroupBox.PerformLayout();
            this.ClassesTabPage.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.ListBox EnumListBox;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label EnumLabel;
        private System.Windows.Forms.Label IntLabel;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.GroupBox EnumGroupBox;
        private System.Windows.Forms.GroupBox WeekGroupBox;
        private System.Windows.Forms.TextBox WeekParseTextBox;
        private System.Windows.Forms.Label WeekLabel;
        private System.Windows.Forms.Label WeekParseLabel;
        private System.Windows.Forms.Button WeekParseButton;
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
        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.Button FilmsButton;
        private System.Windows.Forms.Label IssueYearFilmsLabel;
        private System.Windows.Forms.TextBox IssueYearFilmsTextBox;
        private System.Windows.Forms.Label MinutesFilmsLabel;
        private System.Windows.Forms.TextBox MinutesFilmsTextBox;
        private System.Windows.Forms.Label NameFilmsLabel;
        private System.Windows.Forms.TextBox NameFilmsTextBox;
        private System.Windows.Forms.ListBox FilmsListBox;
        private System.Windows.Forms.TextBox RatingFilmsTextBox;
        private System.Windows.Forms.Label RatingFilmsLabel;
        private System.Windows.Forms.TextBox GenreFilmsTextBox;
        private System.Windows.Forms.Label GenreFilmsLabel;
    }
}

