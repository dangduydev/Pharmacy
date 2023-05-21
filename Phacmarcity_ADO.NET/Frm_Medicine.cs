using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_Medicine : Form
    {
        public Frm_Medicine()
        {
            InitializeComponent();
        }

        private void Frm_Medicine_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlSearch.Enabled= false;
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Enabled = true;
        }

        private void picNCC_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Supplier();
            f.ShowDialog();
        }

        private void picHangSX_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Manufacturer();
            f.ShowDialog();
        }
    }
}
