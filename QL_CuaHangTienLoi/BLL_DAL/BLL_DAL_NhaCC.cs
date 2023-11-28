using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_NhaCC
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_NhaCC() { }
        public List<NHACUNGCAP> getNCCs_List()
        {
            List<NHACUNGCAP> list = new List<NHACUNGCAP>();
            list = qlch.NHACUNGCAPs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getNCCs_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã nhà cung cấp");
            dt.Columns.Add("Tên nhà cung cấp");
            dt.Columns.Add("Địa chỉ");
            dt.Columns.Add("Email");
            dt.Columns.Add("Điện thoại");
            var nhacc = from ncc in qlch.NHACUNGCAPs select new { ncc.MANCC,ncc.TENNCC,ncc.DIACHINCC,ncc.EMAIL,ncc.SDTNCC };
            foreach (var item in nhacc)
            {
                var row = dt.NewRow();
                row[0] = item.MANCC;
                row[1] = item.TENNCC;
                row[2] = item.DIACHINCC;
                row[3] = item.EMAIL;
                row[4] = item.SDTNCC;
                dt.Rows.Add(row);
            }
            return dt;
        }

        public string geTenNCCTheoMa(string maNCC)
        {
            var query = from ncc in qlch.NHACUNGCAPs
                        where ncc.MANCC == maNCC
                        select ncc.TENNCC;

            return query.FirstOrDefault();
        }

    }
}
