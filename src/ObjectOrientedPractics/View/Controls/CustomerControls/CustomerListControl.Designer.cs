namespace ObjectOrientedPractics.View.Controls.CustomerControls
{
    partial class CustomerListControl
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
            this.ListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddEmptyButton = new System.Windows.Forms.Button();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.OrderByComboBox = new System.Windows.Forms.ComboBox();
            this.OrderByLabel = new System.Windows.Forms.Label();
            this.PriorityCustomersCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // ListBox
            // 
            this.ListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.IntegralHeight = false;
            this.ListBox.Location = new System.Drawing.Point(0, 76);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(401, 295);
            this.ListBox.TabIndex = 0;
            this.ListBox.SelectedIndexChanged += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(0, 377);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(326, 377);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddEmptyButton
            // 
            this.AddEmptyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddEmptyButton.Location = new System.Drawing.Point(81, 377);
            this.AddEmptyButton.Name = "AddEmptyButton";
            this.AddEmptyButton.Size = new System.Drawing.Size(75, 23);
            this.AddEmptyButton.TabIndex = 3;
            this.AddEmptyButton.Text = "Add empty";
            this.AddEmptyButton.UseVisualStyleBackColor = true;
            this.AddEmptyButton.Click += new System.EventHandler(this.AddEmptyButton_Click);
            // 
            // FindTextBox
            // 
            this.FindTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FindTextBox.Location = new System.Drawing.Point(33, 0);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(368, 20);
            this.FindTextBox.TabIndex = 5;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(-3, 3);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(30, 13);
            this.FindLabel.TabIndex = 4;
            this.FindLabel.Text = "Find:";
            // 
            // OrderByComboBox
            // 
            this.OrderByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderByComboBox.FormattingEnabled = true;
            this.OrderByComboBox.Location = new System.Drawing.Point(53, 49);
            this.OrderByComboBox.Name = "OrderByComboBox";
            this.OrderByComboBox.Size = new System.Drawing.Size(348, 21);
            this.OrderByComboBox.TabIndex = 7;
            this.OrderByComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderByComboBox_SelectedIndexChanged);
            // 
            // OrderByLabel
            // 
            this.OrderByLabel.AutoSize = true;
            this.OrderByLabel.Location = new System.Drawing.Point(-3, 52);
            this.OrderByLabel.Name = "OrderByLabel";
            this.OrderByLabel.Size = new System.Drawing.Size(50, 13);
            this.OrderByLabel.TabIndex = 6;
            this.OrderByLabel.Text = "Order by:";
            // 
            // PriorityCustomersCheckBox
            // 
            this.PriorityCustomersCheckBox.AutoSize = true;
            this.PriorityCustomersCheckBox.Location = new System.Drawing.Point(0, 26);
            this.PriorityCustomersCheckBox.Name = "PriorityCustomersCheckBox";
            this.PriorityCustomersCheckBox.Size = new System.Drawing.Size(108, 17);
            this.PriorityCustomersCheckBox.TabIndex = 8;
            this.PriorityCustomersCheckBox.Text = "Priority customers";
            this.PriorityCustomersCheckBox.UseVisualStyleBackColor = true;
            this.PriorityCustomersCheckBox.CheckedChanged += new System.EventHandler(this.PriorityCustomersCheckBox_CheckedChanged);
            // 
            // CustomerListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriorityCustomersCheckBox);
            this.Controls.Add(this.OrderByComboBox);
            this.Controls.Add(this.OrderByLabel);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.AddEmptyButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ListBox);
            this.Name = "CustomerListControl";
            this.Size = new System.Drawing.Size(401, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddEmptyButton;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.ComboBox OrderByComboBox;
        private System.Windows.Forms.Label OrderByLabel;
        private System.Windows.Forms.CheckBox PriorityCustomersCheckBox;
    }
}
