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

namespace QL_CuaHangTienLoi
{
    public partial class frmNhanVien : Form
    {
        private bool checkNVNew;
        System.Data.Linq.Binary tempPicture;
        BLL_DAL_NhanVien bLL_DAL_NhanVien = new BLL_DAL_NhanVien();
        public frmNhanVien()
        {
            InitializeComponent();

            LoadThongTinSP(new NHANVIEN());
            checkNVNew = true;
        }

        public frmNhanVien(NHANVIEN nv)
        {
            InitializeComponent();

            checkNVNew = false;

            LoadThongTinSP(nv);

            tempPicture = nv.HinhAnh;
        }

        private void LoadThongTinSP(NHANVIEN nHANVIEN)
        {
            txtMaNV.Text = nHANVIEN.MANHANVIEN;
            txtTenNV.Text = nHANVIEN.TENNHANVIEN;
            cbGioiTinh.Text = nHANVIEN.GIOITINH;
            dtPickNgaySinh.Value = (DateTime)nHANVIEN.NGAYSINH;
            txtDiaChi.Text = nHANVIEN.DIACHI_NV;
            txtSoDT.Text = nHANVIEN.DIENTHOAI_NV;
            txtEmail.Text = nHANVIEN.Email;

            picHinhAnh.Image = bLL_DAL_NhanVien.GetHinhAnhNV(nHANVIEN.MANHANVIEN);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!isValid())
            {
                MessageBox.Show("Vui lòng cung cấp đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK);
                return;
            }

            NHANVIEN nv = new NHANVIEN();
            nv.MANHANVIEN = txtMaNV.Text;
            nv.TENNHANVIEN = txtTenNV.Text;
            nv.GIOITINH = cbGioiTinh.Text;
            nv.NGAYSINH = dtPickNgaySinh.Value;
            nv.DIACHI_NV = txtDiaChi.Text;
            nv.DIENTHOAI_NV = txtSoDT.Text;
            nv.Email = txtEmail.Text;

            try
            {
                System.Drawing.Imaging.ImageFormat format = FConvert.GetImageFormat(picHinhAnh.Image);
                byte[] imageBytes = FConvert.ImageToByteArray(picHinhAnh.Image, format);
                nv.HinhAnh = new System.Data.Linq.Binary(imageBytes);
            }
            catch (Exception)
            {
                nv.HinhAnh = tempPicture;
            }

            if (checkNVNew)
            {
                if (bLL_DAL_NhanVien.Create(nv))
                {
                    MessageBox.Show("Thêm nhân viên mới thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                    Close();
                }
                else
                {
                    MessageBox.Show("Có lỗi trong quá trình thêm!\n Vui lòng kiểm tra lại dữ liệu!", "LỖI",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (bLL_DAL_NhanVien.Edit(nv))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
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
            if (txtTenNV.Text == "" && txtDiaChi.Text == "" && txtSoDT.Text == "" && txtEmail.Text == "" && cbGioiTinh.Text == "")
                return false;
            if (!Checking.IsValidEmail(txtEmail.Text))
                return false;
            if (picHinhAnh.Image == null)
                return false;
            return true;
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picHinhAnh.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
