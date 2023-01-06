namespace ObjectOrientedPractics.View.Controls.InterfaceControls
{
    partial class IEquatableControl
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
            this.ItemListGroupBox1 = new System.Windows.Forms.GroupBox();
            this.ItemListGroupBox2 = new System.Windows.Forms.GroupBox();
            this.SignLabel = new System.Windows.Forms.Label();
            this.ItemListControl2 = new ObjectOrientedPractics.View.Controls.ItemControls.ItemListControl();
            this.ItemListControl1 = new ObjectOrientedPractics.View.Controls.ItemControls.ItemListControl();
            this.ItemListGroupBox1.SuspendLayout();
            this.ItemListGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListGroupBox1
            // 
            this.ItemListGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemListGroupBox1.Controls.Add(this.ItemListControl1);
            this.ItemListGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.ItemListGroupBox1.Name = "ItemListGroupBox1";
            this.ItemListGroupBox1.Size = new System.Drawing.Size(324, 606);
            this.ItemListGroupBox1.TabIndex = 2;
            this.ItemListGroupBox1.TabStop = false;
            this.ItemListGroupBox1.Text = "Item list";
            // 
            // ItemListGroupBox2
            // 
            this.ItemListGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemListGroupBox2.Controls.Add(this.ItemListControl2);
            this.ItemListGroupBox2.Location = new System.Drawing.Point(365, 0);
            this.ItemListGroupBox2.Name = "ItemListGroupBox2";
            this.ItemListGroupBox2.Size = new System.Drawing.Size(435, 606);
            this.ItemListGroupBox2.TabIndex = 3;
            this.ItemListGroupBox2.TabStop = false;
            this.ItemListGroupBox2.Text = "Item list";
            // 
            // SignLabel
            // 
            this.SignLabel.AutoSize = true;
            this.SignLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SignLabel.Location = new System.Drawing.Point(330, 16);
            this.SignLabel.Name = "SignLabel";
            this.SignLabel.Size = new System.Drawing.Size(29, 20);
            this.SignLabel.TabIndex = 4;
            this.SignLabel.Text = "==";
            // 
            // ItemListControl2
            // 
            this.ItemListControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListControl2.IsAdding = false;
            this.ItemListControl2.IsEditor = false;
            this.ItemListControl2.IsRemoving = false;
            this.ItemListControl2.Location = new System.Drawing.Point(3, 16);
            this.ItemListControl2.Name = "ItemListControl2";
            this.ItemListControl2.Size = new System.Drawing.Size(429, 587);
            this.ItemListControl2.TabIndex = 0;
            this.ItemListControl2.ListBoxSelectedIndexChanged += new System.EventHandler(this.ItemListControl2_ListBoxSelectedIndexChanged);
            // 
            // ItemListControl1
            // 
            this.ItemListControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListControl1.IsAdding = false;
            this.ItemListControl1.IsEditor = false;
            this.ItemListControl1.IsRemoving = false;
            this.ItemListControl1.Location = new System.Drawing.Point(3, 16);
            this.ItemListControl1.Name = "ItemListControl1";
            this.ItemListControl1.Size = new System.Drawing.Size(318, 587);
            this.ItemListControl1.TabIndex = 0;
            this.ItemListControl1.ListBoxSelectedIndexChanged += new System.EventHandler(this.ItemListControl1_ListBoxSelectedIndexChanged);
            // 
            // IEquatableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SignLabel);
            this.Controls.Add(this.ItemListGroupBox2);
            this.Controls.Add(this.ItemListGroupBox1);
            this.Name = "IEquatableControl";
            this.Size = new System.Drawing.Size(800, 606);
            this.ItemListGroupBox1.ResumeLayout(false);
            this.ItemListGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ItemListGroupBox1;
        private ItemControls.ItemListControl ItemListControl1;
        private System.Windows.Forms.GroupBox ItemListGroupBox2;
        private ItemControls.ItemListControl ItemListControl2;
        private System.Windows.Forms.Label SignLabel;
    }
}
