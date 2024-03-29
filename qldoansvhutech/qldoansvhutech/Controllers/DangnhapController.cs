﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using qldoansvhutech.Models;

namespace qldoansvhutech.Controllers
{
   
    public class DangnhapController : Controller
    {
        dbQLDADataContext db = new dbQLDADataContext();
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
            var Mssv = collection["Taikhoan"];
            var Matkhau = collection["Matkhau"];
            if(String.IsNullOrEmpty(Mssv))
            {
                ViewData["Loi1"] = "Phải nhập mssv";
            }
            else if (String.IsNullOrEmpty(Matkhau))
            {
                ViewData["Loi2"] = "Phải nhập mật khẩu ";
            }
            else
            {
                Sinhvien sv = db.Sinhviens.FirstOrDefault(n => n.Mssv.CompareTo(Mssv) == 0 && n.Matkhau.CompareTo(Matkhau)==0);
                if (sv != null)
                {
                    Session["Mssv"] = sv;
                    return RedirectToAction("ThongTinSinhVien", "SinhVien");
                }
                else
                    ViewBag.ThongBao = "MSSV hoặc mật khẩu không chính xác !";
            }
            
            return View();
        }       
        public PartialViewResult ID()
        {
            if(Session["Mssv"]!=null)
            {
                Sinhvien sv = (Sinhvien)Session["Mssv"];
                ViewBag.ThongBao = sv.Hoten;
            }
            return PartialView();
        }

        public ActionResult DangNhapGiangVien()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhapGiangVien(FormCollection f)
        {
            string username = f["txtUsername"].ToString();
            string password = f["txtPassword"].ToString();
            Gvhd gv = db.Gvhds.Where(n=>n.Magv == username && n.Matkhau == password).SingleOrDefault();
            if (gv != null)
            {
                Session["GiangVien"] = gv;
                return RedirectToAction("Index", "GiangVien");
            }
            else
                ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không chính xác !";
            return View();
        }
    }
}