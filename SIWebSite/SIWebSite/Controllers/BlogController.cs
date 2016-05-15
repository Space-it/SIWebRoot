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
        public ActionResult Create(Entries model)
        {
            LocalDB.Entryes.Add(model);
            return Redirect("Index");
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            try
            {
                return View(LocalDB.Entryes.First(x => x.Id == Id));
            }
            catch
            {
                return View("Index");
            }
        }
        [HttpPost]
        public ActionResult Edit(Entries model)
        {
            try
            {
                int _saveIndex = 0;
                // find element in db and replace it from changed element
                for (int i = 0; i < LocalDB.Entryes.Count; i++)
                    if (LocalDB.Entryes[i].Id == model.Id)
                    {
                        LocalDB.Entryes[i] = model;
                        _saveIndex = i;
                    }
                return View("Details", LocalDB.Entryes[_saveIndex]);
            }
            catch
            {
                return View("Index");
            }
        }


        [HttpGet]
        public ActionResult Details(int Id)
        {
            try
            {
                return View(LocalDB.Entryes.First(x => x.Id == Id));
            }
            catch
            {
                return View("Index");
            }
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            try
            {
                return View(LocalDB.Entryes.First(x => x.Id == Id));
            }
            catch
            {
                return View("Index");
            }
        }



    }
}