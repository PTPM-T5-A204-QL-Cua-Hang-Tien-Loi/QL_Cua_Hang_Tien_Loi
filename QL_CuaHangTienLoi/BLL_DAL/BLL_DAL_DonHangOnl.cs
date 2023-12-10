using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_DonHangOnl
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        BLL_DAL_SanPham bLL_DAL_SanPham = new BLL_DAL_SanPham();
        BLL_DAL_CTDonHangOnl bLL_DAL_CTDonHangOnl = new BLL_DAL_CTDonHangOnl();
        public BLL_DAL_DonHangOnl() { }
        public List<DonhangOnl> getDonHangOnl_List()
        {
            List<DonhangOnl> list = new List<DonhangOnl>();
            list = qlch.DonhangOnls.ToList();
            return list;
        }

        public DataTable getDonHangOnl_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã đơn hàng");
            dt.Columns.Add("Tên khách hàng");
            dt.Columns.Add("Ngày đặt");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Tình trạng");
            var donHangOnl = from nguoiDung in qlch.Nguoidungs
                             join donHang in qlch.DonhangOnls on nguoiDung.MaNguoiDung equals donHang.MaNguoiDung
                             select new
                             {
                                 Madon = donHang.Madon,
                                 Hoten = nguoiDung.Hoten,
                                 Ngaydat = donHang.Ngaydat,
                                 Diachi = nguoiDung.Diachi,
                                 Tinhtrang = donHang.Tinhtrang
                             };
            foreach (var item in donHangOnl)
            {
                var row = dt.NewRow();
                row[0] = item.Madon;
                row[1] = item.Hoten;
                row[2] = item.Ngaydat;
                row[3] = item.Diachi;
                row[4] = item.Tinhtrang;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public DonhangOnl getInfoDonHang(string maDH)
        {
            DonhangOnl donhangOnl = new DonhangOnl();

            var info = from donHang in qlch.DonhangOnls
                       where donHang.Madon.ToString().Contains(maDH)
                       select new
                       {
                           Madon = donHang.Madon,
                           MaND = donHang.MaNguoiDung,
                           Ngaydat = donHang.Ngaydat,
                           Tinhtrang = donHang.Tinhtrang
                       };

            foreach (var item in info)
            {
                donhangOnl.Madon = item.Madon;
                donhangOnl.Ngaydat = item.Ngaydat;
                donhangOnl.Tinhtrang = item.Tinhtrang;
                donhangOnl.MaNguoiDung = item.MaND;
            }

            return donhangOnl;
        }

        public bool Update(DonhangOnl donhangOnl)
        {
            try
            {
                DonhangOnl donhang = qlch.DonhangOnls.Where(u => u.Madon == donhangOnl.Madon).SingleOrDefault();
                donhang.Madon = donhangOnl.Madon;
                donhang.Ngaydat = donhangOnl.Ngaydat;
                donhang.Tinhtrang = donhangOnl.Tinhtrang;
                if(donhangOnl.Tinhtrang == "Đã giao")
                {
                    List<ChitietdonhangOnl> ct = bLL_DAL_CTDonHangOnl.GetCTDonHangTheoMaDon(donhangOnl.Madon);
                    foreach (var item in ct)
                    {
                        SANPHAM sp = bLL_DAL_SanPham.getInfoSanPham(item.MASP);
                        sp.SOLUONG = (int)(sp.SOLUONG - item.Soluong);
                        bLL_DAL_SanPham.Edit(sp);
                    }
                }
                donhang.MaNguoiDung = donhang.MaNguoiDung;
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
