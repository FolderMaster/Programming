namespace ObjectOrientedPractics.View.Controls.InterfaceControls
{
    partial class ICloneableControl
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
            this.ItemCloneListGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemCloneListControl = new ObjectOrientedPractics.View.Controls.ItemControls.ItemListControl();
            this.CloneButton = new System.Windows.Forms.Button();
            this.ItemListGroupBox.SuspendLayout();
            this.ItemCloneListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListGroupBox
            // 
            this.ItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemListGroupBox.Controls.Add(this.ItemListControl);
            this.ItemListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ItemListGroupBox.Name = "ItemListGroupBox";
            this.ItemListGroupBox.Size = new System.Drawing.Size(324, 482);
            this.ItemListGroupBox.TabIndex = 2;
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
            this.ItemListControl.Size = new System.Drawing.Size(318, 463);
            this.ItemListControl.TabIndex = 0;
            // 
            // ItemCloneListGroupBox
            // 
            this.ItemCloneListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemCloneListGroupBox.Controls.Add(this.ItemCloneListControl);
            this.ItemCloneListGroupBox.Location = new System.Drawing.Point(330, 0);
            this.ItemCloneListGroupBox.Name = "ItemCloneListGroupBox";
            this.ItemCloneListGroupBox.Size = new System.Drawing.Size(307, 482);
            this.ItemCloneListGroupBox.TabIndex = 3;
            this.ItemCloneListGroupBox.TabStop = false;
            this.ItemCloneListGroupBox.Text = "Item clone list";
            // 
            // ItemCloneListControl
            // 
            this.ItemCloneListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemCloneListControl.IsAdding = false;
            this.ItemCloneListControl.IsEditor = false;
            this.ItemCloneListControl.IsRemoving = false;
            this.ItemCloneListControl.Location = new System.Drawing.Point(3, 16);
            this.ItemCloneListControl.Name = "ItemCloneListControl";
            this.ItemCloneListControl.Size = new System.Drawing.Size(301, 463);
            this.ItemCloneListControl.TabIndex = 0;
            // 
            // CloneButton
            // 
            this.CloneButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloneButton.Location = new System.Drawing.Point(0, 488);
            this.CloneButton.Name = "CloneButton";
            this.CloneButton.Size = new System.Drawing.Size(75, 23);
            this.CloneButton.TabIndex = 4;
            this.CloneButton.Text = "Clone";
            this.CloneButton.UseVisualStyleBackColor = true;
            this.CloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // ICloneableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloneButton);
            this.Controls.Add(this.ItemCloneListGroupBox);
            this.Controls.Add(this.ItemListGroupBox);
            this.Name = "ICloneableControl";
            this.Size = new System.Drawing.Size(637, 511);
            this.ItemListGroupBox.ResumeLayout(false);
            this.ItemCloneListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemListGroupBox;
        private ItemControls.ItemListControl ItemListControl;
        private System.Windows.Forms.GroupBox ItemCloneListGroupBox;
        private ItemControls.ItemListControl ItemCloneListControl;
        private System.Windows.Forms.Button CloneButton;
    }
}
