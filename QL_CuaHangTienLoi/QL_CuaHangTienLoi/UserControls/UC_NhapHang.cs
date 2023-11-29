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
using QL_CuaHangTienLoi.GUI;

namespace QL_CuaHangTienLoi.UserControls
{
    public partial class UC_NhapHang : UserControl
    {
        NHAPHANG nhapHang = null;
        BLL_DAL_NhapHang bLL_DAL_Nhap = new BLL_DAL_NhapHang();
        BLL_DAL_CTNhapHang bLL_DAL_CTNhapHang = new BLL_DAL_CTNhapHang();
        BLL_DAL_SanPham bLL_DAL_SanPham = new BLL_DAL_SanPham();
        BLL_DAL_LoaiSP bLL_DAL_LoaiSP = new BLL_DAL_LoaiSP();
        BLL_DAL_NhaCC bLL_DAL_NhaCC = new BLL_DAL_NhaCC();
        private List<CHITIETNHAPHANG> cHITIETNHAPHANGs;

        static UC_NhapHang _obj;
        public static UC_NhapHang Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UC_NhapHang();
                }
                return _obj;
            }
        }
        public UC_NhapHang()
        {
            InitializeComponent();

        }

        private void UC_NhapHang_Load(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = bLL_DAL_SanPham.getSanPhams_Table();
            dgvSanPham.Columns[0].Visible = false;

            loadCTHD();
        }

        private void loadCTHD()
        {
            cbFindLoaiSP.DisplayMember = "TENLOAI";
            cbFindLoaiSP.ValueMember = "MALOAI";
            cbFindLoaiSP.DataSource = bLL_DAL_LoaiSP.getLoaiSPs_List();
            cbFindNCC.DisplayMember = "TENNCC";
            cbFindNCC.ValueMember = "MANCC";
            cbFindNCC.DataSource = bLL_DAL_NhaCC.getNCCs_List();
        }

        private void btnXemTTNCC_Click(object sender, EventArgs e)
        {
            new frmTHNhaCungCap().ShowDialog();
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            new frmSanPham().ShowDialog();
        }

        private void btnXemLichSuNH_Click(object sender, EventArgs e)
        {
            UC_ThongKe.Instance.BringToFront();
        }

        private void dgvSanPham_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.CurrentCell.RowIndex == dgvSanPham.RowCount - 1)
                return;

            if (nhapHang == null)
            {
                nhapHang = new NHAPHANG();
                nhapHang = settingInformation();
            }
            cHITIETNHAPHANGs = new List<CHITIETNHAPHANG>();

            string maSP = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            string tenSP = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            float gia = float.Parse(dgvSanPham.CurrentRow.Cells[6].Value.ToString());

            UC_SanPhamItem item = new UC_SanPhamItem(flowpnl_Item, txtTongTien, maSP, tenSP, gia);
            item.SettingItem();
        }

        private NHAPHANG settingInformation()
        {
            NHAPHANG nHAPHANG = new NHAPHANG();
            txtMaPN.Text = nhapHang.MANHAPHANG;
            dtpNgayTao.Value = nhapHang.NGAYTAO;
            txtTongTien.Text = nhapHang.TONGTIEN.ToString();

            settingNhanVienInformation();

            return nHAPHANG;
        }

        private void settingNhanVienInformation()
        {
            if (frmMain.nhanVien_using != null)
                txtTenNV.Text = frmMain.nhanVien_using.TENNHANVIEN;
            else
                txtTenNV.Clear();
        }

        private void btnChooseProduct_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentCell.RowIndex == dgvSanPham.RowCount - 1)
                return;

            if (nhapHang == null)
            {
                nhapHang = new NHAPHANG();
                nhapHang = settingInformation();
            }
            cHITIETNHAPHANGs = new List<CHITIETNHAPHANG>();

            string maSP = dgvSanPham.CurrentRow.Cells[0].Value.ToString();
            string tenSP = dgvSanPham.CurrentRow.Cells[1].Value.ToString();
            float gia = float.Parse(dgvSanPham.CurrentRow.Cells[6].Value.ToString());

            UC_SanPhamItem item = new UC_SanPhamItem(flowpnl_Item, txtTongTien, maSP, tenSP, gia);
            item.SettingItem();
        }

        private void btnHuyPN_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hủy toàn bộ phiếu nhập hàng?", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                clearInformation();
        }

        private void clearInformation()
        {
            txtMaPN.Clear();
            txtTenNV.Clear();
            txtTongTien.Clear();

            flowpnl_Item.Controls.Clear();

            cHITIETNHAPHANGs.Clear();
            nhapHang = null;
        }

        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            cHITIETNHAPHANGs = new List<CHITIETNHAPHANG>();
            for (int i = 0; i < flowpnl_Item.Controls.Count; i++)
            {
                UC_SanPhamItem item = (UC_SanPhamItem)flowpnl_Item.Controls[i];
                CHITIETNHAPHANG ct = new CHITIETNHAPHANG();
                ct.ID = (i + 1).ToString();
                ct.MANHAPHANG = nhapHang.MANHAPHANG;
                ct.MASP = item.product_id;
                ct.SOLUONG = item.product_quantity;
                ct.GIA = item.product_price;
                cHITIETNHAPHANGs.Add(ct);
            }

            if (frmMain.nhanVien_using != null)
                nhapHang.MANHANVIEN = frmMain.nhanVien_using.MANHANVIEN;
            else
                nhapHang.MANHANVIEN = "";

            nhapHang.TONGTIEN = float.Parse(txtTongTien.Text);



            if (bLL_DAL_Nhap.Create(nhapHang))
            {
                foreach (CHITIETNHAPHANG item in cHITIETNHAPHANGs)
                {
                    bLL_DAL_CTNhapHang.Create(item);
                }

                MessageBox.Show("Đã lưu thông tin hóa đơn!", "THÔNG BÁO");

            }
            else
            {
                MessageBox.Show("Lỗi khi xử lý hóa đơn", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            clearInformation();
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
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(tensp, 0, 0, null, null);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(tensp, giamin, giamax, null, null);
            }
            else if (chbFindTenSP.Checked && !chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(tensp, 0, 0, null, maloai);
            }
            else if (chbFindTenSP.Checked && !chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(tensp, 0, 0, mancc, null);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(tensp, giamin, giamax, null, maloai);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(tensp, giamin, giamax, mancc, null);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(tensp, 0, 0, mancc, maloai);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(tensp, giamin, giamax, mancc, maloai);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(null, giamin, giamax, null, null);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(null, giamin, giamax, null, maloai);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(null, giamin, giamax, mancc, null);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(null, giamin, giamax, mancc, maloai);
            }
            else if (!chbFindTenSP.Checked && !chbGia.Checked && chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(null, 0, 0, mancc, maloai);
            }
            else if (!chbFindTenSP.Checked && !chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(null, 0, 0, mancc, null);
            }
            else if (!chbFindTenSP.Checked && !chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvSanPham.DataSource = bLL_DAL_SanPham.timSP_NhieuGiaTri(null, 0, 0, null, maloai);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvSanPham.DataSource = bLL_DAL_SanPham.getSanPhams_Table();
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFindTenSP.Clear();
            numUDFrom.Value = 1;
            numUDTo.Value = 50;
        }
    }
}
