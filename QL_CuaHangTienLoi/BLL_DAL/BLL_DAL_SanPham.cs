using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_SanPham
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_SanPham() { }
        public List<SANPHAM> getSanPhams_List()
        {
            List<SANPHAM> list = new List<SANPHAM>();
            list = qlch.SANPHAMs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getSanPhams_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hàng");
            dt.Columns.Add("Tên hàng");
            dt.Columns.Add("Đơn vị");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Mã loại");
            dt.Columns.Add("Mã nhà cung cấp");
            dt.Columns.Add("Đơn giá bán");
            var hang = from h in qlch.SANPHAMs select new {h.MASP, h.TENSP,h.DONVI, h.SOLUONG, h.MALOAI,h.MANCC, h.DONGIABAN };
            foreach(var item in hang)
            {
                var row = dt.NewRow();
                row[0] = item.MASP;
                row[1] = item.TENSP;
                row[2] = item.DONVI;
                row[3] = item.SOLUONG;
                row[4] = item.MALOAI;
                row[5] = item.MANCC;
                row[6] = item.DONGIABAN;
                dt.Rows.Add(row);
            }    
            return dt;
        }
    }
}
