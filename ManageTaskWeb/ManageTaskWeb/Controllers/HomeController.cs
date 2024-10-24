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
        public ActionResult DSProject()
        {
            return View();
        }
        public ActionResult DSMember()
        {
            return View();
        }

        public ActionResult DSTask()
        {
            return View();
        }
    }
}
