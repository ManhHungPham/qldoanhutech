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
        dbQLDADataContext db = new dbQLDADataContext();

        // GET: SinhVien
        public ActionResult ThongTinSinhVien()
        {  
            return View();
        }
        public ActionResult SuaSV()
        {
            Sinhvien sv = (Sinhvien)Session["Taikhoan"];
            return View(sv);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaSV(Sinhvien sinhvien)
        {
            if (ModelState.IsValid)
            {
                Sinhvien sv = (Sinhvien)Session["Taikhoan"];
                sv.Hoten = sinhvien.Hoten;
                sv.Gioitinh = sinhvien.Gioitinh;
                sv.Sdt = sinhvien.Sdt;
                sv.Email = sinhvien.Email;
                db.SubmitChanges();
                UpdateModel(sv);
                return RedirectToAction("ThongTinSinhVien");
            }
            return View(sinhvien);
        }
        public ActionResult Dangkydoan()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Dangkydoan(Doan doan)
        {
            ViewBag.Mada = new SelectList(db.Doans.ToList().OrderBy(n => n.Tenda), "Mada", "Tenda");
            if (ModelState.IsValid)
            {
                db.Doans.InsertOnSubmit(doan);
                db.SubmitChanges();
            }
            return RedirectToAction("Dangkydoan");
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