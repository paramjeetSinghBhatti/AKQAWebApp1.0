using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AKQAWebApp.Controllers
{
    public class CustomErrorController : Controller
    {
        //
        // GET: /CustomError/
        public ActionResult Error(int statusCode)
        {
            ViewBag.StatusCode = statusCode;
            return View();
        }
	}
}