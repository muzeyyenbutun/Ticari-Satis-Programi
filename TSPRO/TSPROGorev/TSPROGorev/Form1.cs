using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSPROGorev
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string text = "";
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (treeView1.SelectedNode.Name=="urun")
            {
                panel2.Controls.Clear();
                frmUrun fu = new frmUrun();
                fu.TopLevel = false;
                panel2.Controls.Add(fu);
                fu.Show();
                fu.Dock = DockStyle.Fill;
            }
            else if (treeView1.SelectedNode.Name == "urunhar")
            {
                panel2.Controls.Clear();
                frmUrunHar fuh = new frmUrunHar();
                fuh.TopLevel = false;
                panel2.Controls.Add(fuh);
                fuh.Show();
                fuh.Dock = DockStyle.Fill;
            }
            else if (treeView1.SelectedNode.Name=="carı")
            {
                panel2.Controls.Clear();
                frmCari fc = new frmCari();
                fc.TopLevel = false;
                panel2.Controls.Add(fc);
                fc.Show();
                fc.Dock = DockStyle.Fill;
            }
            else if (treeView1.SelectedNode.Name=="carıhar")
            {
                panel2.Controls.Clear();
                frmCariHar fch = new frmCariHar();
                fch.TopLevel = false;
                panel2.Controls.Add(fch);
                fch.Show();
                fch.Dock = DockStyle.Fill;
            }
        }

       
    }
}
