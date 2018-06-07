using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CU
{
    public partial class CU_Main : Form
    {

        public CU_Main()
        {
            InitializeComponent();
        }

        private void CU_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void saleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sale sale = new Sale();
            sale.MdiParent = this;
            sale.Show();
        }

        private void stockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.MdiParent = this;
            stock.Show();
        }

        private void refundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refund refund = new Refund();
            refund.MdiParent = this;
            refund.Show();
        }
    }
}
