using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        public NHACUNGCAP getNCCTheoMaNCC(string maNCC)
        {

            NHACUNGCAP nHACUNGCAP = new NHACUNGCAP();
            var result = from ncc in qlch.NHACUNGCAPs where ncc.MANCC == maNCC select new { ncc.MANCC, ncc.TENNCC, ncc.DIACHINCC, ncc.EMAIL, ncc.SDTNCC };

            foreach (var item in result)
            {
                nHACUNGCAP.MANCC = item.MANCC;
                nHACUNGCAP.TENNCC = item.TENNCC;
                nHACUNGCAP.DIACHINCC = item.DIACHINCC;
                nHACUNGCAP.EMAIL = item.EMAIL;
                nHACUNGCAP.SDTNCC = item.SDTNCC;
            }

            return nHACUNGCAP;

        }

        public string geTenNCCTheoMa(string maNCC)
        {
            var query = from ncc in qlch.NHACUNGCAPs
                        where ncc.MANCC == maNCC
                        select ncc.TENNCC;

            return query.FirstOrDefault();
        }

        public bool Create(NHACUNGCAP ncc)
        {
            try
            {
                qlch.NHACUNGCAPs.InsertOnSubmit(ncc);
                qlch.SubmitChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Update(NHACUNGCAP ncc)
        {
            try
            {
                NHACUNGCAP nHACUNGCAP = qlch.NHACUNGCAPs.Where(u => u.MANCC == ncc.MANCC).SingleOrDefault();
                nHACUNGCAP.MANCC = ncc.MANCC;
                nHACUNGCAP.TENNCC = ncc.TENNCC;
                nHACUNGCAP.DIACHINCC = ncc.DIACHINCC;
                nHACUNGCAP.EMAIL = ncc.EMAIL;
                nHACUNGCAP.SDTNCC = ncc.SDTNCC;
                qlch.SubmitChanges();
                var result = qlch.NHACUNGCAPs.Where(n => n.MANCC == ncc.MANCC).ToList();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(NHACUNGCAP ncc)
        {
            try
            {
                NHACUNGCAP nHACUNGCAP = qlch.NHACUNGCAPs.Where(u => u.MANCC == ncc.MANCC).SingleOrDefault();
                qlch.NHACUNGCAPs.DeleteOnSubmit(nHACUNGCAP);
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
