namespace QL_CuaHangTienLoi.UserControls
{
    partial class UC_ThongKe
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
            this.gbSales = new System.Windows.Forms.GroupBox();
            this.gbCheckTime = new System.Windows.Forms.GroupBox();
            this.rad6months = new System.Windows.Forms.RadioButton();
            this.rad5years = new System.Windows.Forms.RadioButton();
            this.rad7days = new System.Windows.Forms.RadioButton();
            this.gbImportHistory = new System.Windows.Forms.GroupBox();
            this.dgvImportHistory = new System.Windows.Forms.DataGridView();
            this.gbSellingHistory = new System.Windows.Forms.GroupBox();
            this.dgvSellingHistory = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gbCheckTypeProductChart = new System.Windows.Forms.GroupBox();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalSpending = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalIncome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSpendingDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIncomeDay = new System.Windows.Forms.TextBox();
            this.btnBaoCaoHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaoCaoNhapHang = new System.Windows.Forms.Button();
            this.rad1Year = new System.Windows.Forms.RadioButton();
            this.rad1Month = new System.Windows.Forms.RadioButton();
            this.gbSales.SuspendLayout();
            this.gbCheckTime.SuspendLayout();
            this.gbImportHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportHistory)).BeginInit();
            this.gbSellingHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellingHistory)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.gbCheckTypeProductChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSales
            // 
            this.gbSales.BackColor = System.Drawing.Color.Aquamarine;
            this.gbSales.Controls.Add(this.gbCheckTime);
            this.gbSales.Controls.Add(this.gbImportHistory);
            this.gbSales.Controls.Add(this.gbSellingHistory);
            this.gbSales.Location = new System.Drawing.Point(0, 0);
            this.gbSales.Margin = new System.Windows.Forms.Padding(0);
            this.gbSales.Name = "gbSales";
            this.gbSales.Padding = new System.Windows.Forms.Padding(0);
            this.gbSales.Size = new System.Drawing.Size(800, 879);
            this.gbSales.TabIndex = 1;
            this.gbSales.TabStop = false;
            this.gbSales.Text = "Thống kê doanh thu";
            // 
            // gbCheckTime
            // 
            this.gbCheckTime.BackColor = System.Drawing.Color.Turquoise;
            this.gbCheckTime.Controls.Add(this.rad1Month);
            this.gbCheckTime.Controls.Add(this.rad6months);
            this.gbCheckTime.Controls.Add(this.rad1Year);
            this.gbCheckTime.Controls.Add(this.rad5years);
            this.gbCheckTime.Controls.Add(this.rad7days);
            this.gbCheckTime.ForeColor = System.Drawing.Color.Black;
            this.gbCheckTime.Location = new System.Drawing.Point(6, 812);
            this.gbCheckTime.Name = "gbCheckTime";
            this.gbCheckTime.Size = new System.Drawing.Size(782, 64);
            this.gbCheckTime.TabIndex = 7;
            this.gbCheckTime.TabStop = false;
            this.gbCheckTime.Text = "Biểu đồ doanh thu";
            // 
            // rad6months
            // 
            this.rad6months.AutoSize = true;
            this.rad6months.Location = new System.Drawing.Point(320, 28);
            this.rad6months.Name = "rad6months";
            this.rad6months.Size = new System.Drawing.Size(68, 20);
            this.rad6months.TabIndex = 2;
            this.rad6months.Text = "6 tháng";
            this.rad6months.UseVisualStyleBackColor = true;
            this.rad6months.CheckedChanged += new System.EventHandler(this.rad6months_CheckedChanged);
            // 
            // rad5years
            // 
            this.rad5years.AutoSize = true;
            this.rad5years.Location = new System.Drawing.Point(657, 28);
            this.rad5years.Name = "rad5years";
            this.rad5years.Size = new System.Drawing.Size(61, 20);
            this.rad5years.TabIndex = 1;
            this.rad5years.Text = "5 năm";
            this.rad5years.UseVisualStyleBackColor = true;
            this.rad5years.CheckedChanged += new System.EventHandler(this.rad5years_CheckedChanged);
            // 
            // rad7days
            // 
            this.rad7days.AutoSize = true;
            this.rad7days.Checked = true;
            this.rad7days.Location = new System.Drawing.Point(6, 28);
            this.rad7days.Name = "rad7days";
            this.rad7days.Size = new System.Drawing.Size(65, 20);
            this.rad7days.TabIndex = 0;
            this.rad7days.TabStop = true;
            this.rad7days.Text = "7 ngày";
            this.rad7days.UseVisualStyleBackColor = true;
            this.rad7days.CheckedChanged += new System.EventHandler(this.rad7days_CheckedChanged);
            // 
            // gbImportHistory
            // 
            this.gbImportHistory.BackColor = System.Drawing.Color.Turquoise;
            this.gbImportHistory.Controls.Add(this.dgvImportHistory);
            this.gbImportHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbImportHistory.Location = new System.Drawing.Point(406, 30);
            this.gbImportHistory.Name = "gbImportHistory";
            this.gbImportHistory.Size = new System.Drawing.Size(388, 776);
            this.gbImportHistory.TabIndex = 3;
            this.gbImportHistory.TabStop = false;
            this.gbImportHistory.Text = "Lịch sử nhập hàng";
            // 
            // dgvImportHistory
            // 
            this.dgvImportHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvImportHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImportHistory.Location = new System.Drawing.Point(6, 26);
            this.dgvImportHistory.Name = "dgvImportHistory";
            this.dgvImportHistory.ReadOnly = true;
            this.dgvImportHistory.RowHeadersVisible = false;
            this.dgvImportHistory.RowHeadersWidth = 51;
            this.dgvImportHistory.Size = new System.Drawing.Size(376, 736);
            this.dgvImportHistory.TabIndex = 0;
            this.dgvImportHistory.DataSourceChanged += new System.EventHandler(this.dgvImportHistory_DataSourceChanged);
            // 
            // gbSellingHistory
            // 
            this.gbSellingHistory.BackColor = System.Drawing.Color.Turquoise;
            this.gbSellingHistory.Controls.Add(this.dgvSellingHistory);
            this.gbSellingHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSellingHistory.Location = new System.Drawing.Point(6, 30);
            this.gbSellingHistory.Name = "gbSellingHistory";
            this.gbSellingHistory.Size = new System.Drawing.Size(394, 776);
            this.gbSellingHistory.TabIndex = 0;
            this.gbSellingHistory.TabStop = false;
            this.gbSellingHistory.Text = "Lịch sử bán hàng";
            // 
            // dgvSellingHistory
            // 
            this.dgvSellingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSellingHistory.Location = new System.Drawing.Point(6, 26);
            this.dgvSellingHistory.Name = "dgvSellingHistory";
            this.dgvSellingHistory.ReadOnly = true;
            this.dgvSellingHistory.RowHeadersVisible = false;
            this.dgvSellingHistory.RowHeadersWidth = 51;
            this.dgvSellingHistory.Size = new System.Drawing.Size(382, 736);
            this.dgvSellingHistory.TabIndex = 0;
            this.dgvSellingHistory.DataSourceChanged += new System.EventHandler(this.dgvSellingHistory_DataSourceChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.gbCheckTypeProductChart);
            this.groupBox2.Location = new System.Drawing.Point(800, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(574, 879);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm trong cửa hàng";
            // 
            // gbCheckTypeProductChart
            // 
            this.gbCheckTypeProductChart.BackColor = System.Drawing.Color.Turquoise;
            this.gbCheckTypeProductChart.Controls.Add(this.txtProfit);
            this.gbCheckTypeProductChart.Controls.Add(this.label5);
            this.gbCheckTypeProductChart.Controls.Add(this.txtTotalSpending);
            this.gbCheckTypeProductChart.Controls.Add(this.label4);
            this.gbCheckTypeProductChart.Controls.Add(this.txtTotalIncome);
            this.gbCheckTypeProductChart.Controls.Add(this.label3);
            this.gbCheckTypeProductChart.Controls.Add(this.txtSpendingDay);
            this.gbCheckTypeProductChart.Controls.Add(this.label2);
            this.gbCheckTypeProductChart.Controls.Add(this.txtIncomeDay);
            this.gbCheckTypeProductChart.Controls.Add(this.btnBaoCaoNhapHang);
            this.gbCheckTypeProductChart.Controls.Add(this.btnBaoCaoHD);
            this.gbCheckTypeProductChart.Controls.Add(this.label1);
            this.gbCheckTypeProductChart.ForeColor = System.Drawing.Color.Black;
            this.gbCheckTypeProductChart.Location = new System.Drawing.Point(6, 30);
            this.gbCheckTypeProductChart.Name = "gbCheckTypeProductChart";
            this.gbCheckTypeProductChart.Size = new System.Drawing.Size(565, 846);
            this.gbCheckTypeProductChart.TabIndex = 9;
            this.gbCheckTypeProductChart.TabStop = false;
            // 
            // txtProfit
            // 
            this.txtProfit.Location = new System.Drawing.Point(29, 424);
            this.txtProfit.Multiline = true;
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.ReadOnly = true;
            this.txtProfit.Size = new System.Drawing.Size(500, 35);
            this.txtProfit.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Lợi nhuận";
            // 
            // txtTotalSpending
            // 
            this.txtTotalSpending.Location = new System.Drawing.Point(29, 335);
            this.txtTotalSpending.Multiline = true;
            this.txtTotalSpending.Name = "txtTotalSpending";
            this.txtTotalSpending.ReadOnly = true;
            this.txtTotalSpending.Size = new System.Drawing.Size(500, 35);
            this.txtTotalSpending.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Tổng chi tiêu";
            // 
            // txtTotalIncome
            // 
            this.txtTotalIncome.Location = new System.Drawing.Point(29, 246);
            this.txtTotalIncome.Multiline = true;
            this.txtTotalIncome.Name = "txtTotalIncome";
            this.txtTotalIncome.ReadOnly = true;
            this.txtTotalIncome.Size = new System.Drawing.Size(500, 35);
            this.txtTotalIncome.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Tổng thu nhập";
            // 
            // txtSpendingDay
            // 
            this.txtSpendingDay.Location = new System.Drawing.Point(29, 157);
            this.txtSpendingDay.Multiline = true;
            this.txtSpendingDay.Name = "txtSpendingDay";
            this.txtSpendingDay.ReadOnly = true;
            this.txtSpendingDay.Size = new System.Drawing.Size(500, 35);
            this.txtSpendingDay.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Chi tiêu trong ngày";
            // 
            // txtIncomeDay
            // 
            this.txtIncomeDay.Location = new System.Drawing.Point(29, 68);
            this.txtIncomeDay.Multiline = true;
            this.txtIncomeDay.Name = "txtIncomeDay";
            this.txtIncomeDay.ReadOnly = true;
            this.txtIncomeDay.Size = new System.Drawing.Size(500, 35);
            this.txtIncomeDay.TabIndex = 13;
            // 
            // btnBaoCaoHD
            // 
            this.btnBaoCaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoHD.Location = new System.Drawing.Point(158, 485);
            this.btnBaoCaoHD.Name = "btnBaoCaoHD";
            this.btnBaoCaoHD.Size = new System.Drawing.Size(266, 57);
            this.btnBaoCaoHD.TabIndex = 12;
            this.btnBaoCaoHD.Text = "Báo cáo hóa đơn";
            this.btnBaoCaoHD.UseVisualStyleBackColor = true;
            this.btnBaoCaoHD.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Thu nhập trong ngày";
            // 
            // btnBaoCaoNhapHang
            // 
            this.btnBaoCaoNhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCaoNhapHang.Location = new System.Drawing.Point(158, 566);
            this.btnBaoCaoNhapHang.Name = "btnBaoCaoNhapHang";
            this.btnBaoCaoNhapHang.Size = new System.Drawing.Size(266, 57);
            this.btnBaoCaoNhapHang.TabIndex = 12;
            this.btnBaoCaoNhapHang.Text = "Báo cáo nhập hàng";
            this.btnBaoCaoNhapHang.UseVisualStyleBackColor = true;
            this.btnBaoCaoNhapHang.Click += new System.EventHandler(this.btnBaoCaoNhapHang_Click);
            // 
            // rad1Year
            // 
            this.rad1Year.AutoSize = true;
            this.rad1Year.Location = new System.Drawing.Point(487, 28);
            this.rad1Year.Name = "rad1Year";
            this.rad1Year.Size = new System.Drawing.Size(61, 20);
            this.rad1Year.TabIndex = 1;
            this.rad1Year.Text = "1 năm";
            this.rad1Year.UseVisualStyleBackColor = true;
            this.rad1Year.CheckedChanged += new System.EventHandler(this.rad1Year_CheckedChanged);
            // 
            // rad1Month
            // 
            this.rad1Month.AutoSize = true;
            this.rad1Month.Location = new System.Drawing.Point(150, 28);
            this.rad1Month.Name = "rad1Month";
            this.rad1Month.Size = new System.Drawing.Size(68, 20);
            this.rad1Month.TabIndex = 2;
            this.rad1Month.Text = "1 tháng";
            this.rad1Month.UseVisualStyleBackColor = true;
            this.rad1Month.CheckedChanged += new System.EventHandler(this.rad1Month_CheckedChanged);
            // 
            // UC_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbSales);
            this.Name = "UC_ThongKe";
            this.Size = new System.Drawing.Size(1374, 879);
            this.Load += new System.EventHandler(this.UC_ThongKe_Load);
            this.gbSales.ResumeLayout(false);
            this.gbCheckTime.ResumeLayout(false);
            this.gbCheckTime.PerformLayout();
            this.gbImportHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportHistory)).EndInit();
            this.gbSellingHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSellingHistory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.gbCheckTypeProductChart.ResumeLayout(false);
            this.gbCheckTypeProductChart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSales;
        private System.Windows.Forms.GroupBox gbCheckTime;
        private System.Windows.Forms.RadioButton rad6months;
        private System.Windows.Forms.RadioButton rad5years;
        private System.Windows.Forms.RadioButton rad7days;
        private System.Windows.Forms.GroupBox gbImportHistory;
        private System.Windows.Forms.DataGridView dgvImportHistory;
        private System.Windows.Forms.GroupBox gbSellingHistory;
        private System.Windows.Forms.DataGridView dgvSellingHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbCheckTypeProductChart;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalSpending;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSpendingDay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIncomeDay;
        private System.Windows.Forms.Button btnBaoCaoHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaoCaoNhapHang;
        private System.Windows.Forms.RadioButton rad1Month;
        private System.Windows.Forms.RadioButton rad1Year;
    }
}
