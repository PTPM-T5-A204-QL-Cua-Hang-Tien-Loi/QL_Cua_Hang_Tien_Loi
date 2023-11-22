using BLL_DAL;
using QL_CuaHangTienLoi.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QL_CuaHangTienLoi.UserControls
{
    public partial class UC_BanHang : UserControl
    {
        BLL_DAL_SanPham sanpham = new BLL_DAL_SanPham();
        BLL_DAL_HDBan hoadon = new BLL_DAL_HDBan();
        BLL_DAL_LoaiSP loaisp = new BLL_DAL_LoaiSP();
        BLL_DAL_NhaCC ncc = new BLL_DAL_NhaCC();
        BLL_DAL_NhanVien nhanvien = new BLL_DAL_NhanVien();
        BLL_DAL_Khach khach = new BLL_DAL_Khach();
        BLL_DAL_HDBan hd = new BLL_DAL_HDBan();
        BLL_DAL_ChiTietHD cthd = new BLL_DAL_ChiTietHD();
        static UC_BanHang _obj;
        public static UC_BanHang Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UC_BanHang();
                }
                return _obj;
            }
        }
        public UC_BanHang()
        {
            InitializeComponent();
            dtpNgayTao.Value = DateTime.Now;
        }

        private void btnLichSuBH_Click(object sender, EventArgs e)
        {
            UC_ThongKe.Instance.BringToFront();
        }
        private void loadTable()
        {
            dgvProduct.DataSource = sanpham.getSanPhams_Table();
            loadCTHD();
        }
        private void loadCTHD()
        {
            DataTable dt = taoTableCTHD();
            dgvCTHD.DataSource = dt;
        }
        private DataTable taoTableCTHD()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã sản phẩm");
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Số lượng mua");
            dt.Columns.Add("Đơn giá");
            dt.Columns.Add("Giảm giá");
            dt.Columns.Add("Thành tiền");
            return dt;
        }
        private void btnFind_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFindTenSP.Clear();
            txtGiamGia.Text = "0";
            numSL.ResetText();
            numUDFrom.ResetText();
            numUDTo.ResetText();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void btnChonSP_Click(object sender, EventArgs e)
        {
            if (dgvProduct.RowCount == 1)
                    return;
            else if (dgvProduct.CurrentRow != null && dgvProduct.CurrentRow.Index < dgvProduct.Rows.Count - 1)
            {
                if(txtMaHD.Text == "")
                {
                    DateTime date = DateTime.Now;
                    string mahd = "HD" + date.ToString("ddMMyyyyHHmmss");
                    txtMaHD.Text = mahd;
                }    
                string masp = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                string tensp = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                decimal dongia = decimal.Parse(dgvProduct.CurrentRow.Cells[6].Value.ToString());
                decimal giamgia = decimal.Parse(txtGiamGia.Text) / 100;
                decimal sl = numSL.Value;
                bool flag = false;
                foreach (DataGridViewRow item in dgvCTHD.Rows)
                {
                    if(masp == item.Cells[0].Value)
                    {
                        item.Cells[2].Value = decimal.Parse(item.Cells[2].Value.ToString()) + sl;
                        item.Cells[4].Value = giamgia;
                        item.Cells[5].Value = decimal.Parse(item.Cells[2].Value.ToString()) * dongia * (1 - giamgia);
                        flag = true;
                        txtTongTien.Text = tinhTongTien().ToString("0#,##0");
                    }
                    
                }
                if (flag)
                    return;
                else
                {
                    DataTable dt = (DataTable)dgvCTHD.DataSource;
                    DataRow row = dt.NewRow();
                    row[0] = masp;
                    row[1] = tensp;
                    row[2] = sl;
                    row[3] = dongia;
                    row[4] = giamgia;
                    row[5] = sl * dongia * (1 - giamgia);
                    dt.Rows.Add(row);
                    dgvCTHD.DataSource = dt;
                    txtTongTien.Text = tinhTongTien().ToString("0#,##0");
                }    

            }
        }
        private void loadCBO()
        {
            cbFindLoaiSP.DisplayMember = "TENLOAI";
            cbFindLoaiSP.ValueMember = "MALOAI";
            cbFindLoaiSP.DataSource = loaisp.getLoaiSPs_List();
            cbFindNCC.DisplayMember = "TENNCC";
            cbFindNCC.ValueMember = "MANCC";
            cbFindNCC.DataSource = ncc.getNCCs_List();
            cboNhanVien.DisplayMember = "TENNHANVIEN";
            cboNhanVien.ValueMember = "MANHANVIEN";
            cboNhanVien.DataSource = nhanvien.getNhanViens_List();
            cboKhach.DisplayMember = "TENKHACH";
            cboKhach.ValueMember = "MAKHACH";
            cboKhach.DataSource = khach.getKhachs_List();
        }
        private void btnScan_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelBill_Click(object sender, EventArgs e)
        {
            txtMaHD.Clear();
            cboNhanVien.ResetText();
            cboKhach.ResetText();
            txtTongTien.Clear();
            dtpNgayTao.ResetText();
            loadCTHD();
        }

        private void btnMakeBills_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            string manv = cboNhanVien.SelectedValue.ToString();
            string makhach = cboKhach.SelectedValue.ToString();
            DateTime ngaytao = dtpNgayTao.Value;
            decimal tongtien = decimal.Parse(txtTongTien.Text);
            if(hd.taoHD(mahd, manv, ngaytao, makhach, tongtien))
                MessageBox.Show("Tạo thành công", "Thông tin");
            else
                MessageBox.Show("Tạo thất bại", "Thông tin");
            foreach (DataGridViewRow item in dgvCTHD.Rows)
            {
                if (item.Cells[0].Value != null)
                {
                    string masp = item.Cells[0].Value.ToString();
                    int sl = int.Parse(item.Cells[2].Value.ToString());
                    decimal dongia = decimal.Parse(item.Cells[3].Value.ToString());
                    decimal giamgia = decimal.Parse(item.Cells[4].Value.ToString());
                    decimal thanhtien = decimal.Parse(item.Cells[5].Value.ToString());
                    cthd.themCTHD(mahd, masp, sl, dongia, giamgia, thanhtien);
                }    
            }
        }

        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            loadTable();
            loadCBO();
        }
        private decimal tinhTongTien()
        {
            decimal tongtien = 0;
            foreach(DataGridViewRow item in dgvCTHD.Rows)
            {
                if(item.Cells[5].Value != null)
                {
                    tongtien += decimal.Parse(item.Cells[5].Value.ToString());
                }    
            }
            return tongtien;
        }
        
    }
}
