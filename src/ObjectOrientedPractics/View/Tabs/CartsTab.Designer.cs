namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.ItemListGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemListControl = new ObjectOrientedPractics.View.Controls.ItemControls.ItemListControl();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.CartGroupBox = new System.Windows.Forms.GroupBox();
            this.CartEditorControl = new ObjectOrientedPractics.View.Controls.CartEditorControl();
            this.CustomerSelectorControl = new ObjectOrientedPractics.View.Controls.CustomerControls.CustomerSelectorControl();
            this.ItemListGroupBox.SuspendLayout();
            this.CartGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListGroupBox
            // 
            this.ItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemListGroupBox.Controls.Add(this.ItemListControl);
            this.ItemListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ItemListGroupBox.Name = "ItemListGroupBox";
            this.ItemListGroupBox.Size = new System.Drawing.Size(324, 550);
            this.ItemListGroupBox.TabIndex = 1;
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
            this.ItemListControl.Size = new System.Drawing.Size(318, 531);
            this.ItemListControl.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCartButton.Location = new System.Drawing.Point(0, 556);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(75, 23);
            this.AddToCartButton.TabIndex = 2;
            this.AddToCartButton.Text = "Add to cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // CartGroupBox
            // 
            this.CartGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartGroupBox.Controls.Add(this.CartEditorControl);
            this.CartGroupBox.Location = new System.Drawing.Point(330, 30);
            this.CartGroupBox.Name = "CartGroupBox";
            this.CartGroupBox.Size = new System.Drawing.Size(404, 520);
            this.CartGroupBox.TabIndex = 3;
            this.CartGroupBox.TabStop = false;
            this.CartGroupBox.Text = "Cart";
            // 
            // CartEditorControl
            // 
            this.CartEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartEditorControl.Location = new System.Drawing.Point(3, 16);
            this.CartEditorControl.Name = "CartEditorControl";
            this.CartEditorControl.Size = new System.Drawing.Size(398, 501);
            this.CartEditorControl.TabIndex = 0;
            this.CartEditorControl.OrderCreated += new System.EventHandler(this.CartEditorControl_OrderCreated);
            // 
            // CustomerSelectorControl
            // 
            this.CustomerSelectorControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomerSelectorControl.Location = new System.Drawing.Point(330, 3);
            this.CustomerSelectorControl.Name = "CustomerSelectorControl";
            this.CustomerSelectorControl.Size = new System.Drawing.Size(401, 21);
            this.CustomerSelectorControl.TabIndex = 0;
            this.CustomerSelectorControl.SelectedCustomerChanged += new System.EventHandler(this.CustomerSelectorControl_SelectedCustomerChanged);
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CartGroupBox);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.ItemListGroupBox);
            this.Controls.Add(this.CustomerSelectorControl);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(734, 579);
            this.ItemListGroupBox.ResumeLayout(false);
            this.CartGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.CustomerControls.CustomerSelectorControl CustomerSelectorControl;
        private System.Windows.Forms.GroupBox ItemListGroupBox;
        private Controls.ItemControls.ItemListControl ItemListControl;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.GroupBox CartGroupBox;
        private Controls.CartEditorControl CartEditorControl;
    }
}
