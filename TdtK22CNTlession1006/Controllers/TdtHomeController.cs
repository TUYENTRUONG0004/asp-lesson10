using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TdtK22CNTlession1006.Models;

namespace TdtK22CNTlession1006.Controllers
{
    public class TdtHomeController : Controller
    {
        public ActionResult TdtIndex()
        {
            if (Session["TdtAccount"]  != null)
            {
                var TdtAccount = Session["TdtAccount"] as TdtAccount;
                ViewBag.FullName = TdtAccount.TdtFullName;
            }
            return View();
        }

        public ActionResult TdtAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult TdtContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}