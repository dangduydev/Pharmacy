namespace Phacmarcity_ADO.NET
{
    partial class Frm_Supplier
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
            label14 = new Label();
            picThuoc = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            btnEdit = new Button();
            btnDelete = new Button();
            label8 = new Label();
            label7 = new Label();
            txtTenNCC = new TextBox();
            btnUpdateNCC = new Button();
            btnAdd = new Button();
            label2 = new Label();
            txtMaNCC = new TextBox();
            label11 = new Label();
            dgvNhaCungCap = new DataGridView();
            panel2 = new Panel();
            txtDiaChiNCC = new TextBox();
            txtThongTinDD = new TextBox();
            label3 = new Label();
            btnSearch = new Button();
            btnSave = new Button();
            cbxTimKiem = new ComboBox();
            txtTimKiem = new TextBox();
            label19 = new Label();
            pnlMain = new Panel();
            pnlSearch = new Panel();
            label13 = new Label();
            picHangSX = new PictureBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)picThuoc).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            pnlMain.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHangSX).BeginInit();
            SuspendLayout();
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label14.ForeColor = Color.DarkCyan;
            label14.Location = new Point(139, 127);
            label14.Name = "label14";
            label14.Size = new Size(70, 28);
            label14.TabIndex = 90;
            label14.Text = "Thuốc";
            // 
            // picThuoc
            // 
            picThuoc.BorderStyle = BorderStyle.FixedSingle;
            picThuoc.Image = Properties.Resources.medicine;
            picThuoc.Location = new Point(59, 127);
            picThuoc.Name = "picThuoc";
            picThuoc.Size = new Size(63, 43);
            picThuoc.SizeMode = PictureBoxSizeMode.Zoom;
            picThuoc.TabIndex = 87;
            picThuoc.TabStop = false;
            picThuoc.Click += picThuoc_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1312, 109);
            panel1.TabIndex = 91;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DarkCyan;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(196, 665);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(113, 51);
            btnEdit.TabIndex = 101;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.DarkCyan;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(64, 665);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 51);
            btnDelete.TabIndex = 100;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.DarkCyan;
            label8.Location = new Point(35, 343);
            label8.Name = "label8";
            label8.Size = new Size(78, 28);
            label8.TabIndex = 98;
            label8.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(35, 295);
            label7.Name = "label7";
            label7.Size = new Size(177, 28);
            label7.TabIndex = 97;
            label7.Text = "Tên nhà cung cấp";
            // 
            // txtTenNCC
            // 
            txtTenNCC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTenNCC.Location = new Point(0, 52);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(169, 27);
            txtTenNCC.TabIndex = 96;
            // 
            // btnUpdateNCC
            // 
            btnUpdateNCC.BackColor = Color.DarkCyan;
            btnUpdateNCC.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateNCC.ForeColor = Color.White;
            btnUpdateNCC.Location = new Point(196, 600);
            btnUpdateNCC.Name = "btnUpdateNCC";
            btnUpdateNCC.Size = new Size(113, 51);
            btnUpdateNCC.TabIndex = 95;
            btnUpdateNCC.Text = "Cập nhật";
            btnUpdateNCC.UseVisualStyleBackColor = false;
            btnUpdateNCC.Click += btnUpdateNCC_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.DarkCyan;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(63, 600);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(113, 51);
            btnAdd.TabIndex = 94;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkCyan;
            label2.Location = new Point(35, 243);
            label2.Name = "label2";
            label2.Size = new Size(174, 28);
            label2.TabIndex = 93;
            label2.Text = "Mã nhà cung cấp";
            // 
            // txtMaNCC
            // 
            txtMaNCC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMaNCC.Location = new Point(0, 0);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(169, 27);
            txtMaNCC.TabIndex = 92;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = SystemColors.Control;
            label11.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label11.ForeColor = Color.DarkCyan;
            label11.Location = new Point(765, 181);
            label11.Name = "label11";
            label11.Size = new Size(259, 50);
            label11.TabIndex = 104;
            label11.Text = "Nhà cung cấp";
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.BackgroundColor = SystemColors.ControlLight;
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.GridColor = Color.White;
            dgvNhaCungCap.Location = new Point(515, 248);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.RowHeadersWidth = 51;
            dgvNhaCungCap.RowTemplate.Height = 29;
            dgvNhaCungCap.Size = new Size(754, 513);
            dgvNhaCungCap.TabIndex = 103;
            dgvNhaCungCap.CellClick += dgvNhaCungCap_CellClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkCyan;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 796);
            panel2.Name = "panel2";
            panel2.Size = new Size(1312, 27);
            panel2.TabIndex = 102;
            // 
            // txtDiaChiNCC
            // 
            txtDiaChiNCC.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtDiaChiNCC.Location = new Point(0, 100);
            txtDiaChiNCC.Name = "txtDiaChiNCC";
            txtDiaChiNCC.Size = new Size(169, 27);
            txtDiaChiNCC.TabIndex = 107;
            // 
            // txtThongTinDD
            // 
            txtThongTinDD.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtThongTinDD.Location = new Point(0, 151);
            txtThongTinDD.Name = "txtThongTinDD";
            txtThongTinDD.Size = new Size(169, 27);
            txtThongTinDD.TabIndex = 109;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkCyan;
            label3.Location = new Point(35, 394);
            label3.Name = "label3";
            label3.Size = new Size(187, 28);
            label3.TabIndex = 108;
            label3.Text = "Thông tin đại diện";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkCyan;
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(35, 456);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(113, 51);
            btnSearch.TabIndex = 154;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DarkCyan;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(329, 600);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(113, 51);
            btnSave.TabIndex = 153;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cbxTimKiem
            // 
            cbxTimKiem.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTimKiem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTimKiem.FormattingEnabled = true;
            cbxTimKiem.Items.AddRange(new object[] { "Mã nhà cung cấp", "Tên nhà cung cấp", "Địa chỉ", "Thông tin địa diện" });
            cbxTimKiem.Location = new Point(3, 3);
            cbxTimKiem.Name = "cbxTimKiem";
            cbxTimKiem.Size = new Size(169, 28);
            cbxTimKiem.TabIndex = 164;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtTimKiem.Location = new Point(3, 55);
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
            label19.Location = new Point(128, 498);
            label19.Name = "label19";
            label19.Size = new Size(0, 28);
            label19.TabIndex = 162;
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(txtMaNCC);
            pnlMain.Controls.Add(txtTenNCC);
            pnlMain.Controls.Add(txtDiaChiNCC);
            pnlMain.Controls.Add(txtThongTinDD);
            pnlMain.Location = new Point(261, 247);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(181, 179);
            pnlMain.TabIndex = 165;
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(cbxTimKiem);
            pnlSearch.Controls.Add(txtTimKiem);
            pnlSearch.Location = new Point(261, 442);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(181, 96);
            pnlSearch.TabIndex = 166;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.DarkCyan;
            label13.Location = new Point(343, 127);
            label13.Name = "label13";
            label13.Size = new Size(148, 28);
            label13.TabIndex = 188;
            label13.Text = "Hãng sản xuất";
            // 
            // picHangSX
            // 
            picHangSX.BorderStyle = BorderStyle.FixedSingle;
            picHangSX.Image = Properties.Resources.production;
            picHangSX.Location = new Point(261, 127);
            picHangSX.Name = "picHangSX";
            picHangSX.Size = new Size(63, 43);
            picHangSX.SizeMode = PictureBoxSizeMode.Zoom;
            picHangSX.TabIndex = 187;
            picHangSX.TabStop = false;
            picHangSX.Click += picHangSX_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DarkCyan;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(329, 665);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 51);
            btnCancel.TabIndex = 193;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Frm_Supplier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 823);
            Controls.Add(btnCancel);
            Controls.Add(label13);
            Controls.Add(picHangSX);
            Controls.Add(pnlSearch);
            Controls.Add(pnlMain);
            Controls.Add(label19);
            Controls.Add(btnSearch);
            Controls.Add(btnSave);
            Controls.Add(label3);
            Controls.Add(label11);
            Controls.Add(dgvNhaCungCap);
            Controls.Add(panel2);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnUpdateNCC);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label14);
            Controls.Add(picThuoc);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Frm_Supplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier";
            Load += Frm_Supplier_Load;
            ((System.ComponentModel.ISupportInitialize)picThuoc).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHangSX).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label14;
        private PictureBox picThuoc;
        private Label label1;
        private Panel panel1;
        private Button btnEdit;
        private Button btnDelete;
        private Label label8;
        private Label label7;
        private TextBox txtTenNCC;
        private Button btnUpdateNCC;
        private Button btnAdd;
        private Label label2;
        private TextBox txtMaNCC;
        private Label label11;
        private DataGridView dgvNhaCungCap;
        private Panel panel2;
        private TextBox txtDiaChiNCC;
        private TextBox txtThongTinDD;
        private Label label3;
        private Button btnSearch;
        private Button btnSave;
        private ComboBox cbxTimKiem;
        private TextBox txtTimKiem;
        private Label label19;
        private Panel pnlMain;
        private Panel pnlSearch;
        private Label label13;
        private PictureBox picHangSX;
        private Button btnCancel;
    }
}