using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CuaHangTienLoi.Models;

namespace Web_CuaHangTienLoi.Controllers
{
    public class SanphamController : Controller
    {
        //
        // GET: /SanPham/

        QL_CuaHangTienLoiEntities4 db = new QL_CuaHangTienLoiEntities4();

        public ActionResult GiayIn()
        {
            var gi = db.SANPHAMs.Where(n => n.MALOAI == "LH001").Take(4).ToList();
            return PartialView(gi);
        }

        public ActionResult MayTinh()
        {
            var mt = db.SANPHAMs.Where(n => n.MALOAI == "LH003").Take(4).ToList();
            return PartialView(mt);
        }
        public ActionResult getAll()
        {
            var mt = db.SANPHAMs.ToList();
            return PartialView(mt);
        }
        public ActionResult XemChiTiet(string MASP = "")
        {
            var chitiet = db.SANPHAMs.SingleOrDefault(n => n.MASP == MASP);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }
    }
}
