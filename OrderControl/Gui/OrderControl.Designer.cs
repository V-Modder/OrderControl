using System.Resources;

namespace OrderControl.Gui
{
    partial class OrderControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderControl));
            this.mainRibbon = new System.Windows.Forms.Ribbon();
            this.dummyAppButton = new System.Windows.Forms.RibbonButton();
            this.UndoButton = new System.Windows.Forms.RibbonButton();
            this.RedoButton = new System.Windows.Forms.RibbonButton();
            this.DashboardTab = new System.Windows.Forms.RibbonTab();
            this.DashboardPanel = new System.Windows.Forms.RibbonPanel();
            this.RefreshButton = new System.Windows.Forms.RibbonButton();
            this.OrderTab = new System.Windows.Forms.RibbonTab();
            this.OrderPanel = new System.Windows.Forms.RibbonPanel();
            this.OpenButton = new System.Windows.Forms.RibbonButton();
            this.ProductsTab = new System.Windows.Forms.RibbonTab();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.SuspendLayout();
            // 
            // mainRibbon
            // 
            this.mainRibbon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mainRibbon.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.Minimized = false;
            this.mainRibbon.Name = "mainRibbon";
            // 
            // 
            // 
            this.mainRibbon.OrbDropDown.BorderRoundness = 8;
            this.mainRibbon.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.mainRibbon.OrbDropDown.Name = "";
            this.mainRibbon.OrbDropDown.Size = new System.Drawing.Size(527, 447);
            this.mainRibbon.OrbDropDown.TabIndex = 0;
            this.mainRibbon.OrbImage = null;
            this.mainRibbon.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2010;
            this.mainRibbon.OrbText = "File";
            // 
            // 
            // 
            this.mainRibbon.QuickAcessToolbar.Items.Add(this.dummyAppButton);
            this.mainRibbon.QuickAcessToolbar.Items.Add(this.UndoButton);
            this.mainRibbon.QuickAcessToolbar.Items.Add(this.RedoButton);
            this.mainRibbon.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.mainRibbon.Size = new System.Drawing.Size(791, 130);
            this.mainRibbon.TabIndex = 0;
            this.mainRibbon.Tabs.Add(this.DashboardTab);
            this.mainRibbon.Tabs.Add(this.OrderTab);
            this.mainRibbon.Tabs.Add(this.ProductsTab);
            this.mainRibbon.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.mainRibbon.Text = "ribbon1";
            this.mainRibbon.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // dummyAppButton
            // 
            this.dummyAppButton.Image = ((System.Drawing.Image)(resources.GetObject("dummyAppButton.Image")));
            this.dummyAppButton.IsDummy = true;
            this.dummyAppButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.dummyAppButton.SmallImage = global::OrderControl.Properties.Resources.icon16;
            this.dummyAppButton.Text = "dummyButton";
            this.dummyAppButton.DoubleClick += new System.EventHandler(this.dummyAppButtonDoubleClick);
            this.dummyAppButton.Click += new System.EventHandler(this.dummyAppButtonClick);
            // 
            // UndoButton
            // 
            this.UndoButton.Image = ((System.Drawing.Image)(resources.GetObject("UndoButton.Image")));
            this.UndoButton.IsDummy = false;
            this.UndoButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.UndoButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("UndoButton.SmallImage")));
            this.UndoButton.Text = "ribbonButton1";
            // 
            // RedoButton
            // 
            this.RedoButton.Enabled = false;
            this.RedoButton.Image = ((System.Drawing.Image)(resources.GetObject("RedoButton.Image")));
            this.RedoButton.IsDummy = false;
            this.RedoButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.RedoButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("RedoButton.SmallImage")));
            this.RedoButton.Text = "ribbonButton1";
            // 
            // DashboardTab
            // 
            this.DashboardTab.Panels.Add(this.DashboardPanel);
            this.DashboardTab.Text = "Dashboard";
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.Items.Add(this.RefreshButton);
            this.DashboardPanel.Text = "Dashboard";
            // 
            // RefreshButton
            // 
            this.RefreshButton.AltKey = "F5";
            this.RefreshButton.Image = global::OrderControl.Properties.Resources.refresh32;
            this.RefreshButton.IsDummy = false;
            this.RefreshButton.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.RefreshButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("RefreshButton.SmallImage")));
            this.RefreshButton.Tag = "RefreshButton";
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.Value = "";
            this.RefreshButton.Click += new System.EventHandler(this.ButtonClick);
            // 
            // OrderTab
            // 
            this.OrderTab.Panels.Add(this.OrderPanel);
            this.OrderTab.Text = "Order";
            // 
            // OrderPanel
            // 
            this.OrderPanel.ButtonMoreVisible = false;
            this.OrderPanel.Items.Add(this.OpenButton);
            this.OrderPanel.Items.Add(this.ribbonButton1);
            this.OrderPanel.Items.Add(this.ribbonButton2);
            this.OrderPanel.Items.Add(this.ribbonButton3);
            this.OrderPanel.Items.Add(this.ribbonButton4);
            this.OrderPanel.Text = "Order";
            // 
            // OpenButton
            // 
            this.OpenButton.Image = global::OrderControl.Properties.Resources.order32;
            this.OpenButton.IsDummy = true;
            this.OpenButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("OpenButton.SmallImage")));
            this.OpenButton.Text = "ribbonButton1";
            // 
            // ProductsTab
            // 
            this.ProductsTab.Text = "Products";
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.IsDummy = false;
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "ribbonButton1";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.IsDummy = false;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.IsDummy = false;
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "ribbonButton3";
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.IsDummy = false;
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "ribbonButton4";
            // 
            // OrderControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 400);
            this.Controls.Add(this.mainRibbon);
            this.IsMdiContainer = true;
            this.Name = "OrderControl";
            this.Text = "OrderControl";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Ribbon mainRibbon;
        private System.Windows.Forms.RibbonButton dummyAppButton;
        private System.Windows.Forms.RibbonButton UndoButton;
        private System.Windows.Forms.RibbonTab DashboardTab;
        private System.Windows.Forms.RibbonTab OrderTab;
        private System.Windows.Forms.RibbonTab ProductsTab;
        private System.Windows.Forms.RibbonButton RedoButton;
        private System.Windows.Forms.RibbonPanel DashboardPanel;
        private System.Windows.Forms.RibbonButton RefreshButton;
        private System.Windows.Forms.RibbonPanel OrderPanel;
        private System.Windows.Forms.RibbonButton OpenButton;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
    }
}