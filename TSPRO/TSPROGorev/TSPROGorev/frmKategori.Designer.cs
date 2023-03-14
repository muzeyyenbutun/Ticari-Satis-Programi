namespace TSPROGorev
{
    partial class frmKategori
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
            this.txtKATEGORI_ADI = new System.Windows.Forms.TextBox();
            this.txtKATEGORI_REFNO = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "KATEGORİ ADI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "KATEGORİ REFNO";
            // 
            // txtKATEGORI_ADI
            // 
            this.txtKATEGORI_ADI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(207)))));
            this.txtKATEGORI_ADI.Location = new System.Drawing.Point(145, 65);
            this.txtKATEGORI_ADI.Name = "txtKATEGORI_ADI";
            this.txtKATEGORI_ADI.Size = new System.Drawing.Size(159, 20);
            this.txtKATEGORI_ADI.TabIndex = 7;
            // 
            // txtKATEGORI_REFNO
            // 
            this.txtKATEGORI_REFNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(207)))));
            this.txtKATEGORI_REFNO.Location = new System.Drawing.Point(145, 39);
            this.txtKATEGORI_REFNO.Name = "txtKATEGORI_REFNO";
            this.txtKATEGORI_REFNO.Size = new System.Drawing.Size(159, 20);
            this.txtKATEGORI_REFNO.TabIndex = 6;
            // 
            // frmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(145)))), ((int)(((byte)(126)))));
            this.ClientSize = new System.Drawing.Size(386, 137);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKATEGORI_ADI);
            this.Controls.Add(this.txtKATEGORI_REFNO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmKategori";
            this.Text = "KATEGORİ İŞLEMLERİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKATEGORI_ADI;
        private System.Windows.Forms.TextBox txtKATEGORI_REFNO;
    }
}