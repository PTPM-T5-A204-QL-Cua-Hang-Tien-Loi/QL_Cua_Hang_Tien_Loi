using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_CuaHangTienLoi.Models;

namespace Web_CuaHangTienLoi.Controllers
{
    public class DanhMucController : Controller
    {
        //
        // GET: /DanhMuc/

        QLCuaHangTienLoi db = new QLCuaHangTienLoi();

        public ActionResult DanhmucPartial()
        {
            var danhmuc = db.LOAISPs.ToList();
            return PartialView(danhmuc);
        }
        public ViewResult SanPhamTheoLH(string maLH)
        {
            var ListTH = db.SANPHAMs.Where(s => s.MALOAI == maLH).OrderBy(s => s.DONGIABAN).ToList();
            if (ListTH.Count == 0)
            {
                ViewBag.Imagename = "/Images/erro.png";
                ViewBag.SanPham = "Không có sản phẩm nào thuộc danh mục này";
            }
            return View(ListTH);
        }
        public ActionResult xemchitiet(string Masp = "")
        {
            var chitiet = db.SANPHAMs.SingleOrDefault(n => n.MASP == Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }     

    }
}
