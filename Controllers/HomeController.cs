using Covid19Handbook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace Covid19Handbook.Controllers
{
    public class HomeController : Controller
    {
        private Covid19Model db = new Covid19Model();

        // GET: News
        public ActionResult Index()
        {
            var news = db.News;
            return View(news.ToList());
        }

        public ViewResult News(int? page)
        {
            var news = db.News.ToList();

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(news.ToPagedList(pageNumber, pageSize));
        }
        public ViewResult Details(int? id)
        {
            var newItem = db.News.Find(id);
            if(newItem != null)
            {
                return View("Details", newItem);
            }
            return View("News");
        }

        public ViewResult qnas()
        {
            var qas = db.QAs.ToList();
            return View(qas);
        }

        public ViewResult Documents()
        {
            var documents = db.documents.ToList();
            return View(documents);
        }
        public ViewResult Hotlines()
        {
            var hotlines = db.hotlines.ToList();
            return View(hotlines);
        }

        public ViewResult Patients()
        {
            var patients = db.Patients.ToList();
            return View(patients);
        }

        public ViewResult Doctors()
        {
            var doctors = db.doctors.ToList();
            return View(doctors);
        }

        public ViewResult Trian()
        {
            var thanks = db.Thanks.ToList();
            return View(thanks);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}