namespace TSPROGorev
{
    partial class frmAltKategori
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtALT_KATEGORI_ADI = new System.Windows.Forms.TextBox();
            this.txtALT_KATEGORI_REFNO = new System.Windows.Forms.TextBox();
            this.cmbKATEGORI_REFNO = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ALT KATEGORİ ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "KATEGORI REFNO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "ALT_KATEGORI_REFNO";
            // 
            // txtALT_KATEGORI_ADI
            // 
            this.txtALT_KATEGORI_ADI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(177)))));
            this.txtALT_KATEGORI_ADI.Location = new System.Drawing.Point(182, 90);
            this.txtALT_KATEGORI_ADI.Name = "txtALT_KATEGORI_ADI";
            this.txtALT_KATEGORI_ADI.Size = new System.Drawing.Size(159, 20);
            this.txtALT_KATEGORI_ADI.TabIndex = 10;
            // 
            // txtALT_KATEGORI_REFNO
            // 
            this.txtALT_KATEGORI_REFNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(177)))));
            this.txtALT_KATEGORI_REFNO.Location = new System.Drawing.Point(182, 37);
            this.txtALT_KATEGORI_REFNO.Name = "txtALT_KATEGORI_REFNO";
            this.txtALT_KATEGORI_REFNO.Size = new System.Drawing.Size(159, 20);
            this.txtALT_KATEGORI_REFNO.TabIndex = 8;
            // 
            // cmbKATEGORI_REFNO
            // 
            this.cmbKATEGORI_REFNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(177)))));
            this.cmbKATEGORI_REFNO.FormattingEnabled = true;
            this.cmbKATEGORI_REFNO.Location = new System.Drawing.Point(183, 63);
            this.cmbKATEGORI_REFNO.Name = "cmbKATEGORI_REFNO";
            this.cmbKATEGORI_REFNO.Size = new System.Drawing.Size(158, 21);
            this.cmbKATEGORI_REFNO.TabIndex = 15;
            // 
            // frmAltKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(207)))));
            this.ClientSize = new System.Drawing.Size(400, 159);
            this.Controls.Add(this.cmbKATEGORI_REFNO);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtALT_KATEGORI_ADI);
            this.Controls.Add(this.txtALT_KATEGORI_REFNO);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAltKategori";
            this.Text = "ALT KATEGORİ İŞLEMLERİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtALT_KATEGORI_ADI;
        private System.Windows.Forms.TextBox txtALT_KATEGORI_REFNO;
        private System.Windows.Forms.ComboBox cmbKATEGORI_REFNO;
    }
}