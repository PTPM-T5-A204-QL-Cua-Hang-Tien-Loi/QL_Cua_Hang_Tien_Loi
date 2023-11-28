using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_LoaiSP
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_LoaiSP() { }
        public List<LOAISP> getLoaiSPs_List()
        {
            List<LOAISP> list = new List<LOAISP>();
            list = qlch.LOAISPs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getLoaiSPs_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã loại hàng");
            dt.Columns.Add("Tên loại hàng");
            var loaihang = from lh in qlch.LOAISPs select new { lh.MALOAI,lh.TENLOAI };
            foreach (var item in loaihang)
            {
                var row = dt.NewRow();
                row[0] = item.MALOAI;
                row[1] = item.TENLOAI;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public string geTenLoaiMaLoai(string maLoai)
        {
            var query = from loai in qlch.LOAISPs
                        where loai.MALOAI == maLoai
                        select loai.TENLOAI;

            return query.FirstOrDefault();
        }
    }
}
