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
        private dbQLDADataContext db = new dbQLDADataContext();
        // GET: GiangVien
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult QuanLySinhVien()
        {
            // Lấy giảng viên đang đăng nhập
            Gvhd gv = (Gvhd)Session["GiangVien"];
            // Lấy ra danh sách sinh viên hướng dẫn
            var dsSV = db.Sinhviens.Where(m => m.Magv == gv.Magv).ToList();
            return View(dsSV);
        }
        public ActionResult ThongTinDoAn()
        {
            // Lấy thông tin đồ án đã đăng ký
            Sinhvien sv = (Sinhvien)Session["Mssv"];
            var doAn = db.Doans.Where(n=>n.Id == sv.Id);
            return View(doAn);
        }

        public ActionResult ThemSinhVien()
        {
            Gvhd gv = (Gvhd)Session["GiangVien"];
            var dsSV = from s in db.Sinhviens where !(from a in db.Sinhviens where a.Magv == gv.Magv select a.Magv).Contains(s.Magv) select s; 
            return View(dsSV.ToList());
        }

        [HttpPost]
        public ActionResult ThemSinhVien(FormCollection f)
        {
            string listNew = f["id"].ToString();
            string[] dsId = listNew.Split(';');
            Gvhd gv = (Gvhd)Session["GiangVien"];
            foreach (string item in dsId)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    Sinhvien sv = db.Sinhviens.Where(n => n.Id == int.Parse(item)).SingleOrDefault();
                    sv.Magv = gv.Magv;
                    db.SubmitChanges();
                }
            }
            return RedirectToAction("QuanLySinhVien");
        }

        public ActionResult XoaSinhVien(int id)
        {
            if (id != null)
            {
                Sinhvien sv = db.Sinhviens.Where(n => n.Id == id).SingleOrDefault();
                sv.Magv = "";
                db.SubmitChanges();
            }
            return RedirectToAction("QuanLySinhVien");
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
        public ActionResult BaoCao()
        {
            return View();
        }
    }
}
