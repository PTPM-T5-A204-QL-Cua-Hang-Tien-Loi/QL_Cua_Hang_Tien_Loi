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
    }
}
