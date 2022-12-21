namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountsTab
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
            this.ItemListControl = new ObjectOrientedPractics.View.Controls.ItemListControl();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.DiscountsTestGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscountsTestControl = new ObjectOrientedPractics.View.Controls.DiscountsTestControl();
            this.ItemListGroupBox.SuspendLayout();
            this.DiscountsTestGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListGroupBox
            // 
            this.ItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemListGroupBox.Controls.Add(this.ItemListControl);
            this.ItemListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ItemListGroupBox.Name = "ItemListGroupBox";
            this.ItemListGroupBox.Size = new System.Drawing.Size(324, 461);
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
            this.ItemListControl.Size = new System.Drawing.Size(318, 442);
            this.ItemListControl.TabIndex = 1;
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddToCartButton.Location = new System.Drawing.Point(0, 467);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(75, 23);
            this.AddToCartButton.TabIndex = 3;
            this.AddToCartButton.Text = "Add to cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // DiscountsTestGroupBox
            // 
            this.DiscountsTestGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountsTestGroupBox.Controls.Add(this.DiscountsTestControl);
            this.DiscountsTestGroupBox.Location = new System.Drawing.Point(330, 0);
            this.DiscountsTestGroupBox.Name = "DiscountsTestGroupBox";
            this.DiscountsTestGroupBox.Size = new System.Drawing.Size(388, 490);
            this.DiscountsTestGroupBox.TabIndex = 4;
            this.DiscountsTestGroupBox.TabStop = false;
            this.DiscountsTestGroupBox.Text = "Discounts test";
            // 
            // DiscountsTestControl
            // 
            this.DiscountsTestControl.Amount = 0;
            this.DiscountsTestControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscountsTestControl.Location = new System.Drawing.Point(3, 16);
            this.DiscountsTestControl.Name = "DiscountsTestControl";
            this.DiscountsTestControl.Size = new System.Drawing.Size(382, 471);
            this.DiscountsTestControl.TabIndex = 0;
            // 
            // DiscountsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DiscountsTestGroupBox);
            this.Controls.Add(this.AddToCartButton);
            this.Controls.Add(this.ItemListGroupBox);
            this.Name = "DiscountsTab";
            this.Size = new System.Drawing.Size(718, 490);
            this.ItemListGroupBox.ResumeLayout(false);
            this.DiscountsTestGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemListGroupBox;
        private Controls.ItemListControl ItemListControl;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.GroupBox DiscountsTestGroupBox;
        private Controls.DiscountsTestControl DiscountsTestControl;
    }
}
