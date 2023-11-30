using BLL_DAL;
using QL_CuaHangTienLoi.GUI;
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

namespace QL_CuaHangTienLoi
{
    public partial class frmDangNhap : Form
    {
        BLL_DAL_TaiKhoan bLL_DAL_TaiKhoan = new BLL_DAL_TaiKhoan();
        BLL_DAL_NhanVien BLL_DAL_NhanVien = new BLL_DAL_NhanVien();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogic_Click(object sender, EventArgs e)
        {
            string tentk = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                string maNhanVien = bLL_DAL_TaiKhoan.GetTaiKhoan(tentk, matkhau);
                if (maNhanVien != null)
                {
                    frmMain.nhanVien_using = BLL_DAL_NhanVien.getInfoNhanVien(maNhanVien);
                    this.Hide();
                    new frmMain().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
