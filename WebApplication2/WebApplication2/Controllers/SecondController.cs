using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
  public class SecondController : Controller
    {
        //
        // GET: /second/
        public ActionResult View1()
        {
            ViewBag.Message = "Привет!";
            return View();
        }
    }
}