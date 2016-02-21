namespace OrderControl.Gui.Sub
{
    partial class DashboardForm
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
            this.lbl_newOrder = new System.Windows.Forms.Label();
            this.OrderGroupBox = new System.Windows.Forms.GroupBox();
            this.lbl_newOrderValue = new System.Windows.Forms.Label();
            this.LieferdatumUeberschrittenGroupBox = new System.Windows.Forms.GroupBox();
            this.lbl_articleValue = new System.Windows.Forms.Label();
            this.lbl_article = new System.Windows.Forms.Label();
            this.lbl_orderValue = new System.Windows.Forms.Label();
            this.lbl_order = new System.Windows.Forms.Label();
            this.UnorderdPositionGroupBox = new System.Windows.Forms.GroupBox();
            this.lbl_articleWrongValue = new System.Windows.Forms.Label();
            this.lbl_articleWrong = new System.Windows.Forms.Label();
            this.OrderGroupBox.SuspendLayout();
            this.LieferdatumUeberschrittenGroupBox.SuspendLayout();
            this.UnorderdPositionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_newOrder
            // 
            this.lbl_newOrder.AutoSize = true;
            this.lbl_newOrder.Location = new System.Drawing.Point(6, 31);
            this.lbl_newOrder.Name = "lbl_newOrder";
            this.lbl_newOrder.Size = new System.Drawing.Size(88, 13);
            this.lbl_newOrder.TabIndex = 0;
            this.lbl_newOrder.Text = "Neue Bestellung:";
            // 
            // OrderGroupBox
            // 
            this.OrderGroupBox.Controls.Add(this.lbl_newOrderValue);
            this.OrderGroupBox.Controls.Add(this.lbl_newOrder);
            this.OrderGroupBox.Location = new System.Drawing.Point(12, 12);
            this.OrderGroupBox.Name = "OrderGroupBox";
            this.OrderGroupBox.Size = new System.Drawing.Size(200, 65);
            this.OrderGroupBox.TabIndex = 1;
            this.OrderGroupBox.TabStop = false;
            this.OrderGroupBox.Text = "Bestellung";
            // 
            // lbl_newOrderValue
            // 
            this.lbl_newOrderValue.AutoSize = true;
            this.lbl_newOrderValue.Location = new System.Drawing.Point(181, 31);
            this.lbl_newOrderValue.Name = "lbl_newOrderValue";
            this.lbl_newOrderValue.Size = new System.Drawing.Size(13, 13);
            this.lbl_newOrderValue.TabIndex = 1;
            this.lbl_newOrderValue.Text = "0";
            this.lbl_newOrderValue.Click += new System.EventHandler(this.ActionPerformed);
            // 
            // LieferdatumUeberschrittenGroupBox
            // 
            this.LieferdatumUeberschrittenGroupBox.Controls.Add(this.lbl_articleValue);
            this.LieferdatumUeberschrittenGroupBox.Controls.Add(this.lbl_article);
            this.LieferdatumUeberschrittenGroupBox.Controls.Add(this.lbl_orderValue);
            this.LieferdatumUeberschrittenGroupBox.Controls.Add(this.lbl_order);
            this.LieferdatumUeberschrittenGroupBox.Location = new System.Drawing.Point(12, 99);
            this.LieferdatumUeberschrittenGroupBox.Name = "LieferdatumUeberschrittenGroupBox";
            this.LieferdatumUeberschrittenGroupBox.Size = new System.Drawing.Size(200, 100);
            this.LieferdatumUeberschrittenGroupBox.TabIndex = 2;
            this.LieferdatumUeberschrittenGroupBox.TabStop = false;
            this.LieferdatumUeberschrittenGroupBox.Text = "Lieferdatum Überschritten";
            // 
            // lbl_articleValue
            // 
            this.lbl_articleValue.AutoSize = true;
            this.lbl_articleValue.Location = new System.Drawing.Point(181, 52);
            this.lbl_articleValue.Name = "lbl_articleValue";
            this.lbl_articleValue.Size = new System.Drawing.Size(13, 13);
            this.lbl_articleValue.TabIndex = 3;
            this.lbl_articleValue.Text = "0";
            this.lbl_articleValue.Click += new System.EventHandler(this.ActionPerformed);
            // 
            // lbl_article
            // 
            this.lbl_article.AutoSize = true;
            this.lbl_article.Location = new System.Drawing.Point(7, 52);
            this.lbl_article.Name = "lbl_article";
            this.lbl_article.Size = new System.Drawing.Size(36, 13);
            this.lbl_article.TabIndex = 2;
            this.lbl_article.Text = "Artikel";
            // 
            // lbl_orderValue
            // 
            this.lbl_orderValue.AutoSize = true;
            this.lbl_orderValue.Location = new System.Drawing.Point(181, 30);
            this.lbl_orderValue.Name = "lbl_orderValue";
            this.lbl_orderValue.Size = new System.Drawing.Size(13, 13);
            this.lbl_orderValue.TabIndex = 1;
            this.lbl_orderValue.Tag = "lbl_orderValue";
            this.lbl_orderValue.Text = "0";
            this.lbl_orderValue.Click += new System.EventHandler(this.ActionPerformed);
            // 
            // lbl_order
            // 
            this.lbl_order.AutoSize = true;
            this.lbl_order.Location = new System.Drawing.Point(7, 30);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(68, 13);
            this.lbl_order.TabIndex = 0;
            this.lbl_order.Text = "Bestellungen";
            // 
            // UnorderdPositionGroupBox
            // 
            this.UnorderdPositionGroupBox.Controls.Add(this.lbl_articleWrongValue);
            this.UnorderdPositionGroupBox.Controls.Add(this.lbl_articleWrong);
            this.UnorderdPositionGroupBox.Location = new System.Drawing.Point(12, 217);
            this.UnorderdPositionGroupBox.Name = "UnorderdPositionGroupBox";
            this.UnorderdPositionGroupBox.Size = new System.Drawing.Size(200, 101);
            this.UnorderdPositionGroupBox.TabIndex = 3;
            this.UnorderdPositionGroupBox.TabStop = false;
            this.UnorderdPositionGroupBox.Text = "Falschlieferung";
            // 
            // lbl_articleWrongValue
            // 
            this.lbl_articleWrongValue.AutoSize = true;
            this.lbl_articleWrongValue.Location = new System.Drawing.Point(181, 26);
            this.lbl_articleWrongValue.Name = "lbl_articleWrongValue";
            this.lbl_articleWrongValue.Size = new System.Drawing.Size(13, 13);
            this.lbl_articleWrongValue.TabIndex = 5;
            this.lbl_articleWrongValue.Text = "0";
            this.lbl_articleWrongValue.Click += new System.EventHandler(this.ActionPerformed);
            // 
            // lbl_articleWrong
            // 
            this.lbl_articleWrong.AutoSize = true;
            this.lbl_articleWrong.Location = new System.Drawing.Point(7, 26);
            this.lbl_articleWrong.Name = "lbl_articleWrong";
            this.lbl_articleWrong.Size = new System.Drawing.Size(36, 13);
            this.lbl_articleWrong.TabIndex = 4;
            this.lbl_articleWrong.Text = "Artikel";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 344);
            this.ControlBox = false;
            this.Controls.Add(this.UnorderdPositionGroupBox);
            this.Controls.Add(this.LieferdatumUeberschrittenGroupBox);
            this.Controls.Add(this.OrderGroupBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.OrderGroupBox.ResumeLayout(false);
            this.OrderGroupBox.PerformLayout();
            this.LieferdatumUeberschrittenGroupBox.ResumeLayout(false);
            this.LieferdatumUeberschrittenGroupBox.PerformLayout();
            this.UnorderdPositionGroupBox.ResumeLayout(false);
            this.UnorderdPositionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_newOrder;
        private System.Windows.Forms.GroupBox OrderGroupBox;
        private System.Windows.Forms.Label lbl_newOrderValue;
        private System.Windows.Forms.GroupBox LieferdatumUeberschrittenGroupBox;
        private System.Windows.Forms.Label lbl_articleValue;
        private System.Windows.Forms.Label lbl_article;
        private System.Windows.Forms.Label lbl_orderValue;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.GroupBox UnorderdPositionGroupBox;
        private System.Windows.Forms.Label lbl_articleWrongValue;
        private System.Windows.Forms.Label lbl_articleWrong;
    }
}