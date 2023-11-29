using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_TaiKhoan
    {

        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_TaiKhoan() { }
        public List<TAIKHOAN> getTaiKhoans_List()
        {
            List<TAIKHOAN> list = new List<TAIKHOAN>();
            list = qlch.TAIKHOANs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getTaiKhoans_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã tài khoản");
            dt.Columns.Add("Tên đăng nhập");
            dt.Columns.Add("Mật khẩu");
            dt.Columns.Add("Mã quyền");
            dt.Columns.Add("Mã nhân viên");
            var taikhoan = from tk in qlch.TAIKHOANs select new { tk.MATAIKHOAN,tk.TAIKHOAN1,tk.MATKHAU,tk.MAQUYEN,tk.MANHANVIEN };
            foreach (var item in taikhoan)
            {
                var row = dt.NewRow();
                row[0] = item.MATAIKHOAN;
                row[1] = item.TAIKHOAN1;
                row[2] = item.MATKHAU;
                row[3] = item.MAQUYEN;
                row[4] = item.MANHANVIEN;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public TAIKHOAN getTaiKhoanTheoMaNV(string maNV)
        {

            TAIKHOAN tAIKHOAN = new TAIKHOAN();
            var result = from tk in qlch.TAIKHOANs where tk.MANHANVIEN == maNV select new { tk.MATAIKHOAN, tk.TAIKHOAN1, tk.MATKHAU, tk.MAQUYEN, tk.MANHANVIEN};

            foreach (var item in result)
            {
                tAIKHOAN.MATAIKHOAN = item.MATAIKHOAN;
                tAIKHOAN.TAIKHOAN1 = item.TAIKHOAN1;
                tAIKHOAN.MATKHAU = item.MATKHAU;
                tAIKHOAN.MAQUYEN = item.MAQUYEN;
                tAIKHOAN.MANHANVIEN = item.MANHANVIEN;
            }

            return tAIKHOAN;

        }

        public bool checkTaiKhoanTrung(string tenTaiKhoan)
        {
            int count = qlch.TAIKHOANs.Count(tk => tk.TAIKHOAN1 == tenTaiKhoan);

            return count > 0;

        }

        public string GetTaiKhoan(string taiKhoan, string matKhau)
        {
            var maNhanVien = (from tk in qlch.TAIKHOANs
                              where tk.TAIKHOAN1 == taiKhoan && tk.MATKHAU == matKhau
                              select tk.MANHANVIEN).FirstOrDefault();

            return maNhanVien;
        }

        public bool Create(TAIKHOAN tk)
        {
            try
            {
                qlch.TAIKHOANs.InsertOnSubmit(tk);
                qlch.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(TAIKHOAN tk)
        {
            try
            {
                TAIKHOAN tAIKHOAN = qlch.TAIKHOANs.Where(u => u.MATAIKHOAN == tk.MATAIKHOAN).SingleOrDefault();
                tAIKHOAN.MATAIKHOAN = tk.MATAIKHOAN;
                tAIKHOAN.TAIKHOAN1 = tk.TAIKHOAN1;
                tAIKHOAN.MAQUYEN = tk.MAQUYEN;
                tAIKHOAN.MANHANVIEN = tk.MANHANVIEN;
                
                qlch.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(TAIKHOAN tk)
        {
            try
            {
                TAIKHOAN tAIKHOAN = qlch.TAIKHOANs.Where(u => u.MATAIKHOAN == tk.MATAIKHOAN).SingleOrDefault();
                qlch.TAIKHOANs.DeleteOnSubmit(tAIKHOAN);
                qlch.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
