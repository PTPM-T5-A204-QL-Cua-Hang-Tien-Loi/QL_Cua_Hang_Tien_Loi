using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_Khach
    {
        QL_CUAHANGTIENLOIEntities qlch = new QL_CUAHANGTIENLOIEntities();
        public BLL_DAL_Khach() { }
        public List<KHACH> getKhachs_List()
        {
            List<KHACH> list = new List<KHACH>();
            list = qlch.KHACHes.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getKhachs_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã khách");
            dt.Columns.Add("Tên khách");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Điện thoại");
            var khach = from k in qlch.KHACHes select new { k.MAKHACH,k.TENKHACH,k.DIACHI_KH,k.DIENTHOAI_KH };
            foreach (var item in khach)
            {
                var row = dt.NewRow();
                row[0] = item.MAKHACH;
                row[1] = item.TENKHACH;
                row[2] = item.DIACHI_KH;
                row[3] = item.DIENTHOAI_KH;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
