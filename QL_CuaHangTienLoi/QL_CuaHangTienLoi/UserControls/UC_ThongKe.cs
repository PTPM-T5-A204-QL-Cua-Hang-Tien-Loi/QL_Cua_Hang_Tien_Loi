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
    public partial class UC_ThongKe : UserControl
    {
        static UC_ThongKe _obj;
        public static UC_ThongKe Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new UC_ThongKe();
                }
                return _obj;
            }
        }
        public UC_ThongKe()
        {
            InitializeComponent();
        }
    }
}
