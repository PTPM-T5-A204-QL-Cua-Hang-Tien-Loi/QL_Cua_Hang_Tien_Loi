﻿using BLL_DAL;
using OpenCvSharp;
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
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace QL_CuaHangTienLoi.UserControls
{
    public partial class UC_BanHang : UserControl
    {
        Mat out2 = new Mat();
        double res;
        double res1;

        private List<KeyValuePair<string, double>> similarityList;
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
            string tensp = txtFindTenSP.Text;
            string mancc = cbFindNCC.SelectedValue.ToString();
            string maloai = cbFindLoaiSP.SelectedValue.ToString();
            float giamin = (float)numUDFrom.Value * 1000;
            float giamax = (float)numUDTo.Value * 1000;
            if (chbFindTenSP.Checked && !chbGia.Checked && !chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(tensp, 0, 0, null, null);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(tensp, giamin, giamax, null, null);
            }
            else if (chbFindTenSP.Checked && !chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(tensp, 0, 0, null, maloai);
            }
            else if (chbFindTenSP.Checked && !chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(tensp, 0, 0, mancc, null);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(tensp, giamin, giamax, null, maloai);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(tensp, giamin, giamax, mancc, null);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(tensp, 0, 0, mancc, maloai);
            }
            else if (chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(tensp, giamin, giamax, mancc, maloai);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(null, giamin, giamax, null, null);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(null, giamin, giamax, null, maloai);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(null, giamin, giamax, mancc, null);
            }
            else if (!chbFindTenSP.Checked && chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(null, giamin, giamax, mancc, maloai);
            }
            else if (!chbFindTenSP.Checked && !chbGia.Checked && chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(null, 0, 0, mancc, maloai);
            }
            else if (!chbFindTenSP.Checked && !chbGia.Checked && chbNCC.Checked && !chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(null, 0, 0, mancc, null);
            }
            else if (!chbFindTenSP.Checked && !chbGia.Checked && !chbNCC.Checked && chbLoaiSP.Checked)
            {
                dgvProduct.DataSource = sanpham.timSP_NhieuGiaTri(null, 0, 0, null, maloai);
            }

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
            chonSP();
        }

        private void chonSP()
        {
            if (dgvProduct.RowCount == 1)
                return;
            else if (dgvProduct.CurrentRow != null && dgvProduct.CurrentRow.Index < dgvProduct.Rows.Count - 1)
            {
                if (txtMaHD.Text == "")
                {
                    DateTime date = DateTime.Now;
                    string mahd = "HD" + date.ToString("ddMMyyyyHHmmss");
                    txtMaHD.Text = mahd;
                }
                txtTenNhanVien.Text = frmMain.nhanVien_using.TENNHANVIEN;
                string masp = dgvProduct.CurrentRow.Cells[0].Value.ToString();
                string tensp = dgvProduct.CurrentRow.Cells[1].Value.ToString();
                decimal dongia = decimal.Parse(dgvProduct.CurrentRow.Cells[6].Value.ToString());
                decimal giamgia = decimal.Parse(txtGiamGia.Text) / 100;
                decimal sl = numSL.Value;
                bool flag = false;
                foreach (DataGridViewRow item in dgvCTHD.Rows)
                {
                    if (masp == item.Cells[0].Value)
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
            cboKhach.DisplayMember = "TENKHACH";
            cboKhach.ValueMember = "MAKHACH";
            cboKhach.DataSource = khach.getKhachs_List();
        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            List<double> list = new List<double>();
            InterpolationFlags flag = new InterpolationFlags();
            Mat image1 = new Mat();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                image1 = new Mat(openFile.FileName);
                image1.ConvertTo(image1, MatType.CV_32FC1);
                image1.Resize(new OpenCvSharp.Size(400, 400));
            }
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    Bitmap image2 = (Bitmap)sanpham.GetHinhAnhSP(row.Cells[0].Value.ToString());
                    var imageMat = OpenCvSharp.Extensions.BitmapConverter.ToMat(image2);
                    imageMat.ConvertTo(imageMat, MatType.CV_32FC1);
                    imageMat.Resize(new OpenCvSharp.Size(400, 400));
                    Cv2.MatchTemplate(image1, imageMat, out2, TemplateMatchModes.CCoeffNormed);
                    Cv2.MinMaxLoc(out2, out res1, out res);
                    list.Add(res);
                }

            }
            for (int i = 0; i < list.Count;)
            {
                if (res > 0.7)
                {
                    dgvProduct.CurrentCell = dgvProduct.Rows[i].Cells[i];
                    dgvProduct.Rows[i].Selected = true;
                    chonSP();
                    return;
                }
            }
            MessageBox.Show("Không tìm thấy sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void btnCancelBill_Click(object sender, EventArgs e)
        {
            clearCTHD();
        }

        private void clearCTHD()
        {
            txtMaHD.Clear();
            cboKhach.ResetText();
            txtTongTien.Clear();
            dtpNgayTao.ResetText();
            loadCTHD();
        }

        private void btnMakeBills_Click(object sender, EventArgs e)
        {
            string mahd = txtMaHD.Text;
            string manv = frmMain.nhanVien_using.MANHANVIEN;
            string makhach = cboKhach.SelectedValue.ToString();
            DateTime ngaytao = dtpNgayTao.Value;
            decimal tongtien = decimal.Parse(txtTongTien.Text);
            if (soSanhSL())
            {
                MessageBox.Show("Số lượng bán vượt quá số lượng trong kho");
            }
            else
            {
                if (hd.taoHD(mahd, manv, ngaytao, makhach, tongtien))
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
                clearCTHD();
                loadTable();
            }
        }
        private bool soSanhSL()
        {
            foreach (DataGridViewRow item in dgvCTHD.Rows)
            {

                if (item.Cells[0].Value != null)
                {

                    string masp = item.Cells[0].Value.ToString();
                    int sl = int.Parse(item.Cells[2].Value.ToString());
                    if (sanpham.getSLSP(masp) < sl)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void UC_BanHang_Load(object sender, EventArgs e)
        {
            loadTable();
            loadCBO();

        }
        private decimal tinhTongTien()
        {
            decimal tongtien = 0;
            foreach (DataGridViewRow item in dgvCTHD.Rows)
            {
                if (item.Cells[5].Value != null)
                {
                    tongtien += decimal.Parse(item.Cells[5].Value.ToString());
                }
            }
            return tongtien;
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}