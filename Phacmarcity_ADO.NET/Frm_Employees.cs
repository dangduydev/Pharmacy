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
    public partial class Frm_Employees : Form
    {
        public Frm_Employees()
        {
            InitializeComponent();
        }
        private void Frm_Employees_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlSearch.Enabled = false;
        }

        private void picNCC_Click(object sender, EventArgs e)
        {
            Form ncc = new Frm_Supplier();
            ncc.ShowDialog();
        }

        private void picHangSX_Click(object sender, EventArgs e)
        {
            Form hangSX = new Frm_Manufacturer();
            hangSX.ShowDialog();
        }

        private void picThuoc_Click(object sender, EventArgs e)
        {
            Form thuoc = new Frm_Medicine();
            thuoc.ShowDialog();
        }

        private void picKhachHang_Click(object sender, EventArgs e)
        {
            Form khachHang = new Form();
            khachHang.ShowDialog(); 
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Enabled = true;
        }

        private void cbxTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = StringConvert.ConvertToEnumEmployee(cbxTimKiem.SelectedItem.ToString());

            switch (selectedOption)
            {
                case nameof(Cls_Enum.OptionEmployee.NgaySinh):
                case nameof(Cls_Enum.OptionEmployee.NgayVaoLam):
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
    }
}
