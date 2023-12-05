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

namespace QL_CuaHangTienLoi.UserControls
{
    public partial class UC_DonHang : UserControl
    {
        static UC_DonHang _obj;
        BLL_DAL_DonHangOnl bLL_DAL_DonHangOnl = new BLL_DAL_DonHangOnl();
        DonhangOnl donhangOnl = new DonhangOnl();
        public static UC_DonHang Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UC_DonHang();
                }
                return _obj;
            }
        }
        public UC_DonHang()
        {
            InitializeComponent();
        }

        private void UC_DonHang_Load(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = bLL_DAL_DonHangOnl.getDonHangOnl_Table();
            dgvDonHang.Columns[0].Visible = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvDonHang.DataSource = bLL_DAL_DonHangOnl.getDonHangOnl_Table();

        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDonHang.CurrentCell.RowIndex == dgvDonHang.RowCount - 1)
                return;

            donhangOnl = bLL_DAL_DonHangOnl.getInfoDonHang(dgvDonHang.CurrentRow.Cells[0].Value.ToString());

            txtMaDonHang.Text = donhangOnl.Madon.ToString();
            txtTenKhachHang.Text = dgvDonHang.CurrentRow.Cells[1].Value.ToString();
            dtpNgayDat.Value = (DateTime)donhangOnl.Ngaydat;
            txtDiaChi.Text = dgvDonHang.CurrentRow.Cells[3].Value.ToString();
            txtTrangThai.Text = donhangOnl.Tinhtrang.ToString();

        }

        private void btnCapNhatDH_Click(object sender, EventArgs e)
        {
            if (donhangOnl.Madon.ToString() != "")
                new frmDonHang(donhangOnl).ShowDialog();
        }
    }
}
