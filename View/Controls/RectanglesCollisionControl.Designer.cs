namespace Programming.View.TabPages
{
    partial class RectanglesCollisionControl
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
            this.Panel = new System.Windows.Forms.Panel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.YTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectanglesLabel = new System.Windows.Forms.Label();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.XLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.XTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel.Location = new System.Drawing.Point(214, 0);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(273, 352);
            this.Panel.TabIndex = 31;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(3, 316);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 30;
            this.HeightLabel.Text = "Height:";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Location = new System.Drawing.Point(6, 332);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightTextBox.TabIndex = 25;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(3, 237);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 29;
            this.YLabel.Text = "Y:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(3, 276);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 28;
            this.WidthLabel.Text = "Width:";
            // 
            // YTextBox
            // 
            this.YTextBox.Location = new System.Drawing.Point(6, 253);
            this.YTextBox.Name = "YTextBox";
            this.YTextBox.Size = new System.Drawing.Size(100, 20);
            this.YTextBox.TabIndex = 22;
            this.YTextBox.TextChanged += new System.EventHandler(this.YTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(6, 292);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 24;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // SelectedRectanglesLabel
            // 
            this.SelectedRectanglesLabel.AutoSize = true;
            this.SelectedRectanglesLabel.Location = new System.Drawing.Point(-3, 146);
            this.SelectedRectanglesLabel.Name = "SelectedRectanglesLabel";
            this.SelectedRectanglesLabel.Size = new System.Drawing.Size(104, 13);
            this.SelectedRectanglesLabel.TabIndex = 27;
            this.SelectedRectanglesLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(-3, 0);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabel.TabIndex = 26;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(0, 16);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(207, 95);
            this.ListBox.TabIndex = 16;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(3, 198);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 23;
            this.XLabel.Text = "X:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 159);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 20;
            this.IdLabel.Text = "Id:";
            // 
            // XTextBox
            // 
            this.XTextBox.Location = new System.Drawing.Point(6, 214);
            this.XTextBox.Name = "XTextBox";
            this.XTextBox.Size = new System.Drawing.Size(100, 20);
            this.XTextBox.TabIndex = 21;
            this.XTextBox.TextChanged += new System.EventHandler(this.XTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(6, 175);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 19;
            // 
            // RemoveButton
            // 
            this.RemoveButton.FlatAppearance.BorderSize = 0;
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveButton.Location = new System.Drawing.Point(107, 117);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(100, 26);
            this.RemoveButton.TabIndex = 18;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            this.RemoveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RemoveButton_MouseDown);
            this.RemoveButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            this.RemoveButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RemoveButton_MouseUp);
            // 
            // AddButton
            // 
            this.AddButton.FlatAppearance.BorderSize = 0;
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddButton.Location = new System.Drawing.Point(0, 117);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 26);
            this.AddButton.TabIndex = 17;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            this.AddButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseDown);
            this.AddButton.MouseEnter += new System.EventHandler(this.AddButton_MouseEnter);
            this.AddButton.MouseLeave += new System.EventHandler(this.AddButton_MouseLeave);
            this.AddButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AddButton_MouseUp);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel);
            this.Controls.Add(this.HeightLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.YLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.YTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.SelectedRectanglesLabel);
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.XTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(486, 352);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox YTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label SelectedRectanglesLabel;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox XTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
    }
}
