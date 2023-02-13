namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.OrderGridGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.OrderEditorControl = new ObjectOrientedPractics.View.Controls.OrderControls.OrderEditorControl();
            this.OrdersViewControl = new ObjectOrientedPractics.View.Controls.OrderControls.OrderGridViewControl();
            this.OrderGridGroupBox.SuspendLayout();
            this.OrderGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrderGridGroupBox
            // 
            this.OrderGridGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderGridGroupBox.Controls.Add(this.OrdersViewControl);
            this.OrderGridGroupBox.Location = new System.Drawing.Point(0, 0);
            this.OrderGridGroupBox.Name = "OrderGridGroupBox";
            this.OrderGridGroupBox.Size = new System.Drawing.Size(324, 611);
            this.OrderGridGroupBox.TabIndex = 0;
            this.OrderGridGroupBox.TabStop = false;
            this.OrderGridGroupBox.Text = "Order grid";
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderGroupBox.Controls.Add(this.OrderEditorControl);
            this.OrderGroupBox.Location = new System.Drawing.Point(330, 0);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(576, 611);
            this.OrderGroupBox.TabIndex = 1;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Order";
            // 
            // OrderEditorControl
            // 
            this.OrderEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderEditorControl.Location = new System.Drawing.Point(3, 16);
            this.OrderEditorControl.Name = "OrderEditorControl";
            this.OrderEditorControl.Size = new System.Drawing.Size(570, 592);
            this.OrderEditorControl.TabIndex = 0;
            this.OrderEditorControl.StatusChanged += new System.EventHandler(this.OrderEditorControl_StatusChanged);
            // 
            // OrdersViewControl
            // 
            this.OrdersViewControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersViewControl.Location = new System.Drawing.Point(3, 16);
            this.OrdersViewControl.Name = "OrdersViewControl";
            this.OrdersViewControl.Size = new System.Drawing.Size(318, 592);
            this.OrdersViewControl.TabIndex = 0;
            this.OrdersViewControl.SelectedOrderChanged += new System.EventHandler(this.OrdersViewControl_SelectedOrderChanged);
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderGroupBox);
            this.Controls.Add(this.OrderGridGroupBox);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(906, 611);
            this.OrderGridGroupBox.ResumeLayout(false);
            this.OrderGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox OrderGridGroupBox;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private Controls.OrderControls.OrderEditorControl OrderEditorControl;
        private Controls.OrderControls.OrderGridViewControl OrdersViewControl;
    }
}
