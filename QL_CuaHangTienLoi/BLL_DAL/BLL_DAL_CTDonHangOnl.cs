using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_CTDonHangOnl
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_CTDonHangOnl() { }
        public List<ChitietdonhangOnl> getCTDonHangOnl_List()
        {
            List<ChitietdonhangOnl> list = new List<ChitietdonhangOnl>();
            list = qlch.ChitietdonhangOnls.ToList();
            return list;
        }

        public DataTable getCTDonHangOnl_Table(int maDon)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã đơn hàng");
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Đơn giá");
            dt.Columns.Add("Thành tiền");
            var ctdonHangOnl = from ChitietdonhangOnl in qlch.ChitietdonhangOnls
                               join SANPHAM in qlch.SANPHAMs on ChitietdonhangOnl.MASP equals SANPHAM.MASP
                               where ChitietdonhangOnl.Madon.Equals(maDon)
                               select new
                             {
                                 Madon = ChitietdonhangOnl.Madon,
                                 Tensp = SANPHAM.TENSP,
                                 Soluong = ChitietdonhangOnl.Soluong,
                                 Dongia = ChitietdonhangOnl.Dongia,
                                 Thanhtien = ChitietdonhangOnl.Thanhtien,

                             };
            foreach (var item in ctdonHangOnl)
            {
                var row = dt.NewRow();
                row[0] = item.Madon;
                row[1] = item.Tensp;
                row[2] = item.Soluong;
                row[3] = item.Dongia;
                row[4] = item.Thanhtien;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public List<ChitietdonhangOnl> GetCTDonHangTheoMaDon(int maDon)
        {
            List<ChitietdonhangOnl> chitietdonhangOnls = new List<ChitietdonhangOnl>();
            var ctDonHang = from ct in qlch.ChitietdonhangOnls where ct.Madon == maDon select new { ct.MASP, ct.Soluong };
            foreach (var item in ctDonHang)
            {
                ChitietdonhangOnl ct = new ChitietdonhangOnl();
                ct.MASP = item.MASP;
                ct.Soluong = item.Soluong;
                chitietdonhangOnls.Add(ct);
            }

            return chitietdonhangOnls;
        }
    }
}
