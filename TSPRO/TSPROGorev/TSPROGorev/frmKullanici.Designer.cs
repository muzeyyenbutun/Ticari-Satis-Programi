namespace TSPROGorev
{
    partial class frmKullanici
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
            this.txtKULLANICI_REFNO = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtSIFRESI = new System.Windows.Forms.TextBox();
            this.txtDURUMU = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKULLANICI_REFNO
            // 
            this.txtKULLANICI_REFNO.Location = new System.Drawing.Point(144, 18);
            this.txtKULLANICI_REFNO.Name = "txtKULLANICI_REFNO";
            this.txtKULLANICI_REFNO.Size = new System.Drawing.Size(159, 20);
            this.txtKULLANICI_REFNO.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 1;
            // 
            // txtSIFRESI
            // 
            this.txtSIFRESI.Location = new System.Drawing.Point(144, 71);
            this.txtSIFRESI.Name = "txtSIFRESI";
            this.txtSIFRESI.Size = new System.Drawing.Size(159, 20);
            this.txtSIFRESI.TabIndex = 2;
            // 
            // txtDURUMU
            // 
            this.txtDURUMU.Location = new System.Drawing.Point(144, 98);
            this.txtDURUMU.Name = "txtDURUMU";
            this.txtDURUMU.Size = new System.Drawing.Size(159, 20);
            this.txtDURUMU.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "KULLANICI_REFNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "KULLANICI ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ŞİFRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "DURUMU";
            // 
            // frmKullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(177)))));
            this.ClientSize = new System.Drawing.Size(328, 161);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDURUMU);
            this.Controls.Add(this.txtSIFRESI);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtKULLANICI_REFNO);
            this.Name = "frmKullanici";
            this.Text = "KULLANICI İŞLEMLERİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKULLANICI_REFNO;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSIFRESI;
        private System.Windows.Forms.TextBox txtDURUMU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}