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
    public class MonitoringsController : Controller
    {
        private Covid19Model db = new Covid19Model();

        // GET: Monitorings
        public ActionResult Index()
        {
            var monitorings = db.Monitorings.Include(m => m.Patient);
            return View(monitorings.ToList());
        }

        // GET: Monitorings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitoring monitoring = db.Monitorings.Find(id);
            if (monitoring == null)
            {
                return HttpNotFound();
            }
            return View(monitoring);
        }

        // GET: Monitorings/Create
        public ActionResult Create()
        {
            ViewBag.PatientId = new SelectList(db.Patients, "Id", "Fullname");
            return View();
        }

        // POST: Monitorings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,PatientId,reportDate,bodytemp,spo2,symtomps,doctoradv")] Monitoring monitoring)
        {
            if (ModelState.IsValid)
            {
                db.Monitorings.Add(monitoring);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PatientId = new SelectList(db.Patients, "Id", "Fullname", monitoring.PatientId);
            return View(monitoring);
        }

        // GET: Monitorings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitoring monitoring = db.Monitorings.Find(id);
            if (monitoring == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientId = new SelectList(db.Patients, "Id", "Fullname", monitoring.PatientId);
            return View(monitoring);
        }

        // POST: Monitorings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,PatientId,reportDate,bodytemp,spo2,symtomps,doctoradv")] Monitoring monitoring)
        {
            if (ModelState.IsValid)
            {
                db.Entry(monitoring).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PatientId = new SelectList(db.Patients, "Id", "Fullname", monitoring.PatientId);
            return View(monitoring);
        }

        // GET: Monitorings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Monitoring monitoring = db.Monitorings.Find(id);
            if (monitoring == null)
            {
                return HttpNotFound();
            }
            return View(monitoring);
        }

        // POST: Monitorings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Monitoring monitoring = db.Monitorings.Find(id);
            db.Monitorings.Remove(monitoring);
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
