namespace ObjectOrientedPractics.View.Controls.DiscountControls
{
    partial class DiscountCheckListControl
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
            this.CheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // CheckedListBox
            // 
            this.CheckedListBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CheckedListBox.CheckOnClick = true;
            this.CheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckedListBox.FormattingEnabled = true;
            this.CheckedListBox.IntegralHeight = false;
            this.CheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.CheckedListBox.Name = "CheckedListBox";
            this.CheckedListBox.Size = new System.Drawing.Size(193, 126);
            this.CheckedListBox.TabIndex = 0;
            this.CheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.CheckedListBox_ItemCheck);
            this.CheckedListBox.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox_SelectedIndexChanged);
            // 
            // DiscountCheckListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CheckedListBox);
            this.Name = "DiscountCheckListControl";
            this.Size = new System.Drawing.Size(193, 126);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox CheckedListBox;
    }
}
