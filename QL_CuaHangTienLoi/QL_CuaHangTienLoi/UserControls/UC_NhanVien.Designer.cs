namespace QL_CuaHangTienLoi.UserControls
{
    partial class UC_NhanVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.txtFindSoDT = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.cbFindGioiTinh = new System.Windows.Forms.ComboBox();
            this.txtFindTenNV = new System.Windows.Forms.TextBox();
            this.chbSoDT = new System.Windows.Forms.CheckBox();
            this.chbGioiTinh = new System.Windows.Forms.CheckBox();
            this.chbFindTenNV = new System.Windows.Forms.CheckBox();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.btnCapTK = new System.Windows.Forms.Button();
            this.gbContractsAndAccount = new System.Windows.Forms.GroupBox();
            this.btnSuaTaiKhoan = new System.Windows.Forms.Button();
            this.btnDeleteTaiKhoan = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.btnLoadTTTK = new System.Windows.Forms.Button();
            this.dtPickNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picNhanVien = new System.Windows.Forms.PictureBox();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.gbDetail.SuspendLayout();
            this.gbContractsAndAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.LightSalmon;
            this.gbFilter.Controls.Add(this.dgvNhanVien);
            this.gbFilter.Controls.Add(this.txtFindSoDT);
            this.gbFilter.Controls.Add(this.btnAddNew);
            this.gbFilter.Controls.Add(this.btnReload);
            this.gbFilter.Controls.Add(this.btnDelete);
            this.gbFilter.Controls.Add(this.btnEditNV);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.btnClear);
            this.gbFilter.Controls.Add(this.cbFindGioiTinh);
            this.gbFilter.Controls.Add(this.txtFindTenNV);
            this.gbFilter.Controls.Add(this.chbSoDT);
            this.gbFilter.Controls.Add(this.chbGioiTinh);
            this.gbFilter.Controls.Add(this.chbFindTenNV);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Padding = new System.Windows.Forms.Padding(0);
            this.gbFilter.Size = new System.Drawing.Size(697, 879);
            this.gbFilter.TabIndex = 1;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Lọc thông tin";
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.EnableHeadersVisualStyles = false;
            this.dgvNhanVien.Location = new System.Drawing.Point(13, 202);
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 51;
            this.dgvNhanVien.Size = new System.Drawing.Size(661, 590);
            this.dgvNhanVien.TabIndex = 32;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // txtFindSoDT
            // 
            this.txtFindSoDT.Location = new System.Drawing.Point(205, 112);
            this.txtFindSoDT.Name = "txtFindSoDT";
            this.txtFindSoDT.Size = new System.Drawing.Size(475, 26);
            this.txtFindSoDT.TabIndex = 25;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(19, 812);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(183, 36);
            this.btnAddNew.TabIndex = 21;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(16, 160);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(183, 37);
            this.btnReload.TabIndex = 20;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(497, 812);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 36);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa thông tin";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditNV
            // 
            this.btnEditNV.Location = new System.Drawing.Point(235, 812);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(231, 36);
            this.btnEditNV.TabIndex = 31;
            this.btnEditNV.Text = "Sửa thông tin nhân viên";
            this.btnEditNV.UseVisualStyleBackColor = true;
            this.btnEditNV.Click += new System.EventHandler(this.btnEditNV_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(494, 160);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(183, 36);
            this.btnFind.TabIndex = 18;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(305, 160);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 36);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Làm trống";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cbFindGioiTinh
            // 
            this.cbFindGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindGioiTinh.FormattingEnabled = true;
            this.cbFindGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbFindGioiTinh.Location = new System.Drawing.Point(205, 72);
            this.cbFindGioiTinh.Name = "cbFindGioiTinh";
            this.cbFindGioiTinh.Size = new System.Drawing.Size(176, 28);
            this.cbFindGioiTinh.TabIndex = 10;
            // 
            // txtFindTenNV
            // 
            this.txtFindTenNV.Location = new System.Drawing.Point(205, 37);
            this.txtFindTenNV.Name = "txtFindTenNV";
            this.txtFindTenNV.Size = new System.Drawing.Size(475, 26);
            this.txtFindTenNV.TabIndex = 8;
            // 
            // chbSoDT
            // 
            this.chbSoDT.AutoSize = true;
            this.chbSoDT.Checked = true;
            this.chbSoDT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbSoDT.Location = new System.Drawing.Point(16, 114);
            this.chbSoDT.Name = "chbSoDT";
            this.chbSoDT.Size = new System.Drawing.Size(136, 24);
            this.chbSoDT.TabIndex = 5;
            this.chbSoDT.Text = "Số Điện Thoại";
            this.chbSoDT.UseVisualStyleBackColor = true;
            // 
            // chbGioiTinh
            // 
            this.chbGioiTinh.AutoSize = true;
            this.chbGioiTinh.Checked = true;
            this.chbGioiTinh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGioiTinh.Location = new System.Drawing.Point(16, 77);
            this.chbGioiTinh.Name = "chbGioiTinh";
            this.chbGioiTinh.Size = new System.Drawing.Size(93, 24);
            this.chbGioiTinh.TabIndex = 3;
            this.chbGioiTinh.Text = "Giới tính";
            this.chbGioiTinh.UseVisualStyleBackColor = true;
            // 
            // chbFindTenNV
            // 
            this.chbFindTenNV.AutoSize = true;
            this.chbFindTenNV.Checked = true;
            this.chbFindTenNV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFindTenNV.Location = new System.Drawing.Point(16, 36);
            this.chbFindTenNV.Name = "chbFindTenNV";
            this.chbFindTenNV.Size = new System.Drawing.Size(135, 24);
            this.chbFindTenNV.TabIndex = 0;
            this.chbFindTenNV.Text = "Tên nhân viên";
            this.chbFindTenNV.UseVisualStyleBackColor = true;
            // 
            // gbDetail
            // 
            this.gbDetail.BackColor = System.Drawing.Color.LightSalmon;
            this.gbDetail.Controls.Add(this.txtDiaChi);
            this.gbDetail.Controls.Add(this.txtSoDT);
            this.gbDetail.Controls.Add(this.btnCapTK);
            this.gbDetail.Controls.Add(this.gbContractsAndAccount);
            this.gbDetail.Controls.Add(this.txtGioiTinh);
            this.gbDetail.Controls.Add(this.btnLoadTTTK);
            this.gbDetail.Controls.Add(this.dtPickNgaySinh);
            this.gbDetail.Controls.Add(this.txtEmail);
            this.gbDetail.Controls.Add(this.txtTenNV);
            this.gbDetail.Controls.Add(this.label8);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.picNhanVien);
            this.gbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.Location = new System.Drawing.Point(697, 0);
            this.gbDetail.Margin = new System.Windows.Forms.Padding(0);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Padding = new System.Windows.Forms.Padding(0);
            this.gbDetail.Size = new System.Drawing.Size(683, 879);
            this.gbDetail.TabIndex = 2;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Thông tin nhân viên và hợp đồng";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(307, 157);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(338, 26);
            this.txtDiaChi.TabIndex = 38;
            // 
            // txtSoDT
            // 
            this.txtSoDT.Location = new System.Drawing.Point(307, 198);
            this.txtSoDT.Mask = "0000-000-000";
            this.txtSoDT.Name = "txtSoDT";
            this.txtSoDT.ReadOnly = true;
            this.txtSoDT.Size = new System.Drawing.Size(187, 26);
            this.txtSoDT.TabIndex = 37;
            // 
            // btnCapTK
            // 
            this.btnCapTK.Location = new System.Drawing.Point(356, 314);
            this.btnCapTK.Name = "btnCapTK";
            this.btnCapTK.Size = new System.Drawing.Size(289, 36);
            this.btnCapTK.TabIndex = 35;
            this.btnCapTK.Text = "Cấp tài khoản";
            this.btnCapTK.UseVisualStyleBackColor = true;
            this.btnCapTK.Click += new System.EventHandler(this.btnCapTK_Click);
            // 
            // gbContractsAndAccount
            // 
            this.gbContractsAndAccount.BackColor = System.Drawing.Color.Salmon;
            this.gbContractsAndAccount.Controls.Add(this.btnSuaTaiKhoan);
            this.gbContractsAndAccount.Controls.Add(this.btnDeleteTaiKhoan);
            this.gbContractsAndAccount.Controls.Add(this.btnShowPassword);
            this.gbContractsAndAccount.Controls.Add(this.label10);
            this.gbContractsAndAccount.Controls.Add(this.label9);
            this.gbContractsAndAccount.Controls.Add(this.txtPassword);
            this.gbContractsAndAccount.Controls.Add(this.txtTaiKhoan);
            this.gbContractsAndAccount.Location = new System.Drawing.Point(28, 374);
            this.gbContractsAndAccount.Name = "gbContractsAndAccount";
            this.gbContractsAndAccount.Size = new System.Drawing.Size(629, 180);
            this.gbContractsAndAccount.TabIndex = 34;
            this.gbContractsAndAccount.TabStop = false;
            this.gbContractsAndAccount.Text = "Thông tin tài khoản";
            // 
            // btnSuaTaiKhoan
            // 
            this.btnSuaTaiKhoan.Location = new System.Drawing.Point(222, 129);
            this.btnSuaTaiKhoan.Name = "btnSuaTaiKhoan";
            this.btnSuaTaiKhoan.Size = new System.Drawing.Size(182, 36);
            this.btnSuaTaiKhoan.TabIndex = 40;
            this.btnSuaTaiKhoan.Text = "Sửa tài khoản";
            this.btnSuaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnSuaTaiKhoan.Click += new System.EventHandler(this.btnSuaTaiKhoan_Click);
            // 
            // btnDeleteTaiKhoan
            // 
            this.btnDeleteTaiKhoan.Location = new System.Drawing.Point(422, 130);
            this.btnDeleteTaiKhoan.Name = "btnDeleteTaiKhoan";
            this.btnDeleteTaiKhoan.Size = new System.Drawing.Size(176, 36);
            this.btnDeleteTaiKhoan.TabIndex = 39;
            this.btnDeleteTaiKhoan.Text = "Xoá tài khoản";
            this.btnDeleteTaiKhoan.UseVisualStyleBackColor = true;
            this.btnDeleteTaiKhoan.Click += new System.EventHandler(this.btnDeleteTaiKhoan_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Location = new System.Drawing.Point(43, 132);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(164, 33);
            this.btnShowPassword.TabIndex = 35;
            this.btnShowPassword.Text = "Hiện mật khẩu";
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 20);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mật khẩu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "Tài khoản";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(154, 88);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(444, 26);
            this.txtPassword.TabIndex = 33;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(154, 42);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.ReadOnly = true;
            this.txtTaiKhoan.Size = new System.Drawing.Size(444, 26);
            this.txtTaiKhoan.TabIndex = 32;
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.Location = new System.Drawing.Point(307, 75);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(187, 26);
            this.txtGioiTinh.TabIndex = 33;
            // 
            // btnLoadTTTK
            // 
            this.btnLoadTTTK.Location = new System.Drawing.Point(28, 314);
            this.btnLoadTTTK.Name = "btnLoadTTTK";
            this.btnLoadTTTK.Size = new System.Drawing.Size(252, 36);
            this.btnLoadTTTK.TabIndex = 32;
            this.btnLoadTTTK.Text = "Tải thông tin tài khoản";
            this.btnLoadTTTK.UseVisualStyleBackColor = true;
            this.btnLoadTTTK.Click += new System.EventHandler(this.btnLoadTTTK_Click);
            // 
            // dtPickNgaySinh
            // 
            this.dtPickNgaySinh.Enabled = false;
            this.dtPickNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickNgaySinh.Location = new System.Drawing.Point(307, 115);
            this.dtPickNgaySinh.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtPickNgaySinh.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtPickNgaySinh.Name = "dtPickNgaySinh";
            this.dtPickNgaySinh.Size = new System.Drawing.Size(186, 26);
            this.dtPickNgaySinh.TabIndex = 29;
            this.dtPickNgaySinh.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(307, 242);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(338, 26);
            this.txtEmail.TabIndex = 26;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(307, 33);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.ReadOnly = true;
            this.txtTenNV.Size = new System.Drawing.Size(338, 26);
            this.txtTenNV.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Điện thoại";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // picNhanVien
            // 
            this.picNhanVien.BackColor = System.Drawing.Color.Linen;
            this.picNhanVien.Location = new System.Drawing.Point(16, 37);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Size = new System.Drawing.Size(168, 224);
            this.picNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNhanVien.TabIndex = 0;
            this.picNhanVien.TabStop = false;
            // 
            // UC_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.gbFilter);
            this.Name = "UC_NhanVien";
            this.Size = new System.Drawing.Size(1374, 879);
            this.Load += new System.EventHandler(this.UC_NhanVien_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.gbContractsAndAccount.ResumeLayout(false);
            this.gbContractsAndAccount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtFindTenNV;
        private System.Windows.Forms.CheckBox chbFindTenNV;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.TextBox txtGioiTinh;
        private System.Windows.Forms.Button btnLoadTTTK;
        private System.Windows.Forms.Button btnEditNV;
        private System.Windows.Forms.DateTimePicker dtPickNgaySinh;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picNhanVien;
        private System.Windows.Forms.CheckBox chbSoDT;
        private System.Windows.Forms.TextBox txtFindSoDT;
        private System.Windows.Forms.GroupBox gbContractsAndAccount;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.Button btnCapTK;
        private System.Windows.Forms.DataGridView dgvNhanVien;
        private System.Windows.Forms.MaskedTextBox txtSoDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnDeleteTaiKhoan;
        private System.Windows.Forms.Button btnSuaTaiKhoan;
        private System.Windows.Forms.ComboBox cbFindGioiTinh;
        private System.Windows.Forms.CheckBox chbGioiTinh;
    }
}
