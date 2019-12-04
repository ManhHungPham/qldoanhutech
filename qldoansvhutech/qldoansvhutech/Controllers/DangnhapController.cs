using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using qldoansvhutech.Models;

namespace qldoansvhutech.Controllers
{
   
    public class DangnhapController : Controller
    {
        QuanLyDoAnEntities2 db = new QuanLyDoAnEntities2();
        // GET: Dangnhap
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
            var mssv = collection["mssv"];
            var matkhau = collection["matkhau"];
            if(String.IsNullOrEmpty(mssv))
            {
                ViewData["Loi1"] = "Phải nhập mssv";
            }
            else if (String.IsNullOrEmpty(matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu ";
            }
            else
            {
                sinhvien sv = db.sinhviens.FirstOrDefault(n => n.Mssv == mssv && n.Matkhau == matkhau);
                if (sv != null)
                {
                    return RedirectToAction("Thongtinsinhvien", "SinhVien");
                }
                else
                    ViewBag.ThongBao = "MSSV hoặc mật khẩu không chính xác !";
            }
            return View();
        }
        public PartialViewResult ID()
        {
            if(Session["mssv"]!=null)
            {
                sinhvien sv = (sinhvien)Session["mssv"];
                ViewBag.ThongBao = sv.Mssv;
            }
            return PartialView();
        }

    }
}