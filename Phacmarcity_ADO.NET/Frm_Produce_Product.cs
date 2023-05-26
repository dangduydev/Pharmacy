using Phacmarcity_ADO.NET.BS_layer;
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
using System.Data.SqlClient;

namespace Phacmarcity_ADO.NET
{
    public partial class Frm_Produce_Product : Form
    {
        DataTable dtPhieuXuat = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu
        bool Them;
        string err;
        BLProduce_Product dbTP = new BLProduce_Product();
        public Frm_Produce_Product()
        {
            InitializeComponent();
        }
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
                dtPhieuXuat = new DataTable();
                dtPhieuXuat.Clear();
                DataSet ds = dbTP.LayPhieuXuat();
                dtPhieuXuat = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView
                dgvPhieuXuat.DataSource = dtPhieuXuat;
                // Thay đổi độ rộng cột
                dgvPhieuXuat.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txtMaPX.ResetText();
                this.txtMaNhanVien.ResetText();
                this.txtMaKhachHang.ResetText();
                this.txtMaThuoc.ResetText();
                this.txtSoLuong.ResetText();
                this.txtGia.ResetText();
                this.dateTimePicker1.ResetText();
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
                dgvPhieuXuat_CellClick(null, null);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PhieuXuat. Lỗi rồi!!!");
            }
        }
        void LoadDataSearch(string input, string tukhoa)
        {
            try
            {
                /*dgvPhieuXuat.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;*/
                dtPhieuXuat = new DataTable();
                dtPhieuXuat.Clear();
                DataSet ds = dbTP.TimKiemPhieuXuat(input, tukhoa);
                dtPhieuXuat = ds.Tables[0];
                // Đưa dữ liệu lên DataGridView 
                dgvPhieuXuat.DataSource = dtPhieuXuat;
                // Thay đổi độ rộng cột 
                dgvPhieuXuat.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel 
                /*                this.txtMaPX.ResetText();
                                this.txtMaNhanVien.ResetText();*/
                // Không cho thao tác trên các nút Lưu / Hủy 
                this.btnSave.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát 
                this.btnAdd.Enabled = true;
                this.btnEdit.Enabled = true;
                this.btnDelete.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table PhieuXuat. Lỗi rồi!!!");

            }
        }


        private void Frm_Produce_Product_Load(object sender, EventArgs e)
        {
            pnlMain.Enabled = false;
            pnlSearch.Enabled = false;
            LoadData();
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

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvPhieuXuat.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaPX.Text =
            dgvPhieuXuat.Rows[r].Cells[0].Value.ToString();
            this.txtMaNhanVien.Text =
            dgvPhieuXuat.Rows[r].Cells[1].Value.ToString();
            this.txtMaKhachHang.Text =
            dgvPhieuXuat.Rows[r].Cells[2].Value.ToString();
            this.txtMaThuoc.Text =
            dgvPhieuXuat.Rows[r].Cells[5].Value.ToString();
            this.txtSoLuong.Text =
            dgvPhieuXuat.Rows[r].Cells[6].Value.ToString();
            this.txtGia.Text =
            dgvPhieuXuat.Rows[r].Cells[7].Value.ToString();
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
            this.txtMaPX.ResetText();
            this.txtMaNhanVien.ResetText();
            this.txtMaKhachHang.ResetText();
            this.txtMaThuoc.ResetText();
            this.txtSoLuong.ResetText();
            this.txtGia.ResetText();
            this.dateTimePicker1.ResetText();
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            /*            this.btnHuyBo.Enabled = true;*/
            this.pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = true;
            this.btnEdit.Enabled = true;
            this.btnDelete.Enabled = true;
            // Đưa con trỏ đến TextField txtThanhPho
            this.txtMaPX.Focus();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa
            Them = false;
            // Cho phép thao tác trên Panel
            this.pnlMain.Enabled = true;
            dgvPhieuXuat_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            this.btnSave.Enabled = true;
            this.pnlMain.Enabled = true;
            // Không cho thao tác trên các nút Thêm / Xóa / Thoát
            this.btnAdd.Enabled = false;
            this.btnEdit.Enabled = false;
            this.btnEdit.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaPX.Enabled = true;
            this.txtMaNhanVien.Focus();
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
                    BLProduce_Product blTp = new BLProduce_Product();
                    blTp.ThemPhieuXuat(this.txtMaPX.Text, this.txtMaNhanVien.Text, this.txtMaKhachHang.Text, this.txtMaThuoc.Text, this.txtSoLuong.Text, this.txtGia.Text, this.dateTimePicker1.Value, ref err);
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
                BLProduce_Product blTp = new BLProduce_Product();
                blTp.CapNhatPhieuXuat(this.txtMaPX.Text, this.txtMaNhanVien.Text, this.txtMaKhachHang.Text, this.txtMaThuoc.Text, this.txtSoLuong.Text, this.txtGia.Text, this.dateTimePicker1.Value, ref err);// Load lại dữ liệu trên DataGridView
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
                int r = dgvPhieuXuat.CurrentCell.RowIndex;
                // Lấy MaPX của record hiện hành
                string strPX =
                dgvPhieuXuat.Rows[r].Cells[0].Value.ToString();
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
                    dbTP.XoaPhieuXuat(ref err, strPX);
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

                string typeSearch = StringConvert.ConvertToEnumPhieuXuat(cbxTimKiem.SelectedItem.ToString());
                switch (typeSearch)
                {
                    case nameof(Cls_Enum.OptionPhieuXuat.MaPX):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionPhieuXuat.MaNhanVien):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionPhieuXuat.MaKhachHang):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    case nameof(Cls_Enum.OptionPhieuXuat.MaThuoc):
                        LoadDataSearch(typeSearch, txtTimKiem.Text);
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
