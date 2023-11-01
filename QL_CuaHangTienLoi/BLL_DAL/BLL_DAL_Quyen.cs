using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BLL_DAL_Quyen
    {
        QLCuaHangTienLoiDataContext qlch = new QLCuaHangTienLoiDataContext();
        public BLL_DAL_Quyen() { }
        public List<QUYEN> getQuyens_List()
        {
            List<QUYEN> list = new List<QUYEN>();
            list = qlch.QUYENs.ToList();
            return list;
        }
        //Gọi hàm này khi dùng cho datagridview
        public DataTable getQuyens_Table()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã quyền");
            dt.Columns.Add("Tên quyền");
            var quyen = from q in qlch.QUYENs select new { q.MAQUYEN,q.TENQUYEN };
            foreach (var item in quyen)
            {
                var row = dt.NewRow();
                row[0] = item.MAQUYEN;
                row[1] = item.TENQUYEN;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}
