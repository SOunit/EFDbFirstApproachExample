using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EFDbFirstApproachExample.Models;

namespace EFDbFirstApproachExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index(string search = "")
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();

            // to keep search keyword in view after submit
            ViewBag.search = search;

            List<Product> products = db.Products
                //.Where(temp => temp.CategoryID == 1 && temp.Price >= 50000)
                .Where(temp => temp.ProductName.Contains(search))
                .ToList();
            return View(products);
        }

        public ActionResult Details(long id)
        {
            EFDBFirstDatabaseEntities db = new EFDBFirstDatabaseEntities();
            Product p = db.Products.Where(temp => temp.ProductID == id).FirstOrDefault();
            return View(p);
        }
    }
}