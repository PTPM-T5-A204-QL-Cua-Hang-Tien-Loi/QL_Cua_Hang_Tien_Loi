using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_LoaiHang
    {
        QL_CUAHANGTIENLOIEntities qlch = new QL_CUAHANGTIENLOIEntities();
        public BLL_DAL_LoaiHang() { }
        public List<LOAIHANG> getLoaiHangs_List()
        {
            List<LOAIHANG> list = new List<LOAIHANG>();
            list = qlch.LOAIHANGs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getLoaiHangs_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã loại hàng");
            dt.Columns.Add("Tên loại hàng");
            var loaihang = from lh in qlch.LOAIHANGs select new { lh.MALOAIHANG,lh.TENLOAIHANG };
            foreach (var item in loaihang)
            {
                var row = dt.NewRow();
                row[0] = item.MALOAIHANG;
                row[1] = item.TENLOAIHANG;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
