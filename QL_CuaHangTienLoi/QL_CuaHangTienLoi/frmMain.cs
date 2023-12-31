﻿using BLL_DAL;
using QL_CuaHangTienLoi.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangTienLoi.GUI
{
    public partial class frmMain : Form
    {
        public static NHANVIEN nhanVien_using;
        BLL_DAL_TaiKhoan bLL_DAL_TaiKhoan = new BLL_DAL_TaiKhoan();
        public int quyen;
        public frmMain()
        {
            InitializeComponent();

            this.Width = 1308;
            this.Height = 807;

            AddTabToControl();

            lblTenNV.Text = nhanVien_using.TENNHANVIEN;

            quyen = (int)bLL_DAL_TaiKhoan.checkQuyenNhanVien(nhanVien_using.MANHANVIEN);

            timer1.Start();
        }
        private void ShowTabUsing(string tabName)
        {
            lblTabShow.Text = $"Tab đang hiển thị: {tabName}";
        }

        private void AddTabToControl()
        {
            pnlMain.Controls.Add(UC_TrangChu.Instance);
            pnlMain.Controls.Add(UC_SanPham.Instance);
            pnlMain.Controls.Add(UC_BanHang.Instance);
            pnlMain.Controls.Add(UC_NhapHang.Instance);
            pnlMain.Controls.Add(UC_NhanVien.Instance);
            pnlMain.Controls.Add(UC_ThongKe.Instance);
            pnlMain.Controls.Add(UC_DonHang.Instance);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            
            if (quyen == 2)
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
            else
            {
                ShowTabUsing(btnSanPham.Text);
                UC_SanPham.Instance.BringToFront();
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnBanHang.Text);
            UC_BanHang.Instance.BringToFront();

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            
            if (quyen == 2)
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
            else
            {
                ShowTabUsing(btnNhapHang.Text);
                UC_NhapHang.Instance.BringToFront();
            }
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            
            if (quyen == 2)
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
            else
            {
                ShowTabUsing(btnThongKe.Text);
                UC_ThongKe.Instance.BringToFront();
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            
            if (quyen == 2)
            {
                MessageBox.Show("Bạn không có quyền truy cập!");
            }
            else
            {
                ShowTabUsing(btnNhanVien.Text);
                UC_NhanVien.Instance.BringToFront();
            }
        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnHomePage.Text);
            UC_TrangChu.Instance.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn kết thúc phiên đăng nhập không?", "THÔNG BÁO",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frmMain.nhanVien_using = null;
                this.Hide();
                new frmDangNhap().ShowDialog();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnDonHang_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnDonHang.Text);
            UC_DonHang.Instance.BringToFront();
        }
    }
}
