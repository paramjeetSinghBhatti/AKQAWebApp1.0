using AKQAWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AKQAWebApp.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/
        [HandleError]
        public ActionResult Index()
        {
            return View();
        }
	}
}