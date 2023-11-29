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
    public partial class frmNhaCungCap : Form
    {
        BLL_DAL_NhaCC bll_dal_ncc;
        public frmNhaCungCap()
        {
            InitializeComponent();

            bll_dal_ncc = new BLL_DAL_NhaCC();
            LoadNCC(new NHACUNGCAP());
        }

        public frmNhaCungCap(NHACUNGCAP ncc)
        {
            InitializeComponent();

            bll_dal_ncc = new BLL_DAL_NhaCC();
            LoadNCC(ncc);
        }

        private void LoadNCC(NHACUNGCAP ncc)
        {
            txtMaNCC.Text = ncc.MANCC;
            txtTenNCC.Text = ncc.TENNCC;
            txtDiaChi.Text = ncc.DIACHINCC;
            txtEmail.Text = ncc.EMAIL;
            txtSoDT.Text = ncc.SDTNCC;
        }

        private bool checkInformation(NHACUNGCAP ncc)
        {
            if (ncc.TENNCC == "" || ncc.DIACHINCC == "")
                return false;
            if (ncc.SDTNCC == "" || ncc.SDTNCC.Length < 10)
                return false;
            if (!Checking.IsValidEmail(ncc.EMAIL))
                return false;
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            NHACUNGCAP ncc = new NHACUNGCAP();
            ncc.MANCC = txtMaNCC.Text;
            ncc.TENNCC = txtTenNCC.Text.Trim();
            ncc.DIACHINCC = txtDiaChi.Text.Trim();
            ncc.EMAIL = txtEmail.Text.Trim();
            ncc.SDTNCC = txtSoDT.Text.Trim();

            if (checkInformation(ncc))
            {
                if (bll_dal_ncc.getNCCTheoMaNCC(ncc.MANCC).TENNCC == null)
                {
                    if (bll_dal_ncc.Create(ncc))
                    {
                        MessageBox.Show("Thêm thông tin Nhà cung cấp thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin Nhà cung cấp không thành công!", "LỖI",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (bll_dal_ncc.Update(ncc))
                    {
                        MessageBox.Show("Cập nhật thông tin Nhà cung cấp thành công!", "THÔNG BÁO", MessageBoxButtons.OK);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra trong quá trình cập nhật!", "LỖI",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Thông tin chưa phù hợp!\nVui lòng điều chỉnh lại!", "LỖI",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
