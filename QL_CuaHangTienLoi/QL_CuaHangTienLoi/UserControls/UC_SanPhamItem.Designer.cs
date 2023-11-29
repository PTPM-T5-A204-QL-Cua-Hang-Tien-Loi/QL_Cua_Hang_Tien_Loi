namespace QL_CuaHangTienLoi.UserControls
{
    partial class UC_SanPhamItem
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtValueSanPham = new System.Windows.Forms.TextBox();
            this.numUDQuantity = new System.Windows.Forms.NumericUpDown();
            this.lblTenSP = new System.Windows.Forms.Label();
            this.lblGiaTien = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.pnlControl);
            this.pnlMain.Controls.Add(this.lblTenSP);
            this.pnlMain.Controls.Add(this.lblGiaTien);
            this.pnlMain.Location = new System.Drawing.Point(4, 4);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(447, 54);
            this.pnlMain.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(396, 8);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 46);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.txtValueSanPham);
            this.pnlControl.Controls.Add(this.numUDQuantity);
            this.pnlControl.Location = new System.Drawing.Point(163, 15);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(4);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(225, 36);
            this.pnlControl.TabIndex = 2;
            // 
            // txtValueSanPham
            // 
            this.txtValueSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValueSanPham.Location = new System.Drawing.Point(103, 4);
            this.txtValueSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.txtValueSanPham.Name = "txtValueSanPham";
            this.txtValueSanPham.Size = new System.Drawing.Size(116, 26);
            this.txtValueSanPham.TabIndex = 1;
            // 
            // numUDQuantity
            // 
            this.numUDQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numUDQuantity.Location = new System.Drawing.Point(4, 4);
            this.numUDQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.numUDQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUDQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQuantity.Name = "numUDQuantity";
            this.numUDQuantity.Size = new System.Drawing.Size(91, 26);
            this.numUDQuantity.TabIndex = 0;
            this.numUDQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUDQuantity.ValueChanged += new System.EventHandler(this.numUDQuantity_ValueChanged);
            // 
            // lblTenSP
            // 
            this.lblTenSP.AutoSize = true;
            this.lblTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenSP.Location = new System.Drawing.Point(4, 0);
            this.lblTenSP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTenSP.Name = "lblTenSP";
            this.lblTenSP.Size = new System.Drawing.Size(59, 20);
            this.lblTenSP.TabIndex = 1;
            this.lblTenSP.Text = "TenSP";
            // 
            // lblGiaTien
            // 
            this.lblGiaTien.AutoSize = true;
            this.lblGiaTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTien.Location = new System.Drawing.Point(4, 37);
            this.lblGiaTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGiaTien.Name = "lblGiaTien";
            this.lblGiaTien.Size = new System.Drawing.Size(30, 17);
            this.lblGiaTien.TabIndex = 0;
            this.lblGiaTien.Text = "Giá";
            // 
            // UC_SanPhamItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "UC_SanPhamItem";
            this.Size = new System.Drawing.Size(457, 62);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TextBox txtValueSanPham;
        private System.Windows.Forms.NumericUpDown numUDQuantity;
        private System.Windows.Forms.Label lblTenSP;
        private System.Windows.Forms.Label lblGiaTien;
    }
}
