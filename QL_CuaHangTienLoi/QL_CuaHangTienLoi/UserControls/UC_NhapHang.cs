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
    public partial class UC_NhapHang : UserControl
    {
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
    }
}
