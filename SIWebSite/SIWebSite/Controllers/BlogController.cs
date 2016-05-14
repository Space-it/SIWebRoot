using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SIWebSite.WebCore.DataBase;
using SIWebSite.WebCore.Models;

namespace SIWebSite.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View(LocalDB.Entryes);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Entry model)
        {
            LocalDB.Entryes.Add(model);
            return Redirect("Index");
        }
    }
}