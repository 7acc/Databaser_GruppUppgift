using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using THIS_Hospital;

namespace THIS_Hospital.Controllers
{
    public class CauseTypesController : Controller
    {
        private HospitalDBContext db = new HospitalDBContext();

        // GET: CauseTypes
        public ActionResult Index()
        {
            return View(db.CauseTypes.ToList());
        }

        // GET: CauseTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CauseType causeType = db.CauseTypes.Find(id);
            if (causeType == null)
            {
                return HttpNotFound();
            }
            return View(causeType);
        }

        // GET: CauseTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CauseTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CauseTypeID,CauseTypeName")] CauseType causeType)
        {
            if (ModelState.IsValid)
            {
                db.CauseTypes.Add(causeType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(causeType);
        }

        // GET: CauseTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CauseType causeType = db.CauseTypes.Find(id);
            if (causeType == null)
            {
                return HttpNotFound();
            }
            return View(causeType);
        }

        // POST: CauseTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CauseTypeID,CauseTypeName")] CauseType causeType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(causeType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(causeType);
        }

        // GET: CauseTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CauseType causeType = db.CauseTypes.Find(id);
            if (causeType == null)
            {
                return HttpNotFound();
            }
            return View(causeType);
        }

        // POST: CauseTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CauseType causeType = db.CauseTypes.Find(id);
            db.CauseTypes.Remove(causeType);
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
