using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTE_Product_Purchase
{
    public partial class AdminStart : Form
    {
        public AdminStart(MainForm mf)
        {
            InitializeComponent();
            MF = mf; 
        }
        public MainForm MF { get; set; }
        private void prodsBtn_Click(object sender, EventArgs e)
        {
            ProductsForm pf = new ProductsForm(MF);
            pf.Show();
            Close(); 
        }

        private void purchasesBtn_Click(object sender, EventArgs e)
        {
            PurchasesForm pFrm = new PurchasesForm();
            pFrm.Show();
            Close(); 
        }
    }
}
