namespace ObjectOrientedPractics.View.Controls
{
    partial class OrderEditorControl
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
            this.AdressGroupBox = new System.Windows.Forms.GroupBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.ItemListGroupBox = new System.Windows.Forms.GroupBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CreatedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.CreatedDateTimeLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.ItemListControl = new ObjectOrientedPractics.View.Controls.ItemListControl();
            this.AdressEditorControl = new ObjectOrientedPractics.View.Controls.AdressEditorControl();
            this.AdressGroupBox.SuspendLayout();
            this.ItemListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdressGroupBox
            // 
            this.AdressGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressGroupBox.Controls.Add(this.AdressEditorControl);
            this.AdressGroupBox.Location = new System.Drawing.Point(0, 79);
            this.AdressGroupBox.Name = "AdressGroupBox";
            this.AdressGroupBox.Size = new System.Drawing.Size(495, 170);
            this.AdressGroupBox.TabIndex = 1;
            this.AdressGroupBox.TabStop = false;
            this.AdressGroupBox.Text = "Adress";
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(-3, 438);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(46, 13);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Amount:";
            // 
            // ItemListGroupBox
            // 
            this.ItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemListGroupBox.Controls.Add(this.ItemListControl);
            this.ItemListGroupBox.Location = new System.Drawing.Point(0, 255);
            this.ItemListGroupBox.Name = "ItemListGroupBox";
            this.ItemListGroupBox.Size = new System.Drawing.Size(495, 180);
            this.ItemListGroupBox.TabIndex = 3;
            this.ItemListGroupBox.TabStop = false;
            this.ItemListGroupBox.Text = "Item list";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(-3, 3);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 4;
            this.IdLabel.Text = "Id:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(22, 0);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(473, 20);
            this.IdTextBox.TabIndex = 5;
            // 
            // CreatedDateTimeTextBox
            // 
            this.CreatedDateTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedDateTimeTextBox.Location = new System.Drawing.Point(96, 26);
            this.CreatedDateTimeTextBox.Name = "CreatedDateTimeTextBox";
            this.CreatedDateTimeTextBox.ReadOnly = true;
            this.CreatedDateTimeTextBox.Size = new System.Drawing.Size(399, 20);
            this.CreatedDateTimeTextBox.TabIndex = 7;
            // 
            // CreatedDateTimeLabel
            // 
            this.CreatedDateTimeLabel.AutoSize = true;
            this.CreatedDateTimeLabel.Location = new System.Drawing.Point(-3, 29);
            this.CreatedDateTimeLabel.Name = "CreatedDateTimeLabel";
            this.CreatedDateTimeLabel.Size = new System.Drawing.Size(93, 13);
            this.CreatedDateTimeLabel.TabIndex = 6;
            this.CreatedDateTimeLabel.Text = "Created date time:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(-3, 55);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 8;
            this.StatusLabel.Text = "Status:";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(43, 52);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(452, 21);
            this.StatusComboBox.TabIndex = 9;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // ItemListControl
            // 
            this.ItemListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListControl.IsAdding = false;
            this.ItemListControl.IsEditor = false;
            this.ItemListControl.IsRemoving = false;
            this.ItemListControl.Location = new System.Drawing.Point(3, 16);
            this.ItemListControl.Name = "ItemListControl";
            this.ItemListControl.SelectedIndex = 0;
            this.ItemListControl.Size = new System.Drawing.Size(489, 161);
            this.ItemListControl.TabIndex = 0;
            // 
            // AdressEditorControl
            // 
            this.AdressEditorControl.Adress = null;
            this.AdressEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdressEditorControl.IsReadOnly = true;
            this.AdressEditorControl.Location = new System.Drawing.Point(3, 16);
            this.AdressEditorControl.Name = "AdressEditorControl";
            this.AdressEditorControl.Size = new System.Drawing.Size(489, 151);
            this.AdressEditorControl.TabIndex = 0;
            // 
            // OrderEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.CreatedDateTimeTextBox);
            this.Controls.Add(this.CreatedDateTimeLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.ItemListGroupBox);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.AdressGroupBox);
            this.Name = "OrderEditorControl";
            this.Size = new System.Drawing.Size(495, 451);
            this.AdressGroupBox.ResumeLayout(false);
            this.ItemListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdressEditorControl AdressEditorControl;
        private System.Windows.Forms.GroupBox AdressGroupBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.GroupBox ItemListGroupBox;
        private ItemListControl ItemListControl;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CreatedDateTimeTextBox;
        private System.Windows.Forms.Label CreatedDateTimeLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
    }
}
