using BLL_DAL;
using BLL_DAL.Function;
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

namespace QL_CuaHangTienLoi
{
    public partial class frmSanPham : Form
    {
        BLL_DAL_SanPham sanpham = new BLL_DAL_SanPham();
        BLL_DAL_LoaiSP loaisp = new BLL_DAL_LoaiSP();
        BLL_DAL_NhaCC ncc = new BLL_DAL_NhaCC();
        private bool checkSPNew;
        System.Data.Linq.Binary tempPicture;

        public frmSanPham()
        {
            InitializeComponent();

            LoadDataCombobox();
            LoadThongTinSP(new SANPHAM());
            checkSPNew = true;
        }

        private void LoadThongTinSP(SANPHAM sp)
        {
            txtMaSP.Text = sp.MASP;
            txtTenSP.Text = sp.TENSP;
            txtDonVi.Text = sp.DONVI;
            txtSoLuong.Text = sp.SOLUONG.ToString();
            txtGia.Text = sp.DONGIABAN.ToString();

            cbLoaiSP.Text = loaisp.geTenLoaiMaLoai(sp.MALOAI);
            cbNCC.Text = ncc.geTenNCCTheoMa(sp.MANCC);

            picHinhAnh.Image = sanpham.GetHinhAnhSP(sp.MASP);


        }

        public frmSanPham(SANPHAM sanPham)
        {
            InitializeComponent();

            checkSPNew = false;

            LoadDataCombobox();
            LoadThongTinSP(sanPham);

            tempPicture = sanPham.HINHANH;
        }

        private void LoadDataCombobox()
        {
            cbLoaiSP.DisplayMember = "TENLOAI";
            cbLoaiSP.ValueMember = "MALOAI";
            cbLoaiSP.DataSource = loaisp.getLoaiSPs_List();
            cbNCC.DisplayMember = "TENNCC";
            cbNCC.ValueMember = "MANCC";
            cbNCC.DataSource = ncc.getNCCs_List();
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            new frmNhaCungCap().ShowDialog();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                MessageBox.Show("Vui lòng cung cấp đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            SANPHAM sp = new SANPHAM();
            sp.MASP = txtMaSP.Text;
            sp.TENSP = txtTenSP.Text;
            sp.MALOAI = cbLoaiSP.SelectedValue.ToString();
            sp.DONVI = txtDonVi.Text;
            sp.MANCC = cbNCC.SelectedValue.ToString();
            sp.DONGIABAN = double.Parse(txtGia.Text);
            sp.SOLUONG = int.Parse(txtSoLuong.Text);

            try
            {
                System.Drawing.Imaging.ImageFormat format = FConvert.GetImageFormat(picHinhAnh.Image);
                byte[] imageBytes = FConvert.ImageToByteArray(picHinhAnh.Image, format);
                sp.HINHANH = new System.Data.Linq.Binary(imageBytes);
            }
            catch (Exception)
            {
                sp.HINHANH = tempPicture;
            }

            if (checkSPNew)
            {
                if (sanpham.Create(sp))
                {
                    MessageBox.Show("Thêm sản phẩm mới thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm!\n Vui lòng kiểm tra lại dữ liệu!", "LỖI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                if (sanpham.Edit(sp))
                {
                    MessageBox.Show("Cập nhật sản phẩm thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm!\n Vui lòng kiểm tra lại dữ liệu!", "LỖI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private bool isValid()
        {
            if (txtTenSP.Text == "" && txtDonVi.Text == "")
                return false;
            if (picHinhAnh.Image == null)
                return false;
            return true;
        }
    }
}
