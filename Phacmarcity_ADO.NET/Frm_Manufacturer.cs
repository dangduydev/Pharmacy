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
    public partial class Frm_Manufacturer : Form
    {
        public Frm_Manufacturer()
        {
            InitializeComponent();
        }
        private void Frm_Manufacturer_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled= false;
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

        private void picThuoc_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Medicine();
            f.ShowDialog();
        }
    }
}
