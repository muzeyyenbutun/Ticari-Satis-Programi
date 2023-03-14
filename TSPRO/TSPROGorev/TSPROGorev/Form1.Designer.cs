namespace TSPROGorev
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("ÜRÜN");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("ÜRÜN HAREKETLERİ");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("CARİ");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("CARİ HAREKETLERİ");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("KULLANICI");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("KDV");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ALT KATEGORİ");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("KATEGORİ", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("FATURA DETAY");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("FATURA", new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("SİPARİŞ DETAY");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("SİPARİŞ ", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnYeni = new System.Windows.Forms.ToolStripButton();
            this.btnKaydet = new System.Windows.Forms.ToolStripButton();
            this.btnVazgec = new System.Windows.Forms.ToolStripButton();
            this.btnSil = new System.Windows.Forms.ToolStripButton();
            this.txtAra = new System.Windows.Forms.ToolStripTextBox();
            this.btnAra = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.ımageList2 = new System.Windows.Forms.ImageList(this.components);
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(145)))), ((int)(((byte)(126)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnYeni,
            this.btnKaydet,
            this.btnVazgec,
            this.btnSil,
            this.txtAra,
            this.btnAra});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(821, 30);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnYeni
            // 
            this.btnYeni.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.Image")));
            this.btnYeni.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYeni.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(61, 27);
            this.btnYeni.Text = "Yeni";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.Image")));
            this.btnKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(83, 27);
            this.btnKaydet.Text = "Kaydet";
            // 
            // btnVazgec
            // 
            this.btnVazgec.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVazgec.Image = ((System.Drawing.Image)(resources.GetObject("btnVazgec.Image")));
            this.btnVazgec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVazgec.Name = "btnVazgec";
            this.btnVazgec.Size = new System.Drawing.Size(83, 27);
            this.btnVazgec.Text = "Vazgeç";
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.Image")));
            this.btnSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(47, 27);
            this.btnSil.Text = "Sil";
            // 
            // txtAra
            // 
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(200, 30);
            // 
            // btnAra
            // 
            this.btnAra.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.Image = ((System.Drawing.Image)(resources.GetObject("btnAra.Image")));
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(57, 27);
            this.btnAra.Text = "Ara";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 509);
            this.panel1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(224)))), ((int)(((byte)(207)))));
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.ımageList2;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 0;
            treeNode1.Name = "urun";
            treeNode1.Text = "ÜRÜN";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "urunhar";
            treeNode2.Text = "ÜRÜN HAREKETLERİ";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "carı";
            treeNode3.Text = "CARİ";
            treeNode4.ImageIndex = 3;
            treeNode4.Name = "carıhar";
            treeNode4.Text = "CARİ HAREKETLERİ";
            treeNode5.ImageIndex = 4;
            treeNode5.Name = "kullanıcı";
            treeNode5.Text = "KULLANICI";
            treeNode6.ImageIndex = 5;
            treeNode6.Name = "kdv";
            treeNode6.Text = "KDV";
            treeNode7.ImageIndex = 7;
            treeNode7.Name = "altkategorı";
            treeNode7.Text = "ALT KATEGORİ";
            treeNode8.ImageIndex = 6;
            treeNode8.Name = "kategorı";
            treeNode8.Text = "KATEGORİ";
            treeNode9.Name = "fatdetay";
            treeNode9.SelectedImageKey = "10.png";
            treeNode9.Text = "FATURA DETAY";
            treeNode10.ImageIndex = 8;
            treeNode10.Name = "fatura";
            treeNode10.Text = "FATURA";
            treeNode11.ImageIndex = 11;
            treeNode11.Name = "sıpdetay";
            treeNode11.Text = "SİPARİŞ DETAY";
            treeNode12.ImageIndex = 10;
            treeNode12.Name = "sıparıs";
            treeNode12.Text = "SİPARİŞ ";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode8,
            treeNode10,
            treeNode12});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(265, 657);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // ımageList2
            // 
            this.ımageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList2.ImageStream")));
            this.ımageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList2.Images.SetKeyName(0, "1.png");
            this.ımageList2.Images.SetKeyName(1, "2.png");
            this.ımageList2.Images.SetKeyName(2, "3.png");
            this.ımageList2.Images.SetKeyName(3, "4.png");
            this.ımageList2.Images.SetKeyName(4, "5.png");
            this.ımageList2.Images.SetKeyName(5, "6.png");
            this.ımageList2.Images.SetKeyName(6, "7.png");
            this.ımageList2.Images.SetKeyName(7, "8.png");
            this.ımageList2.Images.SetKeyName(8, "9.png");
            this.ımageList2.Images.SetKeyName(9, "10.png");
            this.ımageList2.Images.SetKeyName(10, "11.png");
            this.ımageList2.Images.SetKeyName(11, "12.png");
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "search.png");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(186)))), ((int)(((byte)(177)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(265, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 509);
            this.panel2.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TSPRO ANA SAYFA";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnYeni;
        private System.Windows.Forms.ToolStripButton btnKaydet;
        private System.Windows.Forms.ToolStripButton btnVazgec;
        private System.Windows.Forms.ToolStripButton btnSil;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripTextBox txtAra;
        private System.Windows.Forms.ToolStripButton btnAra;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.ImageList ımageList2;
    }
}

