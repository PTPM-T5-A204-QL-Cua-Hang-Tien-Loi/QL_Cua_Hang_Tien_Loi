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
    public partial class frmTaiKhoan : Form
    {
        NHANVIEN nHANVIEN;
        TAIKHOAN tk;
        BLL_DAL_Quyen bLL_DAL_Quyen = new BLL_DAL_Quyen();
        BLL_DAL_TaiKhoan bLL_DAL_TaiKhoan = new BLL_DAL_TaiKhoan();
        private bool checkTKNew;
        public frmTaiKhoan()
        {
            InitializeComponent();


        }

        public frmTaiKhoan(TAIKHOAN taiKhoan, NHANVIEN nv)
        {
            InitializeComponent();

            tk = taiKhoan;

            nHANVIEN = nv;

            LoadDataCombobox();

            LoadThongTinTK();

            lblTenNV.Text = nv.TENNHANVIEN;

            checkTKNew = false;
        }

        private void LoadThongTinTK()
        {
            txtMaTK.Text = tk.MATAIKHOAN;
            txtTaiKhoan.Text = tk.TAIKHOAN1;
            txtMatKhau.Text = tk.MATKHAU;
        }

        public frmTaiKhoan(NHANVIEN nv)
        {
            InitializeComponent();

            tk = new TAIKHOAN();

            nHANVIEN = nv;

            LoadDataCombobox();

            LoadThongTinTK();


            lblTenNV.Text = nv.TENNHANVIEN;

            checkTKNew = true;
        }

        private void LoadDataCombobox()
        {
            cbQuyen.DisplayMember = "TENQUYEN";
            cbQuyen.ValueMember = "MAQUYEN";
            cbQuyen.DataSource = bLL_DAL_Quyen.getQuyens_List();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            TAIKHOAN tAIKHOAN = new TAIKHOAN();
            tAIKHOAN.MATAIKHOAN = txtMaTK.Text;
            tAIKHOAN.TAIKHOAN1 = txtTaiKhoan.Text;
            tAIKHOAN.MATKHAU = txtMatKhau.Text;
            tAIKHOAN.MAQUYEN = (int?)cbQuyen.SelectedValue;
            tAIKHOAN.MANHANVIEN = nHANVIEN.MANHANVIEN;

            if (checkInfomation(tAIKHOAN))
            {
                if (checkTKNew)
                {
                    if (bLL_DAL_TaiKhoan.Create(tAIKHOAN))
                    {
                        MessageBox.Show("Thêm thông tin tài khoản cho nhân viên thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin tài khoản không thành công!", "LỖI",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (bLL_DAL_TaiKhoan.Edit(tAIKHOAN))
                    {
                        MessageBox.Show("Cập nhật thông tin tài khoản thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi trong quá trình thêm!\n Vui lòng kiểm tra lại dữ liệu!", "LỖI",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool checkInfomation(TAIKHOAN tAIKHOAN)
        {
            if (tAIKHOAN.TAIKHOAN1 == "" || tAIKHOAN.MATKHAU == "")
                return false;
            return true;
        }
    }
}
