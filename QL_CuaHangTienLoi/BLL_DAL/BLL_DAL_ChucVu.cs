using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_ChucVu
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_ChucVu() { }
        public List<CHUCVU> getChucVus_List()
        {
            List<CHUCVU> list = new List<CHUCVU>();
            list = qlch.CHUCVUs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getChucVus_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã chức vụ");
            dt.Columns.Add("Tên chức vụ");
            var chucvu = from cv in qlch.CHUCVUs select new { cv.MACHUCVU, cv.TENCHUCVU };
            foreach (var item in chucvu)
            {
                var row = dt.NewRow();
                row[0] = item.MACHUCVU;
                row[1] = item.TENCHUCVU;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
