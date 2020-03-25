using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GameReview.Models;

namespace GameReview.Controllers
{
    public class PlatformsController : Controller
    {
        private PlatformsContext db = new PlatformsContext();

        // GET: Platforms
        public ActionResult Index()
        {
            return View(db.Platforms.ToList());
        }

        // GET: Platforms/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Platforms platforms = db.Platforms.Find(id);
            if (platforms == null)
            {
                return HttpNotFound();
            }
            return View(platforms);
        }

        // GET: Platforms/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Platforms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PlatformId,PlatformName,Developer,Price")] Platforms platforms)
        {
            if (ModelState.IsValid)
            {
                db.Platforms.Add(platforms);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(platforms);
        }

        // GET: Platforms/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Platforms platforms = db.Platforms.Find(id);
            if (platforms == null)
            {
                return HttpNotFound();
            }

            ViewBag.PlatformId = new SelectList(db.Platforms, "PlatformId", "PlatformName", platforms.PlatformId);
            return View(platforms);
        }

        // POST: Platforms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PlatformId,PlatformName,Developer,RAM,GPUCore,HDD,Price")] Platforms platforms)
        {
            if (ModelState.IsValid)
            {
                db.Entry(platforms).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(platforms);
        }

        // GET: Platforms/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Platforms platforms = db.Platforms.Find(id);
            if (platforms == null)
            {
                return HttpNotFound();
            }
            return View(platforms);
        }

        // POST: Platforms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Platforms platforms = db.Platforms.Find(id);
            db.Platforms.Remove(platforms);
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
