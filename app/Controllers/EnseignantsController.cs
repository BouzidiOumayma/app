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
    public class EnseignantsController : Controller
    {
        private MyDBContext db = new MyDBContext();

        // GET: Enseignants
        public ActionResult Index()
        {
            return View(db.Enseignants.ToList());
        }

        // GET: Enseignants/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enseignant enseignant = db.Enseignants.Find(id);
            if (enseignant == null)
            {
                return HttpNotFound();
            }
            return View(enseignant);
        }

        // GET: Enseignants/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enseignants/Create
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdEnseignant,Nom,Prenom,Matiere,Niveau,Section")] Enseignant enseignant)
        {
            if (ModelState.IsValid)
            {
                db.Enseignants.Add(enseignant);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(enseignant);
        }

        // GET: Enseignants/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enseignant enseignant = db.Enseignants.Find(id);
            if (enseignant == null)
            {
                return HttpNotFound();
            }
            return View(enseignant);
        }

        // POST: Enseignants/Edit/5
        // Afin de déjouer les attaques par survalidation, activez les propriétés spécifiques auxquelles vous voulez établir une liaison. Pour 
        // plus de détails, consultez https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdEnseignant,Nom,Prenom,Matiere,Niveau,Section")] Enseignant enseignant)
        {
            if (ModelState.IsValid)
            {
                db.Entry(enseignant).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(enseignant);
        }

        // GET: Enseignants/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Enseignant enseignant = db.Enseignants.Find(id);
            if (enseignant == null)
            {
                return HttpNotFound();
            }
            return View(enseignant);
        }

        // POST: Enseignants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Enseignant enseignant = db.Enseignants.Find(id);
            db.Enseignants.Remove(enseignant);
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
