namespace ObjectOrientedPractics.View.Tabs
{
    partial class InterfaceTab
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.IComparableTabPage = new System.Windows.Forms.TabPage();
            this.ICloneableTabPage = new System.Windows.Forms.TabPage();
            this.IEquatableTabPage = new System.Windows.Forms.TabPage();
            this.IComparableControl = new ObjectOrientedPractics.View.Controls.InterfaceControls.IComparableControl();
            this.ICloneableControl = new ObjectOrientedPractics.View.Controls.InterfaceControls.ICloneableControl();
            this.IEquatableControl = new ObjectOrientedPractics.View.Controls.InterfaceControls.IEquatableControl();
            this.TabControl.SuspendLayout();
            this.IComparableTabPage.SuspendLayout();
            this.ICloneableTabPage.SuspendLayout();
            this.IEquatableTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.IComparableTabPage);
            this.TabControl.Controls.Add(this.ICloneableTabPage);
            this.TabControl.Controls.Add(this.IEquatableTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(761, 610);
            this.TabControl.TabIndex = 0;
            // 
            // IComparableTabPage
            // 
            this.IComparableTabPage.Controls.Add(this.IComparableControl);
            this.IComparableTabPage.Location = new System.Drawing.Point(4, 22);
            this.IComparableTabPage.Name = "IComparableTabPage";
            this.IComparableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IComparableTabPage.Size = new System.Drawing.Size(753, 584);
            this.IComparableTabPage.TabIndex = 0;
            this.IComparableTabPage.Text = "IComparable";
            this.IComparableTabPage.UseVisualStyleBackColor = true;
            // 
            // ICloneableTabPage
            // 
            this.ICloneableTabPage.Controls.Add(this.ICloneableControl);
            this.ICloneableTabPage.Location = new System.Drawing.Point(4, 22);
            this.ICloneableTabPage.Name = "ICloneableTabPage";
            this.ICloneableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ICloneableTabPage.Size = new System.Drawing.Size(753, 584);
            this.ICloneableTabPage.TabIndex = 1;
            this.ICloneableTabPage.Text = "ICloneable";
            this.ICloneableTabPage.UseVisualStyleBackColor = true;
            // 
            // IEquatableTabPage
            // 
            this.IEquatableTabPage.Controls.Add(this.IEquatableControl);
            this.IEquatableTabPage.Location = new System.Drawing.Point(4, 22);
            this.IEquatableTabPage.Name = "IEquatableTabPage";
            this.IEquatableTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.IEquatableTabPage.Size = new System.Drawing.Size(753, 584);
            this.IEquatableTabPage.TabIndex = 2;
            this.IEquatableTabPage.Text = "IEquatable";
            this.IEquatableTabPage.UseVisualStyleBackColor = true;
            // 
            // IComparableControl
            // 
            this.IComparableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IComparableControl.Location = new System.Drawing.Point(3, 3);
            this.IComparableControl.Name = "IComparableControl";
            this.IComparableControl.Size = new System.Drawing.Size(747, 578);
            this.IComparableControl.TabIndex = 0;
            // 
            // ICloneableControl
            // 
            this.ICloneableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ICloneableControl.Location = new System.Drawing.Point(3, 3);
            this.ICloneableControl.Name = "ICloneableControl";
            this.ICloneableControl.Size = new System.Drawing.Size(747, 578);
            this.ICloneableControl.TabIndex = 0;
            // 
            // IEquatableControl
            // 
            this.IEquatableControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IEquatableControl.Location = new System.Drawing.Point(3, 3);
            this.IEquatableControl.Name = "IEquatableControl";
            this.IEquatableControl.Size = new System.Drawing.Size(747, 578);
            this.IEquatableControl.TabIndex = 0;
            // 
            // InterfaceTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TabControl);
            this.Name = "InterfaceTab";
            this.Size = new System.Drawing.Size(761, 610);
            this.TabControl.ResumeLayout(false);
            this.IComparableTabPage.ResumeLayout(false);
            this.ICloneableTabPage.ResumeLayout(false);
            this.IEquatableTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage IComparableTabPage;
        private System.Windows.Forms.TabPage ICloneableTabPage;
        private System.Windows.Forms.TabPage IEquatableTabPage;
        private Controls.InterfaceControls.IComparableControl IComparableControl;
        private Controls.InterfaceControls.ICloneableControl ICloneableControl;
        private Controls.InterfaceControls.IEquatableControl IEquatableControl;
    }
}
