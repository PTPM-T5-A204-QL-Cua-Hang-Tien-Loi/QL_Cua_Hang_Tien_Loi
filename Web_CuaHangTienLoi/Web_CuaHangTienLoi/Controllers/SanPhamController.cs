﻿using System;
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

        QL_CuaHangTienLoi_NewEntities db = new QL_CuaHangTienLoi_NewEntities();

        public ActionResult NuocUong()
        {
            var nuoc = db.SANPHAMs.Where(n => n.MALOAI == "LH001").Take(4).ToList();
            return PartialView(nuoc);
        }

        public ActionResult BanhKeo()
        {
            var nuoc = db.SANPHAMs.Where(n => n.MALOAI == "LH003").Take(4).ToList();
            return PartialView(nuoc);
        }

    }
}
