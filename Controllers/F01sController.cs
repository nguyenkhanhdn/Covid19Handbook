using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Covid19Handbook.Models;

namespace Covid19Handbook.Controllers
{
    public class F01sController : Controller
    {
        private Covid19Model db = new Covid19Model();

        // GET: F01s
        public ActionResult Index()
        {
            return View(db.F01s.ToList());
        }

        // GET: F01s/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            F01s f01s = db.F01s.Find(id);
            if (f01s == null)
            {
                return HttpNotFound();
            }
            return View(f01s);
        }

        // GET: F01s/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: F01s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,content,date,type,status,views")] F01s f01s)
        {
            if (ModelState.IsValid)
            {
                db.F01s.Add(f01s);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(f01s);
        }

        // GET: F01s/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            F01s f01s = db.F01s.Find(id);
            if (f01s == null)
            {
                return HttpNotFound();
            }
            return View(f01s);
        }

        // POST: F01s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,content,date,type,status,views")] F01s f01s)
        {
            if (ModelState.IsValid)
            {
                db.Entry(f01s).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(f01s);
        }

        // GET: F01s/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            F01s f01s = db.F01s.Find(id);
            if (f01s == null)
            {
                return HttpNotFound();
            }
            return View(f01s);
        }

        // POST: F01s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            F01s f01s = db.F01s.Find(id);
            db.F01s.Remove(f01s);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
