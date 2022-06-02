namespace MovieApp.View
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
            this.MovieEditorGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieEditorControl = new MovieApp.View.Controls.MovieEditorControl();
            this.MovieListControl = new MovieApp.View.Controls.MovieListControl();
            this.MovieListGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieEditorGroupBox.SuspendLayout();
            this.MovieListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovieEditorGroupBox
            // 
            this.MovieEditorGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovieEditorGroupBox.Controls.Add(this.MovieEditorControl);
            this.MovieEditorGroupBox.Location = new System.Drawing.Point(218, 12);
            this.MovieEditorGroupBox.Name = "MovieEditorGroupBox";
            this.MovieEditorGroupBox.Size = new System.Drawing.Size(203, 146);
            this.MovieEditorGroupBox.TabIndex = 2;
            this.MovieEditorGroupBox.TabStop = false;
            this.MovieEditorGroupBox.Text = "Movie editor";
            // 
            // MovieEditorControl
            // 
            this.MovieEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieEditorControl.Location = new System.Drawing.Point(3, 16);
            this.MovieEditorControl.Movie = null;
            this.MovieEditorControl.Name = "MovieEditorControl";
            this.MovieEditorControl.Size = new System.Drawing.Size(197, 127);
            this.MovieEditorControl.TabIndex = 0;
            this.MovieEditorControl.UpdateMode = MovieApp.View.Controls.UpdateType.None;
            this.MovieEditorControl.CurrentPropertyChanged += new System.EventHandler(this.MovieEditorControl_CurrentPropertyChanged);
            // 
            // MovieListControl
            // 
            this.MovieListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieListControl.Location = new System.Drawing.Point(3, 16);
            this.MovieListControl.Name = "MovieListControl";
            this.MovieListControl.SelectedMovie = null;
            this.MovieListControl.Size = new System.Drawing.Size(194, 407);
            this.MovieListControl.TabIndex = 1;
            this.MovieListControl.EditButtonClicked += new System.EventHandler(this.MovieListControl_EditButtonClicked);
            this.MovieListControl.ListBoxSelectedIndexChanged += new System.EventHandler(this.MovieListControl_ListBoxSelectedIndexChanged);
            // 
            // MovieListGroupBox
            // 
            this.MovieListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MovieListGroupBox.Controls.Add(this.MovieListControl);
            this.MovieListGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MovieListGroupBox.Name = "MovieListGroupBox";
            this.MovieListGroupBox.Size = new System.Drawing.Size(200, 426);
            this.MovieListGroupBox.TabIndex = 3;
            this.MovieListGroupBox.TabStop = false;
            this.MovieListGroupBox.Text = "Movie list";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.MovieListGroupBox);
            this.Controls.Add(this.MovieEditorGroupBox);
            this.Name = "MainForm";
            this.Text = "MovieApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MovieEditorGroupBox.ResumeLayout(false);
            this.MovieListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MovieEditorControl MovieEditorControl;
        private Controls.MovieListControl MovieListControl;
        private System.Windows.Forms.GroupBox MovieEditorGroupBox;
        private System.Windows.Forms.GroupBox MovieListGroupBox;
    }
}

