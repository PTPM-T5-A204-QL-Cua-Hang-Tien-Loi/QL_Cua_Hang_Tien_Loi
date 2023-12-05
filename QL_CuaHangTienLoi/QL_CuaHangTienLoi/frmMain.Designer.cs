namespace QL_CuaHangTienLoi.GUI
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTenNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTabShow = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnDonHang = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.btnBanHang = new System.Windows.Forms.Button();
            this.btnSanPham = new System.Windows.Forms.Button();
            this.btnHomePage = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMove.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMove
            // 
            this.pnlMove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMove.BackColor = System.Drawing.Color.Green;
            this.pnlMove.Controls.Add(this.button1);
            this.pnlMove.Controls.Add(this.lblTenNV);
            this.pnlMove.Controls.Add(this.label1);
            this.pnlMove.Controls.Add(this.lblTabShow);
            this.pnlMove.Location = new System.Drawing.Point(0, 0);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(1722, 67);
            this.pnlMove.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1589, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "ĐĂNG XUẤT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTenNV
            // 
            this.lblTenNV.AutoSize = true;
            this.lblTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNV.ForeColor = System.Drawing.Color.Gold;
            this.lblTenNV.Location = new System.Drawing.Point(1337, 17);
            this.lblTenNV.Name = "lblTenNV";
            this.lblTenNV.Size = new System.Drawing.Size(203, 29);
            this.lblTenNV.TabIndex = 5;
            this.lblTenNV.Text = "NGUYỄN VĂN A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(1189, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Xin chào:";
            // 
            // lblTabShow
            // 
            this.lblTabShow.AutoSize = true;
            this.lblTabShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabShow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTabShow.Location = new System.Drawing.Point(13, 17);
            this.lblTabShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTabShow.Name = "lblTabShow";
            this.lblTabShow.Size = new System.Drawing.Size(268, 32);
            this.lblTabShow.TabIndex = 3;
            this.lblTabShow.Text = "Tab đang hiển thị: ";
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlControl.BackColor = System.Drawing.Color.Lime;
            this.pnlControl.Controls.Add(this.btnDonHang);
            this.pnlControl.Controls.Add(this.lblTime);
            this.pnlControl.Controls.Add(this.btnNhanVien);
            this.pnlControl.Controls.Add(this.btnThongKe);
            this.pnlControl.Controls.Add(this.btnNhapHang);
            this.pnlControl.Controls.Add(this.btnBanHang);
            this.pnlControl.Controls.Add(this.btnSanPham);
            this.pnlControl.Controls.Add(this.btnHomePage);
            this.pnlControl.Location = new System.Drawing.Point(0, 67);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(348, 879);
            this.pnlControl.TabIndex = 1;
            // 
            // btnDonHang
            // 
            this.btnDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDonHang.Image = global::QL_CuaHangTienLoi.Properties.Resources.cart_2;
            this.btnDonHang.Location = new System.Drawing.Point(19, 570);
            this.btnDonHang.Name = "btnDonHang";
            this.btnDonHang.Size = new System.Drawing.Size(305, 74);
            this.btnDonHang.TabIndex = 8;
            this.btnDonHang.Text = "ĐƠN HÀNG";
            this.btnDonHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDonHang.UseVisualStyleBackColor = true;
            this.btnDonHang.Click += new System.EventHandler(this.btnDonHang_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(121, 804);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(64, 25);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "label1";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.Image = global::QL_CuaHangTienLoi.Properties.Resources.icons8_staff_32;
            this.btnNhanVien.Location = new System.Drawing.Point(19, 479);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(305, 74);
            this.btnNhanVien.TabIndex = 5;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanVien.UseVisualStyleBackColor = true;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Image = global::QL_CuaHangTienLoi.Properties.Resources.icons8_plot_32;
            this.btnThongKe.Location = new System.Drawing.Point(19, 390);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(305, 74);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "THỐNG KÊ";
            this.btnThongKe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang.Image = global::QL_CuaHangTienLoi.Properties.Resources.icons8_import_32;
            this.btnNhapHang.Location = new System.Drawing.Point(19, 301);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(305, 74);
            this.btnNhapHang.TabIndex = 3;
            this.btnNhapHang.Text = "NHẬP HÀNG";
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // btnBanHang
            // 
            this.btnBanHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.Image = global::QL_CuaHangTienLoi.Properties.Resources.icons8_purchase_order_32;
            this.btnBanHang.Location = new System.Drawing.Point(19, 212);
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.Size = new System.Drawing.Size(305, 74);
            this.btnBanHang.TabIndex = 2;
            this.btnBanHang.Text = "BÁN HÀNG";
            this.btnBanHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanHang.UseVisualStyleBackColor = true;
            this.btnBanHang.Click += new System.EventHandler(this.btnBanHang_Click);
            // 
            // btnSanPham
            // 
            this.btnSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSanPham.Image = global::QL_CuaHangTienLoi.Properties.Resources.icons8_product_32;
            this.btnSanPham.Location = new System.Drawing.Point(19, 122);
            this.btnSanPham.Name = "btnSanPham";
            this.btnSanPham.Size = new System.Drawing.Size(305, 74);
            this.btnSanPham.TabIndex = 1;
            this.btnSanPham.Text = "SẢN PHẨM";
            this.btnSanPham.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSanPham.UseVisualStyleBackColor = true;
            this.btnSanPham.Click += new System.EventHandler(this.btnSanPham_Click);
            // 
            // btnHomePage
            // 
            this.btnHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomePage.Image = global::QL_CuaHangTienLoi.Properties.Resources.icons8_home_32;
            this.btnHomePage.Location = new System.Drawing.Point(19, 33);
            this.btnHomePage.Name = "btnHomePage";
            this.btnHomePage.Size = new System.Drawing.Size(305, 74);
            this.btnHomePage.TabIndex = 0;
            this.btnHomePage.Text = "TRANG CHỦ";
            this.btnHomePage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHomePage.UseVisualStyleBackColor = true;
            this.btnHomePage.Click += new System.EventHandler(this.btnHomePage_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMain.BackColor = System.Drawing.Color.White;
            this.pnlMain.Location = new System.Drawing.Point(348, 67);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1374, 879);
            this.pnlMain.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1723, 945);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlMove);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Label lblTabShow;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnHomePage;
        private System.Windows.Forms.Button btnSanPham;
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btnBanHang;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenNV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDonHang;
        private System.Windows.Forms.Label lblTime;
    }
}