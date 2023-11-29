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
    public partial class UC_NhanVien : UserControl
    {
        NHANVIEN nv = new NHANVIEN();
        BLL_DAL_NhanVien bLL_DAL_NhanVien = new BLL_DAL_NhanVien();

        static UC_NhanVien _obj;
        public static UC_NhanVien Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UC_NhanVien();
                }
                return _obj;
            }
        }

        public UC_NhanVien()
        {
            InitializeComponent();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frmNhanVien().ShowDialog();
        }

        private void btnCapTK_Click(object sender, EventArgs e)
        {
            new frmTaiKhoan().ShowDialog();
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bLL_DAL_NhanVien.getNhanViens_Table();
            dgvNhanVien.Columns[0].Visible = false;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNhanVien.CurrentCell.RowIndex == dgvNhanVien.RowCount - 1)
                return;

            nv = bLL_DAL_NhanVien.getInfoNhanVien(dgvNhanVien.CurrentRow.Cells[0].Value.ToString());

            txtTenNV.Text = nv.TENNHANVIEN;
            txtGioiTinh.Text = nv.GIOITINH;
            dtPickNgaySinh.Value = (DateTime)nv.NGAYSINH;
            txtDiaChi.Text = nv.DIACHI_NV;
            txtSoDT.Text = nv.DIENTHOAI_NV;
            txtEmail.Text = nv.Email;

            picNhanVien.Image = bLL_DAL_NhanVien.GetHinhAnhNV(nv.MANHANVIEN);

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            dgvNhanVien.DataSource = bLL_DAL_NhanVien.getNhanViens_Table();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTenNV.Clear();
            txtDiaChi.Clear();
            txtSoDT.Clear();
            txtEmail.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "")
            {
                if (MessageBox.Show($"Bạn có muốn xóa nhân viên {nv.TENNHANVIEN}?", "CẢNH BÁO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bLL_DAL_NhanVien.Delete(nv))
                    {
                        MessageBox.Show("Đã xóa thông tin nhân viên!", "THÔNG BÁO");
                        dgvNhanVien.DataSource = bLL_DAL_NhanVien.getNhanViens_Table();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin nhân viên không thành công!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn một nhân viên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEditNV_Click(object sender, EventArgs e)
        {
            if (nv.TENNHANVIEN != "")
                new frmNhanVien(nv).ShowDialog();
        }
    }
}
