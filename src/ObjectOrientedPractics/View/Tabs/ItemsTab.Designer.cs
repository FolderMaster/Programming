namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.ItemGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemEditorControl = new ObjectOrientedPractics.View.Controls.ItemControls.ItemEditorControl();
            this.ItemListGroupBox.SuspendLayout();
            this.ItemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemListGroupBox
            // 
            this.ItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemListGroupBox.Controls.Add(this.ItemListControl);
            this.ItemListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ItemListGroupBox.Name = "ItemListGroupBox";
            this.ItemListGroupBox.Size = new System.Drawing.Size(324, 500);
            this.ItemListGroupBox.TabIndex = 0;
            this.ItemListGroupBox.TabStop = false;
            this.ItemListGroupBox.Text = "Item list";
            // 
            // ItemListControl
            // 
            this.ItemListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListControl.IsAdding = true;
            this.ItemListControl.IsEditor = true;
            this.ItemListControl.IsRemoving = true;
            this.ItemListControl.Location = new System.Drawing.Point(3, 16);
            this.ItemListControl.Name = "ItemListControl";
            this.ItemListControl.SelectedIndex = 0;
            this.ItemListControl.Size = new System.Drawing.Size(318, 481);
            this.ItemListControl.TabIndex = 1;
            this.ItemListControl.ListBoxSelectedIndexChanged += new System.EventHandler(this.ItemListControl_ListBoxSelectedIndexChanged);
            this.ItemListControl.RemoveFromItems += new System.EventHandler(this.ItemListControl_RemoveButtonClick);
            this.ItemListControl.AddToItems += new System.EventHandler(this.ItemListControl_AddButtonClick);
            // 
            // ItemGroupBox
            // 
            this.ItemGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemGroupBox.Controls.Add(this.ItemEditorControl);
            this.ItemGroupBox.Location = new System.Drawing.Point(330, 0);
            this.ItemGroupBox.Name = "ItemGroupBox";
            this.ItemGroupBox.Size = new System.Drawing.Size(470, 500);
            this.ItemGroupBox.TabIndex = 2;
            this.ItemGroupBox.TabStop = false;
            this.ItemGroupBox.Text = "Item";
            // 
            // ItemEditorControl
            // 
            this.ItemEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemEditorControl.Item = null;
            this.ItemEditorControl.Location = new System.Drawing.Point(3, 16);
            this.ItemEditorControl.Name = "ItemEditorControl";
            this.ItemEditorControl.Size = new System.Drawing.Size(464, 481);
            this.ItemEditorControl.TabIndex = 3;
            this.ItemEditorControl.UpdateMode = ObjectOrientedPractics.View.Controls.Enums.UpdateType.None;
            this.ItemEditorControl.CurrentPropertyChanged += new System.EventHandler(this.ItemEditorControl_CurrentPropertyChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemGroupBox);
            this.Controls.Add(this.ItemListGroupBox);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(800, 500);
            this.ItemListGroupBox.ResumeLayout(false);
            this.ItemGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ItemControls.ItemEditorControl ItemEditorControl;
        private Controls.ItemControls.ItemListControl ItemListControl;
        private System.Windows.Forms.GroupBox ItemListGroupBox;
        private System.Windows.Forms.GroupBox ItemGroupBox;
    }
}
