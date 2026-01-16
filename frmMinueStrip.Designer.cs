namespace Course_Practice
{
    partial class frmMinueStrip
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dipositeToAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawFromAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalBalancesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findClinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findByAccountNumberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findByNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClinetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dipositeToAccountToolStripMenuItem,
            this.withdrawFromAccountToolStripMenuItem,
            this.totalBalancesToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.transactionsToolStripMenuItem.Text = "&Transactions";
            // 
            // dipositeToAccountToolStripMenuItem
            // 
            this.dipositeToAccountToolStripMenuItem.Name = "dipositeToAccountToolStripMenuItem";
            this.dipositeToAccountToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.dipositeToAccountToolStripMenuItem.Text = "Diposite To Account";
            // 
            // withdrawFromAccountToolStripMenuItem
            // 
            this.withdrawFromAccountToolStripMenuItem.Name = "withdrawFromAccountToolStripMenuItem";
            this.withdrawFromAccountToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.withdrawFromAccountToolStripMenuItem.Text = "Withdraw From Account";
            // 
            // totalBalancesToolStripMenuItem
            // 
            this.totalBalancesToolStripMenuItem.Name = "totalBalancesToolStripMenuItem";
            this.totalBalancesToolStripMenuItem.Size = new System.Drawing.Size(252, 26);
            this.totalBalancesToolStripMenuItem.Text = "Total Balances";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findClinetToolStripMenuItem,
            this.addNewClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem,
            this.updateClinetToolStripMenuItem,
            this.toolStripMenuItem2,
            this.loginToolStripMenuItem,
            this.existToolStripMenuItem});
            this.clientToolStripMenuItem.Image = global::Course_Practice.Properties.Resources.Book;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.clientToolStripMenuItem.Text = "&Manage Clients";
            // 
            // findClinetToolStripMenuItem
            // 
            this.findClinetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findByAccountNumberToolStripMenuItem,
            this.findByNameToolStripMenuItem});
            this.findClinetToolStripMenuItem.Image = global::Course_Practice.Properties.Resources.question_mark_96;
            this.findClinetToolStripMenuItem.Name = "findClinetToolStripMenuItem";
            this.findClinetToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.findClinetToolStripMenuItem.Text = "&Find Clinet";
            this.findClinetToolStripMenuItem.Click += new System.EventHandler(this.findClinetToolStripMenuItem_Click);
            // 
            // findByAccountNumberToolStripMenuItem
            // 
            this.findByAccountNumberToolStripMenuItem.Name = "findByAccountNumberToolStripMenuItem";
            this.findByAccountNumberToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.findByAccountNumberToolStripMenuItem.Text = "Find By Account Number";
            this.findByAccountNumberToolStripMenuItem.Click += new System.EventHandler(this.findByAccountNumberToolStripMenuItem_Click);
            // 
            // findByNameToolStripMenuItem
            // 
            this.findByNameToolStripMenuItem.Name = "findByNameToolStripMenuItem";
            this.findByNameToolStripMenuItem.Size = new System.Drawing.Size(256, 26);
            this.findByNameToolStripMenuItem.Text = "Find By Name";
            this.findByNameToolStripMenuItem.Click += new System.EventHandler(this.findByNameToolStripMenuItem_Click);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.addNewClientToolStripMenuItem.Text = "Add &New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Image = global::Course_Practice.Properties.Resources.X;
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.deleteClientToolStripMenuItem.Text = "&Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // updateClinetToolStripMenuItem
            // 
            this.updateClinetToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateClinetToolStripMenuItem.CheckOnClick = true;
            this.updateClinetToolStripMenuItem.Name = "updateClinetToolStripMenuItem";
            this.updateClinetToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.updateClinetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.updateClinetToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.updateClinetToolStripMenuItem.Text = "&Update Clinet";
            this.updateClinetToolStripMenuItem.Click += new System.EventHandler(this.updateClinetToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(232, 6);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.loginToolStripMenuItem.Text = "Log&in";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // existToolStripMenuItem
            // 
            this.existToolStripMenuItem.Name = "existToolStripMenuItem";
            this.existToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.existToolStripMenuItem.Text = "&Exist";
            this.existToolStripMenuItem.Click += new System.EventHandler(this.existToolStripMenuItem_Click);
            // 
            // frmMinueStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1311, 707);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frmMinueStrip";
            this.Text = "frmMinueStrip";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findClinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClinetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dipositeToAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawFromAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalBalancesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findByAccountNumberToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findByNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
    }
}