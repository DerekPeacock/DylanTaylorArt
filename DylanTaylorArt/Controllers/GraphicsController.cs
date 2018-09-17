using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DylanTaylorArt.Models;

namespace DylanTaylorArt.Controllers
{
    [Authorize]
    public class GraphicsController : Controller
    {
        private GraphicDbContext db = new GraphicDbContext();

        // GET: Graphics
        public ActionResult Index()
        {
            //var graphics = db.Graphics.Include(c => c.Collection);
            return View(db.Graphics.ToList());
        }

        // GET: Graphics/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Graphic graphic = db.Graphics.Find(id);
            if (graphic == null)
            {
                return HttpNotFound();
            }
            return View(graphic);
        }

        // GET: Graphics/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Graphics/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GraphicID,CollectionId,Title,Description,LargeImagePath,SmallImagePath,Format,Paper,Aspect,ImageWidth,ImageHeight,PaperWidth,PaperHeight,Status,FramedWith,DisplayInCarousel,DisplayOnHomePage,Price")] Graphic graphic)
        {
            if (ModelState.IsValid)
            {
                db.Graphics.Add(graphic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(graphic);
        }

        // GET: Graphics/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Graphic graphic = db.Graphics.Find(id);
            if (graphic == null)
            {
                return HttpNotFound();
            }
            return View(graphic);
        }

        // POST: Graphics/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GraphicID,CollectionId,Title,Description,LargeImagePath,SmallImagePath,Format,Paper,Aspect,ImageWidth,ImageHeight,PaperWidth,PaperHeight,Status,FramedWith,DisplayInCarousel,DisplayOnHomePage,Price")] Graphic graphic)
        {
            if (ModelState.IsValid)
            {
                db.Entry(graphic).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(graphic);
        }

        // GET: Graphics/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Graphic graphic = db.Graphics.Find(id);
            if (graphic == null)
            {
                return HttpNotFound();
            }
            return View(graphic);
        }

        // POST: Graphics/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Graphic graphic = db.Graphics.Find(id);
            db.Graphics.Remove(graphic);
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
