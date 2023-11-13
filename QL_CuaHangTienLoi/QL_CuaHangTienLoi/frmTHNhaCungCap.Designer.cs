namespace QL_CuaHangTienLoi
{
    partial class frmTHNhaCungCap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.chbDiaChiNCC = new System.Windows.Forms.CheckBox();
            this.chbTenNCC = new System.Windows.Forms.CheckBox();
            this.cbTypeProductFilter = new System.Windows.Forms.ComboBox();
            this.chbLoaiSP = new System.Windows.Forms.CheckBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.btnEditSupplier = new System.Windows.Forms.Button();
            this.txtSupplierAddressFilter = new System.Windows.Forms.TextBox();
            this.txtSupplierNameFilter = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(90, 537);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(245, 36);
            this.btnAddNew.TabIndex = 75;
            this.btnAddNew.Text = "Thêm nhà cung cấp";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(385, 178);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 51);
            this.btnClear.TabIndex = 74;
            this.btnClear.Text = "Làm trống";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(90, 178);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(194, 51);
            this.btnReload.TabIndex = 73;
            this.btnReload.Text = "Tải lại";
            this.btnReload.UseVisualStyleBackColor = true;
            // 
            // chbDiaChiNCC
            // 
            this.chbDiaChiNCC.AutoSize = true;
            this.chbDiaChiNCC.Checked = true;
            this.chbDiaChiNCC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbDiaChiNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbDiaChiNCC.Location = new System.Drawing.Point(92, 78);
            this.chbDiaChiNCC.Name = "chbDiaChiNCC";
            this.chbDiaChiNCC.Size = new System.Drawing.Size(216, 29);
            this.chbDiaChiNCC.TabIndex = 72;
            this.chbDiaChiNCC.Text = "Địa chỉ nhà cung cấp";
            this.chbDiaChiNCC.UseVisualStyleBackColor = true;
            // 
            // chbTenNCC
            // 
            this.chbTenNCC.AutoSize = true;
            this.chbTenNCC.Checked = true;
            this.chbTenNCC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTenNCC.Location = new System.Drawing.Point(92, 37);
            this.chbTenNCC.Name = "chbTenNCC";
            this.chbTenNCC.Size = new System.Drawing.Size(192, 29);
            this.chbTenNCC.TabIndex = 71;
            this.chbTenNCC.Text = "Tên nhà cung cấp";
            this.chbTenNCC.UseVisualStyleBackColor = true;
            // 
            // cbTypeProductFilter
            // 
            this.cbTypeProductFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeProductFilter.FormattingEnabled = true;
            this.cbTypeProductFilter.Location = new System.Drawing.Point(369, 122);
            this.cbTypeProductFilter.Name = "cbTypeProductFilter";
            this.cbTypeProductFilter.Size = new System.Drawing.Size(475, 24);
            this.cbTypeProductFilter.TabIndex = 70;
            // 
            // chbLoaiSP
            // 
            this.chbLoaiSP.AutoSize = true;
            this.chbLoaiSP.Checked = true;
            this.chbLoaiSP.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbLoaiSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbLoaiSP.Location = new System.Drawing.Point(91, 121);
            this.chbLoaiSP.Name = "chbLoaiSP";
            this.chbLoaiSP.Size = new System.Drawing.Size(162, 29);
            this.chbLoaiSP.TabIndex = 69;
            this.chbLoaiSP.Text = "Loại sản phẩm";
            this.chbLoaiSP.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(660, 537);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(183, 36);
            this.btnExit.TabIndex = 68;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(660, 480);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 36);
            this.btnDelete.TabIndex = 67;
            this.btnDelete.Text = "Xóa thông tin";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.Location = new System.Drawing.Point(660, 178);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(184, 51);
            this.btnFind.TabIndex = 66;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.EnableHeadersVisualStyles = false;
            this.dgvSupplier.Location = new System.Drawing.Point(91, 249);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.RowHeadersWidth = 51;
            this.dgvSupplier.Size = new System.Drawing.Size(754, 216);
            this.dgvSupplier.TabIndex = 65;
            // 
            // btnEditSupplier
            // 
            this.btnEditSupplier.Location = new System.Drawing.Point(90, 480);
            this.btnEditSupplier.Name = "btnEditSupplier";
            this.btnEditSupplier.Size = new System.Drawing.Size(245, 36);
            this.btnEditSupplier.TabIndex = 62;
            this.btnEditSupplier.Text = "Điều chỉnh thông tin";
            this.btnEditSupplier.UseVisualStyleBackColor = true;
            // 
            // txtSupplierAddressFilter
            // 
            this.txtSupplierAddressFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddressFilter.Location = new System.Drawing.Point(369, 77);
            this.txtSupplierAddressFilter.Name = "txtSupplierAddressFilter";
            this.txtSupplierAddressFilter.Size = new System.Drawing.Size(476, 30);
            this.txtSupplierAddressFilter.TabIndex = 64;
            // 
            // txtSupplierNameFilter
            // 
            this.txtSupplierNameFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierNameFilter.Location = new System.Drawing.Point(369, 36);
            this.txtSupplierNameFilter.Name = "txtSupplierNameFilter";
            this.txtSupplierNameFilter.Size = new System.Drawing.Size(476, 30);
            this.txtSupplierNameFilter.TabIndex = 63;
            // 
            // frmTHNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(944, 606);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.chbDiaChiNCC);
            this.Controls.Add(this.chbTenNCC);
            this.Controls.Add(this.cbTypeProductFilter);
            this.Controls.Add(this.chbLoaiSP);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.btnEditSupplier);
            this.Controls.Add(this.txtSupplierAddressFilter);
            this.Controls.Add(this.txtSupplierNameFilter);
            this.Name = "frmTHNhaCungCap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tổng hợp nhà cung cấp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.CheckBox chbDiaChiNCC;
        private System.Windows.Forms.CheckBox chbTenNCC;
        private System.Windows.Forms.ComboBox cbTypeProductFilter;
        private System.Windows.Forms.CheckBox chbLoaiSP;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Button btnEditSupplier;
        private System.Windows.Forms.TextBox txtSupplierAddressFilter;
        private System.Windows.Forms.TextBox txtSupplierNameFilter;
    }
}