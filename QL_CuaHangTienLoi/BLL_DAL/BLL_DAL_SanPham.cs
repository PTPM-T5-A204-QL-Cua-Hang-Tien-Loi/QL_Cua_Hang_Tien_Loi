using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data.Entity;

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
            dt.Columns.Add("Loại");
            dt.Columns.Add("Đơn vị");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Đơn giá bán");
            var hang = from sp in qlch.SANPHAMs
                       join loai in qlch.LOAISPs on sp.MALOAI equals loai.MALOAI
                       select new
                       {
                           MASP = sp.MASP,
                           TENSP = sp.TENSP,
                           TENLOAI = loai.TENLOAI,
                           DONVI = sp.DONVI,
                           SOLUONG = sp.SOLUONG,
                           DONGIABAN = sp.DONGIABAN
                       }; ;
            foreach(var item in hang)
            {
                var row = dt.NewRow();
                row[0] = item.MASP;
                row[1] = item.TENSP;
                row[2] = item.TENLOAI;
                row[3] = item.DONVI;
                row[4] = item.SOLUONG;
                row[5] = item.DONGIABAN;
                dt.Rows.Add(row);
            }    
            return dt;
        }

      
    }
}
