using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using qldoansvhutech.Models;

namespace qldoansvhutech.Controllers
{
    public class SinhVienController : Controller
    {
        QLDADataContext db = new QLDADataContext();

        // GET: SinhVien
        public ActionResult Thongtinsinhvien()
        {
            return View();
        }
        public ActionResult Dangkydoan()
        {
            return View();
        }
        public ActionResult Dangkynhom()
        {
            return View();
        }
        public ActionResult Nhom()
        {
            return View();
        }
    }
}