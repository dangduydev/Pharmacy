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
using Phacmarcity_ADO.NET.BS_layer;
using System.Data.SqlClient;


namespace Phacmarcity_ADO.NET
{
    public partial class Frm_Enter_Product : Form
    {
        DataTable dtPhieuNhap = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 
        bool Them;
        string err;
        BLPhieuNhap dbTP = new BLPhieuNhap();
        public Frm_Enter_Product()
        {
            InitializeComponent();
        }

        #region Method
        void reset()
        {
            foreach (Control control in pnlMain.Controls)
            {
                if (control is TextBox txt)
                {
                    txt.Clear();
                }
            }
            pnlSearch.Enabled = false;
        }
        void LoadData()
        {
            try
            {
                reset();
                dtPhieuNhap = new DataTable();
                dtPhieuNhap.Clear();
                DataSet ds = dbTP.LayPhieuNhap();
                dtPhieuNhap = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvPhieuNhap.DataSource = dtPhieuNhap;
                // Thay đổi độ rộng cột 
                dgvPhieuNhap.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //this.txtPhieuNhap.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
                //
                //dgvPhieuNhap_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PhieuNhap. Lỗi rồi!!!");
            }
        }

        void LoadDataSearch(string input, string key)
        {
            try
            {
                dtPhieuNhap = new DataTable();
                dtPhieuNhap.Clear();
                DataSet ds = dbTP.TimKiemPhieuNhap(input, key);
                dtPhieuNhap = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvPhieuNhap.DataSource = dtPhieuNhap;
                // Thay đổi độ rộng cột 
                dgvPhieuNhap.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //this.txtPhieuNhap.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table PhieuNhap. Lỗi rồi!!!");

            }
        }
        #endregion

        #region Event


        private void Frm_Enter_Product_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlSearch.Enabled = false;
            LoadData();
        }


        private void cbxTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = StringConvert.ConvertToEnumPhieuNhap(cbxTimKiem.SelectedItem.ToString());

            switch (selectedOption)
            {
                case nameof(Cls_Enum.OptionPhieuNhap.NgaySX):
                case nameof(Cls_Enum.OptionPhieuNhap.NgayHH):
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

        private void btnSave_Click(object sender, EventArgs e)
        {

            // Mở kết nối 
            // Thêm dữ liệu 
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh 
                    BLPhieuNhap blTp = new BLPhieuNhap();
                    blTp.ThemPhieuNhap(this.txtMaPhieuNhap.Text, this.txtMaNhanVien.Text, this.txtMaNCC.Text, this.dtpNgayNhap.Value, ref err);
                    blTp.ThemCTPhieuNhap(this.txtMaPhieuNhap.Text, this.txtMaThuoc.Text, int.Parse(this.txtSoLuong.Text), double.Parse(this.txtGia.Text), this.dtpNSX.Value, this.dtpHSD.Value, ref err);
                    // Load lại dữ liệu trên DataGridView 
                    LoadData();
                    reset();
                    // Thông báo 
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh 
                BLPhieuNhap blTp = new BLPhieuNhap();
                blTp.CapNhatPhieuNhap(this.txtMaPhieuNhap.Text, this.txtMaNhanVien.Text, txtMaNCC.Text, this.dtpNgayNhap.Value, ref err);
                blTp.CapNhatCTPhieuNhap(this.txtMaPhieuNhap.Text, this.txtMaThuoc.Text, int.Parse((this.txtSoLuong.Text)), this.txtGia.Text, this.dtpNSX.Value, this.dtpHSD.Value, ref err);

                // Load lại dữ liệu trên DataGridView 
                LoadData();
                reset();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối 
            pnlMain.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them 
            Them = true;
            // Xóa trống các đối tượng trong Panel 
            reset();
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnDelete.Enabled = false;
            // Đưa con trỏ đến TextField txtPhieuNhap 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvPhieuNhap.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strPhieuNhap =
                dgvPhieuNhap.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL 
                // Hiện thông báo xác nhận việc xóa mẫu tin 
                // Khai báo biến traloi 
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp 
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không? 
                if (traloi == DialogResult.Yes)
                {
                    dbTP.XoaPhieuNhap(ref err, strPhieuNhap);
                    // Cập nhật lại DataGridView 
                    LoadData();
                    // Thông báo 
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo 
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            dgvPhieuNhap_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH 
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvPhieuNhap.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaPhieuNhap.Text =
            dgvPhieuNhap.Rows[r].Cells[0].Value.ToString();
            this.txtMaNhanVien.Text =
            dgvPhieuNhap.Rows[r].Cells[1].Value.ToString();
            this.txtMaNCC.Text =
            dgvPhieuNhap.Rows[r].Cells[2].Value.ToString();
            this.dtpNgayNhap.Text =
            dgvPhieuNhap.Rows[r].Cells[3].Value.ToString();
            this.txtMaThuoc.Text = 
            dgvPhieuNhap.Rows[r].Cells[4].Value.ToString();
            this.txtSoLuong.Text = 
            dgvPhieuNhap.Rows[r].Cells[5].Value.ToString();
            this.txtGia.Text = 
            dgvPhieuNhap.Rows[r].Cells[6].Value.ToString();
            this.dtpNSX.Text = 
            dgvPhieuNhap.Rows[r].Cells[7].Value.ToString();
            this.dtpHSD.Text = 
            dgvPhieuNhap.Rows[r].Cells[8].Value.ToString();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null && cbxTimKiem.SelectedIndex != -1)
            {
                string typeSearch = StringConvert.ConvertToEnumPhieuNhap(cbxTimKiem.SelectedItem.ToString());
                LoadDataSearch(typeSearch, this.txtTimKiem.Text.ToString());

            }
        }

        private void dtpTimKiem_ValueChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null && cbxTimKiem.SelectedIndex != -1)
            {

                string typeSearch = StringConvert.ConvertToEnumPhieuNhap(cbxTimKiem.SelectedItem.ToString());
                switch (typeSearch)
                {
                    case nameof(Cls_Enum.OptionPhieuNhap.NgayHH):
                        LoadDataSearch(typeSearch, this.dtpTimKiem.Value.ToString());
                        break;
                    case nameof(Cls_Enum.OptionPhieuNhap.NgayNhap):
                        LoadDataSearch(typeSearch, this.dtpTimKiem.Value.ToString());
                        break;
                    case nameof(Cls_Enum.OptionPhieuNhap.NgaySX):
                        LoadDataSearch(typeSearch, this.dtpTimKiem.Value.ToString());
                        break;
                    default:
                        break;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            pnlMain.Enabled = false;
            dgvPhieuNhap_CellClick(null, null);
            reset();
        }
        #endregion

    }
}
