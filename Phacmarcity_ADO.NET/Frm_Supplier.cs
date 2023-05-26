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
    public partial class Frm_Supplier : Form
    {

        DataTable dtNCC = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BL_Supplier dbTP = new BL_Supplier();
        public Frm_Supplier()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtNCC = new DataTable();
                dtNCC.Clear();
                DataSet ds = dbTP.LayNCC();
                dtNCC = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvNhaCungCap.DataSource = dtNCC;
                // Thay đổi độ rộng cột
                dgvNhaCungCap.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtMaNCC.ResetText();
                this.txtTenNCC.ResetText();
                this.txtDiaChiNCC.ResetText();
                this.txtThongTinDD.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                this.btnSave.Enabled = false;
                /*                this.btnHuyBo.Enabled = false;*/
                this.pnlMain.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
                /*                this.btnTroVe.Enabled = true;*/
                //
                dgvNhaCungCap_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PhieuXuat. Lỗi rồi!!!");
            }
        }
        void LoadDataSearch(string input, string key)
        {
            try
            {
                dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtNCC = new DataTable();
                dtNCC.Clear();
                DataSet ds = dbTP.TimKiemNCC(input, key);
                dtNCC = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvNhaCungCap.DataSource = dtNCC;
                // Thay đổi độ rộng cột 
                dgvNhaCungCap.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //this.txtKhachHang.ResetText();
                this.txtTenNCC.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table KhachHang. Lỗi rồi!!!");

            }
        }
        private void Frm_Supplier_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlSearch.Enabled = false;
            LoadData();
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

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvNhaCungCap.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaNCC.Text =
            dgvNhaCungCap.Rows[r].Cells[0].Value.ToString();
            this.txtTenNCC.Text =
            dgvNhaCungCap.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChiNCC.Text =
            dgvNhaCungCap.Rows[r].Cells[2].Value.ToString();
            this.txtThongTinDD.Text =
            dgvNhaCungCap.Rows[r].Cells[3].Value.ToString();

        }

        private void btnUpdateNCC_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Kich hoạt biến Them
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtMaNCC.ResetText();
            this.txtTenNCC.ResetText();
            this.txtDiaChiNCC.ResetText();
            this.txtThongTinDD.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            /*            this.btnHuyBo.Enabled = true;*/
            this.pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            // Đưa con trỏ đến TextField txtThanhPho
            this.txtMaNCC.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.pnlMain.Enabled = true;
            dgvNhaCungCap_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaNCC.Enabled = false;
            this.txtTenNCC.Focus();
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
                    BL_Supplier blTp = new BL_Supplier();
                    blTp.ThemNCC(this.txtMaNCC.Text, this.txtTenNCC.Text, this.txtDiaChiNCC.Text, this.txtThongTinDD.Text, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
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
                BL_Supplier blTp = new BL_Supplier();
                blTp.CapNhatNCC(this.txtMaNCC.Text, this.txtTenNCC.Text, this.txtDiaChiNCC.Text, this.txtThongTinDD.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh
                // Lấy thứ tự record hiện hành
                int r = dgvNhaCungCap.CurrentCell.RowIndex;
                // Lấy MaPX của record hiện hành
                string strPX =
                dgvNhaCungCap.Rows[r].Cells[0].Value.ToString();
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
                    dbTP.XoaNCC(ref err, strPX);
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != null && cbxTimKiem.SelectedIndex != -1)
            {

                string typeSearch = StringConvert.ConvertToEnumSupplier(cbxTimKiem.SelectedItem.ToString());
                switch (typeSearch)
                {
                    case nameof(Cls_Enum.OptionSupplier.MaNhaCungCap):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionSupplier.TenNhaCungCap):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionSupplier.DiaChi):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionSupplier.ThongTinDaiDien):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
