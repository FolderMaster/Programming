namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddDiscountTab = new ObjectOrientedPractics.View.Tabs.AddDiscountTab();
            this.SuspendLayout();
            // 
            // AddDiscountTab
            // 
            this.AddDiscountTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddDiscountTab.Location = new System.Drawing.Point(3, 3);
            this.AddDiscountTab.Name = "AddDiscountTab";
            this.AddDiscountTab.Size = new System.Drawing.Size(158, 72);
            this.AddDiscountTab.TabIndex = 0;
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(164, 78);
            this.Controls.Add(this.AddDiscountTab);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddDiscountForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Add discount";
            this.ResumeLayout(false);

        }

        #endregion

        private Tabs.AddDiscountTab AddDiscountTab;
    }
}