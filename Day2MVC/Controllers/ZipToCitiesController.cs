using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Day2MVC.Models;

namespace Day2MVC.Controllers
{
    public class ZipToCitiesController : Controller
    {
        private Day2MVCContext db = new Day2MVCContext();

        // GET: ZipToCities
        public ActionResult Index()
        {
            var zipToCities = db.ZipToCities.Include(z => z.City).Include(z => z.Zip);
            return View(zipToCities.ToList());
        }

        // GET: ZipToCities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZipToCity zipToCity = db.ZipToCities.Find(id);
            if (zipToCity == null)
            {
                return HttpNotFound();
            }
            return View(zipToCity);
        }

        // GET: ZipToCities/Create
        public ActionResult Create()
        {
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "Name");
            ViewBag.ZipId = new SelectList(db.Zips, "ZipId", "ZipCode");
            return View();
        }

        // POST: ZipToCities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ZTCId,ZipId,CityId")] ZipToCity zipToCity)
        {
            if (ModelState.IsValid)
            {
                db.ZipToCities.Add(zipToCity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CityId = new SelectList(db.Cities, "CityId", "Name", zipToCity.CityId);
            ViewBag.ZipId = new SelectList(db.Zips, "ZipId", "ZipCode", zipToCity.ZipId);
            return View(zipToCity);
        }

        // GET: ZipToCities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZipToCity zipToCity = db.ZipToCities.Find(id);
            if (zipToCity == null)
            {
                return HttpNotFound();
            }
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "Name", zipToCity.CityId);
            ViewBag.ZipId = new SelectList(db.Zips, "ZipId", "ZipCode", zipToCity.ZipId);
            return View(zipToCity);
        }

        // POST: ZipToCities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ZTCId,ZipId,CityId")] ZipToCity zipToCity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zipToCity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "Name", zipToCity.CityId);
            ViewBag.ZipId = new SelectList(db.Zips, "ZipId", "ZipCode", zipToCity.ZipId);
            return View(zipToCity);
        }

        // GET: ZipToCities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZipToCity zipToCity = db.ZipToCities.Find(id);
            if (zipToCity == null)
            {
                return HttpNotFound();
            }
            return View(zipToCity);
        }

        // POST: ZipToCities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ZipToCity zipToCity = db.ZipToCities.Find(id);
            db.ZipToCities.Remove(zipToCity);
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
