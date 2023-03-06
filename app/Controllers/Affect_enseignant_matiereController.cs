using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using app.Data;
using app.Models;

namespace app.Controllers
{
    public class Affect_enseignant_matiereController : Controller
    {
        private MyDBContext db = new MyDBContext();

        // GET: Affect_enseignant_matiere
        public ActionResult Index()
        {
            var affect_enseignant_matiere = db.Affect_enseignant_matiere.Include(a => a.Enseignant).Include(a => a.Matiere);
            return View(affect_enseignant_matiere.ToList());
        }

        // GET: Affect_enseignant_matiere/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Affect_enseignant_matiere affect_enseignant_matiere = db.Affect_enseignant_matiere.Find(id);
            if (affect_enseignant_matiere == null)
            {
                return HttpNotFound();
            }
            return View(affect_enseignant_matiere);
        }

        // GET: Affect_enseignant_matiere/Create
        public ActionResult Create()
        {
            ViewBag.IdEnseignant = new SelectList(db.Enseignants, "IdEnseignant", "Nom");
            ViewBag.IdMatiere = new SelectList(db.Matieres, "IdMatiere", "name");
            return View();
        }

        // POST: Affect_enseignant_matiere/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,IdMatiere,IdEnseignant")] Affect_enseignant_matiere affect_enseignant_matiere)
        {
            if (ModelState.IsValid)
            {
                db.Affect_enseignant_matiere.Add(affect_enseignant_matiere);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IdEnseignant = new SelectList(db.Enseignants, "IdEnseignant", "Nom", affect_enseignant_matiere.IdEnseignant);
            ViewBag.IdMatiere = new SelectList(db.Matieres, "IdMatiere", "name", affect_enseignant_matiere.IdMatiere);
            return View(affect_enseignant_matiere);
        }

        // GET: Affect_enseignant_matiere/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Affect_enseignant_matiere affect_enseignant_matiere = db.Affect_enseignant_matiere.Find(id);
            if (affect_enseignant_matiere == null)
            {
                return HttpNotFound();
            }
            ViewBag.IdEnseignant = new SelectList(db.Enseignants, "IdEnseignant", "Nom", affect_enseignant_matiere.IdEnseignant);
            ViewBag.IdMatiere = new SelectList(db.Matieres, "IdMatiere", "name", affect_enseignant_matiere.IdMatiere);
            return View(affect_enseignant_matiere);
        }

        // POST: Affect_enseignant_matiere/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,IdMatiere,IdEnseignant")] Affect_enseignant_matiere affect_enseignant_matiere)
        {
            if (ModelState.IsValid)
            {
                db.Entry(affect_enseignant_matiere).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IdEnseignant = new SelectList(db.Enseignants, "IdEnseignant", "Nom", affect_enseignant_matiere.IdEnseignant);
            ViewBag.IdMatiere = new SelectList(db.Matieres, "IdMatiere", "name", affect_enseignant_matiere.IdMatiere);
            return View(affect_enseignant_matiere);
        }

        // GET: Affect_enseignant_matiere/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Affect_enseignant_matiere affect_enseignant_matiere = db.Affect_enseignant_matiere.Find(id);
            if (affect_enseignant_matiere == null)
            {
                return HttpNotFound();
            }
            return View(affect_enseignant_matiere);
        }

        // POST: Affect_enseignant_matiere/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Affect_enseignant_matiere affect_enseignant_matiere = db.Affect_enseignant_matiere.Find(id);
            db.Affect_enseignant_matiere.Remove(affect_enseignant_matiere);
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
