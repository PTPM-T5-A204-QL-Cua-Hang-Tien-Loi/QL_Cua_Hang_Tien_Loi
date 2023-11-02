using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_NhapHang
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_NhapHang() { }
        public List<NHAPHANG> getNhapHangs_List()
        {
            List<NHAPHANG> list = new List<NHAPHANG>();
            list = qlch.NHAPHANGs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getNhapHangs_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhập");
            dt.Columns.Add("Ngày tạo");
            dt.Columns.Add("Tổng tiền");
            dt.Columns.Add("Mã nhân viên");
            var nhap = from nh in qlch.NHAPHANGs select new { nh.MANHAPHANG,nh.NGAYTAO,nh.TONGTIEN,nh.MANHANVIEN };
            foreach (var item in nhap)
            {
                var row = dt.NewRow();
                row[0] = item.MANHAPHANG;
                row[1] = item.NGAYTAO;
                row[2] = item.TONGTIEN;
                row[3] = item.MANHANVIEN;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
