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

            return View(db.Collections.ToList());
        }

        public ActionResult Collections(int CollectionID)
        {
            PopulateDropdowns(CollectionID);
            var collection = db.Collections.Find(CollectionID);

            return View(collection);
        }

        public ActionResult Shows()
        {
            ViewBag.Message = "Your on show page.";

            return View();
        }

        public ActionResult Chagall()
        {
            ViewBag.Message = "Your on the Chagall page.";

            return View();
        }

        public ActionResult Hockney()
        {
            ViewBag.Message = "Your on the Hockney page.";

            return View();
        }

        public ActionResult HenryMoore()
        {
            ViewBag.Message = "Your on the Henry Moore page.";

            return View();
        }

        public ActionResult JohnHoyland()
        {
            ViewBag.Message = "Your on the John Hoyland page.";

            return View();
        }

        public ActionResult SoniaDelaunay()
        {
            ViewBag.Message = "Your on the Sonia Delaunay page.";

            return View();
        }

        public ActionResult JoanMiro()
        {
            ViewBag.Message = "You are on the Joan Miro page.";

            return View();
        }

		public ActionResult Hilton()
		{
			ViewBag.Message = "You are on the Rose Hilton page.";

			return View();
		}
		public ActionResult Matisse()
		{
			ViewBag.Message = "You are on the Henri Matisse page.";

			return View();
		}

		public ActionResult Picasso()
        {
            ViewBag.Message = "You are on the Picasso page.";

            return View();
        }

        public ActionResult Kellert()
        {
            ViewBag.Message = "Your on the Kellert page.";
            return View(db.Collections.Find(11));
        }

        public ActionResult Green()
        {
            ViewBag.Message = "Your on the Green page.";

            return View(db.Collections.Find(12));
        }

        protected void PopulateDropdowns(object selectedCollection = null)
        {
            var collections = db.Collections.OrderBy(y => y.Year);
            ViewBag.CollectionID = new SelectList(collections, "CollectionID", "CollectionName", selectedCollection);
        }

    }
}