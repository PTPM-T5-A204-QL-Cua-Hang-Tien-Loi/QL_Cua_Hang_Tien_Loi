using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_HDBan
    {
        QL_CUAHANGTIENLOIEntities qlch = new QL_CUAHANGTIENLOIEntities();
        public BLL_DAL_HDBan() { }
        public List<HDBAN> getHDBans_List()
        {
            List<HDBAN> list = new List<HDBAN>();
            list = qlch.HDBANs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getHDBans_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Ngày bán");
            dt.Columns.Add("Mã khách");
            dt.Columns.Add("Tổng tiền");
            var hoadon = from hd in qlch.HDBANs select new { hd.MAHDBAN,hd.MANHANVIEN,hd.NGAYBAN,hd.MAKHACH,hd.TONGTIEN };
            foreach (var item in hoadon)
            {
                var row = dt.NewRow();
                row[0] = item.MAHDBAN;
                row[1] = item.MANHANVIEN;
                row[2] = item.NGAYBAN;
                row[3] = item.MAKHACH;
                row[4] = item.TONGTIEN;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
