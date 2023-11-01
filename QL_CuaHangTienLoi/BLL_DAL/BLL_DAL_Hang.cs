using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_Hang
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_Hang() { }
        public List<HANG> getHangs_List()
        {
            List<HANG> list = new List<HANG>();
            list = qlch.HANGs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getHangs_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hàng");
            dt.Columns.Add("Tên hàng");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Mã loại");
            dt.Columns.Add("Đơn giá nhập");
            dt.Columns.Add("Đơn giá bán");
            var hang = from h in qlch.HANGs select new { h.MAHANG, h.TENHANG, h.SOLUONG, h.MALOAIHANG, h.DONGIANHAP, h.DONGIABAN };
            foreach(var item in hang)
            {
                var row = dt.NewRow();
                row[0] = item.MAHANG;
                row[1] = item.TENHANG;
                row[2] = item.SOLUONG;
                row[3] = item.MALOAIHANG;
                row[4] = item.DONGIANHAP;
                row[5] = item.DONGIABAN;
                dt.Rows.Add(row);
            }    
            return dt;
        }
    }
}
