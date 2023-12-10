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

namespace QL_CuaHangTienLoi
{
    public partial class frmTHNhaCungCap : Form
    {
        BLL_DAL_NhaCC bll_dal_nhacc;
        private NHACUNGCAP ncc_choosing;
        public frmTHNhaCungCap()
        {
            InitializeComponent();
            bll_dal_nhacc = new BLL_DAL_NhaCC();
            btnEditNCC.Enabled = false;
            LoadDataNCC();

        }

        private void LoadDataNCC()
        {
            dgvNCC.Controls.Clear();

            dgvNCC.DataSource = bll_dal_nhacc.getNCCs_Table();
            dgvNCC.Columns[0].Visible = false;

            ncc_choosing = new NHACUNGCAP();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            new frmNhaCungCap().ShowDialog(); 
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataNCC();
        }

        private void btnEditNCC_Click(object sender, EventArgs e)
        {
            new frmNhaCungCap(ncc_choosing).ShowDialog();
        }

        private void dgvNCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvNCC.CurrentCell.RowIndex == dgvNCC.RowCount - 1)
                return;

            ncc_choosing.MANCC = dgvNCC.CurrentRow.Cells[0].Value.ToString();
            ncc_choosing.TENNCC = dgvNCC.CurrentRow.Cells[1].Value.ToString();
            ncc_choosing.DIACHINCC = dgvNCC.CurrentRow.Cells[2].Value.ToString();
            ncc_choosing.EMAIL = dgvNCC.CurrentRow.Cells[3].Value.ToString();
            ncc_choosing.SDTNCC = dgvNCC.CurrentRow.Cells[4].Value.ToString();

            btnEditNCC.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ncc_choosing != null)
            {
                if (MessageBox.Show($"Bạn có thực sự muốn xóa nhà cung cấp {ncc_choosing.TENNCC} không?", "CẢNH BÁO",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (bll_dal_nhacc.Delete(ncc_choosing))
                    {
                        ncc_choosing = null;
                        MessageBox.Show("Đã xóa thông tin thành công!", "THÔNG BÁO");
                        LoadDataNCC();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thông tin không thành công!\nVui lòng kiểm tra lại các sản phẩm của nhà cung cấp này!", "LỖI",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
