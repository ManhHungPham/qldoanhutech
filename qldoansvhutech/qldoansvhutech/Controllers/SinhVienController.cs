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
        [HttpPost]
        public ActionResult SuaSV(FormCollection f)
        {
            var id = f["txtId"].ToString();
            //Sinhvien sv = (Sinhvien)Session["Taikhoan"];
            Sinhvien sv = db.Sinhviens.Where(m=>m.Id == int.Parse(id)).SingleOrDefault();
            sv.Hoten = f["txtHoTen"].ToString();
            sv.Email = f["txtEmail"].ToString();
            sv.Sdt =  f["txtSDT"].ToString();
            string gt = f["chkGT"].ToString();
            bool gtinh = false;
            if(gt.CompareTo("1") == 0)
            {
                gtinh = true;
            }
            sv.Gioitinh = gtinh;
            db.SubmitChanges();
            return RedirectToAction("ThongTinSinhVien");
        }
        public ActionResult Dangkydoan()
        {
            var dsGiangVien = db.Gvhds.ToList();
            ViewBag.DSGV = dsGiangVien;
            Sinhvien sv = (Sinhvien) Session["Mssv"];
            ViewBag.Id = sv.Id;
            return View();
        }

        [HttpPost]
        public ActionResult Dangkydoan(FormCollection f)
        {
            Doan da = new Doan();
            da.Id = int.Parse(f["txtId"].ToString());
            da.Tenda = f["txtTenDoAn"].ToString();
            da.Mota = f["txtMoTa"].ToString();
            da.Magv = f["radMaGV"].ToString();
            db.Doans.InsertOnSubmit(da);
            db.SubmitChanges();
            return RedirectToAction("ThongTinSinhVien");
        }
        public ActionResult Details()
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

        public ActionResult ThongTinDoAn()
        {
            Sinhvien sv = (Sinhvien)Session["Mssv"];
            var doAn = db.Doans.Where(n => n.Id == sv.Id);
            return View(doAn);
        }
    }
}