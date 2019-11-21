using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyDoAn.Controllers
{
    public class GiangVienController : Controller
    {
        // GET: GiangVien
        public ActionResult Index()
        {
            return View();
        }
       
        public ActionResult QuanLySinhVien()
        {
            return View();
        }
        public ActionResult ThongTinDoAn()
        {
            return View();
        }
        public ActionResult NhomDoAn()
        {
            return View();
        }
        public ActionResult ChamDiemDoAn()
        {
            return View();
        }
        public ActionResult PhanChiaCongViec()
        {
            return View();
        }
    }
}