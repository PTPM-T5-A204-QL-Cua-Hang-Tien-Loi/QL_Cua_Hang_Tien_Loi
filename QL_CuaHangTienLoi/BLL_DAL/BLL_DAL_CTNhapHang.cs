using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_CTNhapHang
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_CTNhapHang() { }
        public List<CHITIETNHAPHANG> getCTNhapHangs_List()
        {
            List<CHITIETNHAPHANG> list = new List<CHITIETNHAPHANG>();
            list = qlch.CHITIETNHAPHANGs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getCTNhapHangs_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Mã nhập hàng");
            dt.Columns.Add("Mã sản phẩm");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Số lượng");
            dt.Columns.Add("Tổng");
            var ctnhap = from ctnh in qlch.CHITIETNHAPHANGs select new { ctnh.ID,ctnh.MANHAPHANG,ctnh.MASP,ctnh.GIA,ctnh.SOLUONG,ctnh.TONG };
            foreach (var item in ctnhap)
            {
                var row = dt.NewRow();
                row[0] = item.ID;
                row[1] = item.MANHAPHANG;
                row[2] = item.MASP;
                row[3] = item.GIA;
                row[4] = item.SOLUONG;
                row[5] = item.TONG;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public bool Create(CHITIETNHAPHANG cHITIETNHAPHANG)
        {
            try
            {
                qlch.CHITIETNHAPHANGs.InsertOnSubmit(cHITIETNHAPHANG);
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
