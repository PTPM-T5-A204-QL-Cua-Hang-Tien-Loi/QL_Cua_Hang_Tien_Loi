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
    public partial class UC_BanHang : UserControl
    {
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
        }

        private void btnLichSuBH_Click(object sender, EventArgs e)
        {
            UC_ThongKe.Instance.BringToFront();
        }
    }
}
