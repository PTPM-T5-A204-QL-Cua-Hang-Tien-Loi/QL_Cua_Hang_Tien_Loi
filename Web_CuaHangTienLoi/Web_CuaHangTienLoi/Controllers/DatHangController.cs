using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Web_CuaHangTienLoi.Models;
using System.Data.Entity;

namespace Web_CuaHangTienLoi.Controllers
{
    public class DatHangController : Controller
    {
        //
        // GET: /DonHang/

        QL_CuaHangTienLoiEntities4 db = new QL_CuaHangTienLoiEntities4();
        public ActionResult Index()
        {
            //Kiểm tra đang đăng nhập
            if (Session["use"] == null || Session["use"].ToString() == "")
            {               
                return RedirectToAction("Dangnhap", "User");
            }
            Nguoidung kh = (Nguoidung)Session["use"];
            int maND = kh.MaNguoiDung;
            var donhangs = db.DonhangOnls.Include(d => d.Nguoidung).Where(d => d.MaNguoidung == maND);
            return View(donhangs.ToList());
        }

        //Hiển thị chi tiết đơn hàng
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonhangOnl donhang = db.DonhangOnls.Find(id);
            var chitiet = db.ChitietdonhangOnls.Include(d => d.SANPHAM).Where(d => d.Madon == id).ToList();
            if (donhang == null)
            {
                return HttpNotFound();
            }
            return View(chitiet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}
