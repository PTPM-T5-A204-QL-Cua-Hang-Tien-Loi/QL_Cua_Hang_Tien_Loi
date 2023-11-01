using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_ChiTietHD
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_ChiTietHD() { }
        public List<Chi> getCTHDBans_List()
        {
            List<CHITIETHDBAN> list = new List<CHITIETHDBAN>();
            list = qlch.CHITIETHDBANs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getCTHDBans_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Mã hàng");
            dt.Columns.Add("Số lượng mua");
            dt.Columns.Add("Đơn giá");
            dt.Columns.Add("Giảm giá");
            dt.Columns.Add("Thành tiền");
            var cthoadon = from cthd in qlch.CHITIETHDBANs select new { cthd.MAHDBAN, cthd.MAHANG,cthd.SOLUONGMUA,cthd.DONGIA,cthd.GIAMGIA,cthd.THANHTIEN};
            foreach (var item in cthoadon)
            {
                var row = dt.NewRow();
                row[0] = item.MAHDBAN;
                row[1] = item.MAHANG;
                row[2] = item.SOLUONGMUA;
                row[3] = item.DONGIA;
                row[4] = item.GIAMGIA;
                row[5] = item.THANHTIEN;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
