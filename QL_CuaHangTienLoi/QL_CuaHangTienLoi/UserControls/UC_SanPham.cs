using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL_DAL;

namespace QL_CuaHangTienLoi.UserControls
{
    
    public partial class UC_SanPham : UserControl
    {
        static UC_SanPham _obj;
        BLL_DAL_SanPham bLL_DAL_SanPham = new BLL_DAL_SanPham();
        BLL_DAL_LoaiSP loaisp = new BLL_DAL_LoaiSP();
        SANPHAM sanPham;

        public static UC_SanPham Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UC_SanPham();
                }
                return _obj;
            }
        }
        public UC_SanPham()
        {
            InitializeComponent();
        }

        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = bLL_DAL_SanPham.getSanPhams_Table();
            LoadCbbLoaiSP();
            btnEditProduct.Enabled = false;
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frmSanPham().ShowDialog();
        }

        private void btnSeeMoreSupplier_Click(object sender, EventArgs e)
        {
            new frmTHNhaCungCap().ShowDialog();
        }

        private void dgvSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSP.CurrentCell.RowIndex == dgvSP.RowCount - 1)
                return;

            ClearNCCForm();

            txtMaSP.Text = dgvSP.CurrentRow.Cells[0].Value.ToString();
            txtTenSP.Text = dgvSP.CurrentRow.Cells[1].Value.ToString();
            txtLoaiSP.Text = dgvSP.CurrentRow.Cells[2].Value.ToString();
            txtDonVi.Text = dgvSP.CurrentRow.Cells[3].Value.ToString();
            txtSoLuong.Text = dgvSP.CurrentRow.Cells[4].Value.ToString();
            txtDonGia.Text = dgvSP.CurrentRow.Cells[5].Value.ToString();

            btnEditProduct.Enabled = true;

        }

        private void LoadCbbLoaiSP()
        {
            cbFindLoaiSP.DisplayMember = "TENLOAI";
            cbFindLoaiSP.ValueMember = "MALOAI";
            cbFindLoaiSP.DataSource = loaisp.getLoaiSPs_List();
        }

        private void ClearNCCForm()
        {

            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChiNCC.Clear();
            txtEmailNCC.Clear();
            txtSDTNCC.Clear();

            dgvSPcuaNCC.Controls.Clear();
            dgvSPcuaNCC.DataSource = null;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "")
            {
                new frmSanPham(sanPham).ShowDialog();
            }
        }
    }
}
