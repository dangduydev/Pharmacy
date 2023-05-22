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
    public partial class Frm_Employees : Form
    {
        DataTable dtNhanVien = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 
        bool Them;
        string err;
        BLNhanVien dbTP = new BLNhanVien();
        public Frm_Employees()
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
            pnlSearch.Enabled= false;


        }
        void LoadData()
        {
            try
            {
                reset();
                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                DataSet ds = dbTP.LayNhanVien();
                dtNhanVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvNhanVien.DataSource = dtNhanVien;
                // Thay đổi độ rộng cột 
                dgvNhanVien.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //this.txtNhanVien.ResetText();
                this.txtTenNhanVien.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
                //
                dgvNhanVien_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table NhanVien. Lỗi rồi!!!");
            }
        }
        #endregion

        #region Event

        private void Frm_Employees_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlSearch.Enabled = false;
            LoadData();
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
        void LoadDataSearch(string input, string key)
        {
            try
            {
                dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                DataSet ds = dbTP.TimKiemNhanVien(input, key);
                dtNhanVien = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvNhanVien.DataSource = dtNhanVien;
                // Thay đổi độ rộng cột 
                dgvNhanVien.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //this.txtNhanVien.ResetText();
                this.txtTenNhanVien.ResetText();
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
                MessageBox.Show("Không lấy được nội dung trong table NhanVien. Lỗi rồi!!!");

            }
            #endregion

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
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
            // Đưa con trỏ đến TextField txtNhanVien 
            this.txtTenNhanVien.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            dgvNhanVien_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH 
            this.txtTenNhanVien.Focus();
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvNhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaNhanVien.Text =
            dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenNhanVien.Text =
            dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.dtpNgaySinh.Text =
            dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            this.cbxBoPhan.Text =
            dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            this.txtSDT.Text =
            dgvNhanVien.Rows[r].Cells[4].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtTenNhanVien.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            pnlMain.Enabled = false;
            dgvNhanVien_CellClick(null, null);
            reset();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh 
                    BLNhanVien blTp = new BLNhanVien();
                    blTp.ThemNhanVien(this.txtMaNhanVien.Text, this.txtTenNhanVien.Text, dtpNgaySinh.Value, cbxBoPhan.SelectedItem.ToString(), txtSDT.Text, ref err);
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
            else //Sua
            {
                // Thực hiện lệnh 
                BLNhanVien blTp = new BLNhanVien();
                blTp.CapNhatNhanVien(this.txtMaNhanVien.Text, this.txtTenNhanVien.Text, dtpNgaySinh.Value, cbxBoPhan.SelectedItem.ToString(), txtSDT.Text, ref err);

                // Load lại dữ liệu trên DataGridView 
                LoadData();
                reset();
                // Thông báo 
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối 
            pnlMain.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // Thực hiện lệnh 
                // Lấy thứ tự record hiện hành 
                int r = dgvNhanVien.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strNhanVien =
                dgvNhanVien.Rows[r].Cells[0].Value.ToString();
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
                    dbTP.XoaNhanVien(ref err, strNhanVien);
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
                string typeSearch = StringConvert.ConvertToEnumEmployee(cbxTimKiem.SelectedItem.ToString());
                switch (typeSearch)
                {
                    case nameof(Cls_Enum.OptionEmployee.MaNhanVien):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionEmployee.HoTen):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionEmployee.SoDienThoai):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionEmployee.BoPhan):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionEmployee.NgaySinh):
                        LoadDataSearch(typeSearch, dtpTimKiem.Value.ToString());
                        break;
                    default:
                        break;
                }
            }
        }

        private void dtpTimKiem_ValueChanged(object sender, EventArgs e)
        {
            if (cbxTimKiem.SelectedIndex != -1)
            {
                string typeSearch = StringConvert.ConvertToEnumEmployee(cbxTimKiem.SelectedItem.ToString());
                LoadDataSearch(typeSearch, dtpTimKiem.Value.ToString());
            }
        }
    }
}
