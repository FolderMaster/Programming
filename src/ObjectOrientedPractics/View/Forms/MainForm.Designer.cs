﻿namespace ObjectOrientedPractics.View.Forms
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.InterfaceTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.ItemsTabPage = new System.Windows.Forms.TabPage();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.CartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.OrdersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.InterfaceTab = new ObjectOrientedPractics.View.Tabs.InterfaceTab();
            this.InterfaceTabPage.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.CustomersTabPage.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // InterfaceTabPage
            // 
            this.InterfaceTabPage.Controls.Add(this.InterfaceTab);
            this.InterfaceTabPage.Location = new System.Drawing.Point(4, 22);
            this.InterfaceTabPage.Name = "InterfaceTabPage";
            this.InterfaceTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.InterfaceTabPage.Size = new System.Drawing.Size(908, 551);
            this.InterfaceTabPage.TabIndex = 5;
            this.InterfaceTabPage.Text = "Interface";
            this.InterfaceTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.OrdersTab);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersTabPage.Size = new System.Drawing.Size(908, 551);
            this.OrdersTabPage.TabIndex = 3;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.CartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CartsTabPage.Size = new System.Drawing.Size(908, 551);
            this.CartsTabPage.TabIndex = 2;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Controls.Add(this.CustomersTab);
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(908, 551);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemsTab);
            this.ItemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name = "ItemsTabPage";
            this.ItemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size = new System.Drawing.Size(908, 551);
            this.ItemsTabPage.TabIndex = 0;
            this.ItemsTabPage.Text = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsTabPage);
            this.TabControl.Controls.Add(this.CustomersTabPage);
            this.TabControl.Controls.Add(this.CartsTabPage);
            this.TabControl.Controls.Add(this.OrdersTabPage);
            this.TabControl.Controls.Add(this.InterfaceTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(3, 3);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(916, 577);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // ItemsTab
            // 
            this.ItemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsTab.Location = new System.Drawing.Point(3, 3);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(902, 545);
            this.ItemsTab.TabIndex = 0;
            this.ItemsTab.ItemsChanged += new System.EventHandler(this.ItemsTab_ItemsChanged);
            // 
            // CustomersTab
            // 
            this.CustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab.Location = new System.Drawing.Point(3, 3);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(902, 545);
            this.CustomersTab.TabIndex = 0;
            this.CustomersTab.CustomersChanged += new System.EventHandler(this.CustomersTab_CustomersChanged);
            this.CustomersTab.OrderCreated += new System.EventHandler(this.CustomersTab_OrderCreated);
            // 
            // CartsTab
            // 
            this.CartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTab.Location = new System.Drawing.Point(3, 3);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Size = new System.Drawing.Size(902, 545);
            this.CartsTab.TabIndex = 0;
            this.CartsTab.OrderCreated += new System.EventHandler(this.CartsTab_OrderCreated);
            // 
            // OrdersTab
            // 
            this.OrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersTab.Location = new System.Drawing.Point(3, 3);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.Size = new System.Drawing.Size(902, 545);
            this.OrdersTab.TabIndex = 0;
            // 
            // InterfaceTab
            // 
            this.InterfaceTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InterfaceTab.Location = new System.Drawing.Point(3, 3);
            this.InterfaceTab.Name = "InterfaceTab";
            this.InterfaceTab.Size = new System.Drawing.Size(902, 545);
            this.InterfaceTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 583);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.Text = "Object Oriented Practics";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.InterfaceTabPage.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.CustomersTabPage.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage InterfaceTabPage;
        private Tabs.InterfaceTab InterfaceTab;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private Tabs.OrdersTab OrdersTab;
        private System.Windows.Forms.TabPage CartsTabPage;
        private Tabs.CartsTab CartsTab;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private Tabs.CustomersTab CustomersTab;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private Tabs.ItemsTab ItemsTab;
        private System.Windows.Forms.TabControl TabControl;
    }
}

