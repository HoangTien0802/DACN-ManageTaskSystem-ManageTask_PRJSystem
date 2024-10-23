using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ManageTaskWeb.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult DangNhap()
        {
            return View();
        }

        public ActionResult TrangChu()
        {
            return View();
        }
    }
}
