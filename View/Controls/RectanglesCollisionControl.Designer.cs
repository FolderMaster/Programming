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
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.InfoHeightLabel = new System.Windows.Forms.Label();
            this.InfoHeightTextBox = new System.Windows.Forms.TextBox();
            this.InfoYLabel = new System.Windows.Forms.Label();
            this.InfoWidthLabel = new System.Windows.Forms.Label();
            this.InfoYTextBox = new System.Windows.Forms.TextBox();
            this.InfoWidthTextBox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.ListListBox = new System.Windows.Forms.ListBox();
            this.InfoXLabel = new System.Windows.Forms.Label();
            this.InfoIdLabel = new System.Windows.Forms.Label();
            this.InfoXTextBox = new System.Windows.Forms.TextBox();
            this.InfoIdTextBox = new System.Windows.Forms.TextBox();
            this.ActionsRemoveButton = new System.Windows.Forms.Button();
            this.ActionsAddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(212, 3);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(273, 343);
            this.CanvasPanel.TabIndex = 31;
            // 
            // InfoHeightLabel
            // 
            this.InfoHeightLabel.AutoSize = true;
            this.InfoHeightLabel.Location = new System.Drawing.Point(-3, 315);
            this.InfoHeightLabel.Name = "InfoHeightLabel";
            this.InfoHeightLabel.Size = new System.Drawing.Size(41, 13);
            this.InfoHeightLabel.TabIndex = 30;
            this.InfoHeightLabel.Text = "Height:";
            // 
            // InfoHeightTextBox
            // 
            this.InfoHeightTextBox.Location = new System.Drawing.Point(0, 330);
            this.InfoHeightTextBox.Name = "InfoHeightTextBox";
            this.InfoHeightTextBox.Size = new System.Drawing.Size(100, 20);
            this.InfoHeightTextBox.TabIndex = 25;
            this.InfoHeightTextBox.TextChanged += new System.EventHandler(this.InfoHeightTextBox_TextChanged);
            // 
            // InfoYLabel
            // 
            this.InfoYLabel.AutoSize = true;
            this.InfoYLabel.Location = new System.Drawing.Point(-3, 237);
            this.InfoYLabel.Name = "InfoYLabel";
            this.InfoYLabel.Size = new System.Drawing.Size(17, 13);
            this.InfoYLabel.TabIndex = 29;
            this.InfoYLabel.Text = "Y:";
            // 
            // InfoWidthLabel
            // 
            this.InfoWidthLabel.AutoSize = true;
            this.InfoWidthLabel.Location = new System.Drawing.Point(-3, 276);
            this.InfoWidthLabel.Name = "InfoWidthLabel";
            this.InfoWidthLabel.Size = new System.Drawing.Size(38, 13);
            this.InfoWidthLabel.TabIndex = 28;
            this.InfoWidthLabel.Text = "Width:";
            // 
            // InfoYTextBox
            // 
            this.InfoYTextBox.Location = new System.Drawing.Point(0, 253);
            this.InfoYTextBox.Name = "InfoYTextBox";
            this.InfoYTextBox.Size = new System.Drawing.Size(100, 20);
            this.InfoYTextBox.TabIndex = 22;
            this.InfoYTextBox.TextChanged += new System.EventHandler(this.InfoYTextBox_TextChanged);
            // 
            // InfoWidthTextBox
            // 
            this.InfoWidthTextBox.Location = new System.Drawing.Point(0, 292);
            this.InfoWidthTextBox.Name = "InfoWidthTextBox";
            this.InfoWidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.InfoWidthTextBox.TabIndex = 24;
            this.InfoWidthTextBox.TextChanged += new System.EventHandler(this.InfoWidthTextBox_TextChanged);
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Location = new System.Drawing.Point(-3, 146);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(104, 13);
            this.InfoLabel.TabIndex = 27;
            this.InfoLabel.Text = "Selected Rectangle:";
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(-3, 0);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(64, 13);
            this.ListLabel.TabIndex = 26;
            this.ListLabel.Text = "Rectangles:";
            // 
            // ListListBox
            // 
            this.ListListBox.FormattingEnabled = true;
            this.ListListBox.Location = new System.Drawing.Point(0, 16);
            this.ListListBox.Name = "ListListBox";
            this.ListListBox.Size = new System.Drawing.Size(206, 95);
            this.ListListBox.TabIndex = 16;
            this.ListListBox.SelectedIndexChanged += new System.EventHandler(this.ListListBox_SelectedIndexChanged);
            // 
            // InfoXLabel
            // 
            this.InfoXLabel.AutoSize = true;
            this.InfoXLabel.Location = new System.Drawing.Point(-3, 198);
            this.InfoXLabel.Name = "InfoXLabel";
            this.InfoXLabel.Size = new System.Drawing.Size(17, 13);
            this.InfoXLabel.TabIndex = 23;
            this.InfoXLabel.Text = "X:";
            // 
            // InfoIdLabel
            // 
            this.InfoIdLabel.AutoSize = true;
            this.InfoIdLabel.Location = new System.Drawing.Point(-3, 159);
            this.InfoIdLabel.Name = "InfoIdLabel";
            this.InfoIdLabel.Size = new System.Drawing.Size(19, 13);
            this.InfoIdLabel.TabIndex = 20;
            this.InfoIdLabel.Text = "Id:";
            // 
            // InfoXTextBox
            // 
            this.InfoXTextBox.Location = new System.Drawing.Point(0, 214);
            this.InfoXTextBox.Name = "InfoXTextBox";
            this.InfoXTextBox.Size = new System.Drawing.Size(100, 20);
            this.InfoXTextBox.TabIndex = 21;
            this.InfoXTextBox.TextChanged += new System.EventHandler(this.InfoXTextBox_TextChanged);
            // 
            // InfoIdTextBox
            // 
            this.InfoIdTextBox.Location = new System.Drawing.Point(0, 175);
            this.InfoIdTextBox.Name = "InfoIdTextBox";
            this.InfoIdTextBox.ReadOnly = true;
            this.InfoIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.InfoIdTextBox.TabIndex = 19;
            // 
            // ActionsRemoveButton
            // 
            this.ActionsRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionsRemoveButton.Image = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.ActionsRemoveButton.Location = new System.Drawing.Point(107, 117);
            this.ActionsRemoveButton.Name = "ActionsRemoveButton";
            this.ActionsRemoveButton.Size = new System.Drawing.Size(99, 26);
            this.ActionsRemoveButton.TabIndex = 18;
            this.ActionsRemoveButton.UseVisualStyleBackColor = true;
            this.ActionsRemoveButton.Click += new System.EventHandler(this.ActionsRemoveButton_Click);
            this.ActionsRemoveButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ActionsRemoveButton_MouseDown);
            this.ActionsRemoveButton.MouseEnter += new System.EventHandler(this.ActionsRemoveButton_MouseEnter);
            this.ActionsRemoveButton.MouseLeave += new System.EventHandler(this.ActionsRemoveButton_MouseLeave);
            this.ActionsRemoveButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ActionsRemoveButton_MouseUp);
            // 
            // ActionsAddButton
            // 
            this.ActionsAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ActionsAddButton.Image = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.ActionsAddButton.Location = new System.Drawing.Point(0, 117);
            this.ActionsAddButton.Name = "ActionsAddButton";
            this.ActionsAddButton.Size = new System.Drawing.Size(101, 26);
            this.ActionsAddButton.TabIndex = 17;
            this.ActionsAddButton.UseVisualStyleBackColor = true;
            this.ActionsAddButton.Click += new System.EventHandler(this.ActionsAddButton_Click);
            this.ActionsAddButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ActionsAddButton_MouseDown);
            this.ActionsAddButton.MouseEnter += new System.EventHandler(this.ActionsAddButton_MouseEnter);
            this.ActionsAddButton.MouseLeave += new System.EventHandler(this.ActionsAddButton_MouseLeave);
            this.ActionsAddButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ActionsAddButton_MouseUp);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CanvasPanel);
            this.Controls.Add(this.InfoHeightLabel);
            this.Controls.Add(this.InfoHeightTextBox);
            this.Controls.Add(this.InfoYLabel);
            this.Controls.Add(this.InfoWidthLabel);
            this.Controls.Add(this.InfoYTextBox);
            this.Controls.Add(this.InfoWidthTextBox);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.ListListBox);
            this.Controls.Add(this.InfoXLabel);
            this.Controls.Add(this.InfoIdLabel);
            this.Controls.Add(this.InfoXTextBox);
            this.Controls.Add(this.InfoIdTextBox);
            this.Controls.Add(this.ActionsRemoveButton);
            this.Controls.Add(this.ActionsAddButton);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(486, 350);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.Label InfoHeightLabel;
        private System.Windows.Forms.TextBox InfoHeightTextBox;
        private System.Windows.Forms.Label InfoYLabel;
        private System.Windows.Forms.Label InfoWidthLabel;
        private System.Windows.Forms.TextBox InfoYTextBox;
        private System.Windows.Forms.TextBox InfoWidthTextBox;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.ListBox ListListBox;
        private System.Windows.Forms.Label InfoXLabel;
        private System.Windows.Forms.Label InfoIdLabel;
        private System.Windows.Forms.TextBox InfoXTextBox;
        private System.Windows.Forms.TextBox InfoIdTextBox;
        private System.Windows.Forms.Button ActionsRemoveButton;
        private System.Windows.Forms.Button ActionsAddButton;
    }
}
