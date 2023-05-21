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
    public partial class Frm_Enter_Product : Form
    {
        public Frm_Enter_Product()
        {
            InitializeComponent();
        }

        private void Frm_Enter_Product_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled= false;
            pnlSearch.Enabled= false;   
        }


        private void cbxTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = StringConvert.ConvertToEnumPhieuNhap(cbxTimKiem.SelectedItem.ToString());

            switch (selectedOption)
            {
                case nameof(Cls_Enum.OptionPhieuNhap.NgaySanXuat):
                case nameof(Cls_Enum.OptionPhieuNhap.HanSuDung):
                case nameof(Cls_Enum.OptionPhieuNhap.NgayNhap):
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

        private void picThuoc_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Medicine();
            f.ShowDialog();
        }
    }
}
