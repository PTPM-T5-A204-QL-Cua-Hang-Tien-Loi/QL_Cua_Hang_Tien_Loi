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
        public frmMain()
        {
            InitializeComponent();

            this.Width = 1308;
            this.Height = 807;

            AddTabToControl();


            timer1.Start();
        }

        private void ShowTabUsing(string tabName)
        {
            lblTabShow.Text = "Tab đang hiển thị: {tabName}";
        }

        private void AddTabToControl()
        {
            pnlMain.Controls.Add(UC_TrangChu.Instance);
            pnlMain.Controls.Add(UC_SanPham.Instance);
            pnlMain.Controls.Add(UC_BanHang.Instance);
            pnlMain.Controls.Add(UC_NhapHang.Instance);
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
            ShowTabUsing(btnSanPham.Text);
            UC_SanPham.Instance.BringToFront();
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnBanHang.Text);
            UC_BanHang.Instance.BringToFront();

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            ShowTabUsing(btnNhapHang.Text);
            UC_NhapHang.Instance.BringToFront();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {

        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {

        }

        private void btnHomePage_Click(object sender, EventArgs e)
        {

        }
    }
}
