using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MCAResultController : Controller
    {
        private DbMCA Db = new DbMCA();
        public ActionResult ResultView()
        {
            return View();
        }
    }
}