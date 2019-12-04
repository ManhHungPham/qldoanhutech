using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace qldoansv.Controllers
{
    public class GiangVienController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult QuanLySinhVien()
        {
            return View();
        }
        public IActionResult ThongTinDoAn()
        {
            return View();
        }
        public IActionResult NhomDoAn()
        {
            return View();
        }
        public IActionResult ChamDiemDoAn()
        {
            return View();
        }
        public IActionResult PhanChiaCongViec()
        {
            return View();
        }
    }
}