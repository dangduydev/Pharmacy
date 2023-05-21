using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Phacmarcity_ADO.NET.ENUM;
using Phacmarcity_ADO.NET.Class;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_Supplier : Form
    {
        public Frm_Supplier()
        {
            InitializeComponent();
        }
        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled= false;
            pnlSearch.Enabled= false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Enabled = true;
        }

        private void picThuoc_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Medicine();
            f.ShowDialog();
        }

        private void picHangSX_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Manufacturer();
            f.ShowDialog();
        }
    }
}
