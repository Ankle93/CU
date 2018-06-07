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
    public partial class Sale : Form
    {
        public Sale()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            paymentoption pay = new paymentoption();
            Console.WriteLine("Hello World !");
            pay.Show();
            
            // MessageBox.Show("결제 완료.");
        }
    }
}
