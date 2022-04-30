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

        public ViewResult qnas(int? page)
        {
            var qas = db.QAs.OrderByDescending(q=>q.Id).ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(qas.ToPagedList(pageNumber, pageSize));
        }

        public ViewResult Documents()
        {
            var documents = db.documents.ToList();
            return View(documents);
        }
        public ViewResult Hotlines(int? page)
        {
            var hotlines = db.hotlines.OrderByDescending(h => h.Id).ToList();
            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(hotlines.ToPagedList(pageNumber, pageSize));
        }

        public ViewResult Patients()
        {
            var patients = db.Patients.ToList();
            return View(patients);
        }

        public ViewResult Doctors(int? page)
        {
            var doctors = db.doctors.OrderByDescending(d => d.Id).ToList();
            int pageSize = 4;
            int pageNumber = (page ?? 1);
            return View(doctors.ToPagedList(pageNumber, pageSize));
        }

        public ViewResult Trian(int? page)
        {
            var thanks = db.Thanks.OrderByDescending(t => t.Id).ToList();
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            return View(thanks.ToPagedList(pageNumber, pageSize));
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