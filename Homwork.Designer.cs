namespace Course_Practice
{
    partial class frmHomwork
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
            this.lblHeader = new System.Windows.Forms.Label();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.cmbChoose = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.Crimson;
            this.lblHeader.Location = new System.Drawing.Point(594, 20);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(177, 105);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Boy";
            // 
            // pbPicture
            // 
            this.pbPicture.Image = global::Course_Practice.Properties.Resources.Boy;
            this.pbPicture.Location = new System.Drawing.Point(462, 128);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(440, 499);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 1;
            this.pbPicture.TabStop = false;
            // 
            // cmbChoose
            // 
            this.cmbChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoose.FormattingEnabled = true;
            this.cmbChoose.Items.AddRange(new object[] {
            "Book",
            "Boy",
            "Girl",
            "Pen"});
            this.cmbChoose.Location = new System.Drawing.Point(586, 647);
            this.cmbChoose.Name = "cmbChoose";
            this.cmbChoose.Size = new System.Drawing.Size(192, 24);
            this.cmbChoose.Sorted = true;
            this.cmbChoose.TabIndex = 2;
            this.cmbChoose.SelectedIndexChanged += new System.EventHandler(this.cmbChoose_SelectedIndexChanged);
            // 
            // frmHomwork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1365, 794);
            this.Controls.Add(this.cmbChoose);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmHomwork";
            this.Text = "Homwork";
            this.Load += new System.EventHandler(this.frmHomwork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.ComboBox cmbChoose;
    }
}