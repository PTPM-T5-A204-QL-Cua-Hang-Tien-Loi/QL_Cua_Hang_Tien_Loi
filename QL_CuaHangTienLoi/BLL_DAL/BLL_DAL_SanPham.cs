using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Linq.SqlClient;
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
    }
}
