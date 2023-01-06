namespace ObjectOrientedPractics.View.Controls.InterfaceControls
{
    partial class IComparableControl
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
            this.SortedItemListGroupBox = new System.Windows.Forms.GroupBox();
            this.SortedItemListControl = new ObjectOrientedPractics.View.Controls.ItemControls.ItemListControl();
            this.ItemListGroupBox.SuspendLayout();
            this.SortedItemListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListGroupBox
            // 
            this.ItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemListGroupBox.Controls.Add(this.ItemListControl);
            this.ItemListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ItemListGroupBox.Name = "ItemListGroupBox";
            this.ItemListGroupBox.Size = new System.Drawing.Size(324, 440);
            this.ItemListGroupBox.TabIndex = 1;
            this.ItemListGroupBox.TabStop = false;
            this.ItemListGroupBox.Text = "Item list";
            // 
            // ItemListControl
            // 
            this.ItemListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListControl.IsAdding = false;
            this.ItemListControl.IsEditor = false;
            this.ItemListControl.IsRemoving = false;
            this.ItemListControl.Location = new System.Drawing.Point(3, 16);
            this.ItemListControl.Name = "ItemListControl";
            this.ItemListControl.Size = new System.Drawing.Size(318, 421);
            this.ItemListControl.TabIndex = 0;
            // 
            // SortedItemListGroupBox
            // 
            this.SortedItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SortedItemListGroupBox.Controls.Add(this.SortedItemListControl);
            this.SortedItemListGroupBox.Location = new System.Drawing.Point(330, 0);
            this.SortedItemListGroupBox.Name = "SortedItemListGroupBox";
            this.SortedItemListGroupBox.Size = new System.Drawing.Size(427, 440);
            this.SortedItemListGroupBox.TabIndex = 2;
            this.SortedItemListGroupBox.TabStop = false;
            this.SortedItemListGroupBox.Text = "Sorted item list";
            // 
            // SortedItemListControl
            // 
            this.SortedItemListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SortedItemListControl.IsAdding = false;
            this.SortedItemListControl.IsEditor = false;
            this.SortedItemListControl.IsRemoving = false;
            this.SortedItemListControl.Location = new System.Drawing.Point(3, 16);
            this.SortedItemListControl.Name = "SortedItemListControl";
            this.SortedItemListControl.Size = new System.Drawing.Size(421, 421);
            this.SortedItemListControl.TabIndex = 0;
            // 
            // IComparableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SortedItemListGroupBox);
            this.Controls.Add(this.ItemListGroupBox);
            this.Name = "IComparableControl";
            this.Size = new System.Drawing.Size(757, 440);
            this.ItemListGroupBox.ResumeLayout(false);
            this.SortedItemListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemListGroupBox;
        private ItemControls.ItemListControl ItemListControl;
        private System.Windows.Forms.GroupBox SortedItemListGroupBox;
        private ItemControls.ItemListControl SortedItemListControl;
    }
}
