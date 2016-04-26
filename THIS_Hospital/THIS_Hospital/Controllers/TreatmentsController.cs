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
    public class TreatmentsController : Controller
    {
        private HospitalDBContext db = new HospitalDBContext();

        // GET: Treatments
        public ActionResult Index()
        {
            var _Treatment = db._Treatment.Include(t => t.Patient).Include(t => t.TreatmentStatus).Include(t => t.whatsDone);
            return View(_Treatment.ToList());
        }

        // GET: Treatments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db._Treatment.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }//

        // GET: Treatments/Create
        public ActionResult Create()
        {
            ViewBag.PatientID = new SelectList(db._Patient, "PatientID", "FName");
            ViewBag.TreatmentStatusID = new SelectList(db._Treatmentstatus, "TreatmentStatusID", "Status");
            ViewBag.WhatsDoneID = new SelectList(db._WhatsDone, "WhatsDoneID", "Description");
            return View();
        }

        // POST: Treatments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TreatmentID,Date,StillAlive,PatientID,WhatsDoneID,TreatmentStatusID")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db._Treatment.Add(treatment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PatientID = new SelectList(db._Patient, "PatientID", "FName", treatment.PatientID);
            ViewBag.TreatmentStatusID = new SelectList(db._Treatmentstatus, "TreatmentStatusID", "Status", treatment.TreatmentStatusID);
            ViewBag.WhatsDoneID = new SelectList(db._WhatsDone, "WhatsDoneID", "Description", treatment.WhatsDoneID);
            return View(treatment);
        }

        // GET: Treatments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db._Treatment.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            ViewBag.PatientID = new SelectList(db._Patient, "PatientID", "FName", treatment.PatientID);
            ViewBag.TreatmentStatusID = new SelectList(db._Treatmentstatus, "TreatmentStatusID", "Status", treatment.TreatmentStatusID);
            ViewBag.WhatsDoneID = new SelectList(db._WhatsDone, "WhatsDoneID", "Description", treatment.WhatsDoneID);
            return View(treatment);
        }

        // POST: Treatments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TreatmentID,Date,StillAlive,PatientID,WhatsDoneID,TreatmentStatusID")] Treatment treatment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(treatment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PatientID = new SelectList(db._Patient, "PatientID", "FName", treatment.PatientID);
            ViewBag.TreatmentStatusID = new SelectList(db._Treatmentstatus, "TreatmentStatusID", "Status", treatment.TreatmentStatusID);
            ViewBag.WhatsDoneID = new SelectList(db._WhatsDone, "WhatsDoneID", "Description", treatment.WhatsDoneID);
            return View(treatment);
        }

        // GET: Treatments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Treatment treatment = db._Treatment.Find(id);
            if (treatment == null)
            {
                return HttpNotFound();
            }
            return View(treatment);
        }

        // POST: Treatments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Treatment treatment = db._Treatment.Find(id);
            db._Treatment.Remove(treatment);
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
