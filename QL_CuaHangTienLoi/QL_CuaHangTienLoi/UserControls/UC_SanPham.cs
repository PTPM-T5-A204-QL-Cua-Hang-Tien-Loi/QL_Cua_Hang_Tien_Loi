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

        SANPHAM _sp = new SANPHAM();
        private NHACUNGCAP _ncc = null;
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

            ClearNCCForm();
            _sp = sanpham.getInfoSanPham(dgvSP.CurrentRow.Cells[0].Value.ToString());

            txtTenSP.Text = _sp.TENSP;
            txtLoaiSP.Text = loaisp.geTenLoaiMaLoai(dgvSP.CurrentRow.Cells[4].Value.ToString());
            txtDonVi.Text = _sp.DONVI;
            txtSoLuong.Text = _sp.SOLUONG.ToString();
            txtDonGia.Text = _sp.DONGIABAN.ToString();

            picSanPham.Image = sanpham.GetHinhAnhSP(_sp.MASP);

            btnEditProduct.Enabled = true;
        }

        private void ClearNCCForm()
        {
            _ncc = null;

            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtDiaChiNCC.Clear();
            txtEmailNCC.Clear();
            txtSDTNCC.Clear();

            dgvSPTheoNCC.Controls.Clear();
            dgvSPTheoNCC.DataSource = null;
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
            if (txtTenSP.Text != "")
            {
                new frmSanPham(_sp).ShowDialog();
            } else
            {
                MessageBox.Show("Bạn chưa chọn một sản phẩm!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "")
            {
                if (MessageBox.Show($"Bạn có muốn xóa sản phẩm {_sp.TENSP}?", "CẢNH BÁO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (sanpham.Delete(_sp))
                    {
                        MessageBox.Show("Đã xóa thông tin sản phẩm!", "THÔNG BÁO");
                        dgvSP.DataSource = sanpham.getSanPhams_Table();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin sản phẩm không thành công!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn một sản phẩm!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string tensp = txtFindTenSP.Text;
            string mancc = cbFindNCC.SelectedValue.ToString();
            string maloai = cbFindLoaiSP.SelectedValue.ToString();
            float giamin = (float)numUDFrom.Value * 1000;
            float giamax = (float)numUDTo.Value * 1000;
            if (chbFindTenSP.Checked && !chbGia.Checked && !chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(tensp, 0, 0, null, null);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(tensp, giamin, giamax, null, null);
            }
            else if (chbFindTenSP.Checked && !chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(tensp, 0, 0, null, maloai);
            }
            else if (chbFindTenSP.Checked && !chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(tensp, 0, 0, mancc, null);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(tensp, giamin, giamax, null, maloai);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(tensp, giamin, giamax, mancc, null);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(tensp, 0, 0, mancc, maloai);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(tensp, giamin, giamax, mancc, maloai);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(null, giamin, giamax, null, null);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(null, giamin, giamax, null, maloai);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(null, giamin, giamax, mancc, null);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(null, giamin, giamax, mancc, maloai);
            }
            else if (!chbFindTenSP.Checked && !chbGia.Checked && chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(null, 0, 0, mancc, maloai);
            }
            else if (!chbFindTenSP.Checked && !chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(null, 0, 0, mancc, null);
            }
            else if (!chbFindTenSP.Checked && !chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSP.DataSource = sanpham.timSP_NhieuGiaTri(null, 0, 0, null, maloai);
            }
        }

        private void btnLoadNCC_Click(object sender, EventArgs e)
        {
            
            if (txtTenSP.Text != "")
            {
                _ncc = ncc.getNCCTheoMaNCC(_sp.MANCC);

                txtMaNCC.Text = _ncc.MANCC;
                txtTenNCC.Text = _ncc.TENNCC;
                txtDiaChiNCC.Text = _ncc.DIACHINCC;
                txtEmailNCC.Text = _ncc.EMAIL;
                txtSDTNCC.Text = _ncc.SDTNCC;

                dgvSPTheoNCC.DataSource = sanpham.getSanPhamsTheoMaNCC_Table(_ncc.MANCC);
                dgvSPTheoNCC.Columns[4].Visible = false;
                dgvSPTheoNCC.Columns[5].Visible = false;
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn một sản phẩm!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvSPTheoNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSPTheoNCC.CurrentCell.RowIndex == dgvSP.RowCount - 1)
                return;

            _sp = sanpham.getInfoSanPham(dgvSPTheoNCC.CurrentRow.Cells[0].Value.ToString());

            txtTenSP.Text = _sp.TENSP;
            txtLoaiSP.Text = loaisp.geTenLoaiMaLoai(dgvSPTheoNCC.CurrentRow.Cells[4].Value.ToString());
            txtDonVi.Text = _sp.DONVI;
            txtSoLuong.Text = _sp.SOLUONG.ToString();
            txtDonGia.Text = _sp.DONGIABAN.ToString();

            picSanPham.Image = sanpham.GetHinhAnhSP(_sp.MASP);

            btnEditProduct.Enabled = true;
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            if (_ncc != null)
                new frmNhaCungCap(_ncc).ShowDialog();
        }
    }
}
