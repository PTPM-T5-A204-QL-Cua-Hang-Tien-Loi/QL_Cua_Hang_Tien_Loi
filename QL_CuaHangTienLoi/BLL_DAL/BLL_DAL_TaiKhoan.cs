using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    internal class BLL_DAL_TaiKhoan
    {

        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_TaiKhoan() { }
        public List<TAIKHOAN> getTaiKhoans_List()
        {
            List<TAIKHOAN> list = new List<TAIKHOAN>();
            list = qlch.TAIKHOANs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getTaiKhoans_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã tài khoản");
            dt.Columns.Add("Tên đăng nhập");
            dt.Columns.Add("Mật khẩu");
            dt.Columns.Add("Mã quyền");
            dt.Columns.Add("Mã nhân viên");
            var taikhoan = from tk in qlch.TAIKHOANs select new { tk.MATAIKHOAN,tk.TAIKHOAN1,tk.MATKHAU,tk.MAQUYEN,tk.MANHANVIEN };
            foreach (var item in taikhoan)
            {
                var row = dt.NewRow();
                row[0] = item.MATAIKHOAN;
                row[1] = item.TAIKHOAN1;
                row[2] = item.MATKHAU;
                row[3] = item.MAQUYEN;
                row[4] = item.MANHANVIEN;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
