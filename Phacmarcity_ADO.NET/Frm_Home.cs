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
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }


        private void picPhanHoi_Click(object sender, EventArgs e)
        {
            
        }

        private void picNganSach_Click(object sender, EventArgs e)
        {

        }

        private void picXemPhanHoi_Click(object sender, EventArgs e)
        {

        }

        private void picPhieuNhap_Click(object sender, EventArgs e)
        {
            Form form = new Frm_Enter_Product();
            form.ShowDialog();
        }

        private void picNhanVien_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Employees();
            f.ShowDialog();
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

        private void picPhieuXuat_Click(object sender, EventArgs e)
        {
            Form f = new Frm_Produce_Product();
            f.ShowDialog();
        }
    }
}
