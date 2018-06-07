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
    public partial class paymentoption : Form
    {
        public paymentoption()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cash cash = new Cash();
            this.Hide();
            cash.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Card card = new Card();
            this.Hide();
            card.Show();
        }
    }
}
