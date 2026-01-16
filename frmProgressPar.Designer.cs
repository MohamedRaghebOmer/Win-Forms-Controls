namespace Course_Practice
{
    partial class frmProgressPar
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnIncreesProgressPar = new System.Windows.Forms.Button();
            this.btnRestProgressPar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Info;
            this.progressBar1.Location = new System.Drawing.Point(499, 361);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(342, 41);
            this.progressBar1.TabIndex = 0;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.ForeColor = System.Drawing.SystemColors.Control;
            this.lblProgress.Location = new System.Drawing.Point(643, 277);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(55, 32);
            this.lblProgress.TabIndex = 1;
            this.lblProgress.Text = "0%";
            // 
            // btnIncreesProgressPar
            // 
            this.btnIncreesProgressPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncreesProgressPar.Location = new System.Drawing.Point(361, 448);
            this.btnIncreesProgressPar.Name = "btnIncreesProgressPar";
            this.btnIncreesProgressPar.Size = new System.Drawing.Size(270, 72);
            this.btnIncreesProgressPar.TabIndex = 2;
            this.btnIncreesProgressPar.Text = "Incress Progress Par";
            this.btnIncreesProgressPar.UseVisualStyleBackColor = true;
            this.btnIncreesProgressPar.Click += new System.EventHandler(this.btnIncreesProgressPar_Click);
            // 
            // btnRestProgressPar
            // 
            this.btnRestProgressPar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestProgressPar.Location = new System.Drawing.Point(747, 448);
            this.btnRestProgressPar.Name = "btnRestProgressPar";
            this.btnRestProgressPar.Size = new System.Drawing.Size(270, 72);
            this.btnRestProgressPar.TabIndex = 4;
            this.btnRestProgressPar.Text = "Reset Progress Par";
            this.btnRestProgressPar.UseVisualStyleBackColor = true;
            this.btnRestProgressPar.Click += new System.EventHandler(this.btnRestProgressPar_Click);
            // 
            // frmProgressPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1341, 782);
            this.Controls.Add(this.btnRestProgressPar);
            this.Controls.Add(this.btnIncreesProgressPar);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar1);
            this.Name = "frmProgressPar";
            this.Text = "frmProgressPar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnIncreesProgressPar;
        private System.Windows.Forms.Button btnRestProgressPar;
    }
}