namespace Course_Practice
{
    partial class frmCombo_Box
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHomwork = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Option1",
            "Option2",
            "Option3",
            "Option4"});
            this.comboBox1.Location = new System.Drawing.Point(523, 61);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 24);
            this.comboBox1.Sorted = true;
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(570, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 76);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add Ali To Box";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHomwork
            // 
            this.btnHomwork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomwork.Location = new System.Drawing.Point(570, 493);
            this.btnHomwork.Name = "btnHomwork";
            this.btnHomwork.Size = new System.Drawing.Size(173, 76);
            this.btnHomwork.TabIndex = 3;
            this.btnHomwork.Text = "HomeWork";
            this.btnHomwork.UseVisualStyleBackColor = true;
            this.btnHomwork.Click += new System.EventHandler(this.btnHomwork_Click);
            // 
            // frmCombo_Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1362, 796);
            this.Controls.Add(this.btnHomwork);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmCombo_Box";
            this.Text = "Combo_Box";
            this.Load += new System.EventHandler(this.frmCombo_Box_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHomwork;
    }
}