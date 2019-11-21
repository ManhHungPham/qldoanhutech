using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace qldoansv.Controllers
{
    public class SinhVienController : Controller
    {
        public IActionResult Thongtinsinhvien()
        {
            return View();
        }
        public IActionResult Dangkydoan()
        {
            return View();
        }
        public IActionResult Dangkynhom()
        {
            return View();
        }
        public IActionResult Nhom()
        {
            return View();
        }
    }
}