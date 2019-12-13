using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using qldoansvhutech.Models;

namespace qldoansvhutech.Controllers
{
    public class GiangVienController : Controller
    {
        QLDADataContext db = new QLDADataContext();
        // GET: GiangVien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var magv = collection["magv"];
            var matkhau = collection["matkhau"];
            if (String.IsNullOrEmpty(magv))
            {
                ViewData["Loi1"] = "Phải nhập tài khoản";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu ";
            }
            else
            {
              gvhd gv = db.gvhds.FirstOrDefault(n => n.magv == magv && n.matkhau == matkhau);
                if (gv != null)
                {
                    return RedirectToAction("Index","GiangVien");
                }
                else
                    ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không chính xác !";
            }
            return View();
        }
        public ActionResult QuanLySinhVien()
        {
            var sv = from sva in db.sinhviens select sva;
                return View(sv);
        }
        public ActionResult ThongTinDoAn()
        {
            var da = from doan in db.doans select doan;
            return View(da);
        }
        public ActionResult NhomDoAn()
        {
            var nhom = from nhomda in db.nhoms select nhomda;
            return View(nhom);
        }
        public ActionResult PhuTrachDoAn()
        {
            var pt = from pda in db.ptdas select pda;
            return View(pt);
        }
        public ActionResult PhanChiaCongViec()
        {
            return View();
        }
        public ActionResult BaoCao()
        {
            return View();
        }
    }
}
