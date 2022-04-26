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
    public class QAsController : Controller
    {
        private Covid19Model db = new Covid19Model();

        // GET: QAs
        public ActionResult Index()
        {
            return View(db.QAs.ToList());
        }

        // GET: QAs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QA qA = db.QAs.Find(id);
            if (qA == null)
            {
                return HttpNotFound();
            }
            return View(qA);
        }

        // GET: QAs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,question,Answer,description,date")] QA qA)
        {
            if (ModelState.IsValid)
            {
                db.QAs.Add(qA);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qA);
        }

        // GET: QAs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QA qA = db.QAs.Find(id);
            if (qA == null)
            {
                return HttpNotFound();
            }
            return View(qA);
        }

        // POST: QAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,question,Answer,description,date")] QA qA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qA).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qA);
        }

        // GET: QAs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QA qA = db.QAs.Find(id);
            if (qA == null)
            {
                return HttpNotFound();
            }
            return View(qA);
        }

        // POST: QAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QA qA = db.QAs.Find(id);
            db.QAs.Remove(qA);
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
