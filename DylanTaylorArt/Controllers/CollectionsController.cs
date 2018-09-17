using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using DylanTaylorArt.Models;

namespace DylanTaylorArt
{
    [Authorize()]
    public class CollectionsController : Controller
    {
        private GraphicDbContext db = new GraphicDbContext();

        // GET: Collections
        public ActionResult Index()
        {
            return View(db.Collections.ToList());
        }

        // GET: Collections/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collection graphicCollection = db.Collections.Find(id);
            if (graphicCollection == null)
            {
                return HttpNotFound();
            }
            return View(graphicCollection);
        }

        // GET: Collections/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Collections/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CollectionId,CollectionName,Artist,Year,Description,ImagePath")] Collection graphicCollection)
        {
            if (ModelState.IsValid)
            {
                db.Collections.Add(graphicCollection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(graphicCollection);
        }

        // GET: Collections/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collection graphicCollection = db.Collections.Find(id);
            if (graphicCollection == null)
            {
                return HttpNotFound();
            }
            return View(graphicCollection);
        }

        // POST: Collections/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CollectionId,CollectionName,Artist,Year,Description,ImagePath")] Collection graphicCollection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(graphicCollection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(graphicCollection);
        }

        // GET: Collections/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Collection graphicCollection = db.Collections.Find(id);
            if (graphicCollection == null)
            {
                return HttpNotFound();
            }
            return View(graphicCollection);
        }

        // POST: Collections/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Collection graphicCollection = db.Collections.Find(id);
            db.Collections.Remove(graphicCollection);
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
