namespace TSPROGorev
{
    partial class frmKDV
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKDV_ORANI = new System.Windows.Forms.TextBox();
            this.txtKDV_REFNO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "KDV ORANI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "KDV_REFNO";
            // 
            // txtKDV_ORANI
            // 
            this.txtKDV_ORANI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(203)))), ((int)(((byte)(198)))));
            this.txtKDV_ORANI.Location = new System.Drawing.Point(119, 38);
            this.txtKDV_ORANI.Name = "txtKDV_ORANI";
            this.txtKDV_ORANI.Size = new System.Drawing.Size(159, 20);
            this.txtKDV_ORANI.TabIndex = 7;
            // 
            // txtKDV_REFNO
            // 
            this.txtKDV_REFNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(203)))), ((int)(((byte)(198)))));
            this.txtKDV_REFNO.Location = new System.Drawing.Point(119, 12);
            this.txtKDV_REFNO.Name = "txtKDV_REFNO";
            this.txtKDV_REFNO.Size = new System.Drawing.Size(159, 20);
            this.txtKDV_REFNO.TabIndex = 6;
            // 
            // frmKDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(292, 87);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKDV_ORANI);
            this.Controls.Add(this.txtKDV_REFNO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKDV";
            this.Text = "KDV İŞLEMLERİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKDV_ORANI;
        private System.Windows.Forms.TextBox txtKDV_REFNO;
    }
}