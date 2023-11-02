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
    
    public partial class UC_SanPham : UserControl
    {
        static UC_SanPham _obj;
        BLL_DAL_SanPham sanpham = new BLL_DAL_SanPham();
        public static UC_SanPham Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UC_SanPham();
                }
                return _obj;
            }
        }
        public UC_SanPham()
        {
            InitializeComponent();
        }

        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            dgvSP.DataSource = sanpham.getSanPhams_Table();
        }
    }
}
