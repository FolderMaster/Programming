namespace ObjectOrientedPractics.View.Controls
{
    partial class DiscountsTestControl
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
            this.AmountLabel = new System.Windows.Forms.Label();
            this.PointsDiscountControl = new ObjectOrientedPractics.View.Controls.PointsDiscountControl();
            this.PercentDiscountControl = new ObjectOrientedPractics.View.Controls.PercentDiscountControl();
            this.ItemListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListGroupBox
            // 
            this.ItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemListGroupBox.Controls.Add(this.ItemListControl);
            this.ItemListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ItemListGroupBox.Name = "ItemListGroupBox";
            this.ItemListGroupBox.Size = new System.Drawing.Size(519, 376);
            this.ItemListGroupBox.TabIndex = 5;
            this.ItemListGroupBox.TabStop = false;
            this.ItemListGroupBox.Text = "Item list";
            // 
            // ItemListControl
            // 
            this.ItemListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListControl.IsAdding = false;
            this.ItemListControl.IsEditor = true;
            this.ItemListControl.IsRemoving = true;
            this.ItemListControl.Location = new System.Drawing.Point(3, 16);
            this.ItemListControl.Name = "ItemListControl";
            this.ItemListControl.Size = new System.Drawing.Size(513, 357);
            this.ItemListControl.TabIndex = 0;
            this.ItemListControl.RemoveFromItems += new System.EventHandler(this.ItemListControl_RemoveFromItems);
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(-3, 379);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(49, 13);
            this.AmountLabel.TabIndex = 6;
            this.AmountLabel.Text = "Amount: ";
            // 
            // PointsDiscountControl
            // 
            this.PointsDiscountControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PointsDiscountControl.Discount = 0;
            this.PointsDiscountControl.Location = new System.Drawing.Point(0, 395);
            this.PointsDiscountControl.Name = "PointsDiscountControl";
            this.PointsDiscountControl.Size = new System.Drawing.Size(519, 55);
            this.PointsDiscountControl.TabIndex = 2;
            this.PointsDiscountControl.Applied += new System.EventHandler(this.PointsDiscountControl_Applied);
            // 
            // PercentDiscountControl
            // 
            this.PercentDiscountControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PercentDiscountControl.Discount = 0;
            this.PercentDiscountControl.Location = new System.Drawing.Point(0, 456);
            this.PercentDiscountControl.Name = "PercentDiscountControl";
            this.PercentDiscountControl.Size = new System.Drawing.Size(519, 54);
            this.PercentDiscountControl.TabIndex = 1;
            this.PercentDiscountControl.Applied += new System.EventHandler(this.PercentDiscountControl_Applied);
            // 
            // DiscountsTestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ItemListGroupBox);
            this.Controls.Add(this.PointsDiscountControl);
            this.Controls.Add(this.PercentDiscountControl);
            this.Name = "DiscountsTestControl";
            this.Size = new System.Drawing.Size(519, 510);
            this.ItemListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PercentDiscountControl PercentDiscountControl;
        private PointsDiscountControl PointsDiscountControl;
        private System.Windows.Forms.GroupBox ItemListGroupBox;
        private ItemListControl ItemListControl;
        private System.Windows.Forms.Label AmountLabel;
    }
}
