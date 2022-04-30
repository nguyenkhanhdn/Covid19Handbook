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
    public class ThankfulsController : Controller
    {
        private Covid19Model db = new Covid19Model();

        // GET: Thankfuls
        public ActionResult Index()
        {
            return View(db.Thanks.ToList());
        }

        // GET: Thankfuls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thankful thankful = db.Thanks.Find(id);
            if (thankful == null)
            {
                return HttpNotFound();
            }
            return View(thankful);
        }

        // GET: Thankfuls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Thankfuls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost,ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Content,Status")] Thankful thankful)
        {
            if (ModelState.IsValid)
            {
                db.Thanks.Add(thankful);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(thankful);
        }

        // GET: Thankfuls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thankful thankful = db.Thanks.Find(id);
            if (thankful == null)
            {
                return HttpNotFound();
            }
            return View(thankful);
        }

        // POST: Thankfuls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost, ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Content,Status")] Thankful thankful)
        {
            if (ModelState.IsValid)
            {
                db.Entry(thankful).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(thankful);
        }

        // GET: Thankfuls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Thankful thankful = db.Thanks.Find(id);
            if (thankful == null)
            {
                return HttpNotFound();
            }
            return View(thankful);
        }

        // POST: Thankfuls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Thankful thankful = db.Thanks.Find(id);
            db.Thanks.Remove(thankful);
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
