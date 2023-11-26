using BLL_DAL.Function;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Linq;
using System.Data.Linq.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_SanPham
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_SanPham() { }
        public List<SANPHAM> getSanPhams_List()
        {
            List<SANPHAM> list = new List<SANPHAM>();
            list = qlch.SANPHAMs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getSanPhams_Table()
        {
            DataTable dt = taoTable();
            var hang = from h in qlch.SANPHAMs select new {h.MASP, h.TENSP,h.DONVI, h.SOLUONG, h.MALOAI,h.MANCC, h.DONGIABAN };
            foreach(var item in hang)
            {
                var row = dt.NewRow();
                row[0] = item.MASP;
                row[1] = item.TENSP;
                row[2] = item.DONVI;
                row[3] = item.SOLUONG;
                row[4] = item.MALOAI;
                row[5] = item.MANCC;
                row[6] = item.DONGIABAN;
                dt.Rows.Add(row);
            }    
            return dt;
        }

        public byte[] getHinhAnhSanPham(string maSP)
        {
            var query = from sp in qlch.SANPHAMs
                        where sp.MASP == maSP
                        select sp.HINHANH;

            if (query != null)
            {
                List<byte> byteArray = new List<byte>();

                foreach (System.Data.Linq.Binary linqBinary in query)
                {
                    if (linqBinary != null && linqBinary.Length > 0)
                    {
                        byteArray.AddRange(linqBinary.ToArray());
                    }
                }

                return byteArray.ToArray();
            }
            else
            {
                return null;
            }

        }

        public SANPHAM getInfoSanPham (string maSp)
        {
            SANPHAM sp = new SANPHAM();

            var info = from h in qlch.SANPHAMs where h.MASP.Contains(maSp) select new { h.MASP, h.TENSP, h.DONVI, h.SOLUONG, h.MALOAI, h.MANCC, h.DONGIABAN, h.HINHANH };

            foreach (var item in info)
            {
                sp.MASP = item.MASP;
                sp.TENSP = item.TENSP;
                sp.DONVI = item.DONVI;
                sp.SOLUONG = item.SOLUONG;
                sp.MALOAI = item.MALOAI;
                sp.MANCC = item.MANCC;
                sp.HINHANH = item.HINHANH;
                sp.DONGIABAN = item.DONGIABAN;
            }

            return sp;
        }

        private DataTable taoTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã hàng");
            dt.Columns.Add("Tên hàng");
            dt.Columns.Add("Đơn vị");
            dt.Columns.Add("Số lượng", typeof(int));
            dt.Columns.Add("Mã loại");
            dt.Columns.Add("Mã nhà cung cấp");
            dt.Columns.Add("Đơn giá bán", typeof(float));
            return dt;
        }
        public DataTable timSP_NhieuGiaTri(string tensp, float giamin, float giamax, string mancc, string maloai)
        {
            DataTable dt = taoTable();
            if (tensp != null)
            {
                var sanpham = from h in qlch.SANPHAMs where h.TENSP.Contains(tensp) select new { h.MASP, h.TENSP, h.DONVI, h.SOLUONG, h.MALOAI, h.MANCC, h.DONGIABAN };
                foreach (var item in sanpham)
                {
                    var row = dt.NewRow();
                    row[0] = item.MASP;
                    row[1] = item.TENSP;
                    row[2] = item.DONVI;
                    row[3] = item.SOLUONG;
                    row[4] = item.MALOAI;
                    row[5] = item.MANCC;
                    row[6] = item.DONGIABAN;
                    dt.Rows.Add(row);
                }
            }
            else if (giamax != 0)
            {
                var sanpham = from h in qlch.SANPHAMs where (h.DONGIABAN >= giamin && h.DONGIABAN <= giamax) select new { h.MASP, h.TENSP, h.DONVI, h.SOLUONG, h.MALOAI, h.MANCC, h.DONGIABAN };
                foreach (var item in sanpham)
                {
                    var row = dt.NewRow();
                    row[0] = item.MASP;
                    row[1] = item.TENSP;
                    row[2] = item.DONVI;
                    row[3] = item.SOLUONG;
                    row[4] = item.MALOAI;
                    row[5] = item.MANCC;
                    row[6] = item.DONGIABAN;
                    dt.Rows.Add(row);
                }
                giamax = 0;
            }
            else if (mancc != null)
            {
                var sanpham = from h in qlch.SANPHAMs where h.MANCC == mancc select new { h.MASP, h.TENSP, h.DONVI, h.SOLUONG, h.MALOAI, h.MANCC, h.DONGIABAN };
                foreach (var item in sanpham)
                {
                    var row = dt.NewRow();
                    row[0] = item.MASP;
                    row[1] = item.TENSP;
                    row[2] = item.DONVI;
                    row[3] = item.SOLUONG;
                    row[4] = item.MALOAI;
                    row[5] = item.MANCC;
                    row[6] = item.DONGIABAN;
                    dt.Rows.Add(row);
                }
                mancc = null;
            }
            else if(maloai != null) 
            {
                var sanpham = from h in qlch.SANPHAMs where h.MALOAI == maloai select new { h.MASP, h.TENSP, h.DONVI, h.SOLUONG, h.MALOAI, h.MANCC, h.DONGIABAN };
                foreach (var item in sanpham)
                {
                    var row = dt.NewRow();
                    row[0] = item.MASP;
                    row[1] = item.TENSP;
                    row[2] = item.DONVI;
                    row[3] = item.SOLUONG;
                    row[4] = item.MALOAI;
                    row[5] = item.MANCC;
                    row[6] = item.DONGIABAN;
                    dt.Rows.Add(row);
                }
                maloai = null;
            }
            if (giamax != 0)
            {
                DataRow[] rows = dt.Select("[Đơn giá bán]>=" + giamin + " AND [Đơn giá bán]<=" + giamax + "");
                cloneTable(dt, rows);
            }
            if (mancc != null)
            {
                DataRow[] rows = dt.Select("[Mã nhà cung cấp]='" + mancc + "'");
                cloneTable(dt, rows);
            }
            if (maloai != null)
            {
                DataRow[] rows = dt.Select("[Mã loại]='" + maloai + "'");
                cloneTable(dt, rows);
            }

            return dt;
        }
        private void cloneTable(DataTable dt, DataRow[] rows)
        {
            DataTable newdt = dt.Clone();
            foreach (DataRow row in rows)
            {
                DataRow newRow = newdt.NewRow();
                newRow.ItemArray = row.ItemArray;
                newdt.Rows.Add(newRow);
            }
            dt = newdt;
        }

        public bool Create(SANPHAM sp)
        {
            try
            {
                qlch.SANPHAMs.InsertOnSubmit(sp);
                qlch.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Edit(SANPHAM sp)
        {
            try
            {
                SANPHAM sanPham = qlch.SANPHAMs.Where(u => u.MASP == sp.MASP).SingleOrDefault();
                sanPham.MASP = sp.MASP;
                sanPham.TENSP = sp.TENSP;
                sanPham.DONVI = sp.DONVI;
                sanPham.SOLUONG = sp.SOLUONG;
                sanPham.MALOAI = sp.MALOAI;
                sanPham.MANCC = sp.MANCC;
                sanPham.HINHANH = sp.HINHANH;
                sanPham.DONGIABAN = sp.DONGIABAN;
                qlch.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public System.Drawing.Image GetHinhAnhSP(string maSP)
        {
            var imageData = (from sp in qlch.SANPHAMs
                             where sp.MASP == maSP
                             select sp.HINHANH).FirstOrDefault();

            if (imageData != null && imageData.Length > 0)
            {
                byte[] imageBytes = imageData.ToArray();
                return FConvert.ByteArrayToImage(imageBytes);
            }
            else
            {
                return null; 
            }
        }
    }
}
