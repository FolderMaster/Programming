﻿namespace ObjectOrientedPractics.View.Controls
{
    partial class CartEditorControl
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
            this.TotalLabel = new System.Windows.Forms.Label();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.ItemListGroupBox = new System.Windows.Forms.GroupBox();
            this.ItemListControl = new ObjectOrientedPractics.View.Controls.ItemControls.ItemListControl();
            this.DiscountCheckListGroupBox = new System.Windows.Forms.GroupBox();
            this.DiscountCheckListControl = new ObjectOrientedPractics.View.Controls.DiscountControls.DiscountCheckListControl();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.ItemListGroupBox.SuspendLayout();
            this.DiscountCheckListGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(-3, 422);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(37, 13);
            this.TotalLabel.TabIndex = 2;
            this.TotalLabel.Text = "Total: ";
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateOrderButton.Location = new System.Drawing.Point(253, 417);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(75, 23);
            this.CreateOrderButton.TabIndex = 3;
            this.CreateOrderButton.Text = "Create order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // ItemListGroupBox
            // 
            this.ItemListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemListGroupBox.Controls.Add(this.ItemListControl);
            this.ItemListGroupBox.Location = new System.Drawing.Point(0, 0);
            this.ItemListGroupBox.Name = "ItemListGroupBox";
            this.ItemListGroupBox.Size = new System.Drawing.Size(328, 256);
            this.ItemListGroupBox.TabIndex = 4;
            this.ItemListGroupBox.TabStop = false;
            this.ItemListGroupBox.Text = "Item list";
            // 
            // ItemListControl
            // 
            this.ItemListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemListControl.IsAdding = false;
            this.ItemListControl.IsEditor = true;
            this.ItemListControl.IsRemoving = true;
            this.ItemListControl.IsSampling = false;
            this.ItemListControl.Location = new System.Drawing.Point(3, 16);
            this.ItemListControl.Name = "ItemListControl";
            this.ItemListControl.SelectedItem = null;
            this.ItemListControl.Size = new System.Drawing.Size(322, 237);
            this.ItemListControl.TabIndex = 0;
            this.ItemListControl.RemoveFromItems += new System.EventHandler(this.ItemListControl_RemoveFromItems);
            // 
            // DiscountCheckListGroupBox
            // 
            this.DiscountCheckListGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountCheckListGroupBox.Controls.Add(this.DiscountCheckListControl);
            this.DiscountCheckListGroupBox.Location = new System.Drawing.Point(0, 275);
            this.DiscountCheckListGroupBox.Name = "DiscountCheckListGroupBox";
            this.DiscountCheckListGroupBox.Size = new System.Drawing.Size(328, 123);
            this.DiscountCheckListGroupBox.TabIndex = 5;
            this.DiscountCheckListGroupBox.TabStop = false;
            this.DiscountCheckListGroupBox.Text = "Discount check list";
            // 
            // DiscountCheckListControl
            // 
            this.DiscountCheckListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DiscountCheckListControl.Location = new System.Drawing.Point(3, 16);
            this.DiscountCheckListControl.Name = "DiscountCheckListControl";
            this.DiscountCheckListControl.Size = new System.Drawing.Size(322, 104);
            this.DiscountCheckListControl.TabIndex = 0;
            this.DiscountCheckListControl.DiscountAmountChanged += new System.EventHandler(this.DiscountCheckListControl_DiscountAmountChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(-3, 259);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(49, 13);
            this.AmountLabel.TabIndex = 6;
            this.AmountLabel.Text = "Amount: ";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Location = new System.Drawing.Point(-3, 401);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(93, 13);
            this.DiscountAmountLabel.TabIndex = 7;
            this.DiscountAmountLabel.Text = "Discount amount: ";
            // 
            // CartEditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.DiscountCheckListGroupBox);
            this.Controls.Add(this.ItemListGroupBox);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.TotalLabel);
            this.Name = "CartEditorControl";
            this.Size = new System.Drawing.Size(328, 440);
            this.ItemListGroupBox.ResumeLayout(false);
            this.DiscountCheckListGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ItemControls.ItemListControl ItemListControl;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.GroupBox ItemListGroupBox;
        private System.Windows.Forms.GroupBox DiscountCheckListGroupBox;
        private DiscountControls.DiscountCheckListControl DiscountCheckListControl;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
    }
}