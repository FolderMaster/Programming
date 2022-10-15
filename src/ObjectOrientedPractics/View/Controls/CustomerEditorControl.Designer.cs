namespace ObjectOrientedPractics.View.Controls
{
    partial class CustomerEditorControl
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
            this.components = new System.ComponentModel.Container();
            this.IdLabel = new System.Windows.Forms.Label();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AdressGroupBox = new System.Windows.Forms.GroupBox();
            this.AdressEditorControl = new ObjectOrientedPractics.View.Controls.AdressEditorControl();
            this.AdressGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(-3, 3);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "Id:";
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(-3, 29);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(55, 13);
            this.FullNameLabel.TabIndex = 2;
            this.FullNameLabel.Text = "Full name:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(22, 0);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(291, 20);
            this.IdTextBox.TabIndex = 1;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(58, 26);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(255, 20);
            this.FullNameTextBox.TabIndex = 3;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // AdressGroupBox
            // 
            this.AdressGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressGroupBox.Controls.Add(this.AdressEditorControl);
            this.AdressGroupBox.Location = new System.Drawing.Point(0, 52);
            this.AdressGroupBox.Name = "AdressGroupBox";
            this.AdressGroupBox.Size = new System.Drawing.Size(313, 175);
            this.AdressGroupBox.TabIndex = 4;
            this.AdressGroupBox.TabStop = false;
            this.AdressGroupBox.Text = "Adress";
            // 
            // AdressEditorControl
            // 
            this.AdressEditorControl.Adress = null;
            this.AdressEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdressEditorControl.Location = new System.Drawing.Point(3, 16);
            this.AdressEditorControl.Name = "AdressEditorControl";
            this.AdressEditorControl.Size = new System.Drawing.Size(307, 156);
            this.AdressEditorControl.TabIndex = 0;
            this.AdressEditorControl.CurrentPropertyChanged += new System.EventHandler(this.AdressEditorControl_CurrentPropertyChanged);
            // 
            // CustomerEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AdressGroupBox);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.IdLabel);
            this.Name = "CustomerEditorControl";
            this.Size = new System.Drawing.Size(313, 227);
            this.AdressGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.GroupBox AdressGroupBox;
        private AdressEditorControl AdressEditorControl;
    }
}
