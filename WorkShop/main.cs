using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkShop
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.MdiParent = this;
            frm.Show();

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.MdiParent = this;
            frm.Show();
        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageProduct frm = new frmManageProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            Form9 frm = new Form9();
            frm.MdiParent = this;
            frm.Show();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Form10 frm = new Form10();
            frm.MdiParent = this;
            frm.Show();
        }

        private void fromOrderCountryYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.MdiParent = this;
            frm.Show();
        }

        private void insertProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddProduct frm = new FrmAddProduct();
            frm.MdiParent = this;
            frm.Show();
        }

        private void formAddUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 frm = new Form14();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
