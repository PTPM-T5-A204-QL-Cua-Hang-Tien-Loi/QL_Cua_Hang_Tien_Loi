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
        BLL_DAL_SanPham sanpham = new BLL_DAL_SanPham();
        BLL_DAL_LoaiSP loaisp = new BLL_DAL_LoaiSP();
        BLL_DAL_NhaCC ncc = new BLL_DAL_NhaCC();

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
            dgvSP.DataSource = sanpham.getSanPhams_Table();

            loadCTHD();

        }

        private void loadCTHD()
        {
            cbFindLoaiSP.DisplayMember = "TENLOAI";
            cbFindLoaiSP.ValueMember = "MALOAI";
            cbFindLoaiSP.DataSource = loaisp.getLoaiSPs_List();
            cbFindNCC.DisplayMember = "TENNCC";
            cbFindNCC.ValueMember = "MANCC";
            cbFindNCC.DataSource = ncc.getNCCs_List();
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

            //ClearNCCForm();
            SANPHAM sp = new SANPHAM();
            txtTenSP.Text = dgvSP.CurrentRow.Cells[1].Value.ToString();
            txtLoaiSP.Text = loaisp.geTenLoaiMaLoai(dgvSP.CurrentRow.Cells[4].Value.ToString());
            txtDonVi.Text = dgvSP.CurrentRow.Cells[2].Value.ToString();
            txtSoLuong.Text = dgvSP.CurrentRow.Cells[3].Value.ToString();
            txtDonGia.Text = dgvSP.CurrentRow.Cells[6].Value.ToString();

            picSanPham.Image = sanpham.GetHinhAnhSP(dgvSP.CurrentRow.Cells[0].Value.ToString());

            btnEditProduct.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvSP.DataSource = sanpham.getSanPhams_Table();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFindTenSP.Clear();
            numUDFrom.Value = 1;
            numUDTo.Value = 50;

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {

        }

        private void btnLoadSupplier_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
