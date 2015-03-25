using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
   public class FirstController : Controller
    {
        //
        // GET: /first/
        public ActionResult View1()
        {

           ViewBag.Message = "Привет! " ; 
           ViewBag.Message1 = "Сейчас "  + DateTime.Now; 
            return View();
        }
    }
}

