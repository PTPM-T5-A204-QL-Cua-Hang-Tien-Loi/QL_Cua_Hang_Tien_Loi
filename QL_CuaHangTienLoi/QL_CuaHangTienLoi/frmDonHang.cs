using BLL_DAL;
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
    public partial class frmDonHang : Form
    {
        BLL_DAL_DonHangOnl bLL_DAL_DonHangOnl = new BLL_DAL_DonHangOnl();
        DonhangOnl dho;
        public frmDonHang()
        {
            InitializeComponent();
        }

        public frmDonHang(DonhangOnl donhangOnl)
        {
            InitializeComponent();

            dho = donhangOnl;

            LoadDonHang(dho);
        }

        private void LoadDonHang(DonhangOnl dho)
        {
            txtMaDonHang.Text = dho.Madon.ToString();

            cbTinhTrang.Text = dho.Tinhtrang;
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DonhangOnl donhangOnl = new DonhangOnl();

            donhangOnl = dho;
            donhangOnl.Tinhtrang = cbTinhTrang.Text;

            try
            {
                if (bLL_DAL_DonHangOnl.Update(donhangOnl))
                {
                    MessageBox.Show("Cập nhật đơn hàng thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật đơn hàng không thành công!", "LỖI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Đã xảy ra lỗi!", "LỖI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
