using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_CuaHangTienLoi.Models;

namespace Web_CuaHangTienLoi.Models
{
    public class GioHang
    {
        QL_CuaHangTienLoi db = new QL_CuaHangTienLoi();

        public string iMasp { get; set; }
        public string sTensp { get; set; }
        public int sHinhAnh { get; set; }
        public double dDonGia { get; set; }
        public int iSoLuong { get; set; }
        public double ThanhTien
        {
            get { return iSoLuong * dDonGia; }
        }

        //Hàm tạo cho giỏ hàng
        public GioHang(string Masp)
        {
            iMasp = Masp;
            SANPHAM sp = db.SANPHAMs.Single(n => n.MASP == iMasp);
            sTensp = sp.TENSP;
            //sHinhAnh = int.Parse(sp.HINHANH.ToString());
            dDonGia = double.Parse(sp.DONGIABAN.ToString());
            iSoLuong = 1;
        }
    }
}