namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CenterLabel = new System.Windows.Forms.Label();
            this.CenterTextBox = new System.Windows.Forms.TextBox();
            this.Button = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(102, 153);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 28;
            this.IdLabel.Text = "Id:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(104, 169);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 22;
            // 
            // CenterLabel
            // 
            this.CenterLabel.AutoSize = true;
            this.CenterLabel.Location = new System.Drawing.Point(101, 75);
            this.CenterLabel.Name = "CenterLabel";
            this.CenterLabel.Size = new System.Drawing.Size(41, 13);
            this.CenterLabel.TabIndex = 27;
            this.CenterLabel.Text = "Center:";
            // 
            // CenterTextBox
            // 
            this.CenterTextBox.Location = new System.Drawing.Point(104, 91);
            this.CenterTextBox.Name = "CenterTextBox";
            this.CenterTextBox.ReadOnly = true;
            this.CenterTextBox.Size = new System.Drawing.Size(100, 20);
            this.CenterTextBox.TabIndex = 20;
            // 
            // Button
            // 
            this.Button.Location = new System.Drawing.Point(105, 215);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(100, 23);
            this.Button.TabIndex = 23;
            this.Button.Text = "Find";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.ClassesRectanglesButton_Click);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(101, 114);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(34, 13);
            this.ColorLabel.TabIndex = 26;
            this.ColorLabel.Text = "Color:";
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(104, 130);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 21;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ClassesRectanglesColorTextBox_TextChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(101, 36);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 25;
            this.WidthLabel.Text = "Width:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(105, 52);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 19;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.ClassesRectanglesWidthTextBox_TextChanged);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(101, 0);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(43, 13);
            this.LengthLabel.TabIndex = 24;
            this.LengthLabel.Text = "Length:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(105, 13);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 18;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.ClassesRectanglesLengthTextBox_TextChanged);
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.Location = new System.Drawing.Point(0, 0);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(72, 238);
            this.ListBox.TabIndex = 17;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ClassesRectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.CenterLabel);
            this.Controls.Add(this.CenterTextBox);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.ColorLabel);
            this.Controls.Add(this.ColorTextBox);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.LengthTextBox);
            this.Controls.Add(this.ListBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(204, 238);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label CenterLabel;
        private System.Windows.Forms.TextBox CenterTextBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.ListBox ListBox;
    }
}
