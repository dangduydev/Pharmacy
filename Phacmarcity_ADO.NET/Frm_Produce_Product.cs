using Phacmarcity_ADO.NET.Class;
using Phacmarcity_ADO.NET.ENUM;
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
    public partial class Frm_Produce_Product : Form
    {
        public Frm_Produce_Product()
        {
            InitializeComponent();
        }

        private void Frm_Produce_Product_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlSearch.Enabled = false;
        }

        private void cbxTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = StringConvert.ConvertToEnumPhieuXuat(cbxTimKiem.SelectedItem.ToString());

            switch (selectedOption)
            {
                case nameof(Cls_Enum.OptionPhieuXuat.NgayXuat):
                    dtpTimKiem.Visible = true;
                    dtpTimKiem.Enabled = true;
                    txtTimKiem.Visible = false;
                    break;
                default:
                    dtpTimKiem.Visible = false;
                    txtTimKiem.Visible = true;
                    txtTimKiem.Enabled = true;
                    break;
            }
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

        private void picKhachHang_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Client();
            f.ShowDialog();
        }
    }
}
