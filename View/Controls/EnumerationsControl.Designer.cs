namespace Programming.View.Controls
{
    partial class EnumerationsControl
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
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.IntLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.ValueListBox = new System.Windows.Forms.ListBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(0, 16);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(130, 147);
            this.EnumsListBox.TabIndex = 6;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsEnumsListBox_SelectedIndexChanged);
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.Location = new System.Drawing.Point(214, 0);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(58, 13);
            this.IntLabel.TabIndex = 11;
            this.IntLabel.Text = "Value\'s int:";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(-3, 0);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(107, 13);
            this.EnumsLabel.TabIndex = 7;
            this.EnumsLabel.Text = "Choose enumeration:";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(214, 16);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.ReadOnly = true;
            this.IntTextBox.Size = new System.Drawing.Size(55, 20);
            this.IntTextBox.TabIndex = 9;
            // 
            // ValueListBox
            // 
            this.ValueListBox.FormattingEnabled = true;
            this.ValueListBox.Location = new System.Drawing.Point(136, 16);
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Size = new System.Drawing.Size(72, 147);
            this.ValueListBox.TabIndex = 8;
            this.ValueListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsValueListBox_SelectedIndexChanged);
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(133, 0);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ValueLabel.TabIndex = 10;
            this.ValueLabel.Text = "Choose value:";
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumsListBox);
            this.Controls.Add(this.IntLabel);
            this.Controls.Add(this.EnumsLabel);
            this.Controls.Add(this.IntTextBox);
            this.Controls.Add(this.ValueListBox);
            this.Controls.Add(this.ValueLabel);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(269, 162);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label IntLabel;
        private System.Windows.Forms.Label EnumsLabel;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.ListBox ValueListBox;
        private System.Windows.Forms.Label ValueLabel;
    }
}
