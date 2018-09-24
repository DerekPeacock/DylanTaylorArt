using DylanTaylorArt.Models;
using System.Linq;
using System.Web.Mvc;

namespace DylanTaylorArt.Controllers
{
    public class HomeController : Controller
    {

        private GraphicDbContext db = new GraphicDbContext();


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Gallery()
        {
            ViewBag.Message = "Your Gallery page.";

            return View();
        }

        public ActionResult Collections(int id = 1)
        {
            PopulateDropdowns(id);
            return View(db.Collections.Find(id));
        }

        public ActionResult Shows()
        {
            ViewBag.Message = "Your on show page.";

            return View();
        }

        protected void PopulateDropdowns(object selectedCollection = null)
        {
            var collections = db.Collections;
            ViewBag.CollectionID = new SelectList(collections, "CollectionID", "CollectionName", selectedCollection);
        }

    }
}