using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIWebSite.WebCore.Models;

namespace SIWebSite.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Persons model)
        {
            ViewBag.Message = "Welcome " + model.Login + " !";
            return View("Index");
        }
    }
}