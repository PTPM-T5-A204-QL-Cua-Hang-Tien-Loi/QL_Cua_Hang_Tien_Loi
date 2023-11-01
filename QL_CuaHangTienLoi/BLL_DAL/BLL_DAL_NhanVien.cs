using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_NhanVien
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_NhanVien() { }
        public List<NHANVIEN> getNhanViens_List()
        {
            List<NHANVIEN> list = new List<NHANVIEN>();
            list = qlch.NHANVIENs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getNhanViens_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Tên nhân viên");
            dt.Columns.Add("Giới tính");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Điện thoại");
            dt.Columns.Add("Ngày sinh");
            var nhanvien = from nv in qlch.NHANVIENs select new { nv.MANHANVIEN,nv.TENNHANVIEN,nv.GIOITINH,nv.DIACHI_NV,nv.DIENTHOAI_NV,nv.NGAYSINH };
            foreach (var item in nhanvien)
            {
                var row = dt.NewRow();
                row[0] = item.MANHANVIEN;
                row[1] = item.TENNHANVIEN;
                row[2] = item.GIOITINH;
                row[3] = item.DIACHI_NV;
                row[4] = item.DIENTHOAI_NV;
                row[5] = item.NGAYSINH;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
