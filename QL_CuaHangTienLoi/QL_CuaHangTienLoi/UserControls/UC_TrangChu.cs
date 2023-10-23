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
    public partial class UC_TrangChu : UserControl
    {
        static UC_TrangChu _obj;
        public static UC_TrangChu Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UC_TrangChu();
                }
                return _obj;
            }
        }
        public UC_TrangChu()
        {
            InitializeComponent();
        }
    }
}
