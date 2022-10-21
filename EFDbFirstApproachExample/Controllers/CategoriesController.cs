using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EFDbFirstApproachExample.Models;

namespace EFDbFirstApproachExample.Controllers
{
    public class CategoriesController : Controller
    {
        // GET: Categories
        public ActionResult Index()
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();

            List<Category> categories = db.Categories.ToList();

            return View(categories);
        }
    }
}