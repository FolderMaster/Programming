
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
            this.seasonHandleControl1 = new Programming.View.Controls.SeasonHandleControl();
            this.EnumsWeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.enumerationsControl1 = new Programming.View.Controls.EnumerationsControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.ClassesMoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.moviesControl1 = new Programming.View.Controls.MoviesControl();
            this.ClassesRectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.rectanglesControl1 = new Programming.View.Controls.RectanglesControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesCollisionControl = new Programming.View.TabPages.RectanglesCollisionControl();
            this.TabControl.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.EnumsSeasonGroupBox.SuspendLayout();
            this.EnumsWeekdayGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.ClassesMoviesGroupBox.SuspendLayout();
            this.ClassesRectanglesGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabPage);
            this.TabControl.Controls.Add(this.ClassesTabPage);
            this.TabControl.Controls.Add(this.RectanglesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(509, 389);
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
            this.EnumsTabPage.Size = new System.Drawing.Size(501, 363);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // EnumsSeasonGroupBox
            // 
            this.EnumsSeasonGroupBox.Controls.Add(this.seasonHandleControl1);
            this.EnumsSeasonGroupBox.Location = new System.Drawing.Point(247, 202);
            this.EnumsSeasonGroupBox.Name = "EnumsSeasonGroupBox";
            this.EnumsSeasonGroupBox.Size = new System.Drawing.Size(246, 77);
            this.EnumsSeasonGroupBox.TabIndex = 8;
            this.EnumsSeasonGroupBox.TabStop = false;
            this.EnumsSeasonGroupBox.Text = "Season Handle";
            // 
            // seasonHandleControl1
            // 
            this.seasonHandleControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seasonHandleControl1.Location = new System.Drawing.Point(3, 16);
            this.seasonHandleControl1.Name = "seasonHandleControl1";
            this.seasonHandleControl1.Size = new System.Drawing.Size(240, 58);
            this.seasonHandleControl1.TabIndex = 0;
            // 
            // EnumsWeekdayGroupBox
            // 
            this.EnumsWeekdayGroupBox.Controls.Add(this.weekdayParsingControl1);
            this.EnumsWeekdayGroupBox.Location = new System.Drawing.Point(8, 202);
            this.EnumsWeekdayGroupBox.Name = "EnumsWeekdayGroupBox";
            this.EnumsWeekdayGroupBox.Size = new System.Drawing.Size(233, 77);
            this.EnumsWeekdayGroupBox.TabIndex = 7;
            this.EnumsWeekdayGroupBox.TabStop = false;
            this.EnumsWeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekdayParsingControl1.Location = new System.Drawing.Point(3, 16);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(227, 58);
            this.weekdayParsingControl1.TabIndex = 0;
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.enumerationsControl1);
            this.EnumsGroupBox.Location = new System.Drawing.Point(8, 6);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(485, 190);
            this.EnumsGroupBox.TabIndex = 6;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enumerationsControl1.Location = new System.Drawing.Point(3, 16);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(479, 171);
            this.enumerationsControl1.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.ClassesMoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.ClassesRectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ClassesTabPage.Size = new System.Drawing.Size(501, 363);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // ClassesMoviesGroupBox
            // 
            this.ClassesMoviesGroupBox.Controls.Add(this.moviesControl1);
            this.ClassesMoviesGroupBox.Location = new System.Drawing.Point(254, 6);
            this.ClassesMoviesGroupBox.Name = "ClassesMoviesGroupBox";
            this.ClassesMoviesGroupBox.Size = new System.Drawing.Size(239, 273);
            this.ClassesMoviesGroupBox.TabIndex = 8;
            this.ClassesMoviesGroupBox.TabStop = false;
            this.ClassesMoviesGroupBox.Text = "Movies";
            // 
            // moviesControl1
            // 
            this.moviesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesControl1.Location = new System.Drawing.Point(3, 16);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(233, 254);
            this.moviesControl1.TabIndex = 0;
            // 
            // ClassesRectanglesGroupBox
            // 
            this.ClassesRectanglesGroupBox.Controls.Add(this.rectanglesControl1);
            this.ClassesRectanglesGroupBox.Location = new System.Drawing.Point(8, 6);
            this.ClassesRectanglesGroupBox.Name = "ClassesRectanglesGroupBox";
            this.ClassesRectanglesGroupBox.Size = new System.Drawing.Size(239, 273);
            this.ClassesRectanglesGroupBox.TabIndex = 7;
            this.ClassesRectanglesGroupBox.TabStop = false;
            this.ClassesRectanglesGroupBox.Text = "Rectangles";
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesControl1.Location = new System.Drawing.Point(3, 16);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(233, 254);
            this.rectanglesControl1.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.RectanglesCollisionControl);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RectanglesTabPage.Size = new System.Drawing.Size(501, 363);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesCollisionControl
            // 
            this.RectanglesCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesCollisionControl.Location = new System.Drawing.Point(3, 3);
            this.RectanglesCollisionControl.Name = "RectanglesCollisionControl";
            this.RectanglesCollisionControl.Size = new System.Drawing.Size(495, 357);
            this.RectanglesCollisionControl.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 389);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming";
            this.TabControl.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.EnumsSeasonGroupBox.ResumeLayout(false);
            this.EnumsWeekdayGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.ClassesMoviesGroupBox.ResumeLayout(false);
            this.ClassesRectanglesGroupBox.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.GroupBox EnumsWeekdayGroupBox;
        private System.Windows.Forms.GroupBox EnumsSeasonGroupBox;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox ClassesRectanglesGroupBox;
        private System.Windows.Forms.GroupBox ClassesMoviesGroupBox;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private TabPages.RectanglesCollisionControl RectanglesCollisionControl;
        private Controls.EnumerationsControl enumerationsControl1;
        private Controls.WeekdayParsingControl weekdayParsingControl1;
        private Controls.SeasonHandleControl seasonHandleControl1;
        private Controls.RectanglesControl rectanglesControl1;
        private Controls.MoviesControl moviesControl1;
    }
}

