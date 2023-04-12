namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            this.PriorityOrderCreatorControl = new ObjectOrientedPractics.View.Controls.OrderControls.PriorityOrderCreatorControl();
            this.ItemListGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemListControl = new ObjectOrientedPractics.View.Controls.ItemControls.ItemListControl();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.PriorityOrderGroupBox = new System.Windows.Forms.GroupBox();
            this.RandomlyAddToCartButton = new System.Windows.Forms.Button();
            this.ItemListGroupBox.SuspendLayout();
            this.PriorityOrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // PriorityOrderCreatorControl
            // 
            this.PriorityOrderCreatorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PriorityOrderCreatorControl.Location = new System.Drawing.Point(3, 16);
            this.PriorityOrderCreatorControl.Name = "PriorityOrderCreatorControl";
            this.PriorityOrderCreatorControl.Size = new System.Drawing.Size(504, 536);
            this.PriorityOrderCreatorControl.TabIndex = 0;
            // 
            // ItemListGroupBox
            // 
            this.ItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemListGroupBox.Controls.Add(this.ItemListControl);
            this.ItemListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ItemListGroupBox.Name = "ItemListGroupBox";
            this.ItemListGroupBox.Size = new System.Drawing.Size(324, 555);
            this.ItemListGroupBox.TabIndex = 2;
            this.ItemListGroupBox.TabStop = false;
            this.ItemListGroupBox.Text = "Item list";
            // 
            // ItemListControl
            // 
            this.ItemListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListControl.IsAdding = true;
            this.ItemListControl.IsEditor = false;
            this.ItemListControl.IsRemoving = true;
            this.ItemListControl.Location = new System.Drawing.Point(3, 16);
            this.ItemListControl.Name = "ItemListControl";
            this.ItemListControl.Size = new System.Drawing.Size(318, 536);
            this.ItemListControl.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCartButton.Location = new System.Drawing.Point(0, 561);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(75, 23);
            this.AddToCartButton.TabIndex = 3;
            this.AddToCartButton.Text = "Add to cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // PriorityOrderGroupBox
            // 
            this.PriorityOrderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityOrderGroupBox.Controls.Add(this.PriorityOrderCreatorControl);
            this.PriorityOrderGroupBox.Location = new System.Drawing.Point(330, 0);
            this.PriorityOrderGroupBox.Name = "PriorityOrderGroupBox";
            this.PriorityOrderGroupBox.Size = new System.Drawing.Size(510, 555);
            this.PriorityOrderGroupBox.TabIndex = 4;
            this.PriorityOrderGroupBox.TabStop = false;
            this.PriorityOrderGroupBox.Text = "Priority order";
            // 
            // RandomlyAddToCartButton
            // 
            this.RandomlyAddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomlyAddToCartButton.Location = new System.Drawing.Point(208, 561);
            this.RandomlyAddToCartButton.Name = "RandomlyAddToCartButton";
            this.RandomlyAddToCartButton.Size = new System.Drawing.Size(116, 23);
            this.RandomlyAddToCartButton.TabIndex = 5;
            this.RandomlyAddToCartButton.Text = "Randomly add to cart";
            this.RandomlyAddToCartButton.UseVisualStyleBackColor = true;
            this.RandomlyAddToCartButton.Click += new System.EventHandler(this.RandomlyAddToCartButton_Click);
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RandomlyAddToCartButton);
            this.Controls.Add(this.PriorityOrderGroupBox);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.ItemListGroupBox);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(840, 584);
            this.ItemListGroupBox.ResumeLayout(false);
            this.PriorityOrderGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.OrderControls.PriorityOrderCreatorControl PriorityOrderCreatorControl;
        private System.Windows.Forms.GroupBox ItemListGroupBox;
        private Controls.ItemControls.ItemListControl ItemListControl;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.GroupBox PriorityOrderGroupBox;
        private System.Windows.Forms.Button RandomlyAddToCartButton;
    }
}
