namespace QL_CuaHangTienLoi.UserControls
{
    partial class UC_BanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cbFindNCC = new System.Windows.Forms.ComboBox();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnChonSP = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numUDTo = new System.Windows.Forms.NumericUpDown();
            this.numUDFrom = new System.Windows.Forms.NumericUpDown();
            this.cbFindLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtFindTenSP = new System.Windows.Forms.TextBox();
            this.chbLoaiSP = new System.Windows.Forms.CheckBox();
            this.chbNCC = new System.Windows.Forms.CheckBox();
            this.chbGia = new System.Windows.Forms.CheckBox();
            this.chbFindTenSP = new System.Windows.Forms.CheckBox();
            this.gbMakeBill = new System.Windows.Forms.GroupBox();
            this.btnMakeBills = new System.Windows.Forms.Button();
            this.btnCancelBill = new System.Windows.Forms.Button();
            this.gbListProduct = new System.Windows.Forms.GroupBox();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.dtpNgayTao = new System.Windows.Forms.DateTimePicker();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).BeginInit();
            this.gbMakeBill.SuspendLayout();
            this.gbListProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.SuspendLayout();
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.Aqua;
            this.gbFilter.Controls.Add(this.txtGiamGia);
            this.gbFilter.Controls.Add(this.label8);
            this.gbFilter.Controls.Add(this.label7);
            this.gbFilter.Controls.Add(this.numSL);
            this.gbFilter.Controls.Add(this.cbFindNCC);
            this.gbFilter.Controls.Add(this.dgvProduct);
            this.gbFilter.Controls.Add(this.btnReload);
            this.gbFilter.Controls.Add(this.btnScan);
            this.gbFilter.Controls.Add(this.btnChonSP);
            this.gbFilter.Controls.Add(this.btnFind);
            this.gbFilter.Controls.Add(this.btnClear);
            this.gbFilter.Controls.Add(this.label1);
            this.gbFilter.Controls.Add(this.numUDTo);
            this.gbFilter.Controls.Add(this.numUDFrom);
            this.gbFilter.Controls.Add(this.cbFindLoaiSP);
            this.gbFilter.Controls.Add(this.txtFindTenSP);
            this.gbFilter.Controls.Add(this.chbLoaiSP);
            this.gbFilter.Controls.Add(this.chbNCC);
            this.gbFilter.Controls.Add(this.chbGia);
            this.gbFilter.Controls.Add(this.chbFindTenSP);
            this.gbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Margin = new System.Windows.Forms.Padding(0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(697, 879);
            this.gbFilter.TabIndex = 4;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Lọc thông tin";
            // 
            // cbFindNCC
            // 
            this.cbFindNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindNCC.FormattingEnabled = true;
            this.cbFindNCC.Location = new System.Drawing.Point(201, 141);
            this.cbFindNCC.Name = "cbFindNCC";
            this.cbFindNCC.Size = new System.Drawing.Size(475, 28);
            this.cbFindNCC.TabIndex = 35;
            // 
            // dgvProduct
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.Location = new System.Drawing.Point(15, 281);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.Size = new System.Drawing.Size(661, 469);
            this.dgvProduct.TabIndex = 34;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(15, 239);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(183, 36);
            this.btnReload.TabIndex = 33;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(15, 812);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(275, 36);
            this.btnScan.TabIndex = 32;
            this.btnScan.Text = "Dùng máy quét";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // btnChonSP
            // 
            this.btnChonSP.Location = new System.Drawing.Point(401, 812);
            this.btnChonSP.Name = "btnChonSP";
            this.btnChonSP.Size = new System.Drawing.Size(275, 36);
            this.btnChonSP.TabIndex = 29;
            this.btnChonSP.Text = "Chọn sản phẩm";
            this.btnChonSP.UseVisualStyleBackColor = true;
            this.btnChonSP.Click += new System.EventHandler(this.btnChonSP_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(493, 239);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(183, 36);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(304, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 36);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Làm trống";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "đến";
            // 
            // numUDTo
            // 
            this.numUDTo.Location = new System.Drawing.Point(403, 91);
            this.numUDTo.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numUDTo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDTo.Name = "numUDTo";
            this.numUDTo.Size = new System.Drawing.Size(107, 26);
            this.numUDTo.TabIndex = 24;
            this.numUDTo.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numUDFrom
            // 
            this.numUDFrom.Location = new System.Drawing.Point(201, 91);
            this.numUDFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDFrom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDFrom.Name = "numUDFrom";
            this.numUDFrom.Size = new System.Drawing.Size(107, 26);
            this.numUDFrom.TabIndex = 23;
            this.numUDFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbFindLoaiSP
            // 
            this.cbFindLoaiSP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFindLoaiSP.FormattingEnabled = true;
            this.cbFindLoaiSP.Location = new System.Drawing.Point(201, 187);
            this.cbFindLoaiSP.Name = "cbFindLoaiSP";
            this.cbFindLoaiSP.Size = new System.Drawing.Size(475, 28);
            this.cbFindLoaiSP.TabIndex = 22;
            // 
            // txtFindTenSP
            // 
            this.txtFindTenSP.Location = new System.Drawing.Point(201, 43);
            this.txtFindTenSP.Name = "txtFindTenSP";
            this.txtFindTenSP.Size = new System.Drawing.Size(475, 26);
            this.txtFindTenSP.TabIndex = 20;
            // 
            // chbLoaiSP
            // 
            this.chbLoaiSP.AutoSize = true;
            this.chbLoaiSP.Checked = true;
            this.chbLoaiSP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLoaiSP.Location = new System.Drawing.Point(15, 189);
            this.chbLoaiSP.Name = "chbLoaiSP";
            this.chbLoaiSP.Size = new System.Drawing.Size(141, 24);
            this.chbLoaiSP.TabIndex = 19;
            this.chbLoaiSP.Text = "Loại sản phẩm";
            this.chbLoaiSP.UseVisualStyleBackColor = true;
            // 
            // chbNCC
            // 
            this.chbNCC.AutoSize = true;
            this.chbNCC.Checked = true;
            this.chbNCC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbNCC.Location = new System.Drawing.Point(15, 141);
            this.chbNCC.Name = "chbNCC";
            this.chbNCC.Size = new System.Drawing.Size(134, 24);
            this.chbNCC.TabIndex = 18;
            this.chbNCC.Text = "Nhà cung cấp";
            this.chbNCC.UseVisualStyleBackColor = true;
            // 
            // chbGia
            // 
            this.chbGia.AutoSize = true;
            this.chbGia.Checked = true;
            this.chbGia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbGia.Location = new System.Drawing.Point(15, 93);
            this.chbGia.Name = "chbGia";
            this.chbGia.Size = new System.Drawing.Size(114, 24);
            this.chbGia.TabIndex = 17;
            this.chbGia.Text = "Giá (nghìn)";
            this.chbGia.UseVisualStyleBackColor = true;
            // 
            // chbFindTenSP
            // 
            this.chbFindTenSP.AutoSize = true;
            this.chbFindTenSP.Checked = true;
            this.chbFindTenSP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbFindTenSP.Location = new System.Drawing.Point(15, 45);
            this.chbFindTenSP.Name = "chbFindTenSP";
            this.chbFindTenSP.Size = new System.Drawing.Size(137, 24);
            this.chbFindTenSP.TabIndex = 16;
            this.chbFindTenSP.Text = "Tên sản phẩm";
            this.chbFindTenSP.UseVisualStyleBackColor = true;
            // 
            // gbMakeBill
            // 
            this.gbMakeBill.BackColor = System.Drawing.Color.Aqua;
            this.gbMakeBill.Controls.Add(this.btnMakeBills);
            this.gbMakeBill.Controls.Add(this.btnCancelBill);
            this.gbMakeBill.Controls.Add(this.gbListProduct);
            this.gbMakeBill.Controls.Add(this.dtpNgayTao);
            this.gbMakeBill.Controls.Add(this.txtMaHD);
            this.gbMakeBill.Controls.Add(this.txtTongTien);
            this.gbMakeBill.Controls.Add(this.label5);
            this.gbMakeBill.Controls.Add(this.label6);
            this.gbMakeBill.Controls.Add(this.label4);
            this.gbMakeBill.Controls.Add(this.label3);
            this.gbMakeBill.Controls.Add(this.label2);
            this.gbMakeBill.Controls.Add(this.cboKhach);
            this.gbMakeBill.Controls.Add(this.cboNhanVien);
            this.gbMakeBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbMakeBill.Location = new System.Drawing.Point(697, 0);
            this.gbMakeBill.Margin = new System.Windows.Forms.Padding(0);
            this.gbMakeBill.Name = "gbMakeBill";
            this.gbMakeBill.Size = new System.Drawing.Size(677, 879);
            this.gbMakeBill.TabIndex = 5;
            this.gbMakeBill.TabStop = false;
            this.gbMakeBill.Text = "Tạo hóa đơn bán hàng";
            // 
            // btnMakeBills
            // 
            this.btnMakeBills.Location = new System.Drawing.Point(468, 812);
            this.btnMakeBills.Name = "btnMakeBills";
            this.btnMakeBills.Size = new System.Drawing.Size(183, 36);
            this.btnMakeBills.TabIndex = 38;
            this.btnMakeBills.Text = "Tạo hóa đơn";
            this.btnMakeBills.UseVisualStyleBackColor = true;
            this.btnMakeBills.Click += new System.EventHandler(this.btnMakeBills_Click);
            // 
            // btnCancelBill
            // 
            this.btnCancelBill.Location = new System.Drawing.Point(22, 812);
            this.btnCancelBill.Name = "btnCancelBill";
            this.btnCancelBill.Size = new System.Drawing.Size(183, 36);
            this.btnCancelBill.TabIndex = 32;
            this.btnCancelBill.Text = "Hủy hóa đơn";
            this.btnCancelBill.UseVisualStyleBackColor = true;
            this.btnCancelBill.Click += new System.EventHandler(this.btnCancelBill_Click);
            // 
            // gbListProduct
            // 
            this.gbListProduct.Controls.Add(this.dgvCTHD);
            this.gbListProduct.Location = new System.Drawing.Point(22, 281);
            this.gbListProduct.Name = "gbListProduct";
            this.gbListProduct.Size = new System.Drawing.Size(629, 525);
            this.gbListProduct.TabIndex = 37;
            this.gbListProduct.TabStop = false;
            this.gbListProduct.Text = "Danh sách sản phẩm và in hóa đơn";
            // 
            // dgvCTHD
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.EnableHeadersVisualStyles = false;
            this.dgvCTHD.Location = new System.Drawing.Point(6, 21);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.Size = new System.Drawing.Size(617, 498);
            this.dgvCTHD.TabIndex = 34;
            // 
            // dtpNgayTao
            // 
            this.dtpNgayTao.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpNgayTao.Enabled = false;
            this.dtpNgayTao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayTao.Location = new System.Drawing.Point(189, 138);
            this.dtpNgayTao.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpNgayTao.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dtpNgayTao.Name = "dtpNgayTao";
            this.dtpNgayTao.Size = new System.Drawing.Size(351, 26);
            this.dtpNgayTao.TabIndex = 36;
            this.dtpNgayTao.Value = new System.DateTime(2022, 2, 4, 0, 0, 0, 0);
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(189, 90);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(351, 26);
            this.txtMaHD.TabIndex = 34;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(189, 187);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(351, 26);
            this.txtTongTien.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tổng tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ngày tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhân viên";
            // 
            // numSL
            // 
            this.numSL.Location = new System.Drawing.Point(569, 774);
            this.numSL.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(107, 26);
            this.numSL.TabIndex = 36;
            this.numSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 776);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "Số lượng mua";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 776);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Giảm giá";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(93, 773);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(128, 26);
            this.txtGiamGia.TabIndex = 38;
            this.txtGiamGia.Text = "0";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(189, 43);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(446, 28);
            this.cboNhanVien.TabIndex = 22;
            // 
            // cboKhach
            // 
            this.cboKhach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhach.FormattingEnabled = true;
            this.cboKhach.Location = new System.Drawing.Point(189, 231);
            this.cboKhach.Name = "cboKhach";
            this.cboKhach.Size = new System.Drawing.Size(446, 28);
            this.cboKhach.TabIndex = 22;
            // 
            // UC_BanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMakeBill);
            this.Controls.Add(this.gbFilter);
            this.Name = "UC_BanHang";
            this.Size = new System.Drawing.Size(1374, 879);
            this.Load += new System.EventHandler(this.UC_BanHang_Load);
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).EndInit();
            this.gbMakeBill.ResumeLayout(false);
            this.gbMakeBill.PerformLayout();
            this.gbListProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.GroupBox gbMakeBill;
        private System.Windows.Forms.Button btnMakeBills;
        private System.Windows.Forms.Button btnCancelBill;
        private System.Windows.Forms.GroupBox gbListProduct;
        private System.Windows.Forms.DateTimePicker dtpNgayTao;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnChonSP;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numUDTo;
        private System.Windows.Forms.NumericUpDown numUDFrom;
        private System.Windows.Forms.ComboBox cbFindLoaiSP;
        private System.Windows.Forms.TextBox txtFindTenSP;
        private System.Windows.Forms.CheckBox chbLoaiSP;
        private System.Windows.Forms.CheckBox chbNCC;
        private System.Windows.Forms.CheckBox chbGia;
        private System.Windows.Forms.CheckBox chbFindTenSP;
        private System.Windows.Forms.ComboBox cbFindNCC;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboKhach;
        private System.Windows.Forms.ComboBox cboNhanVien;
    }
}
