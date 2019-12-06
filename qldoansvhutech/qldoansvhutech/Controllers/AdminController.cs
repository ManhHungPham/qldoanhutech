using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace qldoansvhutech.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ThongTin()
        {
            return View();
        }
        public ActionResult DanhSachGiangVien()
        {
            return View();
        }
        public ActionResult PhanChiaHuongDan()
        {
            return View();
        }
        public ActionResult DanhSachSinhVien()
        {
            return View();
        }
        public ActionResult QuanLyDoAn()
        {
            return View();
        }
    }
}