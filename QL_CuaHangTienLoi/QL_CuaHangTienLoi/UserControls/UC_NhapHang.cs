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
    public partial class UC_NhapHang : UserControl
    {
        BLL_DAL_NhapHang nhap = new BLL_DAL_NhapHang();
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
            dgvProduct.DataSource = nhap.getNhapHangs_Table();
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
    }
}
