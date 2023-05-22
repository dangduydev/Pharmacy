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
using System.Data.SqlClient;
using Phacmarcity_ADO.NET.BS_layer;
using Phacmarcity_ADO.NET.DB_layer;
using Phacmarcity_ADO.NET.Class;
using Phacmarcity_ADO.NET.ENUM;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_Client : Form
    {
        DataTable dtKhachHang = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu 
        bool Them;
        string err;
        BLKhachHang dbTP = new BLKhachHang();
        public Frm_Client()
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
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                DataSet ds = dbTP.LayKhachHang();
                dtKhachHang = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvKhachHang.DataSource = dtKhachHang;
                // Thay đổi độ rộng cột 
                dgvKhachHang.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //this.txtKhachHang.ResetText();
                this.txtTenKhachHang.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                this.btnCancel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
                //
                //dgvKhachHang_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table KhachHang. Lỗi rồi!!!");
            }
        }

        void LoadDataSearch(string input, string key)
        {
            try
            {
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dtKhachHang = new DataTable();
                dtKhachHang.Clear();
                DataSet ds = dbTP.TimKiemKhachHang(input, key);
                dtKhachHang = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvKhachHang.DataSource = dtKhachHang;
                // Thay đổi độ rộng cột 
                dgvKhachHang.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                //this.txtKhachHang.ResetText();
                this.txtTenKhachHang.ResetText();
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
                MessageBox.Show("Không lấy được nội dung trong table KhachHang. Lỗi rồi!!!");

            }
        }

        #endregion

        #region Event

        private void Frm_Client_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlSearch.Enabled = false;
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pnlSearch.Enabled = true;
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
            // Đưa con trỏ đến TextField txtKhachHang 
            this.txtTenKhachHang.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa 
            Them = false;
            // Cho phép thao tác trên Panel 
            dgvKhachHang_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = true;
            this.btnCancel.Enabled = true;
            pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát 
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH 
            this.txtTenKhachHang.Focus();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành 
            int r = dgvKhachHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel 
            this.txtMaKhachHang.Text =
            dgvKhachHang.Rows[r].Cells[0].Value.ToString();
            this.txtTenKhachHang.Text =
            dgvKhachHang.Rows[r].Cells[1].Value.ToString();
            this.txtSDT.Text =
            dgvKhachHang.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChi.Text =
            dgvKhachHang.Rows[r].Cells[3].Value.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel 
            this.txtTenKhachHang.ResetText();
            // Cho thao tác trên các nút Thêm / Sửa / Xóa / Thoát 
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            // Không cho thao tác trên các nút Lưu / Hủy / Panel 
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            pnlMain.Enabled = false;
            dgvKhachHang_CellClick(null, null);
            reset();
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
                    BLKhachHang blTp = new BLKhachHang();
                    blTp.ThemKhachHang(this.txtMaKhachHang.Text, this.txtTenKhachHang.Text, this.txtSDT.Text, this.txtDiaChi.Text, ref err);
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
                BLKhachHang blTp = new BLKhachHang();
                blTp.CapNhatKhachHang(this.txtMaKhachHang.Text, this.txtTenKhachHang.Text, this.txtSDT.Text, this.txtDiaChi.Text, ref err);

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
                int r = dgvKhachHang.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành 
                string strKhachHang =
                dgvKhachHang.Rows[r].Cells[0].Value.ToString();
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
                    dbTP.XoaKhachHang(ref err, strKhachHang);
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

                string typeSearch = StringConvert.ConvertToEnumClient(cbxTimKiem.SelectedItem.ToString());
                switch (typeSearch)
                {
                    case nameof(Cls_Enum.OptionClient.MaKhachHang):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionClient.TenKhachHang):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionClient.SoDienThoai):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionClient.DiaChi):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    default:
                        break;
                }
            }
        }
        #endregion

    }
}
