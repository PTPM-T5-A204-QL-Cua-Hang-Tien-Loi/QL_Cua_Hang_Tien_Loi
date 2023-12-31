﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_HDBan
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_HDBan() { }
        public List<HDBAN> getHDBans_List()
        {
            List<HDBAN> list = new List<HDBAN>();
            list = qlch.HDBANs.ToList();
            return list;
        }
        private DataTable taoTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Mã nhân viên");
            dt.Columns.Add("Ngày bán");
            dt.Columns.Add("Mã khách");
            dt.Columns.Add("Tổng tiền");
            return dt;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getHDBans_Table()
        {
            DataTable dt = taoTable();
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
        public DataTable getHDBansTheoNgay_Table(DateTime datenow, DateTime datethen)
        {
            DataTable dt = taoTable();
            var hoadon = from hd in qlch.HDBANs where hd.NGAYBAN>=datethen && hd.NGAYBAN<=datenow select new { hd.MAHDBAN, hd.MANHANVIEN, hd.NGAYBAN, hd.MAKHACH, hd.TONGTIEN };
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
        public List<HDBAN> getHDBansTheoNgay_List(DateTime datenow, DateTime datethen)
        {
            List<HDBAN> list = new List<HDBAN>();
            list = (List<HDBAN>)qlch.HDBANs.ToList().Where(hd => hd.NGAYBAN >= datethen && hd.NGAYBAN <= datenow);
            return list;
        }
        public bool taoHD(string mahd, string manv, DateTime ngayban, string makhach, decimal tongtien)
        {
            try
            {
                HDBAN hd = new HDBAN();
                hd.MAHDBAN = mahd;
                hd.MANHANVIEN = manv;
                hd.NGAYBAN = ngayban;
                hd.MAKHACH = makhach;
                hd.TONGTIEN = (double)tongtien;
                qlch.HDBANs.InsertOnSubmit(hd);
                qlch.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
