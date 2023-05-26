namespace Phacmarcity_ADO.NET
{
    partial class Frm_Produce_Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label15 = new Label();
            picKhachHang = new PictureBox();
            label14 = new Label();
            picThuoc = new PictureBox();
            btnEdit = new Button();
            btnDelete = new Button();
            dateTimePicker1 = new DateTimePicker();
            label10 = new Label();
            label6 = new Label();
            txtGia = new TextBox();
            label9 = new Label();
            txtSoLuong = new TextBox();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            dgvPhieuXuat = new DataGridView();
            btnUpdate = new Button();
            btnAdd = new Button();
            label3 = new Label();
            label2 = new Label();
            txtMaPX = new TextBox();
            label1 = new Label();
            txtMaNhanVien = new TextBox();
            panel1 = new Panel();
            label16 = new Label();
            txtMaKhachHang = new TextBox();
            btnSearch = new Button();
            btnSave = new Button();
            dtpTimKiem = new DateTimePicker();
            cbxTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            label19 = new Label();
            pnlMain = new Panel();
            txtMaThuoc = new TextBox();
            pnlSearch = new Panel();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)picKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picThuoc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuat).BeginInit();
            panel1.SuspendLayout();
            pnlMain.SuspendLayout();
            pnlSearch.SuspendLayout();
            SuspendLayout();
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label15.ForeColor = Color.DarkCyan;
            label15.Location = new Point(350, 135);
            label15.Name = "label15";
            label15.Size = new Size(123, 28);
            label15.TabIndex = 148;
            label15.Text = "Khách hàng";
            // 
            // picKhachHang
            // 
            picKhachHang.BorderStyle = BorderStyle.FixedSingle;
            picKhachHang.Image = Properties.Resources.employee__1_;
            picKhachHang.Location = new Point(260, 135);
            picKhachHang.Name = "picKhachHang";
            picKhachHang.Size = new Size(63, 43);
            picKhachHang.SizeMode = PictureBoxSizeMode.Zoom;
            picKhachHang.TabIndex = 147;
            picKhachHang.TabStop = false;
            picKhachHang.Click += picKhachHang_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkCyan;
            label14.Location = new Point(141, 135);
            label14.Name = "label14";
            label14.Size = new Size(70, 28);
            label14.TabIndex = 146;
            label14.Text = "Thuốc";
            // 
            // picThuoc
            // 
            picThuoc.BorderStyle = BorderStyle.FixedSingle;
            picThuoc.Image = Properties.Resources.medicine;
            picThuoc.Location = new Point(61, 135);
            picThuoc.Name = "picThuoc";
            picThuoc.Size = new Size(63, 43);
            picThuoc.SizeMode = PictureBoxSizeMode.Zoom;
            picThuoc.TabIndex = 142;
            picThuoc.TabStop = false;
            picThuoc.Click += picThuoc_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkCyan;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(160, 687);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 51);
            btnEdit.TabIndex = 138;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkCyan;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(28, 687);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 51);
            btnDelete.TabIndex = 137;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.ImeMode = ImeMode.NoControl;
            dateTimePicker1.Location = new Point(3, 244);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 27);
            dateTimePicker1.TabIndex = 136;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.DarkCyan;
            label10.Location = new Point(25, 460);
            label10.Name = "label10";
            label10.Size = new Size(110, 28);
            label10.TabIndex = 135;
            label10.Text = "Ngày xuất";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.DarkCyan;
            label6.Location = new Point(25, 420);
            label6.Name = "label6";
            label6.Size = new Size(87, 28);
            label6.TabIndex = 134;
            label6.Text = "Đơn giá";
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtGia.Location = new Point(3, 204);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(169, 27);
            txtGia.TabIndex = 133;
            txtGia.Text = "VND";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkCyan;
            label9.Location = new Point(25, 380);
            label9.Name = "label9";
            label9.Size = new Size(97, 28);
            label9.TabIndex = 132;
            label9.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtSoLuong.Location = new Point(3, 164);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(169, 27);
            txtSoLuong.TabIndex = 131;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(25, 300);
            label8.Name = "label8";
            label8.Size = new Size(157, 28);
            label8.TabIndex = 129;
            label8.Text = "Mã khách hàng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(25, 260);
            label7.Name = "label7";
            label7.Size = new Size(141, 28);
            label7.TabIndex = 128;
            label7.Text = "Mã nhân viên";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 796);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 27);
            panel2.TabIndex = 126;
            // 
            // dgvPhieuXuat
            // 
            dgvPhieuXuat.BackgroundColor = SystemColors.ControlLight;
            dgvPhieuXuat.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhieuXuat.GridColor = Color.White;
            dgvPhieuXuat.Location = new Point(465, 223);
            dgvPhieuXuat.Name = "dgvPhieuXuat";
            dgvPhieuXuat.RowHeadersWidth = 51;
            dgvPhieuXuat.RowTemplate.Height = 29;
            dgvPhieuXuat.Size = new Size(800, 541);
            dgvPhieuXuat.TabIndex = 125;
            dgvPhieuXuat.CellClick += dgvPhieuXuat_CellClick;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.DarkCyan;
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(160, 622);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 51);
            btnUpdate.TabIndex = 124;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkCyan;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(27, 622);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 51);
            btnAdd.TabIndex = 123;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(25, 340);
            label3.Name = "label3";
            label3.Size = new Size(102, 28);
            label3.TabIndex = 117;
            label3.Text = "Mã thuốc";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(25, 220);
            label2.Name = "label2";
            label2.Size = new Size(149, 28);
            label2.TabIndex = 116;
            label2.Text = "Mã phiếu xuất";
            // 
            // txtMaPX
            // 
            txtMaPX.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaPX.Location = new Point(3, 4);
            txtMaPX.Name = "txtMaPX";
            txtMaPX.Size = new Size(169, 27);
            txtMaPX.TabIndex = 115;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(430, 35);
            label1.Name = "label1";
            label1.Size = new Size(400, 31);
            label1.TabIndex = 0;
            label1.Text = "Pharmacy Managerment Version 1.0";
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaNhanVien.Location = new Point(3, 44);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(169, 27);
            txtMaNhanVien.TabIndex = 127;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 109);
            panel1.TabIndex = 114;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = SystemColors.Control;
            label16.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.DarkCyan;
            label16.Location = new Point(775, 170);
            label16.Name = "label16";
            label16.Size = new Size(210, 50);
            label16.TabIndex = 149;
            label16.Text = "Phiếu Xuất";
            // 
            // txtMaKhachHang
            // 
            txtMaKhachHang.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaKhachHang.Location = new Point(3, 84);
            txtMaKhachHang.Name = "txtMaKhachHang";
            txtMaKhachHang.Size = new Size(169, 27);
            txtMaKhachHang.TabIndex = 150;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkCyan;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(28, 517);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 51);
            btnSearch.TabIndex = 152;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkCyan;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(291, 622);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 51);
            btnSave.TabIndex = 151;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // dtpTimKiem
            // 
            dtpTimKiem.CalendarFont = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dtpTimKiem.Format = DateTimePickerFormat.Short;
            dtpTimKiem.Location = new Point(2, 51);
            dtpTimKiem.Name = "dtpTimKiem";
            dtpTimKiem.Size = new Size(169, 27);
            dtpTimKiem.TabIndex = 165;
            // 
            // cbxTimKiem
            // 
            cbxTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTimKiem.FormattingEnabled = true;
            cbxTimKiem.Items.AddRange(new object[] { "Mã phiếu xuất", "Mã nhân viên", "Mã khách hàng", "Mã thuốc", "Số lượng", "Ngày xuất" });
            cbxTimKiem.Location = new Point(3, 3);
            cbxTimKiem.Name = "cbxTimKiem";
            cbxTimKiem.Size = new Size(169, 28);
            cbxTimKiem.TabIndex = 164;
            cbxTimKiem.SelectedIndexChanged += cbxTimKiem_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(3, 51);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(169, 27);
            txtTimKiem.TabIndex = 163;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label19.ForeColor = Color.DarkCyan;
            label19.Location = new Point(129, 544);
            label19.Name = "label19";
            label19.Size = new Size(0, 28);
            label19.TabIndex = 162;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(txtMaThuoc);
            pnlMain.Controls.Add(txtMaPX);
            pnlMain.Controls.Add(txtMaNhanVien);
            pnlMain.Controls.Add(txtSoLuong);
            pnlMain.Controls.Add(txtGia);
            pnlMain.Controls.Add(dateTimePicker1);
            pnlMain.Controls.Add(txtMaKhachHang);
            pnlMain.Location = new Point(217, 220);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(179, 281);
            pnlMain.TabIndex = 166;
            // 
            // txtMaThuoc
            // 
            txtMaThuoc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaThuoc.Location = new Point(5, 127);
            txtMaThuoc.Name = "txtMaThuoc";
            txtMaThuoc.Size = new Size(169, 27);
            txtMaThuoc.TabIndex = 151;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(cbxTimKiem);
            pnlSearch.Controls.Add(txtTimKiem);
            pnlSearch.Controls.Add(dtpTimKiem);
            pnlSearch.Location = new Point(217, 500);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(179, 84);
            pnlSearch.TabIndex = 167;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkCyan;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(291, 687);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 51);
            btnCancel.TabIndex = 193;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Frm_Produce_Product
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 823);
            Controls.Add(btnCancel);
            Controls.Add(pnlSearch);
            Controls.Add(pnlMain);
            Controls.Add(label19);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(picKhachHang);
            Controls.Add(label14);
            Controls.Add(picThuoc);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(label10);
            Controls.Add(label6);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(dgvPhieuXuat);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "Frm_Produce_Product";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Produce_Product";
            Load += Frm_Produce_Product_Load;
            ((System.ComponentModel.ISupportInitialize)picKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)picThuoc).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhieuXuat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label15;
        private PictureBox picKhachHang;
        private Label label14;
        private PictureBox picThuoc;
        private Button btnEdit;
        private Button btnDelete;
        private DateTimePicker dateTimePicker1;
        private Label label10;
        private Label label6;
        private TextBox txtGia;
        private Label label9;
        private TextBox txtSoLuong;
        private Label label8;
        private Label label7;
        private Panel panel2;
        private DataGridView dgvPhieuXuat;
        private Button btnUpdate;
        private Button btnAdd;
        private Label label3;
        private Label label2;
        private TextBox txtMaPX;
        private Label label1;
        private TextBox txtMaNhanVien;
        private Panel panel1;
        private Label label16;
        private TextBox txtMaKhachHang;
        private Button btnSearch;
        private Button btnSave;
        private DateTimePicker dtpTimKiem;
        private ComboBox cbxTimKiem;
        private TextBox txtTimKiem;
        private Label label19;
        private Panel pnlMain;
        private Panel pnlSearch;
        private Button btnCancel;
        private TextBox txtMaThuoc;
    }
}