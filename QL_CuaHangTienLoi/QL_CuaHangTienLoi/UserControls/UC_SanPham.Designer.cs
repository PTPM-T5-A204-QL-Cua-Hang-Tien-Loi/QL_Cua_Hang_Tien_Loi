namespace QL_CuaHangTienLoi.UserControls
{
    partial class UC_SanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.btnLoadSupplier = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.gbSupplier = new System.Windows.Forms.GroupBox();
            this.btnSeeMoreSupplier = new System.Windows.Forms.Button();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.gbProductOfSupplier = new System.Windows.Forms.GroupBox();
            this.dgvProductOfSupplier = new System.Windows.Forms.DataGridView();
            this.txtSDTNCC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmailNCC = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaChiNCC = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.picSanPham = new System.Windows.Forms.PictureBox();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.cbFindNCC = new System.Windows.Forms.ComboBox();
            this.dgvSP = new System.Windows.Forms.DataGridView();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
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
            this.txtLoaiSP = new System.Windows.Forms.TextBox();
            this.gbDetail.SuspendLayout();
            this.gbSupplier.SuspendLayout();
            this.gbProductOfSupplier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOfSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).BeginInit();
            this.gbFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDetail
            // 
            this.gbDetail.BackColor = System.Drawing.Color.SpringGreen;
            this.gbDetail.Controls.Add(this.txtLoaiSP);
            this.gbDetail.Controls.Add(this.btnLoadSupplier);
            this.gbDetail.Controls.Add(this.btnEditProduct);
            this.gbDetail.Controls.Add(this.gbSupplier);
            this.gbDetail.Controls.Add(this.txtDonGia);
            this.gbDetail.Controls.Add(this.label6);
            this.gbDetail.Controls.Add(this.txtSoLuong);
            this.gbDetail.Controls.Add(this.label5);
            this.gbDetail.Controls.Add(this.txtDonVi);
            this.gbDetail.Controls.Add(this.label4);
            this.gbDetail.Controls.Add(this.label3);
            this.gbDetail.Controls.Add(this.txtTenSP);
            this.gbDetail.Controls.Add(this.label2);
            this.gbDetail.Controls.Add(this.picSanPham);
            this.gbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetail.Location = new System.Drawing.Point(696, 0);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(678, 879);
            this.gbDetail.TabIndex = 4;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Thông tin sản phẩm và nhà cung cấp";
            // 
            // btnLoadSupplier
            // 
            this.btnLoadSupplier.Location = new System.Drawing.Point(338, 259);
            this.btnLoadSupplier.Name = "btnLoadSupplier";
            this.btnLoadSupplier.Size = new System.Drawing.Size(299, 59);
            this.btnLoadSupplier.TabIndex = 38;
            this.btnLoadSupplier.Text = "Tải thông tin nhà cung cấp";
            this.btnLoadSupplier.UseVisualStyleBackColor = true;
            this.btnLoadSupplier.Click += new System.EventHandler(this.btnLoadSupplier_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(6, 259);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(298, 59);
            this.btnEditProduct.TabIndex = 32;
            this.btnEditProduct.Text = "Chỉnh sửa thông tin sản phẩm";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // gbSupplier
            // 
            this.gbSupplier.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.gbSupplier.Controls.Add(this.btnSeeMoreSupplier);
            this.gbSupplier.Controls.Add(this.btnEditSupplier);
            this.gbSupplier.Controls.Add(this.gbProductOfSupplier);
            this.gbSupplier.Controls.Add(this.txtSDTNCC);
            this.gbSupplier.Controls.Add(this.label12);
            this.gbSupplier.Controls.Add(this.txtEmailNCC);
            this.gbSupplier.Controls.Add(this.label11);
            this.gbSupplier.Controls.Add(this.txtDiaChiNCC);
            this.gbSupplier.Controls.Add(this.label10);
            this.gbSupplier.Controls.Add(this.txtTenNCC);
            this.gbSupplier.Controls.Add(this.label9);
            this.gbSupplier.Controls.Add(this.txtMaNCC);
            this.gbSupplier.Controls.Add(this.label8);
            this.gbSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSupplier.Location = new System.Drawing.Point(6, 357);
            this.gbSupplier.Name = "gbSupplier";
            this.gbSupplier.Size = new System.Drawing.Size(629, 491);
            this.gbSupplier.TabIndex = 37;
            this.gbSupplier.TabStop = false;
            this.gbSupplier.Text = "Thông tin về nhà cung cấp";
            // 
            // btnSeeMoreSupplier
            // 
            this.btnSeeMoreSupplier.Location = new System.Drawing.Point(324, 449);
            this.btnSeeMoreSupplier.Name = "btnSeeMoreSupplier";
            this.btnSeeMoreSupplier.Size = new System.Drawing.Size(299, 36);
            this.btnSeeMoreSupplier.TabIndex = 50;
            this.btnSeeMoreSupplier.Text = "Xem thêm nhà cung cấp khác";
            this.btnSeeMoreSupplier.UseVisualStyleBackColor = true;
            this.btnSeeMoreSupplier.Click += new System.EventHandler(this.btnSeeMoreSupplier_Click);
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Location = new System.Drawing.Point(7, 449);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(299, 36);
            this.btnEditSupplier.TabIndex = 39;
            this.btnEditSupplier.Text = "Điều chỉnh thông tin";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            // 
            // gbProductOfSupplier
            // 
            this.gbProductOfSupplier.Controls.Add(this.dgvProductOfSupplier);
            this.gbProductOfSupplier.Location = new System.Drawing.Point(7, 223);
            this.gbProductOfSupplier.Name = "gbProductOfSupplier";
            this.gbProductOfSupplier.Size = new System.Drawing.Size(616, 220);
            this.gbProductOfSupplier.TabIndex = 49;
            this.gbProductOfSupplier.TabStop = false;
            this.gbProductOfSupplier.Text = "Các sản phẩm đang cung cấp";
            // 
            // dgvProductOfSupplier
            // 
            this.dgvProductOfSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductOfSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvProductOfSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductOfSupplier.EnableHeadersVisualStyles = false;
            this.dgvProductOfSupplier.Location = new System.Drawing.Point(6, 26);
            this.dgvProductOfSupplier.Name = "dgvProductOfSupplier";
            this.dgvProductOfSupplier.ReadOnly = true;
            this.dgvProductOfSupplier.RowHeadersWidth = 51;
            this.dgvProductOfSupplier.Size = new System.Drawing.Size(604, 188);
            this.dgvProductOfSupplier.TabIndex = 0;
            // 
            // txtSDTNCC
            // 
            this.txtSDTNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTNCC.Location = new System.Drawing.Point(135, 175);
            this.txtSDTNCC.Name = "txtSDTNCC";
            this.txtSDTNCC.ReadOnly = true;
            this.txtSDTNCC.Size = new System.Drawing.Size(290, 30);
            this.txtSDTNCC.TabIndex = 48;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 178);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = "Số điện thoại";
            // 
            // txtEmailNCC
            // 
            this.txtEmailNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailNCC.Location = new System.Drawing.Point(136, 140);
            this.txtEmailNCC.Name = "txtEmailNCC";
            this.txtEmailNCC.ReadOnly = true;
            this.txtEmailNCC.Size = new System.Drawing.Size(481, 30);
            this.txtEmailNCC.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = "Email";
            // 
            // txtDiaChiNCC
            // 
            this.txtDiaChiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChiNCC.Location = new System.Drawing.Point(135, 105);
            this.txtDiaChiNCC.Name = "txtDiaChiNCC";
            this.txtDiaChiNCC.ReadOnly = true;
            this.txtDiaChiNCC.Size = new System.Drawing.Size(481, 30);
            this.txtDiaChiNCC.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = "Địa chỉ kho";
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNCC.Location = new System.Drawing.Point(136, 70);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.ReadOnly = true;
            this.txtTenNCC.Size = new System.Drawing.Size(481, 30);
            this.txtTenNCC.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Tên đại diện";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNCC.Location = new System.Drawing.Point(136, 35);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.ReadOnly = true;
            this.txtMaNCC.Size = new System.Drawing.Size(290, 30);
            this.txtMaNCC.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 38);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = "Mã định danh";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(326, 202);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(311, 26);
            this.txtDonGia.TabIndex = 34;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(194, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Giá niêm yết";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(326, 164);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.ReadOnly = true;
            this.txtSoLuong.Size = new System.Drawing.Size(311, 26);
            this.txtSoLuong.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 31;
            this.label5.Text = "Số lượng kho";
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(326, 127);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.ReadOnly = true;
            this.txtDonVi.Size = new System.Drawing.Size(311, 26);
            this.txtDonVi.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Đơn vị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loại sản phẩm";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Location = new System.Drawing.Point(325, 33);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(313, 51);
            this.txtTenSP.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên sản phẩm";
            // 
            // picSanPham
            // 
            this.picSanPham.BackColor = System.Drawing.Color.Linen;
            this.picSanPham.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSanPham.Location = new System.Drawing.Point(6, 43);
            this.picSanPham.Name = "picSanPham";
            this.picSanPham.Size = new System.Drawing.Size(180, 180);
            this.picSanPham.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSanPham.TabIndex = 1;
            this.picSanPham.TabStop = false;
            // 
            // gbFilter
            // 
            this.gbFilter.BackColor = System.Drawing.Color.SpringGreen;
            this.gbFilter.Controls.Add(this.cbFindNCC);
            this.gbFilter.Controls.Add(this.dgvSP);
            this.gbFilter.Controls.Add(this.btnAddNew);
            this.gbFilter.Controls.Add(this.btnReload);
            this.gbFilter.Controls.Add(this.btnDelete);
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
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(697, 879);
            this.gbFilter.TabIndex = 5;
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
            this.cbFindNCC.TabIndex = 32;
            // 
            // dgvSP
            // 
            this.dgvSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.Green;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSP.EnableHeadersVisualStyles = false;
            this.dgvSP.Location = new System.Drawing.Point(15, 281);
            this.dgvSP.Name = "dgvSP";
            this.dgvSP.ReadOnly = true;
            this.dgvSP.RowHeadersWidth = 51;
            this.dgvSP.Size = new System.Drawing.Size(661, 525);
            this.dgvSP.TabIndex = 31;
            this.dgvSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSP_CellClick);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(15, 812);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(183, 36);
            this.btnAddNew.TabIndex = 30;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(15, 239);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(183, 36);
            this.btnReload.TabIndex = 29;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(493, 812);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 36);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Xóa thông tin";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(493, 239);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(183, 36);
            this.btnFind.TabIndex = 27;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(304, 239);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 36);
            this.btnClear.TabIndex = 26;
            this.btnClear.Text = "Clear";
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
            // txtLoaiSP
            // 
            this.txtLoaiSP.Location = new System.Drawing.Point(326, 91);
            this.txtLoaiSP.Name = "txtLoaiSP";
            this.txtLoaiSP.ReadOnly = true;
            this.txtLoaiSP.Size = new System.Drawing.Size(311, 26);
            this.txtLoaiSP.TabIndex = 39;
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.gbDetail);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(1374, 879);
            this.Load += new System.EventHandler(this.UC_SanPham_Load);
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.gbSupplier.ResumeLayout(false);
            this.gbSupplier.PerformLayout();
            this.gbProductOfSupplier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductOfSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSanPham)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDFrom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Button btnLoadSupplier;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.GroupBox gbSupplier;
        private System.Windows.Forms.Button btnSeeMoreSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.GroupBox gbProductOfSupplier;
        private System.Windows.Forms.DataGridView dgvProductOfSupplier;
        private System.Windows.Forms.TextBox txtSDTNCC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEmailNCC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiaChiNCC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picSanPham;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.DataGridView dgvSP;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnDelete;
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
        private System.Windows.Forms.TextBox txtLoaiSP;
    }
}
