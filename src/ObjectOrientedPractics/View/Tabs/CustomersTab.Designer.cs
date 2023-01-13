namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.CustomerListGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerEditorControl = new ObjectOrientedPractics.View.Controls.CustomerControls.CustomerEditorControl();
            this.CustomerListControl = new ObjectOrientedPractics.View.Controls.CustomerControls.CustomerListControl();
            this.GenerateOrderButton = new System.Windows.Forms.Button();
            this.CustomerListGroupBox.SuspendLayout();
            this.CustomerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomerListGroupBox
            // 
            this.CustomerListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomerListGroupBox.Controls.Add(this.CustomerListControl);
            this.CustomerListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.CustomerListGroupBox.Name = "CustomerListGroupBox";
            this.CustomerListGroupBox.Size = new System.Drawing.Size(324, 500);
            this.CustomerListGroupBox.TabIndex = 0;
            this.CustomerListGroupBox.TabStop = false;
            this.CustomerListGroupBox.Text = "Customer list";
            // 
            // CustomerGroupBox
            // 
            this.CustomerGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerGroupBox.Controls.Add(this.CustomerEditorControl);
            this.CustomerGroupBox.Location = new System.Drawing.Point(330, 0);
            this.CustomerGroupBox.Name = "CustomerGroupBox";
            this.CustomerGroupBox.Size = new System.Drawing.Size(470, 471);
            this.CustomerGroupBox.TabIndex = 2;
            this.CustomerGroupBox.TabStop = false;
            this.CustomerGroupBox.Text = "Customer";
            // 
            // CustomerEditorControl
            // 
            this.CustomerEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerEditorControl.Location = new System.Drawing.Point(3, 16);
            this.CustomerEditorControl.Name = "CustomerEditorControl";
            this.CustomerEditorControl.Size = new System.Drawing.Size(464, 452);
            this.CustomerEditorControl.TabIndex = 3;
            this.CustomerEditorControl.CurrentPropertyChanged += new System.EventHandler(this.CustomerEditorControl_CurrentPropertyChanged);
            // 
            // CustomerListControl
            // 
            this.CustomerListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerListControl.Location = new System.Drawing.Point(3, 16);
            this.CustomerListControl.Name = "CustomerListControl";
            this.CustomerListControl.Size = new System.Drawing.Size(318, 481);
            this.CustomerListControl.TabIndex = 1;
            this.CustomerListControl.SelectedCustomerChanged += new System.EventHandler(this.CustomerListControl_ListBoxSelectedIndexChanged);
            this.CustomerListControl.RemoveFromCustomers += new System.EventHandler(this.CustomerListControl_RemoveButtonClick);
            this.CustomerListControl.AddToCustomers += new System.EventHandler(this.CustomerListControl_AddButtonClick);
            // 
            // GenerateOrderButton
            // 
            this.GenerateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateOrderButton.Location = new System.Drawing.Point(712, 477);
            this.GenerateOrderButton.Name = "GenerateOrderButton";
            this.GenerateOrderButton.Size = new System.Drawing.Size(88, 23);
            this.GenerateOrderButton.TabIndex = 3;
            this.GenerateOrderButton.Text = "Generate order";
            this.GenerateOrderButton.UseVisualStyleBackColor = true;
            this.GenerateOrderButton.Click += new System.EventHandler(this.GenerateOrderButton_Click);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GenerateOrderButton);
            this.Controls.Add(this.CustomerGroupBox);
            this.Controls.Add(this.CustomerListGroupBox);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(800, 500);
            this.CustomerListGroupBox.ResumeLayout(false);
            this.CustomerGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CustomerListGroupBox;
        private System.Windows.Forms.GroupBox CustomerGroupBox;
        private Controls.CustomerControls.CustomerEditorControl CustomerEditorControl;
        private Controls.CustomerControls.CustomerListControl CustomerListControl;
        private System.Windows.Forms.Button GenerateOrderButton;
    }
}
