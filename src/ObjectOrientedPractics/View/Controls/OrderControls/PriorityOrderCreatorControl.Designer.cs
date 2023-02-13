namespace ObjectOrientedPractics.View.Controls.OrderControls
{
    partial class PriorityOrderCreatorControl
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
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.AdressGroupBox = new System.Windows.Forms.GroupBox();
            this.AdressEditorControl = new ObjectOrientedPractics.View.Controls.AdressEditorControl();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.DesiredDeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DesiredDeliveryTimeLabel = new System.Windows.Forms.Label();
            this.DesiredDeliveryDateTextBox = new System.Windows.Forms.TextBox();
            this.DesiredDeliveryDateLabel = new System.Windows.Forms.Label();
            this.ItemListGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemListControl = new ObjectOrientedPractics.View.Controls.ItemControls.ItemListControl();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.CreatedDateTimeTextBox = new System.Windows.Forms.TextBox();
            this.CreatedDateTimeLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.AdressGroupBox.SuspendLayout();
            this.ItemListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(43, 52);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(481, 21);
            this.StatusComboBox.TabIndex = 15;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // AdressGroupBox
            // 
            this.AdressGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdressGroupBox.Controls.Add(this.AdressEditorControl);
            this.AdressGroupBox.Location = new System.Drawing.Point(0, 146);
            this.AdressGroupBox.Name = "AdressGroupBox";
            this.AdressGroupBox.Size = new System.Drawing.Size(524, 169);
            this.AdressGroupBox.TabIndex = 16;
            this.AdressGroupBox.TabStop = false;
            this.AdressGroupBox.Text = "Adress";
            // 
            // AdressEditorControl
            // 
            this.AdressEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdressEditorControl.Location = new System.Drawing.Point(3, 16);
            this.AdressEditorControl.Name = "AdressEditorControl";
            this.AdressEditorControl.Size = new System.Drawing.Size(518, 150);
            this.AdressEditorControl.TabIndex = 0;
            this.AdressEditorControl.CurrentPropertyChanged += new System.EventHandler(this.AdressEditorControl_CurrentPropertyChanged);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(-3, 55);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 14;
            this.StatusLabel.Text = "Status:";
            // 
            // DesiredDeliveryTimeComboBox
            // 
            this.DesiredDeliveryTimeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesiredDeliveryTimeComboBox.FormattingEnabled = true;
            this.DesiredDeliveryTimeComboBox.Location = new System.Drawing.Point(110, 119);
            this.DesiredDeliveryTimeComboBox.Name = "DesiredDeliveryTimeComboBox";
            this.DesiredDeliveryTimeComboBox.Size = new System.Drawing.Size(414, 21);
            this.DesiredDeliveryTimeComboBox.TabIndex = 18;
            this.DesiredDeliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DesiredDeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // DesiredDeliveryTimeLabel
            // 
            this.DesiredDeliveryTimeLabel.AutoSize = true;
            this.DesiredDeliveryTimeLabel.Location = new System.Drawing.Point(-3, 122);
            this.DesiredDeliveryTimeLabel.Name = "DesiredDeliveryTimeLabel";
            this.DesiredDeliveryTimeLabel.Size = new System.Drawing.Size(107, 13);
            this.DesiredDeliveryTimeLabel.TabIndex = 17;
            this.DesiredDeliveryTimeLabel.Text = "Desired delivery time:";
            // 
            // DesiredDeliveryDateTextBox
            // 
            this.DesiredDeliveryDateTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesiredDeliveryDateTextBox.Location = new System.Drawing.Point(112, 93);
            this.DesiredDeliveryDateTextBox.Name = "DesiredDeliveryDateTextBox";
            this.DesiredDeliveryDateTextBox.Size = new System.Drawing.Size(412, 20);
            this.DesiredDeliveryDateTextBox.TabIndex = 20;
            this.DesiredDeliveryDateTextBox.TextChanged += new System.EventHandler(this.DesiredDeliveryDateTextBox_TextChanged);
            // 
            // DesiredDeliveryDateLabel
            // 
            this.DesiredDeliveryDateLabel.AutoSize = true;
            this.DesiredDeliveryDateLabel.Location = new System.Drawing.Point(-3, 96);
            this.DesiredDeliveryDateLabel.Name = "DesiredDeliveryDateLabel";
            this.DesiredDeliveryDateLabel.Size = new System.Drawing.Size(109, 13);
            this.DesiredDeliveryDateLabel.TabIndex = 19;
            this.DesiredDeliveryDateLabel.Text = "Desired delivery date:";
            // 
            // ItemListGroupBox
            // 
            this.ItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemListGroupBox.Controls.Add(this.ItemListControl);
            this.ItemListGroupBox.Location = new System.Drawing.Point(0, 321);
            this.ItemListGroupBox.Name = "ItemListGroupBox";
            this.ItemListGroupBox.Size = new System.Drawing.Size(524, 115);
            this.ItemListGroupBox.TabIndex = 21;
            this.ItemListGroupBox.TabStop = false;
            this.ItemListGroupBox.Text = "Item list";
            // 
            // ItemListControl
            // 
            this.ItemListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListControl.IsAdding = false;
            this.ItemListControl.IsEditor = true;
            this.ItemListControl.IsRemoving = true;
            this.ItemListControl.IsSampling = false;
            this.ItemListControl.Location = new System.Drawing.Point(3, 16);
            this.ItemListControl.Name = "ItemListControl";
            this.ItemListControl.SelectedItem = null;
            this.ItemListControl.Size = new System.Drawing.Size(518, 96);
            this.ItemListControl.TabIndex = 0;
            this.ItemListControl.RemoveFromItems += new System.EventHandler(this.ItemListControl_RemoveFromItems);
            this.ItemListControl.AddToItems += new System.EventHandler(this.ItemListControl_AddToItems);
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearOrderButton.Location = new System.Drawing.Point(449, 442);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(75, 23);
            this.ClearOrderButton.TabIndex = 22;
            this.ClearOrderButton.Text = "Clear order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(-3, 447);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(49, 13);
            this.AmountLabel.TabIndex = 23;
            this.AmountLabel.Text = "Amount: ";
            // 
            // CreatedDateTimeTextBox
            // 
            this.CreatedDateTimeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedDateTimeTextBox.Location = new System.Drawing.Point(96, 26);
            this.CreatedDateTimeTextBox.Name = "CreatedDateTimeTextBox";
            this.CreatedDateTimeTextBox.ReadOnly = true;
            this.CreatedDateTimeTextBox.Size = new System.Drawing.Size(428, 20);
            this.CreatedDateTimeTextBox.TabIndex = 27;
            // 
            // CreatedDateTimeLabel
            // 
            this.CreatedDateTimeLabel.AutoSize = true;
            this.CreatedDateTimeLabel.Location = new System.Drawing.Point(-3, 29);
            this.CreatedDateTimeLabel.Name = "CreatedDateTimeLabel";
            this.CreatedDateTimeLabel.Size = new System.Drawing.Size(93, 13);
            this.CreatedDateTimeLabel.TabIndex = 26;
            this.CreatedDateTimeLabel.Text = "Created date time:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(22, 0);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(502, 20);
            this.IdTextBox.TabIndex = 25;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(-3, 3);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 24;
            this.IdLabel.Text = "Id:";
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(-3, 76);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(78, 13);
            this.PriorityOptionsLabel.TabIndex = 28;
            this.PriorityOptionsLabel.Text = "Priority options:";
            // 
            // PriorityOrderCreatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriorityOptionsLabel);
            this.Controls.Add(this.CreatedDateTimeTextBox);
            this.Controls.Add(this.CreatedDateTimeLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ClearOrderButton);
            this.Controls.Add(this.ItemListGroupBox);
            this.Controls.Add(this.DesiredDeliveryDateTextBox);
            this.Controls.Add(this.DesiredDeliveryDateLabel);
            this.Controls.Add(this.DesiredDeliveryTimeComboBox);
            this.Controls.Add(this.DesiredDeliveryTimeLabel);
            this.Controls.Add(this.AdressGroupBox);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.StatusLabel);
            this.Name = "PriorityOrderCreatorControl";
            this.Size = new System.Drawing.Size(524, 465);
            this.AdressGroupBox.ResumeLayout(false);
            this.ItemListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.GroupBox AdressGroupBox;
        private AdressEditorControl AdressEditorControl;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox DesiredDeliveryTimeComboBox;
        private System.Windows.Forms.Label DesiredDeliveryTimeLabel;
        private System.Windows.Forms.TextBox DesiredDeliveryDateTextBox;
        private System.Windows.Forms.Label DesiredDeliveryDateLabel;
        private System.Windows.Forms.GroupBox ItemListGroupBox;
        private ItemControls.ItemListControl ItemListControl;
        private System.Windows.Forms.Button ClearOrderButton;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.TextBox CreatedDateTimeTextBox;
        private System.Windows.Forms.Label CreatedDateTimeLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label PriorityOptionsLabel;
    }
}
